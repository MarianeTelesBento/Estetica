using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Estetica.UI.Models
{
    public class Cadastro : Validacao
    {
        
        public int CadastrarDados(string table, string d1, string d2, string d3, string d4, string d5, string d6, string d7, string d8, string d9, string d10, string d11)
        {
            string connectionString = "Data Source=FAC0539673W10-1;Initial Catalog=Estetica;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand inserirCommand = new SqlCommand($"insert into {table} values(@d1, @d2, @d3, @d4, @d5, @d6, @d7, @d8, @d9, @d10, @d11); SELECT SCOPE_IDENTITY();", connection);

            /*SqlCommand GetIdCommand = new SqlCommand($"Select * {table} values(@d1, @d2, @d3); ", connection);*/

            inserirCommand.Parameters.AddWithValue("@d1", d1);
            inserirCommand.Parameters.AddWithValue("@d2", d2);
            inserirCommand.Parameters.AddWithValue("@d3", d3);
            inserirCommand.Parameters.AddWithValue("@d4", d4);
            inserirCommand.Parameters.AddWithValue("@d5", d5);
            inserirCommand.Parameters.AddWithValue("@d6", d6);
            inserirCommand.Parameters.AddWithValue("@d7", d7);
            inserirCommand.Parameters.AddWithValue("@d8", d8);
            inserirCommand.Parameters.AddWithValue("@d9", d9);
            inserirCommand.Parameters.AddWithValue("@d10", d10);
            inserirCommand.Parameters.AddWithValue("@d11", d11);

            int commandID = Convert.ToInt32(inserirCommand.ExecuteScalar());
            
            connection.Close();

            return commandID;
        }

        public int CadastrarDados(string table, string d1, string d2, string d3, string d4, string d5)
        {
            string connectionString = "Data Source=FAC0539673W10-1;Initial Catalog=Estetica;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand inserirCommand = new SqlCommand($"insert into {table} values(@d1, @d2, @d3, @d4, @d5); SELECT SCOPE_IDENTITY();", connection);

            /*SqlCommand GetIdCommand = new SqlCommand($"Select * {table} values(@d1, @d2, @d3); ", connection);*/

            inserirCommand.Parameters.AddWithValue("@d1", d1);
            inserirCommand.Parameters.AddWithValue("@d2", d2);
            inserirCommand.Parameters.AddWithValue("@d3", d3);
            inserirCommand.Parameters.AddWithValue("@d4", d4);
            inserirCommand.Parameters.AddWithValue("@d5", d5);

            int commandID = Convert.ToInt32(inserirCommand.ExecuteScalar());

            connection.Close();

            return commandID;
        }
    }
}
