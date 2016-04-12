using Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Infra
{
    public class RegistroDAO
    {

        public void Insere(Registro r)
        {
            DAL dal = new DAL();

            using (var cmd = new System.Data.SqlClient.SqlCommand("INSERT INTO Registros (Descricao,Valor) VALUES (@desc,@val)", dal.Connection))
            {
                cmd.Parameters.AddWithValue("@desc", r.Descricao);
                cmd.Parameters.AddWithValue("@val", r.Valor);
                cmd.ExecuteNonQuery();
            }
        }

        public double Acumulo(int type)
        {
            DAL dal = new DAL();
            using (var cmd = new SqlCommand("SELECT SUM(Valor) as Valor FROM Registros WHERE Valor " + (type == 1 ? '>' : '<') + "0", dal.Connection))
            {
                using (var reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    var valor = reader["Valor"].ToString();
                    if (String.IsNullOrEmpty(valor))
                        valor = "0";

                    Debug.WriteLine("valor: " + valor);
                    return Convert.ToDouble(valor);
                }
            }
        }
        public Registro Recupera(int id)
        {
            DAL dal = new DAL();
            using (var cmd = new SqlCommand("SELECT * FROM Registros WHERE id = " + id, dal.Connection))
            {
                using (var reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    var rid = Int32.Parse(reader["id"].ToString());
                    var desc = reader["Descricao"].ToString();
                    var val = Convert.ToDouble(reader["Valor"]);

                    return new Registro(rid,val, desc);
                }
            }
        }
        public void Atualiza(Registro r)
        {
            DAL dal = new DAL();
            Debug.WriteLine("ID: " + r.id);
            using (var cmd = new SqlCommand("UPDATE Registros SET Descricao = @desc, Valor = @val WHERE id = @id", dal.Connection))
            {
                cmd.Parameters.AddWithValue("@desc", r.Descricao);
                cmd.Parameters.AddWithValue("@val", r.Valor);
                cmd.Parameters.AddWithValue("@id", r.id);
                cmd.ExecuteNonQuery();
            }
        }
        public void Exclui(int id)
        {
            DAL dal = new DAL();
            using (var cmd = new SqlCommand("DELETE FROM Registros WHERE id = @id", dal.Connection))
            {
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }

        }
    }
}
