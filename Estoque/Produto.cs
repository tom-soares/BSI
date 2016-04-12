using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque
{
    public class Produto
    {
        public string Descricao { get; private set; }
        public string Local { get; private set; }
        public int QtdMin { get; private set; }
        public int QtdTotal { get; set; }
        public int ID_Produto { get; private set; }
        public static int Cont { get; private set; }

        public Produto(string Descricao, string Local, int QtdMin = 0 )
        {
            try
            {
                Produto.Cont++;
                ID_Produto = Produto.Cont;
                this.Descricao = Descricao;
                this.Local = Local;
                this.QtdMin = QtdMin;
        
            }
            catch (Exception)
            {
                Produto.Cont--;
                throw new Exception("Erro ao criar o objeto");
            }
        }

    }
    
}
