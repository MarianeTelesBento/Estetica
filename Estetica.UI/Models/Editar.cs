using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Estetica.UI.Models
{
    public class Editar : Validacao
    {
        
        public List<string> EditarDados(string table, int d1) 
        {
            List<string> DadosCliente = new List<string>();

            string connectionString = "Data Source=FAC0539673W10-1;Initial Catalog=Estetica;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();


            if (table == "Cliente")
            {
                SqlCommand pesquisaCommand = new SqlCommand($"SELECT * FROM {table} WHERE IdCliente = @d1; ", connection);

                pesquisaCommand.Parameters.AddWithValue("@d1", d1);


                SqlDataReader reader = pesquisaCommand.ExecuteReader();

                if (reader.HasRows)//Preenche os TEXTS se ouver linha
                {
                    reader.Read();
                    DadosCliente.Add(reader["NomeCliente"].ToString());
                    DadosCliente.Add(reader["IdadeCliente"].ToString());
                    DadosCliente.Add(reader["EmailCliente"].ToString());

                    DadosCliente.Add(reader["TelefoneCliente"].ToString());
                    DadosCliente.Add(reader["CepCliente"].ToString());
                    DadosCliente.Add(reader["GeneroCliente"].ToString());
                    DadosCliente.Add(reader["ClassificacaoFitzpatrickCliente"].ToString());
                    DadosCliente.Add(reader["EspessuraPeleCliente"].ToString());
                    DadosCliente.Add(reader["OleosidadePeleCliente"].ToString());
                    DadosCliente.Add(reader["HidratacaoPeleCliente"].ToString());
                    DadosCliente.Add(reader["LesoesPeleCliente"].ToString());

                    return DadosCliente;
                }
                else
                {
                    DadosCliente.Add("ID, não encontrado");
                    return DadosCliente;
                }
            }
            else
            {
                SqlCommand pesquisaCommand = new SqlCommand($"SELECT * FROM {table} WHERE IdAtendimento = @d1; ", connection);

                pesquisaCommand.Parameters.AddWithValue("@d1", d1);

                SqlDataReader reader = pesquisaCommand.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    DadosCliente.Add(reader["IdCliente"].ToString());
                    DadosCliente.Add(reader["IdAtendente"].ToString());
                    DadosCliente.Add(reader["ProcedimentoAtendimento"].ToString());

                    DadosCliente.Add(reader["ProdutoAtendimento"].ToString());
                    DadosCliente.Add(reader["TempoAtendimento"].ToString());

                    return DadosCliente;
                }
                else
                {
                    DadosCliente.Add("ID, não encontrado");
                    return DadosCliente;
                }
            }

            connection.Close();

        }


        
    }
}
