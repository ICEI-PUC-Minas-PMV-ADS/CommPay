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

        public ActionResult gerarPDF(float somaVendas, string dataFormatada, float somaComissoes, string dataRelatorio, string dataGeracaoRelatorio)
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
            double imageX = 200;
            double imageY = 40;
            double imageWidth = 180;
            double imageHeight = 75;

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
            desenho.DrawString(title, titleFont, XBrushes.Black, new XPoint(titleX, 170));
           
            //Definição da posição do subtítulo
            double subTitleX = 270;
            double subTitleY = 190;           

            //Definição fonte e cor subtitulo
            XFont subTitleFont = new XFont("Arial", 12, XFontStyle.Italic);
           
            //Escrevendo subtitulo
            desenho.DrawString("" + dataRelatorio, subTitleFont, XBrushes.Black, subTitleX, subTitleY);
            
            //Desenho do card de total em vendas
            XFont cardTitleFont = new XFont("Arial", 20, XFontStyle.Bold);
            double cardVendaTitleX = 60;
            double cardVendaTitleY = 260;
            desenho.DrawString("Total em vendas " , cardTitleFont, XBrushes.Black, cardVendaTitleX, cardVendaTitleY);
            XFont cardValueFont = new XFont("Arial", 16);
            double cardVendaValueX = 95;
            double cardVendaValueY = 290;
            desenho.DrawString("" + somaVendas.ToString("C", new System.Globalization.CultureInfo("pt-BR")), cardValueFont, XBrushes.Black, cardVendaValueX, cardVendaValueY);


            //Desenho do card data da última venda            
            double cardUltimaCompraTitleX = 330;
            double cardUltimaCompraTitleY = 260;
            desenho.DrawString("Data da última venda ", cardTitleFont, XBrushes.Black, cardUltimaCompraTitleX, cardUltimaCompraTitleY);
            double cardUltimaCompraValueX = 390;
            double cardUltimaCompraValueY = 290;
            desenho.DrawString("" + dataFormatada, cardValueFont, XBrushes.Black, cardUltimaCompraValueX, cardUltimaCompraValueY);


            //Desenho do card comissões            
            double cardComissoesTitleX = 60;
            double cardComissoesTitleY = 440;
            desenho.DrawString("Comissões á pagar ", cardTitleFont, XBrushes.Black, cardComissoesTitleX, cardComissoesTitleY);
            double cardComissoesValueX = 110;
            double cardComissoesValueY = 470;
            desenho.DrawString("" + somaComissoes.ToString("C", new System.Globalization.CultureInfo("pt-BR")), cardValueFont, XBrushes.Black, cardComissoesValueX, cardComissoesValueY);


            //Desenho do card data de pagamento            
            double cardDataPagamentoTitleX = 340;
            double cardDataPagamentoTitleY = 440;
            desenho.DrawString("Data de pagamento" , cardTitleFont, XBrushes.Black, cardDataPagamentoTitleX, cardDataPagamentoTitleY);
            double cardDataPagamentoValueX = 400;
            double cardDataPagamentoValueY = 470;
            desenho.DrawString("" + dataFormatada, cardValueFont, XBrushes.Black, cardDataPagamentoValueX, cardDataPagamentoValueY);

            //Desenho da data de criação do relatório
            double dataCriacaoX = 195;
            double dataCriacaoY = 800;
            desenho.DrawString("Relatório gerado em " + dataGeracaoRelatorio, subTitleFont, XBrushes.Black, dataCriacaoX, dataCriacaoY);

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

