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
    public partial class Pagamento : Form
    {
        // Criação dos Objetos e Variáveis que irão receber os dados
        Clientes cliente = new Clientes();
        DataTable carrinho = new DataTable();
        DateTime dataatual;
        Vendas venda = new Vendas();

        public Pagamento(Clientes vcliente, DataTable vcarrinho, DateTime vdataatual, Vendas vvenda)
        {
            // Recebendo os dados da compra
            this.cliente = vcliente;
            this.carrinho = vcarrinho;
            this.dataatual = vdataatual;
            this.venda = vvenda;

            InitializeComponent();

            // Data Grid View criado para organizar as informações do Data Table carrinho. Esse DGV será usado para a criação de
            // itens da venda
            dgauxiliar.DataSource = carrinho;
        }

        #region Botão Finalizar Venda
        private void btnfinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                // Declaração de variáveis
                decimal v_avista, v_cartao, troco, totalpago, total;

                // Preenchimento das variáveis/Recebimento dos dados
                v_avista = decimal.Parse(txtavista.Text);
                v_cartao = decimal.Parse(txtcartao.Text);
                total = decimal.Parse(txttotalpag.Text);

                // Cálculo do total pago
                totalpago = v_avista + v_cartao;

                // Verificação do total pago
                if(totalpago < total)
                {
                    MessageBox.Show("O total pago é menor que o valor da venda!");
                }
                else
                {
                    // Registrando os dados da venda no banco de dados

                    // Cálculo do troco
                    troco = totalpago - total;

                    // Montagem do Objeto Vendas
                    venda.cliente_id    = cliente.id;
                    venda.data_venda    = dataatual;
                    venda.total_venda   = total;
                    venda.obs           = txtobs.Text;

                    // Criação de uma venda
                    VendaDAO vdao = new VendaDAO();
                    vdao.CadastrarVenda(venda);

                    // Montagem do Objeto Item de Venda
                    int contadorA, iterador; iterador = 0;
                    contadorA = carrinho.Rows.Count;

                    // Criação do(s) item(ns) da venda
                    while(contadorA > 0) // O Laço de Repetição se dá necessário por conta que uma venda por ter diversos itens
                    {
                        ItemVenda item = new ItemVenda();
                        item.venda_id = venda.id;
                        item.produto_id = (int)dgauxiliar.Rows[iterador].Cells["Código"].Value;
                        //item.produto_id = Int32.Parse((string)carrinho.Rows[iterador]["Código"].ToString());
                        item.qtd = (int)dgauxiliar.Rows[iterador].Cells["Qtd"].Value;
                        item.subtotal = (decimal)dgauxiliar.Rows[iterador].Cells["Subtotal"].Value;

                        ItemVendaDAO idao = new ItemVendaDAO();
                        idao.CadastrarItemVenda(item);
                        contadorA = contadorA - 1;
                        iterador = iterador + 1;
                    }
                    
                    txttroco.Text = troco.ToString();

                    // Fechando o FrmPagamento e voltando ao FrmVendas
                    this.Hide();
                    this.Close();

                    FrmVendas telaVendas = new FrmVendas();
                    telaVendas.ShowDialog();
                }
            }
            catch(Exception erro)
            {
                MessageBox.Show("Aconteceu o erro " + erro);
            }
        }
        #endregion

        #region Carregamento da Tela de Pagamentos
    private void FrmPagamento_Load(object sender, EventArgs e)
        {
            txttroco.Text = "0,00";
            txtavista.Text = "0,00";
            txtcartao.Text = "0,00";
        }
        #endregion
    }
}
