using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Projeto_Gioia.br.com.projeto.con
{
    public class ConnectionFactory
    {
        // Método para criar a conexão com o banco de dados
        public MySqlConnection GetConnection()
        {
            string conexao = ConfigurationManager.ConnectionStrings["bdgioia"].ConnectionString;

            return new MySqlConnection(conexao);
        }
    }
}
