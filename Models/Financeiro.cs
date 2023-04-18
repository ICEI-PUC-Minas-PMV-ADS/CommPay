using System;
using Commpay.Models.Enums;

public class Financeiro : Usuario
{
    public Financeiro(int id, string nome, string cpf, string senha, Cargo cargo) : base(id, nome, cpf, senha)
    {
        this.cargo = Cargo.Financeiro;        
    }
}
