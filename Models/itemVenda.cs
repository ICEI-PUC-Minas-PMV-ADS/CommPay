using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace Commpay.Models
{
    [Table("Item Venda")]

    public class ItemVenda
    {

        [Key]

        public int Id { get; set; }

        public int Quantidade { get; set; }

        [Required(ErrorMessage = "Obrigatório o preenchimento da quantidade de item")]

        public int Id_Venda { get; set; }
        [ForeignKey("VendaId")]

        public Venda? Venda { get; set; }

        public int Id_Produto { get; set; }
        [ForeignKey("ProdutoId")]

        public Produto? Produto { get; set; }

    }

}