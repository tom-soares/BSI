using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Domain;

namespace ControleFinanceiro.Infra
{
    public class UsuarioDAO
    {
        public int login(string email, string password)
        {
            DAL dal = new DAL();
            var sql = "SELECT COUNT(*) FROM [User] WHERE email = @email AND password = @password";
            var cmd = new System.Data.SqlClient.SqlCommand(sql, dal.Connection);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@password", password);
            int count = (int)cmd.ExecuteScalar();
            return count;
        }
    }
}
