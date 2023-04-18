using System;
using Commpay.Models;

public class Financeiro : Usuario
{
    public Financeiro(int id, string nome, string cpf, string senha, cargo cargo) : base(id, nome, cpf, senha)
    {
        this.cargo = cargo.Vendedor;
    }
}
