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
    public partial class FrmFornecedores : Form
    {
        public FrmFornecedores()
        {
            InitializeComponent();
        }

        #region Botão Cadastrar
        private void btncadastrar_Click(object sender, EventArgs e)
        {
            // Recebendo os dados em um objeto Model de Cliente
            Fornecedores fornecedor = new Fornecedores();

            fornecedor.nome = txtnome.Text;
            fornecedor.cnpj = txtcnpj.Text;
            fornecedor.email = txtemail.Text;
            fornecedor.telefone = txttelefone.Text;
            fornecedor.celular = txtcelular.Text;
            fornecedor.cep = txtcep.Text;
            fornecedor.endereco = txtendereco.Text;
            fornecedor.numero = int.Parse(txtnumero.Text);
            fornecedor.complemento = txtcomplemento.Text;
            fornecedor.bairro = txtbairro.Text;
            fornecedor.cidade = txtcidade.Text;
            fornecedor.uf = cbuf.Text;

            // Criação do objeto ClienteDAO para chamar o método Cadastrar
            FornecedorDAO dao = new FornecedorDAO();
            dao.CadastrarFornecedor(fornecedor);

            // Refresh no DataGridView
            dgfornecedores.DataSource = dao.ListarTodosFornecedores();
        }
        #endregion

        #region Botão Editar
        private void btneditar_Click_1(object sender, EventArgs e)
        {
            // Recebendo os dados inseridos em um objeto Model de Cliente
            Fornecedores fornecedor = new Fornecedores();

            fornecedor.nome = txtnome.Text;
            fornecedor.cnpj = txtcnpj.Text;
            fornecedor.email = txtemail.Text;
            fornecedor.telefone = txttelefone.Text;
            fornecedor.celular = txtcelular.Text;
            fornecedor.cep = txtcep.Text;
            fornecedor.endereco = txtendereco.Text;
            fornecedor.numero = int.Parse(txtnumero.Text);
            fornecedor.complemento = txtcomplemento.Text;
            fornecedor.bairro = txtbairro.Text;
            fornecedor.cidade = txtcidade.Text;
            fornecedor.uf = cbuf.Text;
            fornecedor.id = int.Parse(txtcodigo.Text);

            // Criando o objeto ClienteDAO para chamar o método AlterarCliente
            FornecedorDAO dao = new FornecedorDAO();
            dao.AlterarFornecedor(fornecedor);

            // Refresh no DataGridView
            dgfornecedores.DataSource = dao.ListarTodosFornecedores();
        }
        #endregion

        #region Botão Pesquisar
        private void btnpesquisar_Click_1(object sender, EventArgs e)
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

        #region Botão Excluir
        private void btnexcluir_Click(object sender, EventArgs e)
        {
            // Criando um objeto ClienteDAO para conseguir chamar o método que exclui um cliente
            FornecedorDAO dao = new FornecedorDAO();
            dao.ExcluirFornecedor(int.Parse(txtcodigo.Text));

            // Refresh no DataGridView
            dgfornecedores.DataSource = dao.ListarTodosFornecedores();
        }
        #endregion

        #region Método que carrega o DataGridView da tela Consulta de Fornecedores de forma automática
        private void FrmFornecedores_Load(object sender, EventArgs e)
        {
            FornecedorDAO dao = new FornecedorDAO();
            dgfornecedores.DataSource = dao.ListarTodosFornecedores();
        }
        #endregion

        #region Método para procurar fornecedor por nome (evento TextChanged no txtconsulta (tabPage "Consulta de Fornecedores"))
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            string nome = "%" + txtconsulta.Text + "%";
            FornecedorDAO dao = new FornecedorDAO();
            dgfornecedores.DataSource = dao.ConsultarFornecedorPorNome(nome);
        }
        #endregion

        #region Método responsável por, ao clicar em qualquer linha do DataGridView (Consulta de Clientes), selecionar os todos os dados do cliente e ir para a tela principal
        private void dgfornecedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Pegando os dados da linha selecionada
            txtcodigo.Text = dgfornecedores.CurrentRow.Cells[0].Value.ToString();
            txtnome.Text = dgfornecedores.CurrentRow.Cells[1].Value.ToString();
            txtcnpj.Text = dgfornecedores.CurrentRow.Cells[2].Value.ToString();
            txtemail.Text = dgfornecedores.CurrentRow.Cells[3].Value.ToString();
            txttelefone.Text = dgfornecedores.CurrentRow.Cells[4].Value.ToString();
            txtcelular.Text = dgfornecedores.CurrentRow.Cells[5].Value.ToString();
            txtcep.Text = dgfornecedores.CurrentRow.Cells[6].Value.ToString();
            txtendereco.Text = dgfornecedores.CurrentRow.Cells[7].Value.ToString();
            txtnumero.Text = dgfornecedores.CurrentRow.Cells[8].Value.ToString();
            txtcomplemento.Text = dgfornecedores.CurrentRow.Cells[9].Value.ToString();
            txtbairro.Text = dgfornecedores.CurrentRow.Cells[10].Value.ToString();
            txtcidade.Text = dgfornecedores.CurrentRow.Cells[11].Value.ToString();
            cbuf.Text = dgfornecedores.CurrentRow.Cells[12].Value.ToString();

            // Alterando o TabPage para a guia de Dados Pessoais
            tabControl1.SelectedTab = tab1;
        }
        #endregion

        #region Botão Limpar Dados
        private void button2_Click(object sender, EventArgs e)
        {
            txtcodigo.Clear();
            txtnome.Clear();
            txtcnpj.Clear();
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
