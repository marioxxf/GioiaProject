using MySql.Data.MySqlClient;
using Projeto_Gioia.br.com.projeto.con;
using Projeto_Gioia.br.com.projeto.model;
using Projeto_Gioia.br.com.projeto.view;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Gioia.br.com.projeto.dao
{
    public class FuncionarioDAO
    {
        // Atributo para construtor MySQL
        private MySqlConnection conexao;

        // Construtor
        public FuncionarioDAO()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }

        // Métodos
        #region Método que cadastra um funcionário
        public void CadastrarFuncionario(Funcionarios funcionario)
        {
            try
            {
                // Comando SQL
                string sql = @"insert into tb_funcionarios (nome,rg,cpf,email,senha,cargo,nivel_acesso,telefone,celular,cep,endereco,numero,complemento,bairro,cidade,estado)
                              values (@nome, @rg, @cpf, @email, @senha, @cargo, @nivel_acesso, @telefone, @celular, @cep, @endereco, @numero, @complemento, @bairro, @cidade, @estado)";

                // Organização do comando SQL
                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@nome", funcionario.nome);
                executasql.Parameters.AddWithValue("@rg", funcionario.rg);
                executasql.Parameters.AddWithValue("@cpf", funcionario.cpf);
                executasql.Parameters.AddWithValue("@email", funcionario.email);
                executasql.Parameters.AddWithValue("@senha", funcionario.senha);
                executasql.Parameters.AddWithValue("@cargo", funcionario.cargo);
                executasql.Parameters.AddWithValue("@nivel_acesso", funcionario.nivel_acesso);
                executasql.Parameters.AddWithValue("@telefone", funcionario.telefone);
                executasql.Parameters.AddWithValue("@celular", funcionario.celular);
                executasql.Parameters.AddWithValue("@cep", funcionario.cep);
                executasql.Parameters.AddWithValue("@endereco", funcionario.endereco);
                executasql.Parameters.AddWithValue("@numero", funcionario.numero);
                executasql.Parameters.AddWithValue("@complemento", funcionario.complemento);
                executasql.Parameters.AddWithValue("@bairro", funcionario.bairro);
                executasql.Parameters.AddWithValue("@cidade", funcionario.cidade);
                executasql.Parameters.AddWithValue("@estado", funcionario.uf);

                // Abertura de conexão + executação do comando SQL
                conexao.Open();
                executasql.ExecuteNonQuery();

                MessageBox.Show("Funcionário cadastrado com sucesso!");

                // Fechamento da conexão SQL
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro " + erro);
            }
        }
        #endregion

        #region Método que altera um funcionário
        public void AlterarFuncionario(Funcionarios funcionario)
        {
            try
            {
                // Comando SQL
                string sql = @"update tb_funcionarios set nome = @nome, rg = @rg, cpf = @cpf, email = @email,
                               senha = @senha, cargo = @cargo, nivel_acesso = @nivel_acesso, telefone = @telefone,
                               celular = @celular, cep = @cep, endereco = @endereco, numero = @numero, complemento = @complemento, 
                               bairro = @bairro, cidade = @cidade, estado = @estado where id = @id";

                // Organização do comando SQL
                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@nome", funcionario.nome);
                executasql.Parameters.AddWithValue("@rg", funcionario.rg);
                executasql.Parameters.AddWithValue("@cpf", funcionario.cpf);
                executasql.Parameters.AddWithValue("@email", funcionario.email);
                executasql.Parameters.AddWithValue("@senha", funcionario.senha);
                executasql.Parameters.AddWithValue("@cargo", funcionario.cargo);
                executasql.Parameters.AddWithValue("@nivel_acesso", funcionario.nivel_acesso);
                executasql.Parameters.AddWithValue("@telefone", funcionario.telefone);
                executasql.Parameters.AddWithValue("@celular", funcionario.celular);
                executasql.Parameters.AddWithValue("@cep", funcionario.cep);
                executasql.Parameters.AddWithValue("@endereco", funcionario.endereco);
                executasql.Parameters.AddWithValue("@numero", funcionario.numero);
                executasql.Parameters.AddWithValue("@complemento", funcionario.complemento);
                executasql.Parameters.AddWithValue("@bairro", funcionario.bairro);
                executasql.Parameters.AddWithValue("@cidade", funcionario.cidade);
                executasql.Parameters.AddWithValue("@estado", funcionario.uf);

                executasql.Parameters.AddWithValue("@id", funcionario.id);

                // Abertura de conexão + executação do comando SQL
                conexao.Open();
                executasql.ExecuteNonQuery();

                MessageBox.Show("Os dados do funcionário foram atualizados com sucesso!");

                // Fechamento da conexão
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro " + erro);
            }
        }
        #endregion

        #region Método que exclui um funcionário
        public void ExcluirFuncionario(int idfuncionario)
        {
            try
            {
                // Comando SQL
                string sql = @"delete from tb_funcionarios where id = @id";

                // Organização do comando SQL
                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@id", idfuncionario);

                // Abertura da conexão + execução do comando SQL
                conexao.Open();
                executasql.ExecuteNonQuery();

                MessageBox.Show("Funcionário excluído com sucesso!");

                // Fechamento da conexão
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro " + erro);
            }
        }
        #endregion

        #region Método que lista todos os funcionários
        public DataTable ListarTodosFuncionarios()
        {
            try
            {
                // Criação do DataTable + comando SQL
                DataTable tabelaFuncionario = new DataTable();
                string sql = @"select * from tb_funcionarios";

                // Organização do comando SQL
                MySqlCommand executasql = new MySqlCommand(sql, conexao);

                // Abertura de conexão + executação do comando SQL
                conexao.Open();
                executasql.ExecuteNonQuery();

                // Preenchimento do DataTable
                MySqlDataAdapter adapter = new MySqlDataAdapter(executasql);
                adapter.Fill(tabelaFuncionario);

                // Fechamento da conexão
                conexao.Close();

                return tabelaFuncionario;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro " + erro);
                return null;
            }
        }
        #endregion

        #region Método que consulta um funcionário pelo nome
        public DataTable ConsultarFuncionarioPorNome(string nome)
        {
            try
            {
                // Criação do DataTable + comando SQL
                DataTable tabelaFuncionario = new DataTable();
                string sql = @"select * from tb_funcionarios where nome like @nome";

                // Organização do comando SQL
                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@nome", nome);

                // Abertura da conexão + executação do comando SQL
                conexao.Open();
                executasql.ExecuteNonQuery();

                // Preenchimento do DataTable
                MySqlDataAdapter adapter = new MySqlDataAdapter(executasql);
                adapter.Fill(tabelaFuncionario);

                // Fechamento da conexão
                conexao.Close();

                return tabelaFuncionario;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro " + erro);
                return null;
            }
        }
        #endregion

        #region Método que consulta um funcionário pelo CPF
        public DataTable ConsultarFuncionarioPorCPF(string cpf)
        {
            try
            {
                // Criação do DataTable + comando SQL
                DataTable tabelaFuncionario = new DataTable();
                string sql = @"select * from tb_funcionarios where cpf = @cpf";

                // Organização do comando SQL
                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@cpf", cpf);

                // Abertura da conexão + executação do comando SQL
                conexao.Open();
                executasql.ExecuteNonQuery();

                // Preenchimento do DataTable
                MySqlDataAdapter adapter = new MySqlDataAdapter(executasql);
                adapter.Fill(tabelaFuncionario);

                // Fechamento da conexão
                conexao.Close();

                return tabelaFuncionario;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro " + erro);
                return null;
            }
        }
        #endregion

        #region Método responsável por efetuar login
        public void EfetuarLogin(string email, string senha)
        {
            try
            {
                string sql = @"select * from tb_funcionarios where email = @email AND senha = @senha";
                
                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@email", email);
                executasql.Parameters.AddWithValue("@senha", senha);

                conexao.Open();
                MySqlDataReader rs = executasql.ExecuteReader();

                if(rs.Read())
                {
                    string nivel = rs.GetString("nivel_acesso");
                    string nome = rs.GetString("nome");

                    FrmMenu tela = new FrmMenu();
                    tela.lbllogado.Text = nome;

                    tela.email = email;
                    tela.senha = senha;

                    if(nivel.Equals("Administrador"))
                    {
                        MessageBox.Show("Bem-vindo ao sistema, administrador " + nome + "!");
                        tela.ShowDialog();
                    }
                    else if(nivel.Equals("Usuário"))
                    {
                        MessageBox.Show("Bem-vindo ao sistema, usuário " + nome + "!");

                        // Especificação das permissões
                        tela.opCadastroCliente.Enabled = false;
                        tela.opCadastroFuncionario.Enabled = false;
                        tela.opCadastroFornecedor.Enabled = false;
                        tela.opCadastroProduto.Enabled = false;
                        tela.opRegistroVendas.Enabled = false;

                        tela.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("O usuário possui um nível de acesso errado!");
                    }
                    conexao.Close();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorreto!");
                }
            }
            catch(Exception erro)
            {
                MessageBox.Show("Aconteceu o erro " + erro);
            }
        }
        #endregion

        #region Método responsável por verificar se o nível do usuário logado é Administrador ou Usuário comum e, com base nisso, criar restrições no FrmClientes
        public void RestringirFrmClientes(string email, string senha)
        {
            try
            {
                string sql = @"select * from tb_funcionarios where email = @email AND senha = @senha";

                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@email", email);
                executasql.Parameters.AddWithValue("@senha", senha);

                conexao.Open();
                MySqlDataReader rs = executasql.ExecuteReader();

                if (rs.Read())
                {
                    string nivel = rs.GetString("nivel_acesso");

                    FrmClientes telaCliente = new FrmClientes();

                    if (nivel.Equals("Administrador"))
                    {
                        // Nenhuma restrição a fazer
                        telaCliente.Show();
                        telaCliente.tabControl1.SelectedTab = telaCliente.tab2;
                    }
                    else if (nivel.Equals("Usuário"))
                    {
                        // Definição das permissões
                        telaCliente.Show();
                        telaCliente.tab1.Enabled = false;
                        telaCliente.tabControl1.SelectedTab = telaCliente.tab2;
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha incorreto!");
                    }
                    conexao.Close();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro " + erro);
            }
        }
        #endregion

        #region Método responsável por verificar se o nível do usuário logado é Administrador ou Usuário comum e, com base nisso, criar restrições no FrmFuncionarios
        public void RestringirFrmFuncionarios(string email, string senha)
        {
            try
            {
                string sql = @"select * from tb_funcionarios where email = @email AND senha = @senha";

                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@email", email);
                executasql.Parameters.AddWithValue("@senha", senha);

                conexao.Open();
                MySqlDataReader rs = executasql.ExecuteReader();

                if (rs.Read())
                {
                    string nivel = rs.GetString("nivel_acesso");

                    FrmFuncionarios telaFuncionario = new FrmFuncionarios();

                    if (nivel.Equals("Administrador"))
                    {
                        // Nenhuma restrição a fazer
                        telaFuncionario.Show();
                        telaFuncionario.tabControl1.SelectedTab = telaFuncionario.tab2;
                    }
                    else if (nivel.Equals("Usuário"))
                    {
                        // Definição das permissões
                        telaFuncionario.Show();
                        telaFuncionario.tab1.Enabled = false;
                        telaFuncionario.tabControl1.SelectedTab = telaFuncionario.tab2;
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha incorreto!");
                    }
                    conexao.Close();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro " + erro);
            }
        }
        #endregion

        #region Método responsável por verificar se o nível do usuário logado é Administrador ou Usuário comum e, com base nisso, criar restrições no FrmFornecedores
        public void RestringirFrmFornecedores(string email, string senha)
        {
            try
            {
                string sql = @"select * from tb_funcionarios where email = @email AND senha = @senha";

                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@email", email);
                executasql.Parameters.AddWithValue("@senha", senha);

                conexao.Open();
                MySqlDataReader rs = executasql.ExecuteReader();

                if (rs.Read())
                {
                    string nivel = rs.GetString("nivel_acesso");

                    FrmFornecedores telaFornecedor = new FrmFornecedores();

                    if (nivel.Equals("Administrador"))
                    {
                        // Nenhuma restrição a fazer
                        telaFornecedor.Show();
                        telaFornecedor.tabControl1.SelectedTab = telaFornecedor.tab2;
                    }
                    else if (nivel.Equals("Usuário"))
                    {
                        // Definição das permissões
                        telaFornecedor.Show();
                        telaFornecedor.tab1.Enabled = false;
                        telaFornecedor.tabControl1.SelectedTab = telaFornecedor.tab2;
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha incorreto!");
                    }
                    conexao.Close();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro " + erro);
            }
        }
        #endregion

        #region Método responsável por verificar se o nível do usuário logado é Administrador ou Usuário comum e, com base nisso, criar restrições no FrmProdutos
        public void RestringirFrmProdutos(string email, string senha)
        {
            try
            {
                string sql = @"select * from tb_funcionarios where email = @email AND senha = @senha";

                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@email", email);
                executasql.Parameters.AddWithValue("@senha", senha);

                conexao.Open();
                MySqlDataReader rs = executasql.ExecuteReader();

                if (rs.Read())
                {
                    string nivel = rs.GetString("nivel_acesso");

                    FrmProdutos telaProduto = new FrmProdutos();

                    if (nivel.Equals("Administrador"))
                    {
                        // Nenhuma restrição a fazer
                        telaProduto.Show();
                        telaProduto.tabControl1.SelectedTab = telaProduto.tab2;
                    }
                    else if (nivel.Equals("Usuário"))
                    {
                        // Definição das permissões
                        telaProduto.Show();
                        telaProduto.tab1.Enabled = false;
                        telaProduto.tabControl1.SelectedTab = telaProduto.tab2;
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha incorreto!");
                    }
                    conexao.Close();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro " + erro);
            }
        }
        #endregion
    }
}
