using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Registro
    {
        public int id { get; private set; }
        public double Valor { get; private set; }
        public string Descricao { get; set; }

        public Registro(double v, string d)
        {
            Valor = v;
            Descricao = d;
        }
        public Registro(int id, double v, string d)
        {
            this.id = id;
            Valor = v;
            Descricao = d;
        }
    }  
}
