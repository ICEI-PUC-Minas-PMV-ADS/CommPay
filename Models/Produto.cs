using Commpay.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Commpay.Models
{
    [Table("Produto")] //Criação da tabela Produto.
    public class Produto //Criação da classe.
    {
        //Atributos da classe.
        [Key] //Primary Key.
        public int Id { get; set; }

        [Required(ErrorMessage = "Preenchimento obrigatório!")] //Mensagem de obrigatoriedade!
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Preenchimento obrigatório!")] //Mensagem de obrigatoriedade!
        public float Valor { get; set; }
    }
}
