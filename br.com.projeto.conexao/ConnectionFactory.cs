using MySql.Data.MySqlClient;
using System.Configuration;

namespace ProjetoControleVendas.br.com.projeto.conexao
{
    public class ConnectionFactory
    {
        // Metodo que conecta o banco de dados
        public MySqlConnection getconnection()
        {
            string conexao = ConfigurationManager.ConnectionStrings["bdvendas"].ConnectionString;

            return new MySqlConnection(conexao); 
        }
    }
}
