﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Commpay.Models.Enums;

namespace Commpay.Models
{

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
        public Cargo cargo { get; set; }

        public Usuario(int id, string nome, string cpf, string senha, Cargo cargo)
        {
            this.id = id;
            this.nome = nome;
            this.cpf = cpf;
            this.senha = senha;
            this.cargo = cargo;
        }

        public Usuario()
        {
        }
    }
}
