using Commpay.Models.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Commpay.Models
{
    [Table("Venda")] //Criação da Tabela.
    public class Venda //Classe base de Usuário.
    {
        [Key] // Primary Key
        public int Id { get; set; }

        [Required(ErrorMessage = "Preenchimento obrigatório!")]
        public string Vendedor { get; set; }

        [Required(ErrorMessage = "Preenchimento obrigatório!")]
        [DataType(DataType.Date)]
        public DateTime Data_Compra { get; set; }

        [Required(ErrorMessage = "Preenchimento obrigatório!")]
        public string Valor_Total { get; set; }

        [Required(ErrorMessage = "Preenchimento obrigatório!")]
        public string Entregador { get; set; }

        [Required(ErrorMessage = "Preenchimento obrigatório!")]
        [DataType(DataType.Date)]
        public DateTime Data_Entrega { get; set; }

        //[Required(ErrorMessage = "Preenchimento obrigatório!")]
        //public StatusEntrega Status_Entrega { get; set; }

        
    }
}
