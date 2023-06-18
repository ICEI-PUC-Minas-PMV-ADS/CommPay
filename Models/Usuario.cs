using Commpay.CustomAttributes;
using Commpay.Models.Enums;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Commpay.Models
{
    [Table("Usuario")] //Criação da Tabela.
    public class Usuario //Classe base de Usuário.
    {
        [Key] // Primary Key
        public int Id { get; set; }

        [Required(ErrorMessage = "Preenchimento obrigatório!")]
        [RegularExpression("^[a-zA-Z]+", ErrorMessage = "Apenas caracteres de A a Z são permitidos")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preenchimento obrigatório!")]
        [CPFValidator]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Preenchimento obrigatório!")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Preenchimento obrigatório!")]
        public Cargos Cargo { get; set; }

    }
}

