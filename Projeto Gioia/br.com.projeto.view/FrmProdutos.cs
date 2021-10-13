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
    public partial class FrmProdutos : Form
    {
        public FrmProdutos()
        {
            InitializeComponent();
        }

        #region Botão Cadastrar
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Produtos produto = new Produtos();

                // Receber os dados
                produto.descricao = txtdescricao.Text;
                produto.preco_custo = decimal.Parse(txtprecocusto.Text);
                produto.preco_venda = decimal.Parse(txtprecovenda.Text);
                produto.qtd_estoque = int.Parse(txtqtdestoque.Text);
                produto.for_id = int.Parse(cbfornecedores.SelectedValue.ToString());

                // Cadastrar no banco
                ProdutoDAO dao = new ProdutoDAO();
                dao.CadastrarProduto(produto);

                // Recarregar o DataGrid
                dgprodutos.DataSource = dao.ListarTodosProdutos();

                MessageBox.Show("Produto cadastrado com sucesso!");
            }
            catch (Exception)
            {
                MessageBox.Show("Preencha todos os campos!");
            }
        }
        #endregion

        #region Botão Editar
        private void btneditar_Click(object sender, EventArgs e)
        {
            try
            {
                Produtos produto = new Produtos();

                // Receber os dados
                produto.descricao = txtdescricao.Text;
                produto.preco_custo = decimal.Parse(txtprecocusto.Text);
                produto.preco_venda = decimal.Parse(txtprecovenda.Text);
                produto.qtd_estoque = int.Parse(txtqtdestoque.Text);
                produto.for_id = int.Parse(cbfornecedores.SelectedValue.ToString());

                produto.id = int.Parse(txtcodigo.Text);

                // Alterar no banco
                ProdutoDAO dao = new ProdutoDAO();
                dao.AlterarProduto(produto);

                // Recarregar o DataGrid
                dgprodutos.DataSource = dao.ListarTodosProdutos();
            }
            catch (Exception)
            {
                MessageBox.Show("Preencha todos os campos!");
            }
        }

        #endregion

        #region Botão Excluir
        private void btnexcluir_Click(object sender, EventArgs e)
        {
            try
            {
                Produtos produto = new Produtos();

                // 1o passo: Receber os dados
                produto.id = int.Parse(txtcodigo.Text);

                // 2o passo: Cadastrar no banco
                ProdutoDAO dao = new ProdutoDAO();
                dao.ExcluirProduto(produto);

                // 3o passo: Recarregar o DataGrid
                dgprodutos.DataSource = dao.ListarTodosProdutos();
            }
            catch (Exception)
            {
                MessageBox.Show("Preencha todos os campos!");
            }
        }
        #endregion

        #region Botão Limpar Dados
        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtcodigo.Clear();
            txtdescricao.Clear();
            txtprecocusto.Clear();
            txtprecovenda.Clear();
            txtqtdestoque.Clear();
            cbfornecedores.Text = null;
        }
        #endregion

        #region Programação do cbfornecedores
        private void FrmProdutos_Load(object sender, EventArgs e)
        {
            // Como carregar e configurar o ComboBox (cbfuncionarios)
            FornecedorDAO dao = new FornecedorDAO();
            cbfornecedores.DataSource = dao.ListarTodosFornecedores();
            cbfornecedores.DisplayMember = "nome";
            cbfornecedores.ValueMember = "id";

            // Carregando o DataGridView de produtos
            ProdutoDAO dao_produto = new ProdutoDAO();
            dgprodutos.DataSource = dao_produto.ListarTodosProdutos();
        }
        #endregion

        #region Método responsável pela coleta dos dados do produto selecionado com um click na aba Consulta de Produtos
        private void dgprodutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Pegando os dados do produto selecionado
            txtcodigo.Text = dgprodutos.CurrentRow.Cells[0].Value.ToString();
            txtdescricao.Text = dgprodutos.CurrentRow.Cells[1].Value.ToString();
            txtprecocusto.Text = dgprodutos.CurrentRow.Cells[2].Value.ToString();
            txtprecovenda.Text = dgprodutos.CurrentRow.Cells[3].Value.ToString();
            txtqtdestoque.Text = dgprodutos.CurrentRow.Cells[4].Value.ToString();
            cbfornecedores.Text = dgprodutos.CurrentRow.Cells[5].Value.ToString();

            // Trocando a aba
            tabControl1.SelectedTab = tab1;
        }
        #endregion

        #region Programação do TextBox a frente do "Nome", na tabpage Consulta de Produtos
        private void txtconsulta_TextChanged(object sender, EventArgs e)
        {
            // Listar produtos por descrição
            string nome = "%" + txtconsulta.Text + "%";
            ProdutoDAO dao = new ProdutoDAO();
            dgprodutos.DataSource = dao.ListarTodosProdutosPorNome(nome);
        }
        #endregion
    }
}
