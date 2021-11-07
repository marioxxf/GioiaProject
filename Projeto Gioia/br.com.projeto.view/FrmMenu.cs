using MySql.Data.MySqlClient;
using Projeto_Gioia.br.com.projeto.dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Gioia.br.com.projeto.view
{
    public partial class FrmMenu : Form
    {

        public string email, senha; // Criação de variáveis globais para o método EfetuarLogin fornecer o email e a senha do usuário.
        // Com essas informações, o método TestarLogin funcionará e validará se o usuário é Administrador ou Usuário.
        public FrmMenu()
        {
            InitializeComponent();
        }

        #region Opção Cadastro de Clientes (Cliente -> Cadastro de Clientes)
        private void cadastroDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientes tela = new FrmClientes();
            tela.Show();
        }
        #endregion

        #region Opção Consulta de Clientes (Aba Produtos -> Cadastro de Produtos)
        private void consultaDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FuncionarioDAO dao = new FuncionarioDAO();
            dao.RestringirFrmClientes(email, senha);
        }
        #endregion

        #region Opção Cadastro de Funcionários (Funcionários -> Cadastro de Funcionários)
        private void cadastroDeFuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFuncionarios tela = new FrmFuncionarios();
            tela.Show();
        }
        #endregion

        #region Opção Consulta de Funcionários (Funcionários -> Consulta de Funcionários)
        private void consultaDeFuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FuncionarioDAO dao = new FuncionarioDAO();
            dao.RestringirFrmFuncionarios(email, senha);
        }
        #endregion

        #region Opção Cadastro de Fornecedores (Fornecedores -> Cadastro de Fornecedores)
        private void cadastroDeFornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFornecedores tela = new FrmFornecedores();
            tela.Show();
        }
        #endregion

        #region Opção Consulta de Fornecedores (Fornecedores -> Consulta de Fornecedores)
        private void consultaDeFornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FuncionarioDAO dao = new FuncionarioDAO();
            dao.RestringirFrmFornecedores(email, senha);
        }
        #endregion

        #region Opção Cadastro de Produtos (Aba Produtos -> Cadastro de Produtos)
        private void cadastroDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProdutos tela = new FrmProdutos();
            tela.Show();
        }
        #endregion

        #region Opção Consulta de Produtos (Produtos -> Consulta de Produtos)
        private void consultaDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FuncionarioDAO dao = new FuncionarioDAO();
            dao.RestringirFrmProdutos(email, senha);
        }
        #endregion

        #region Opção Registro de Vendas (Aba Vendas -> Registro de Vendas)
        private void registroDeVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVendas tela = new FrmVendas();
            tela.Show();
        }
        #endregion

        #region Opção Histórico de Vendas (Aba Vendas -> Histórico de Vendas)
        private void opHistoricoVendas_Click(object sender, EventArgs e)
        {
            FrmHistorico tela = new FrmHistorico();
            tela.Show();
        }
        #endregion

        #region Programação do Timer que possibilita o funcionamento do fluxo do txthoraatual
        private void timer1_Tick(object sender, EventArgs e)
        {
            txthoraatual.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnbackup_Click(object sender, EventArgs e)
        {
            string arquivo = "C:\\backup.sql";
            string constring = "server=localhost;PORT=3306;user=root;pwd=mario;database=bdgioia; Convert Zero Datetime=True;";

            using (MySqlConnection conn = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        cmd.Connection = conn;
                        conn.Open();
                        mb.ExportToFile(arquivo);
                        conn.Close();
                        MessageBox.Show("Backup completo!");
                    }
                }
            }
        }
        #endregion

        #region Programação do FrmMenu Load
        private void FrmMenu_Load(object sender, EventArgs e)
        {
            txtdataatual.Text = DateTime.Now.ToShortDateString();

            timer1.Start();
        }
        #endregion
    }
}
