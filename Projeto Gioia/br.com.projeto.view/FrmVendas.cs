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
    public partial class FrmVendas : Form
    {
        // Objetos do Cliente e ClienteDAO
        Clientes cliente = new Clientes();
        ClienteDAO clientedao = new ClienteDAO();

        // Objetos do Produto e ProdutoDAO
        Produtos produto = new Produtos();
        ProdutoDAO dao = new ProdutoDAO();

        // Variáveis Globais
        int qtd;
        decimal preco;
        decimal subtotal, total;

        // Carrinho
        public DataTable carrinho = new DataTable();

        public FrmVendas()
        {
            InitializeComponent();

            // Montagem do DataGridView
            carrinho.Columns.Add("Código", typeof(int));
            carrinho.Columns.Add("Produto", typeof(string));
            carrinho.Columns.Add("Qtd", typeof(int));
            carrinho.Columns.Add("Preço", typeof(decimal));
            carrinho.Columns.Add("Subtotal", typeof(decimal));

            // Definindo que o DataGridView irá utilizar o DataTable
            dgcarrinho.DataSource = carrinho;
        }

        #region Carregamento do WindowsForm
        private void FrmVendas_Load(object sender, EventArgs e)
        {
            // Coletando a data atual de forma automática
            txtdata.Text = DateTime.Now.ToShortDateString();
        }
        #endregion

        #region Programação da inserção de CPF + Enter no txtcpf
        private void txtcpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Consulta de cliente por CPF
            if(e.KeyChar == 13)
            {
                cliente = clientedao.RetornaClientePorCPF(txtcpf.Text);

                if(cliente != null)
                {
                    // Colocar o nome do cliente no campo do texto de nome do cliente
                    txtnome.Text = cliente.nome;
                }
                else
                {
                    // Limpar os dados caso não encontre o cliente
                    txtcpf.Clear();
                    txtcpf.Focus();
                    txtnome.Clear();
                }
            }
        }
        #endregion

        #region Programação da consulta de produtos via código
        private void txtcodigoproduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                produto = dao.RetornaProdutoPorID(int.Parse(txtcodigoproduto.Text));

                if(produto != null)
                {
                    txtdescricao.Text = produto.descricao;
                    txtpreco.Text = produto.preco_custo.ToString();

                    // Enfatizando o campo Quantidade para chamar a atenção do usuário
                    txtqtd.Focus();
                    txtqtd.BackColor = Color.Yellow;
                }
                else
                {
                    txtcodigoproduto.Focus();
                    txtcodigoproduto.Clear();
                    txtpreco.Clear();
                    txtdescricao.Clear();
                }
            }
        }
        #endregion

        #region Botão Excluir item (excluir item do carrinho)
        private void btnexcluir_Click(object sender, EventArgs e)
        {
            try
            {
                decimal subproduto = decimal.Parse(dgcarrinho.CurrentRow.Cells[4].Value.ToString());
                
                // Excluindo um item do carrinho
                int indice = dgcarrinho.CurrentRow.Index;
                DataRow linha = carrinho.Rows[indice];

                // Remover a linha referente ao produto que o usuário quer excluir do carrinho (DataGridView dgcarrinho)
                carrinho.Rows.Remove(linha);
                carrinho.AcceptChanges();

                total = total - subproduto;

                txttotal.Text = total.ToString();
                MessageBox.Show("Item removido do carrinho com sucesso!");
            }
            catch(Exception)
            {
                MessageBox.Show("Selecione o item para excluir!");
            }
        }
        #endregion

        #region Botão Pagamento
        private void btnpagamento_Click(object sender, EventArgs e)
        {
            FrmPagamento tela = new FrmPagamento(cliente, carrinho, DateTime.Parse(txtdata.Text));

            // Passando o Total para o txttotalpag da Tela de Pagamentos
            tela.txttotalpag.Text = total.ToString();
            tela.ShowDialog();

            this.Close();
        }
        #endregion

        #region Botão Adicionar Item (adicionar item ao carrinho)
        private void btnadicionar_Click(object sender, EventArgs e)
        {
            try
            {
            qtd = int.Parse(txtqtd.Text);
            preco = decimal.Parse(txtpreco.Text);

            subtotal = qtd * preco;

            total = total + subtotal;
            txttotal.Text = total.ToString();

            // Adicionar produto ao carrinho
            carrinho.Rows.Add(int.Parse(txtcodigoproduto.Text), txtdescricao.Text, qtd, preco, subtotal);

            txtcodigoproduto.Clear();
            txtdescricao.Clear();
            txtqtd.Clear();
            txtpreco.Clear();

            txtcodigoproduto.Focus();
            }
            catch(Exception)
            {
                MessageBox.Show("Pesquise um produto!");
            }
        }
        #endregion
    }
}
