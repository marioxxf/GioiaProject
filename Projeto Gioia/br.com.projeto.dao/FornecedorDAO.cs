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
    public class FornecedorDAO
    {
        // Atributo o construtor MySQL
        private MySqlConnection conexao;
        
        // Construtor
        public FornecedorDAO()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }

        // Métodos
        #region Método responsável por cadastrar um fornecedor
        public void CadastrarFornecedor(Fornecedores fornecedor)
        {
            try
            {
                // Comando SQL
                string sql = @"insert tb_fornecedores (nome,cnpj,email,telefone,celular,cep,
                             endereco,numero,complemento,bairro,cidade,estado) values (@nome, @cnpj, @email, @telefone, @celular, @cep, 
                             @endereco, @numero, @complemento, @bairro, @cidade, @estado)";

                // Organização do comando SQL
                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@nome", fornecedor.nome);
                executasql.Parameters.AddWithValue("@cnpj", fornecedor.cnpj);
                executasql.Parameters.AddWithValue("@email", fornecedor.email);
                executasql.Parameters.AddWithValue("@telefone", fornecedor.telefone);
                executasql.Parameters.AddWithValue("@celular", fornecedor.celular);
                executasql.Parameters.AddWithValue("@cep", fornecedor.cep);
                executasql.Parameters.AddWithValue("@endereco", fornecedor.endereco);
                executasql.Parameters.AddWithValue("@numero", fornecedor.numero);
                executasql.Parameters.AddWithValue("@complemento", fornecedor.complemento);
                executasql.Parameters.AddWithValue("@bairro", fornecedor.bairro);
                executasql.Parameters.AddWithValue("@cidade", fornecedor.cidade);
                executasql.Parameters.AddWithValue("@estado", fornecedor.uf);

                // Abertura da conexão + executação do comando SQL
                conexao.Open();
                executasql.ExecuteNonQuery();

                MessageBox.Show("Fornecedor cadastrado com sucesso!");

                // Fechamento da conexão
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro " + erro);
            }
        }
        #endregion

        #region Método responsável por alterar um fornecedor

        public void AlterarFornecedor(Fornecedores fornecedor)
        {
            try
            {
                // Comando SQL
                string sql = @"update tb_fornecedores set nome = @nome, cnpj = @cnpj, email = @email,
                             telefone = @telefone, celular = @celular, cep = @cep, endereco = @endereco,
                             numero = @numero, complemento = @complemento, bairro = @bairro, cidade = @cidade,
                             estado = @estado where id = @id";

                // Organização do comando SQL
                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@nome", fornecedor.nome);
                executasql.Parameters.AddWithValue("@cnpj", fornecedor.cnpj);
                executasql.Parameters.AddWithValue("@email", fornecedor.email);
                executasql.Parameters.AddWithValue("@telefone", fornecedor.telefone);
                executasql.Parameters.AddWithValue("@celular", fornecedor.celular);
                executasql.Parameters.AddWithValue("@cep", fornecedor.cep);
                executasql.Parameters.AddWithValue("@endereco", fornecedor.endereco);
                executasql.Parameters.AddWithValue("@numero", fornecedor.numero);
                executasql.Parameters.AddWithValue("@complemento", fornecedor.complemento);
                executasql.Parameters.AddWithValue("@bairro", fornecedor.bairro);
                executasql.Parameters.AddWithValue("@cidade", fornecedor.cidade);
                executasql.Parameters.AddWithValue("@estado", fornecedor.uf);

                executasql.Parameters.AddWithValue("@id", fornecedor.id);

                // Abertura da conexão + executação do comando SQL
                conexao.Open();
                executasql.ExecuteNonQuery();

                MessageBox.Show("Os dados do fornecedor foram atualizados com sucesso!");

                // Fechamento da conexão
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro " + erro);
            }
        }
        #endregion

        #region Método responsável por excluir um fornecedor

        public void ExcluirFornecedor(int idfornecedor)
        {
            try
            {
                // Comando SQL
                string sql = @"delete from tb_produtos where id = @id;

                             delete from tb_fornecedores where id = @id";

                // Organização do comando SQL
                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@id", idfornecedor);

                // Abertura da conexão + executação do comando SQL
                conexao.Open();
                executasql.ExecuteNonQuery();

                MessageBox.Show("Fornecedor excluído com sucesso!");

                // Fechamento da conexão
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro " + erro);
            }
        }
        #endregion

        #region Método responsável por listar todos os fornecedores
        public DataTable ListarTodosFornecedores()
        {
            try
            {
                // Criação do DataTable + Comando SQL
                DataTable tabelaFornecedor = new DataTable();
                string sql = @"select * from tb_fornecedores";

                // Organização do comando SQL
                MySqlCommand executasql = new MySqlCommand(sql, conexao);

                // Abertura da conexão + executação do comando SQL
                conexao.Open();
                executasql.ExecuteNonQuery();

                // Preenchimento do DataTable
                MySqlDataAdapter adapter = new MySqlDataAdapter(executasql);
                adapter.Fill(tabelaFornecedor);

                // Fechamento da conexão
                conexao.Close();

                return tabelaFornecedor;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro " + erro);
                return null;
            }
        }

        #endregion

        #region Método responsável por consultar o fornecedor pelo nome
        public DataTable ConsultarFornecedorPorNome(string nome)
        {
            try
            {
                // Criação do DataTable + Comando SQL
                DataTable tabelaFornecedor = new DataTable();
                string sql = @"select * from tb_fornecedores where nome like @nome";

                // Organização do comando SQL
                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@nome", nome);

                // Abertura da conexão + executação do comando SQL
                conexao.Open();
                executasql.ExecuteNonQuery();

                // Preenchimento do DataTable
                MySqlDataAdapter adapter = new MySqlDataAdapter(executasql);
                adapter.Fill(tabelaFornecedor);

                // Fechamento da conexão
                conexao.Close();

                return tabelaFornecedor;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro " + erro);
                return null;
            }
        }
        #endregion

        #region Método responsável por consultar o fornecedor pelo CNPJ
        public DataTable ConsultarFornecedorPorCNPJ(string cnpj)
        {
            try
            {
                // Criação do DataTable + Comando SQL
                DataTable tabelaFornecedor = new DataTable();
                string sql = @"select * from tb_fornecedores where cnpj = @cnpj";

                // Organização do comando SQL
                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@cnpj", cnpj);

                // Abertura da conexão + executação do comando SQL
                conexao.Open();
                executasql.ExecuteNonQuery();

                // Preenchimento do DataTable
                MySqlDataAdapter adapter = new MySqlDataAdapter(executasql);
                adapter.Fill(tabelaFornecedor);

                // Fechamento da conexão
                conexao.Close();

                return tabelaFornecedor;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro " + erro);
                return null;
            }
        }
        #endregion
    }
}
