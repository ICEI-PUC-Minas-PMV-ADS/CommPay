using System;
using Commpay.Models.Enums;

namespace Commpay.Models
{
    public class Vendedor : Usuario
    {
        public Vendedor(int id, string nome, string cpf, string senha, Cargo cargo) : base(id, nome, cpf, senha)
        {
            this.cargo = Cargo.Vendedor;
        }

        public void CadastrarVenda()
        {

        }
    }
}
