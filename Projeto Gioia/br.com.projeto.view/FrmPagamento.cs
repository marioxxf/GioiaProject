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
    public partial class FrmPagamento : Form
    {
        // Criação dos Objetos que irão receber os dados
        Clientes cliente = new Clientes();
        DataTable carrinho = new DataTable();
        DateTime dataatual;
        public FrmPagamento(Clientes vcliente, DataTable vcarrinho, DateTime vdataatual)
        {
            // Recebendo os dados da compra
            this.cliente = vcliente;
            this.carrinho = vcarrinho;
            this.dataatual = vdataatual;

            InitializeComponent();
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
                    Vendas venda = new Vendas();
                    venda.cliente_id    = cliente.id;
                    venda.data_venda    = dataatual;
                    venda.total_venda   = total;
                    venda.obs           = txtobs.Text;

                    VendaDAO vdao = new VendaDAO();
                    vdao.CadastrarVenda(venda);

                    txttroco.Text = troco.ToString();

                    // Fechando a Tela de Pagamentos quando finalizar a venda ao clicar no botão 'Finalizar venda'
                    FrmPagamento.ActiveForm.Close();

                    // Retornando à tela de Registro de Vendas
                    FrmVendas telav = new FrmVendas();
                    telav.Show();
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
