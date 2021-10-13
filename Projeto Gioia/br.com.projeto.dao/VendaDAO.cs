using MySql.Data.MySqlClient;
using Projeto_Gioia.br.com.projeto.con;
using Projeto_Gioia.br.com.projeto.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Gioia.br.com.projeto.dao
{
    public class VendaDAO
    {
        // Atributo
        private MySqlConnection conexao;

        // Construtor
        public VendaDAO()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }

        // Métodos
        #region Método para cadastrar uma venda
        public void CadastrarVenda(Vendas venda)
        {
            try
            {
                // Criação do comando SQL + DataTable
                string sql = @"insert into tb_vendas (cliente_id, data_venda, total_venda, observacoes)
                             values (@cliente_id, @data_venda, @total_venda, @observacoes)";

                // Organização do comando SQL
                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@cliente_id", venda.cliente_id);
                executasql.Parameters.AddWithValue("@data_venda", venda.data_venda);
                executasql.Parameters.AddWithValue("@total_venda", venda.total_venda);
                executasql.Parameters.AddWithValue("@observacoes", venda.obs);

                // Abertura de conexão e execução do comando SQL
                conexao.Open();
                executasql.ExecuteNonQuery();

                MessageBox.Show("Venda cadastrada com sucesso!");

                // Fechamento da conexão
                conexao.Close();
            }
            catch(Exception erro)
            {
                MessageBox.Show("Aconteceu o erro " + erro);
            }
        }
        #endregion
    }
}
