namespace Commpay.Models
{
    public class VendaProduto
    {

        public Venda Venda { get; set; }

        public ICollection<Produto> Produto { get; set; } 
    
    }
}
