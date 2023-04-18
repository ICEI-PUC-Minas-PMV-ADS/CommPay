using System;
using Commpay.Models;

public class Vendedor : Usuario
{
    public Vendedor(int id, string nome, string cpf, string senha, cargo cargo) : base(id, nome, cpf, senha)
    {
        this.cargo = cargo.Vendedor;
    }

    public void CadastrarVenda()
    {

    }
}
