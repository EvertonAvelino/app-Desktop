using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class Endereco
    {

        private String connString = "";

        public Endereco()
        {
             connString = ConfigurationManager.ConnectionStrings["conexao"].ConnectionString;
        }
         

        //medoto para listar/select
        public DataTable Lista(int pessoaId)
        {

            DataTable table = new DataTable();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string sql = "select * from enderecos where pessoa_id =" + pessoaId;

                SqlCommand cmd = new SqlCommand(sql, conn);
               
                conn.Open();
                using (SqlDataAdapter a = new SqlDataAdapter(cmd))
                {
                    a.Fill(table);
                }
            }
            return table;
        }

    }
        
}

