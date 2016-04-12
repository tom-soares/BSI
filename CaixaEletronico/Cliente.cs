using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    public class Cliente : Pessoa
    {
        private int Cliente_Id { get; set; }

        public Cliente(int id, string nome) : base(id, nome)
        {
            this.Cliente_Id = base.Pessoa_Id;
        }

        public override string ToString()
        {
            return base.Nome;
        }
             
    }
}
