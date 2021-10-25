using MySql.Data.MySqlClient;
using Projeto_Gioia.br.com.projeto.con;
using Projeto_Gioia.br.com.projeto.model;
using System;
using System.Collections.Generic;
using System.Data;
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
                // Criação do comando SQL
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

        #region Método responsável por retornar o ID da última venda
        public int RetornaIdUltimaVenda()
        {
            try
            {
                int idvenda = 0;

                string sql = @"select max(id) id from tb_vendas";

                MySqlCommand executasql = new MySqlCommand(sql, conexao);

                conexao.Open();

                MySqlDataReader rs = executasql.ExecuteReader();

                if(rs.Read())
                {
                    idvenda = rs.GetInt32("id");
                }
                else
                {
                    MessageBox.Show("Não foi encontrada vendas no banco de dados!");
                }

                conexao.Close();
                return idvenda;
            }
            catch(Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
                conexao.Close();
                return 0;
            }
        }
        #endregion

        #region Método responsável por filtrar vendas por determinado período
        public DataTable ListarVendasPorPeriodo(DateTime dtinicio, DateTime dtfim)
        {
            try
            {
                DataTable tabelaHistorico = new DataTable();

                string sql = @"SELECT v.id as 'Código da Venda',
                             v.data_venda as 'Data',
                             v.total_venda as 'Total',
                             c.nome as 'Cliente',
                             v.observacoes as 'Obs'
                             FROM TB_VENDAS as v join TB_CLIENTES as C ON (v.cliente_id = c.id)
                             WHERE v.data_venda BETWEEN @datainicio and @datafim";

                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@datainicio", dtinicio);
                executasql.Parameters.AddWithValue("@datafim", dtfim);

                conexao.Open();
                executasql.ExecuteNonQuery();

                MySqlDataAdapter adapter = new MySqlDataAdapter(executasql);
                adapter.Fill(tabelaHistorico);
                conexao.Close();

                return tabelaHistorico;
            }
            catch(Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
                return null;
            }
        }
        #endregion

        #region Método responsável por retornar a lista de todas as vendas
        public DataTable ListarTodasVendas()
        {
            try
            {
                DataTable tabelaHistorico = new DataTable();

                string sql = @"SELECT v.id as 'Código da Venda',
                             v.data_venda as 'Data',
                             v.total_venda as 'Total',
                             c.nome as 'Cliente',
                             v.observacoes as 'Obs'
                             FROM TB_VENDAS as v join TB_CLIENTES as C ON (v.cliente_id = c.id)";

                MySqlCommand executasql = new MySqlCommand(sql, conexao);

                conexao.Open();
                executasql.ExecuteNonQuery();

                MySqlDataAdapter adapter = new MySqlDataAdapter(executasql);
                adapter.Fill(tabelaHistorico);
                conexao.Close();

                return tabelaHistorico;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
                return null;
            }
        }
        #endregion

        #region Método responsável por retornar detalhes de uma venda
        public DataTable ListarDetalhes(int id)
        {
            try
            {
                DataTable tabelaDetalhes = new DataTable();

                string sql = @"select 	p.descricao as 'Produto',
		                                i.qtd as 'Qtd comprada',
                                        p.preco_venda as 'Valor',
                                        i.subtotal as 'Subtotal'
                               from tb_produtos as p join tb_itensvendas as i on (p.id = i.produto_id)
                               where i.venda_id = @id;";

                MySqlCommand executasql = new MySqlCommand(sql, conexao);

                executasql.Parameters.AddWithValue("@id", id);

                conexao.Open();
                executasql.ExecuteNonQuery();

                MySqlDataAdapter adapter = new MySqlDataAdapter(executasql);
                adapter.Fill(tabelaDetalhes);
                conexao.Close();

                return tabelaDetalhes;
            }
            catch(Exception erro)
            {
                MessageBox.Show("Aconteceu o erro " + erro);
                return null;
            }
        }
        #endregion
    }
}
