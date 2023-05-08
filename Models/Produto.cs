using Commpay.Models.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Commpay.Models
{
    [Table("Produto")] //Criação da tabela Produto.
    public class Produto //Criação da classe.
    {
        //Atributos da classe.
        [Key] //Primary Key.
        [DisplayName("Código do Produto")]        
        public int Id { get; set; }

        [DisplayName("Descrição")]
        [Required(ErrorMessage = "Preenchimento obrigatório!")] //Mensagem de obrigatoriedade!
        public string Descricao { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        [Required(ErrorMessage = "Preenchimento obrigatório!")] //Mensagem de obrigatoriedade!
        public decimal Valor { get; set; }
    }
}
