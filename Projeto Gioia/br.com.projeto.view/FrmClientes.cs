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
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

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
                txtendereco.Text =      dados.Tables[0].Rows[0]["logradouro"].ToString();
                txtbairro.Text =        dados.Tables[0].Rows[0]["bairro"].ToString();
                txtcidade.Text =        dados.Tables[0].Rows[0]["localidade"].ToString();
                txtcomplemento.Text =   dados.Tables[0].Rows[0]["complemento"].ToString();
                cbuf.Text =             dados.Tables[0].Rows[0]["uf"].ToString();
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
            Clientes cliente = new Clientes();

            cliente.nome =          txtnome.Text;
            cliente.rg =            txtrg.Text;
            cliente.cpf =           txtcpf.Text;
            cliente.email =         txtemail.Text;
            cliente.telefone =      txttelefone.Text;
            cliente.celular =       txtcelular.Text;
            cliente.cep =           txtcep.Text;
            cliente.endereco =      txtendereco.Text;
            cliente.numero =        int.Parse(txtnumero.Text);
            cliente.complemento =   txtcomplemento.Text;
            cliente.bairro =        txtbairro.Text;
            cliente.cidade =        txtcidade.Text;
            cliente.uf =            cbuf.Text;

            // Criação do objeto ClienteDAO para chamar o método Cadastrar
            ClienteDAO dao = new ClienteDAO();
            dao.CadastrarCliente(cliente);

            // Refresh no DataGridView
            dgclientes.DataSource = dao.ListarTodosClientes();
        }


        #endregion

        #region Botão Editar
        private void btneditar_Click(object sender, EventArgs e)
        {
            // Recebendo os dados inseridos em um objeto Model de Cliente
            Fornecedores cliente = new Fornecedores();

            cliente.nome =          txtnome.Text;
            cliente.rg =            txtrg.Text;
            cliente.cpf =           txtcpf.Text;
            cliente.email =         txtemail.Text;
            cliente.telefone =      txttelefone.Text;
            cliente.celular =       txtcelular.Text;
            cliente.cep =           txtcep.Text;
            cliente.endereco =      txtendereco.Text;
            cliente.numero =        int.Parse(txtnumero.Text);
            cliente.complemento =   txtcomplemento.Text;
            cliente.bairro =        txtbairro.Text;
            cliente.cidade =        txtcidade.Text;
            cliente.uf =            cbuf.Text;
            cliente.id = int.Parse(txtcodigo.Text);

            // Criando o objeto ClienteDAO para chamar o método AlterarCliente
            ClienteDAO dao = new ClienteDAO();
            dao.AlterarCliente(cliente);

            // Refresh no DataGridView
            dgclientes.DataSource = dao.ListarTodosClientes();
        }
        #endregion

        #region Botão Excluir
        private void btnexcluir_Click(object sender, EventArgs e)
        {
            // Criando um objeto ClienteDAO para conseguir chamar o método que exclui um cliente
            ClienteDAO dao = new ClienteDAO();
            dao.ExcluirCliente(int.Parse(txtcodigo.Text));

            // Refresh no DataGridView
            dgclientes.DataSource = dao.ListarTodosClientes();
        }

        #endregion

        #region Método que carrega o DataGridView da tela Consulta de Clientes de forma automática
        private void FrmClientes_Load(object sender, EventArgs e)
        {
            ClienteDAO dao = new ClienteDAO();
            dgclientes.DataSource = dao.ListarTodosClientes();
        }
        #endregion

        #region Método responsável por, ao clicar em qualquer linha do DataGridView (Consulta de Clientes), selecionar os todos os dados do cliente e ir para a tela principal
        private void dgclientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Pegando os dados da linha selecionada
            txtcodigo.Text =        dgclientes.CurrentRow.Cells[0].Value.ToString();
            txtnome.Text =          dgclientes.CurrentRow.Cells[1].Value.ToString();
            txtrg.Text =            dgclientes.CurrentRow.Cells[2].Value.ToString();
            txtcpf.Text =           dgclientes.CurrentRow.Cells[3].Value.ToString();
            txtemail.Text =         dgclientes.CurrentRow.Cells[4].Value.ToString();
            txttelefone.Text =      dgclientes.CurrentRow.Cells[5].Value.ToString();
            txtcelular.Text =       dgclientes.CurrentRow.Cells[6].Value.ToString();
            txtcep.Text =           dgclientes.CurrentRow.Cells[7].Value.ToString();
            txtendereco.Text =      dgclientes.CurrentRow.Cells[8].Value.ToString();
            txtnumero.Text =        dgclientes.CurrentRow.Cells[9].Value.ToString();
            txtcomplemento.Text =   dgclientes.CurrentRow.Cells[10].Value.ToString();
            txtbairro.Text =        dgclientes.CurrentRow.Cells[11].Value.ToString();
            txtcidade.Text =        dgclientes.CurrentRow.Cells[12].Value.ToString();
            cbuf.Text =             dgclientes.CurrentRow.Cells[13].Value.ToString();

            // Alterando o TabPage para a guia de Dados Pessoais
            tabControl1.SelectedTab = tab1;
         }
            #endregion
        
        #region Botão Limpar Dados
        private void button2_Click(object sender, EventArgs e)
        {
            txtcodigo.Clear();
            txtnome.Clear();
            txtcpf.Clear();
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

        #region Método para procurar cliente por nome (evento TextChanged no txtconsulta (tabPage "Consulta de Clientes"))
        private void txtconsulta_TextChanged(object sender, EventArgs e)
        {
            string nome = "%" + txtconsulta.Text + "%";
            ClienteDAO dao = new ClienteDAO();
            dgclientes.DataSource = dao.ConsultarClientePorNome(nome);
        }
        #endregion
    }
}
