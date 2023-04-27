using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Commpay.Models
{
    [Table("ItemVenda")]
    public class ItemVenda
    {
        [Key]
        public int Id { get; set; }

        public int Quantidade { get; set; }

        [Required(ErrorMessage = "Obrigatório o Preenchimento da quantidade!")]

        //public int Id_Venda { get; set; }
        //[ForeignKey("Id_venda")]

        //public Venda Venda { get; set; }

        public int Id_Venda { get; set; }
        [ForeignKey("Id_Venda")]

        public Venda Venda { get; set; }

        public int Id_Produto { get; set; }
        [ForeignKey("Id_Produto")]

        public Produto Produto { get; set; }
    }
}
