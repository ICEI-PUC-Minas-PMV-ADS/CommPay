using System;
using Commpay.Models.Enums;

public class Expedidor : Usuario
{
    public Expedidor(int id, string nome, string cpf, string senha, Cargo cargo) : base(id, nome, cpf, senha)
    {
        this.cargo = Cargo.Expedidor;
    }

    public void AlterarStatusEntrega()
    {

    }
}
