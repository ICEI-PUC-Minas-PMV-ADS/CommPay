using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Commpay.Models;
using System.Security.Claims;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Drawing.Layout;
using System.Drawing;
using PdfSharp.Charting;
using static System.Net.Mime.MediaTypeNames;

namespace Commpay.Controllers
{
    public class VendasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public VendasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Vendas
        public async Task<IActionResult> Index()
        {
              return _context.Vendas != null ? 
                          View(await _context.Vendas.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Vendas'  is null.");
        }

        // GET: Vendas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Vendas == null)
            {
                return NotFound();
            }

            var venda = await _context.Vendas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (venda == null)
            {
                return NotFound();
            }

            return View(venda);
        }


        // GET: Vendas/Create
        public async Task<IActionResult> Create()
        {
            var vendaProduto = new VendaProduto() {
                Venda = new Venda()
                {
                    Vendedor = User.FindFirstValue(ClaimTypes.Name),
                    Data_Compra = DateTime.Now,
                    Data_Entrega = DateTime.Now.AddDays(10),
                    Entregador = "Jose",


                },
                Produto = _context.Produtos
                       .OrderBy(x => x.Descricao)
                       .AsNoTracking().ToList()
             };

          return View(vendaProduto);

        }

        // POST: Vendas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Venda venda)
        {

            var vendedor = User.FindFirstValue(ClaimTypes.Name);
            venda.Vendedor = vendedor;
            venda.Data_Compra = DateTime.Now;
            venda.Data_Entrega = DateTime.Now.AddDays(10);

            ModelState.Remove("Vendedor");

            if (ModelState.IsValid)
            {
                _context.Add(venda);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            
            return View();
        }

        // GET: Vendas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Vendas == null)
            {
                return NotFound();
            }

            var venda = await _context.Vendas.FindAsync(id);
            if (venda == null)
            {
                return NotFound();
            }
            return View(venda);
        }

        // POST: Vendas/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Vendedor,Data_Compra,Valor_Total,Entregador,Data_Entrega,Status")] Venda venda)
        {
            if (id != venda.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(venda);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VendaExists(venda.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(venda);
        }

        // GET: Vendas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Vendas == null)
            {
                return NotFound();
            }

            var venda = await _context.Vendas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (venda == null)
            {
                return NotFound();
            }

            return View(venda);
        }

        // POST: Vendas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Vendas == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Vendas'  is null.");
            }
            var venda = await _context.Vendas.FindAsync(id);
            if (venda != null)
            {
                _context.Vendas.Remove(venda);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public ActionResult gerarPDF(float somaVendas, string dataFormatada, int contadorVendedores, float somaComissoes, string formattedDate)
        {
            //Cria um documento PDF.
            var document = new PdfDocument();

            //Adiciona uma página.
            PdfPage page = document.AddPage();

            //Cria o objeto XGraphics que desenha a página.
            XGraphics desenho = XGraphics.FromPdfPage(page);            

            //Cria logo do cabeçalho
            XImage logo = XImage.FromFile("C:\\Users\\pablo\\OneDrive\\Área de Trabalho\\Clone_CommPay\\wwwroot\\src\\logo_p.jpg");

            //Definição da posição e tamanho da imagem
            double imageX = 20;
            double imageY = 20;
            double imageWidth = 85;
            double imageHeight = 45;

            //Desenha a imagem
            desenho.DrawImage(logo, imageX, imageY, imageWidth, imageHeight);            

            //Obtem o tamanho da página.
            double pageWidth = page.Width.Point;

            //Define a fonte do título
            XFont titleFont = new XFont("Arial", 24, XFontStyle.Bold);

            //Definição do título
            string title = "Relatório Geral";

            //Obtém a largura do título            
            XSize titleSize = desenho.MeasureString(title, titleFont);
            double titleWidth = titleSize.Width;

            //Centraliza o texto
            double titleX = (page.Width - titleSize.Width) / 2;

            //Adiciona o título a página            
            desenho.DrawString(title, titleFont, XBrushes.Black, new XPoint(titleX, 50));

            //Definição subtítulo
            string subTitle = "Período dd/mm/yyyy á dd/mm/yyyy";

            //Definição da posição do subtítulo
            double subTitleX = 20;
            double subTitleY = 80;           

            //Definição fonte subtitulo
            XFont subTitleFont = new XFont("Arial", 9, XFontStyle.Italic);           

            //Escrevendo subtitulo
            desenho.DrawString(subTitle, subTitleFont, XBrushes.Black, subTitleX, subTitleY);

            //Desenho do card de total em vendas
            XFont cardVendasValueFont = new XFont("Arial", 16);
            double cardVendaX = 20;
            double cardvendaY = 120;
            desenho.DrawString("Total em vendas: " + somaVendas.ToString("C", new System.Globalization.CultureInfo("pt-BR")), cardVendasValueFont, XBrushes.Black, cardVendaX, cardvendaY);

            //Desenho do card data da última compra            
            XFont cardUltimaVendaValueFont = new XFont("Arial", 16);
            double cardUltimaVendaX = 20;
            double cardUltimaVendaY = 180;
            desenho.DrawString("Data da última venda: " + dataFormatada, cardUltimaVendaValueFont, XBrushes.Black, cardUltimaVendaX, cardUltimaVendaY);

            //Desenho do card vendedores ativos            
            XFont cardVendedoresFont = new XFont("Arial", 16);
            double cardVendedoresX = 20;
            double cardVendedoresY = 240;
            desenho.DrawString("Vendedores ativos: " + contadorVendedores, cardUltimaVendaValueFont, XBrushes.Black, cardVendedoresX, cardVendedoresY);

            //Desenho do card comissoes            
            XFont cardComissoesFont = new XFont("Arial", 16);
            double cardComissoesX = 20;
            double cardComissoesY = 300;
            desenho.DrawString("Total de comissões a serem pagas: " + somaComissoes.ToString("C", new System.Globalization.CultureInfo("pt-BR")), cardUltimaVendaValueFont, XBrushes.Black, cardComissoesX, cardComissoesY);

            //Desenho do card data da última compra            
            XFont cardDataPagamentoFont = new XFont("Arial", 16);
            double cardDataPagamentoX = 20;
            double cardDataPagamentoY = 360;
            desenho.DrawString("Data de pagamento: " + dataFormatada, cardUltimaVendaValueFont, XBrushes.Black, cardDataPagamentoX, cardDataPagamentoY);

            //Salva o documento PDF em uma memória de fluxo.
            MemoryStream stream = new MemoryStream();
            document.Save(stream);
            stream.Position = 0;

            //Retorna o arquivo PDF para donwload
            return File(stream, "application/pdf", "relatorio.pdf");
        }

        private bool VendaExists(int id)
        {
          return (_context.Vendas?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}

