using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace ControleFinanceiro.Infra
{
    public class DAL : IDisposable
    {
        public SqlConnection Connection { get; set; }
        
        public DAL()
        {
            Connection = new SqlConnection(ConnectionDb.Default.Conexao);
            Connection.Open();
        }

        public void Dispose()
        {
            Connection.Close();
        }
    }
}
