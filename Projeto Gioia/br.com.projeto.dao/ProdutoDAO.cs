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
    public class ProdutoDAO
    {
        // Atributo do construtor
        private MySqlConnection conexao;

        // Construtor MySQl
        public ProdutoDAO()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }

        // Métodos
        #region Método que cadastra um produto
        public void CadastrarProduto(Produtos produto)
        {
            try
            {
                // Comando SQL
                string sql = @"insert into tb_produtos (descricao, preco_custo, preco_venda, qtd_estoque, for_id)
                             values (@descricao, @preco_custo, @preco_venda, @qtd_estoque, @for_id)";

                // Organizãção do comando SQL
                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@descricao", produto.descricao);
                executasql.Parameters.AddWithValue("@preco_custo", produto.preco_custo);
                executasql.Parameters.AddWithValue("@preco_venda", produto.preco_venda);
                executasql.Parameters.AddWithValue("@qtd_estoque", produto.qtd_estoque);
                executasql.Parameters.AddWithValue("@for_id", produto.for_id);

                // Abertura de conexão + executação de comando SQL
                conexao.Open();
                executasql.ExecuteNonQuery();

                // Fechamento de conexão
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
            }
        }
        #endregion

        #region Método que altera um produto
        public void AlterarProduto(Produtos produto)
        {
            try
            {
                // Comando SQL
                string sql = @"update tb_produtos set descricao = @descricao, preco_custo = @preco_custo, preco_venda = @preco_venda, 
                             qtd_estoque = @qtd_estoque, for_id = @for_id
                             where id = @id";

                // Organizãção do comando SQL
                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@descricao", produto.descricao);
                executasql.Parameters.AddWithValue("@preco_custo", produto.preco_custo);
                executasql.Parameters.AddWithValue("@preco_venda", produto.preco_venda);
                executasql.Parameters.AddWithValue("@qtd_estoque", produto.qtd_estoque);
                executasql.Parameters.AddWithValue("@for_id", produto.for_id);

                executasql.Parameters.AddWithValue("@id", produto.id);

                // Abertura de conexão + executação de comando SQL
                conexao.Open();
                executasql.ExecuteNonQuery();

                MessageBox.Show("Os dados do produto foram atualizados com sucesso!");

                // Fechamento de conexão
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
            }
        }
        #endregion

        #region Método que exclui um produto
        public void ExcluirProduto(Produtos produto)
        {
            try
            {
                // Comando SQL
                string sql = @"delete from tb_produtos where id = @id";

                // Organizãção do comando SQL
                MySqlCommand executasql = new MySqlCommand(sql, conexao);

                executasql.Parameters.AddWithValue("@id", produto.id);

                // Abertura de conexão + executação de comando SQL
                conexao.Open();
                executasql.ExecuteNonQuery();
                MessageBox.Show("Produto excluido com sucesso");

                // Fechamento de conexão
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
            }
        }
        #endregion

        #region Método que lista todos os produtos
        public DataTable ListarTodosProdutos()
        {
            try
            {
                // Criação do DataTabler + Comando SQL
                DataTable tabelaProduto = new DataTable();
                string sql = @"SELECT p.id as 'Código',
	                           p.descricao as 'Descrição',
                               p.preco_custo as 'Preço de Custo',
                               p.preco_venda as 'Preço de Venda',
                               p.qtd_estoque as 'Qtd',
                               f.nome as 'Fornecedor' FROM tb_produtos as p
	                           join tb_fornecedores as f on (p.for_id = f.id);";

                // Organizãção do comando SQL
                MySqlCommand executasql = new MySqlCommand(sql, conexao);

                // Abertura de conexão + executação de comando SQL
                conexao.Open();
                executasql.ExecuteNonQuery();

                // Preenchimento do DataTable
                MySqlDataAdapter adapter = new MySqlDataAdapter(executasql);
                adapter.Fill(tabelaProduto);

                // Abertura de conexão
                conexao.Close();

                return tabelaProduto;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
                return null;
            }
        }
        #endregion

        #region Método que lista todos os produtos por nome
        public DataTable ListarTodosProdutosPorNome(string nome)
        {
            try
            {
                // 1o passo: Criar o comando SQL e o nosso DataTable
                DataTable tabelaProduto = new DataTable();
                string sql = @"SELECT p.id as 'Código',
                                p.descricao as 'Descrição',
                                p.preco_custo as 'Preço de Custo',
                                p.preco_venda as 'Preço de Venda',
                                p.qtd_estoque as 'Qtd',
                                f.nome as 'Fornecedor' FROM tb_produtos as p
                                join tb_fornecedores as f on (p.for_id = f.id)
                                WHERE p.descricao like @nome;";

                // 2o passo: Organizar e executar o comando SQL
                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@nome", nome);

                // 3o passo: Abrir a conexão e executá-la
                conexao.Open();
                executasql.ExecuteNonQuery();

                //4o passo: Preencher o nosso DataTable com os dados do Select
                MySqlDataAdapter adapter = new MySqlDataAdapter(executasql);
                adapter.Fill(tabelaProduto);
                conexao.Close();

                return tabelaProduto;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
                return null;
            }
        }
        #endregion

        #region Método que retorna um objeto Produto através do código
        public Produtos RetornaProdutoPorID(int id)
        {
            try
            {
                // Criãção do comando SQL e do objeto Produto
                Produtos produto = new Produtos();
                string sql = @"select * from tb_produtos where id = @id";

                // Organização e execução do comando SQL
                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@id", id);

                // Abertura da conexão
                conexao.Open();

                // Montagem do objeto Produto
                MySqlDataReader rs = executasql.ExecuteReader();

                if(rs.Read())
                {
                    produto.id = rs.GetInt32("id");
                    produto.descricao = rs.GetString("descricao");
                    produto.preco_custo = rs.GetDecimal("preco_venda");
                    conexao.Close();
                    return produto;
                }
                else
                {
                    // Caso não encontre o produto
                    MessageBox.Show("Produto não encontrado no banco de dados.");
                    conexao.Close();
                    return null;
                }
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
