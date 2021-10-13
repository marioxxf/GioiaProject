using Projeto_Gioia.br.com.projeto.dao;
using Projeto_Gioia.br.com.projeto.model;
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
    public partial class FrmFuncionarios : Form
    {
        public FrmFuncionarios()
        {
            InitializeComponent();
        }

        #region Método que carrega o DataGridView da tela Consulta de Clientes de forma automática
        private void FrmFuncionarios_Load(object sender, EventArgs e)
        {
            FuncionarioDAO dao = new FuncionarioDAO();
            dgfuncionarios.DataSource = dao.ListarTodosFuncionarios();
        }
        #endregion

        #region Método para procurar funcionário por nome (evento TextChanged no txtconsulta (tabPage "Consulta de Funcionários"))
        private void txtconsulta_TextChanged(object sender, EventArgs e)
        {
            string nome = "%" + txtconsulta.Text + "%";
            FuncionarioDAO dao = new FuncionarioDAO();
            dgfuncionarios.DataSource = dao.ConsultarFuncionarioPorNome(nome);
        }
        #endregion

        #region Método responsável por, ao clicar em qualquer linha do DataGridView (Consulta de Clientes), selecionar os todos os dados do cliente e ir para a tela principal
        private void dgfuncionarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Pegando os dados da linha selecionada
            txtcodigo.Text =        dgfuncionarios.CurrentRow.Cells[0].Value.ToString();
            txtnome.Text =          dgfuncionarios.CurrentRow.Cells[1].Value.ToString();
            txtrg.Text =            dgfuncionarios.CurrentRow.Cells[2].Value.ToString();
            txtcpf.Text =           dgfuncionarios.CurrentRow.Cells[3].Value.ToString();
            txtemail.Text =         dgfuncionarios.CurrentRow.Cells[4].Value.ToString();
            txtsenha.Text =         dgfuncionarios.CurrentRow.Cells[5].Value.ToString();
            txtcargo.Text =         dgfuncionarios.CurrentRow.Cells[6].Value.ToString();
            cbnivelacesso.Text =   dgfuncionarios.CurrentRow.Cells[7].Value.ToString();
            txttelefone.Text =      dgfuncionarios.CurrentRow.Cells[8].Value.ToString();
            txtcelular.Text =       dgfuncionarios.CurrentRow.Cells[9].Value.ToString();
            txtcep.Text =           dgfuncionarios.CurrentRow.Cells[10].Value.ToString();
            txtendereco.Text =      dgfuncionarios.CurrentRow.Cells[11].Value.ToString();
            txtnumero.Text =        dgfuncionarios.CurrentRow.Cells[12].Value.ToString();
            txtcomplemento.Text =   dgfuncionarios.CurrentRow.Cells[13].Value.ToString();
            txtbairro.Text =        dgfuncionarios.CurrentRow.Cells[14].Value.ToString();
            txtcidade.Text =        dgfuncionarios.CurrentRow.Cells[15].Value.ToString();
            cbuf.Text =             dgfuncionarios.CurrentRow.Cells[16].Value.ToString();

            // Alterando o TabPage para a guia de Dados Pessoais
            tabControl1.SelectedTab = tab1;
        }
        #endregion

        #region Botão Pesquisar
        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                // Recebendo o CEP
                string cep = txtcep.Text;
                string xml = "https://viacep.com.br/ws/" + cep + "/xml/";

                // Estrutura da leitura do arquivo .xml
                DataSet dados = new DataSet();
                dados.ReadXml(xml);

                // Direcionando os dados do Via Cep para os campos de texto do programa
                txtendereco.Text = dados.Tables[0].Rows[0]["logradouro"].ToString();
                txtbairro.Text = dados.Tables[0].Rows[0]["bairro"].ToString();
                txtcidade.Text = dados.Tables[0].Rows[0]["localidade"].ToString();
                txtcomplemento.Text = dados.Tables[0].Rows[0]["complemento"].ToString();
                cbuf.Text = dados.Tables[0].Rows[0]["uf"].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Endereço não encontrado! Por favor, preencha os campos relativos ao endereço manualmente.");
            }
        }
        #endregion

        #region Botão Cadastrar
        private void btncadastrar_Click(object sender, EventArgs e)
        {
            // Recebendo os dados em um objeto Model de Cliente
            Funcionarios funcionario = new Funcionarios();

            funcionario.nome = txtnome.Text;
            funcionario.rg = txtrg.Text;
            funcionario.cpf = txtcpf.Text;
            funcionario.email = txtemail.Text;
            funcionario.telefone = txttelefone.Text;
            funcionario.cargo = txtcargo.Text;
            funcionario.nivel_acesso = cbnivelacesso.Text;
            funcionario.senha = txtsenha.Text;
            funcionario.celular = txtcelular.Text;
            funcionario.cep = txtcep.Text;
            funcionario.endereco = txtendereco.Text;
            funcionario.numero = int.Parse(txtnumero.Text);
            funcionario.complemento = txtcomplemento.Text;
            funcionario.bairro = txtbairro.Text;
            funcionario.cidade = txtcidade.Text;
            funcionario.uf = cbuf.Text;

            // Criação do objeto ClienteDAO para chamar o método Cadastrar
            FuncionarioDAO dao = new FuncionarioDAO();
            dao.CadastrarFuncionario(funcionario);

            // Refresh no DataGridView
            dgfuncionarios.DataSource = dao.ListarTodosFuncionarios();
        }
        #endregion

        #region Botão Editar
        private void btneditar_Click(object sender, EventArgs e)
        {
            // Recebendo os dados inseridos em um objeto Model de Cliente
            Funcionarios funcionario = new Funcionarios();

            funcionario.nome = txtnome.Text;
            funcionario.rg = txtrg.Text;
            funcionario.cpf = txtcpf.Text;
            funcionario.email = txtemail.Text;
            funcionario.cargo = txtcargo.Text;
            funcionario.nivel_acesso = cbnivelacesso.Text;
            funcionario.senha = txtsenha.Text;
            funcionario.telefone = txttelefone.Text;
            funcionario.celular = txtcelular.Text;
            funcionario.cep = txtcep.Text;
            funcionario.endereco = txtendereco.Text;
            funcionario.numero = int.Parse(txtnumero.Text);
            funcionario.complemento = txtcomplemento.Text;
            funcionario.bairro = txtbairro.Text;
            funcionario.cidade = txtcidade.Text;
            funcionario.uf = cbuf.Text;
            funcionario.id = int.Parse(txtcodigo.Text);

            // Criando o objeto ClienteDAO para chamar o método AlterarCliente
            FuncionarioDAO dao = new FuncionarioDAO();
            dao.AlterarFuncionario(funcionario);

            // Refresh no DataGridView
            dgfuncionarios.DataSource = dao.ListarTodosFuncionarios();
        }

        #endregion

        #region Botão Excluir
        private void btnexcluir_Click(object sender, EventArgs e)
        {
            // Criando um objeto ClienteDAO para conseguir chamar o método que exclui um cliente
            FuncionarioDAO dao = new FuncionarioDAO();
            dao.ExcluirFuncionario(int.Parse(txtcodigo.Text));

            // Refresh no DataGridView
            dgfuncionarios.DataSource = dao.ListarTodosFuncionarios();
        }
        #endregion

        #region Botão Limpar Dados
        private void button2_Click(object sender, EventArgs e)
        {
            txtcodigo.Clear();
            txtnome.Clear();
            txtcpf.Clear();
            txtsenha.Clear();
            cbnivelacesso = null;
            txtcargo.Clear();
            txtrg.Clear();
            txtemail.Clear();
            txtcelular.Clear();
            txttelefone.Clear();
            txtcep.Clear();
            txtendereco.Clear();
            txtcidade.Clear();
            txtbairro.Clear();
            txtcomplemento.Clear();
            cbuf.Text = null;
            txtnumero.Clear();
        }
        #endregion
    }
}

