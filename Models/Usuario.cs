using Commpay.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Mail;
using System.Runtime.CompilerServices;

namespace Commpay.Models
{
    [Table("Usuario")] //Criação da Tabela.
    public abstract class Usuario //Classe base de Usuário.
    {
        [Key] // Primary Key
        public int Id { get; set; }

        [Required(ErrorMessage = "Preenchimento obrigatório!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preenchimento obrigatório!")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Preenchimento obrigatório!")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Preenchimento obrigatório!")]
        public Cargos Cargo { get; set; }
    }
}

