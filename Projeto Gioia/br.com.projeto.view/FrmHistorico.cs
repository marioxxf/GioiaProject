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
    public partial class FrmHistorico : Form
    {
        // Variáveis globais
        int id;
        string nome, data, total, obs, coletorid;

        public FrmHistorico()
        {
            InitializeComponent();
        }

        #region Botão Pesquisar
        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dtinicio, dtfim;

                dtinicio = txtdtinicio.Value;
                dtfim = txtdtfim.Value;

                VendaDAO dao = new VendaDAO();

                dghistorico.DataSource = dao.ListarVendasPorPeriodo(dtinicio, dtfim);

                if(dghistorico.Rows.Count == 0)
                {
                    MessageBox.Show("Não foram encontradas vendas no período indicado!");
                    dghistorico.DataSource = dao.ListarTodasVendas();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Não foram encontradas vendas no período indicado!");
            }
        }
        #endregion

        #region Programação do Form Load
        private void FrmHistorico_Load(object sender, EventArgs e)
        {
            VendaDAO dao = new VendaDAO();
            dghistorico.DataSource = dao.ListarTodasVendas();
        }
        #endregion

        #region Método responsável por captar a linha do Data Grid View que foi clicada
        private void dghistorico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            coletorid = dghistorico.CurrentRow.Cells[0].Value.ToString();
            id = int.Parse(coletorid);

            nome = dghistorico.CurrentRow.Cells[3].Value.ToString();
            total = dghistorico.CurrentRow.Cells[2].Value.ToString();
            obs = dghistorico.CurrentRow.Cells[4].Value.ToString();
            data = dghistorico.CurrentRow.Cells[1].Value.ToString();

            FrmDetalheVenda tela = new FrmDetalheVenda(id, nome, total, data, obs);
            tela.Show();
        }
        #endregion
    }
}
