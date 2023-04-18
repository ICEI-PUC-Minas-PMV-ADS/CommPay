using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Commpay.Models
{
    public enum cargo
    {
        Expedidor,
        Vendedor,
        Financeiro
    }
    [Table("Usuário")]
    public class Usuario
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage = "Campo obrigatório!")]
        public string nome { get; set; }
        [Required(ErrorMessage = "Campo obrigatório!")]
        public string cpf { get; set; }
        [Required(ErrorMessage = "Campo obrigatório!")]
        public string senha { get; set; }
        public cargo cargo { get; set; }

        public Usuario(int id, string nome, string cpf, string senha)
        {
            this.id = id;
            this.nome = nome;
            this.cpf = cpf;
            this.senha = senha;
        }

        public void VizualizarRelatorio()
        {

        }
    }
}
