using System;
using Commpay.Models;

public class Expedidor : Usuario
{
    public Expedidor(int id, string nome, string cpf, string senha, cargo cargo) : base(id, nome, cpf, senha)
    {
        this.cargo = cargo.Expedidor;
    }

    public void AlterarStatusEntrega()
    {

    }
}
