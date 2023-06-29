using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenBank.Model.DAO
{
    public class ConexaoDAO
    {

        SqlConnection con = new SqlConnection();

        public ConexaoDAO()
        {
            con.ConnectionString = @"Data Source = IAGO\SQLEXPRESS; Initial Catalog = GreenBank; Integrated Security = True";
        }

        public SqlConnection Conectar()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }

            return con;
        }

        public void Desconectar()
        {
            if(con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }

    }
}
