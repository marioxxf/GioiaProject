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
    public partial class FrmDetalheVenda : Form
    {
        // Variáveis globais
        int id;
        string nome, total, datavenda, obs;

        public FrmDetalheVenda(int vidvenda, string vnome, string vtotal, string vdata, string vobs)
        {
            this.id = vidvenda;
            this.nome = vnome;
            this.datavenda = vdata;
            this.total = vtotal;
            this.obs = vobs;

            InitializeComponent();
        }

        #region Programação do Form Load
        private void FrmDetalheVenda_Load(object sender, EventArgs e)
        {
            txtnome.Text = nome;
            txttotal.Text = total; 
            txtdata.Text = datavenda;
            txtobs.Text = obs;
            
            VendaDAO dao = new VendaDAO();
            dgdetalhes.DataSource = dao.ListarDetalhes(id);
        }
        #endregion
    }
}
