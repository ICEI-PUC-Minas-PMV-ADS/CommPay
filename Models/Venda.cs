using Commpay.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Commpay.Models
{
    [Table("Venda")]
    public class Venda
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Preenchimento obrigatório!")]
        public string Vendedor { get; set; }

        [Required(ErrorMessage = "Preenchimento obrigatório!")]
        [DisplayName("Data Compra")]
        [DataType(DataType.Date)]
        public DateTime Data_Compra { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        [DisplayName("Valor total")]
        [Required(ErrorMessage = "Preenchimento obrigatório!")]
        public decimal Valor_Total { get; set; }

        [Required(ErrorMessage = "Preenchimento obrigatório!")]
        public string Entregador { get; set; }

        [Required(ErrorMessage = "Preenchimento obrigatório!")]
        [DisplayName("Data Entrega")]
        [DataType(DataType.Date)]
        public DateTime Data_Entrega { get; set; }

        public Status? Status { get; set; }

        [ForeignKey("Usuario")]
        public int IdUsuario { get; set; }
        public Usuario Usuario { get; set; }
    }
}