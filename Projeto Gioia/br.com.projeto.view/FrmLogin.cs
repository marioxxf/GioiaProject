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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        #region Botão Entrar
        private void btnentrar_Click(object sender, EventArgs e)
        {
            try
            {
                FuncionarioDAO dao = new FuncionarioDAO();
                string email, senha;

                email = txtemail.Text;
                senha = txtsenha.Text;

                // Escondendo o FrmLogin
                //this.Hide();

                dao.EfetuarLogin(email, senha);
            }
            catch(Exception)
            {
                MessageBox.Show("Preencha todos os campos!");
            }
        }
        #endregion


    }
}