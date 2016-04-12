using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
     public class Pessoa
    {
        protected int Pessoa_Id { get; set; }
        protected string Nome { get; set; }

        public Pessoa(int id, string nome)
        {
            this.Pessoa_Id = id;
            this.Nome = nome;
        }

        public bool getId(int id)
        {
            if (id == Pessoa_Id)
            {
                return true;
            }
            else return false;
        }
    }
}
