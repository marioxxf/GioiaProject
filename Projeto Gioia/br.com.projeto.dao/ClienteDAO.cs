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
    public class ClienteDAO
    {
        // Atributo da conexão
        private MySqlConnection conexao;

        // Construtor da conexão
        public ClienteDAO()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }

        // Métodos
        #region Método responsável por cadastrar um novo cliente
        public void CadastrarCliente(Clientes cliente)
        {
            try
            {
                // Comando SQL
                string sql = @"insert into tb_clientes (nome,rg,cpf,email,telefone,celular,cep,endereco,numero,complemento,bairro,cidade,estado)
                             values (@nome, @rg, @cpf, @email, @telefone, @celular, @cep, @endereco, @numero, @complemento, @bairro, @cidade, @estado)";

                // Organização do comando SQL
                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@nome",         cliente.nome);
                executasql.Parameters.AddWithValue("@rg",           cliente.rg);
                executasql.Parameters.AddWithValue("@cpf",          cliente.cpf);
                executasql.Parameters.AddWithValue("@email",        cliente.email);
                executasql.Parameters.AddWithValue("@telefone",     cliente.telefone);
                executasql.Parameters.AddWithValue("@celular",      cliente.celular);
                executasql.Parameters.AddWithValue("@cep",          cliente.cep);
                executasql.Parameters.AddWithValue("@endereco",     cliente.endereco);
                executasql.Parameters.AddWithValue("@numero",       cliente.numero);
                executasql.Parameters.AddWithValue("@complemento",  cliente.complemento);
                executasql.Parameters.AddWithValue("@bairro",       cliente.bairro);
                executasql.Parameters.AddWithValue("@cidade",       cliente.cidade);
                executasql.Parameters.AddWithValue("@estado",       cliente.uf);

                // Abertura de conexão para executação do comando SQL
                conexao.Open();
                executasql.ExecuteNonQuery();

                MessageBox.Show("Cliente cadastrado com sucesso!");

                // Fechamento da conexão
                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
            }
        }
        #endregion

        #region Método responsável por alterar um cliente
        public void AlterarCliente(Fornecedores cliente)
        {
            try
            {
                // Comando SQL
                string sql = @"update tb_clientes set nome  = @nome, rg = @rg, cpf = @cpf,
                               cep = @cep, endereco = @endereco, numero = @numero, complemento = @complemento,
                               bairro = @bairro, cidade = @cidade, estado = @estado where id = @id";

                // Organização do comando SQL
                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@nome", cliente.nome);
                executasql.Parameters.AddWithValue("@rg", cliente.rg);
                executasql.Parameters.AddWithValue("@cpf", cliente.cpf);
                executasql.Parameters.AddWithValue("@email", cliente.email);
                executasql.Parameters.AddWithValue("@telefone", cliente.telefone);
                executasql.Parameters.AddWithValue("@celular", cliente.celular);
                executasql.Parameters.AddWithValue("@cep", cliente.cep);
                executasql.Parameters.AddWithValue("@endereco", cliente.endereco);
                executasql.Parameters.AddWithValue("@numero", cliente.numero);
                executasql.Parameters.AddWithValue("@complemento", cliente.complemento);
                executasql.Parameters.AddWithValue("@bairro", cliente.bairro);
                executasql.Parameters.AddWithValue("@cidade", cliente.cidade);
                executasql.Parameters.AddWithValue("@estado", cliente.uf);

                executasql.Parameters.AddWithValue("@id", cliente.id);

                // Abertura de conexão para executação do comando SQL
                conexao.Open();
                executasql.ExecuteNonQuery();

                MessageBox.Show("Os dados do cliente foram atualizados com sucesso!");

                // Fechamento da conexão
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
            }
        }
        #endregion

        #region Método que exclui um cliente
        public void ExcluirCliente(int idcliente)
        {
            try
            {
                // Comando SQL
                string sql = @"delete from tb_clientes where id = @id";

                // Organização do comando SQL
                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@id", idcliente);

                // Abertura de conexão para executação do comando SQL
                conexao.Open();
                executasql.ExecuteNonQuery();

                MessageBox.Show("Cliente excluído com sucesso!");

                // Fechamento da conexão
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
            }
        }
        #endregion

        #region Método que lista todos os clientes
        public DataTable ListarTodosClientes()
        {
            try
            {
                // Criação da DataTable + Comando SQL
                DataTable tabelaCliente = new DataTable();
                string sql = @"select * from tb_clientes";

                // Organização do comando SQL
                MySqlCommand executasql = new MySqlCommand(sql, conexao);

                // Abertura de conexão para executação do comando SQL
                conexao.Open();
                executasql.ExecuteNonQuery();

                // Preenchimento do DataTable
                MySqlDataAdapter adapter = new MySqlDataAdapter(executasql);
                adapter.Fill(tabelaCliente);

                // // Fechamento da conexão
                conexao.Close();

                return tabelaCliente;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
                return null;
            }
        }

        #endregion

        #region Método que consulta um cliente por nome
        public DataTable ConsultarClientePorNome(string nome)
        {
            try
            {
                // Criação do DataTabela + Comando SQL
                DataTable tabelaCliente = new DataTable();
                string sql = @"select * from tb_clientes where nome like @nome";

                // Organização do comando SQL
                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@nome", nome);

                // Abertura de conexão para executação do comando SQL
                conexao.Open();
                executasql.ExecuteNonQuery();

                // Preenchimento do DataTable
                MySqlDataAdapter adapter = new MySqlDataAdapter(executasql);
                adapter.Fill(tabelaCliente);

                // Fechamento da conexão
                conexao.Close();

                return tabelaCliente;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
                return null;
            }
        }
        #endregion

        #region Método que consulta um cliente por CPF
        public DataTable ConsultarClientePorCPF(string cpf)
        {
            try
            {
                // Criação do DataTabela + Comando SQL
                DataTable tabelaCliente = new DataTable();
                string sql = @"select * from tb_clientes where cpf = @cpf";

                // Organização do comando SQL
                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@cpf", cpf);

                // // Abertura de conexão para executação do comando SQL
                conexao.Open();
                executasql.ExecuteNonQuery();

                // Preenchimento do DataTable
                MySqlDataAdapter adapter = new MySqlDataAdapter(executasql);
                adapter.Fill(tabelaCliente);

                // // Fechamento da conexão
                conexao.Close();

                return tabelaCliente;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
                return null;
            }
        }
        #endregion

        #region Método responsável por retornar um objeto do tipo Cliente através do CPF
        public Clientes RetornaClientePorCPF(string cpf)
        {
            try
            {
                // Criação do comando SQL e objeto Cliente
                Clientes cliente = new Clientes();
                string sql = @"select * from tb_clientes where cpf = @cpf";

                // Organização e execução do comando SQL
                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@cpf", cpf);

                // Abertura da conexão para a execução do comando SQL
                conexao.Open();

                // Montagem do objeto Cliente para ser retornado
                MySqlDataReader rs = executasql.ExecuteReader();

                if(rs.Read())
                {
                    // Montagem do objeto
                    cliente.id = rs.GetInt32("id");
                    cliente.nome = rs.GetString("nome");

                    conexao.Close();
                    return cliente;
                }
                else
                {
                    // Cãso não encontre ninguém
                    MessageBox.Show("Cliente não encontrado no banco de dados!");
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
