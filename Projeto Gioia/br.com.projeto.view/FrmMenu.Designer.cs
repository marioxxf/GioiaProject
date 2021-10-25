
namespace Projeto_Gioia.br.com.projeto.view
{
    partial class FrmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opCadastroCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.opConsultaClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opCadastroFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.opConsultaFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opCadastroFornecedor = new System.Windows.Forms.ToolStripMenuItem();
            this.opConsultaFornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opCadastroProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.opConsultaProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opRegistroVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.opHistoricoVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbllogado = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtdataatual = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txthoraatual = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.funcionáriosToolStripMenuItem,
            this.fornecedoresToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.vendasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opCadastroCliente,
            this.opConsultaClientes});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // opCadastroCliente
            // 
            this.opCadastroCliente.Name = "opCadastroCliente";
            this.opCadastroCliente.Size = new System.Drawing.Size(182, 22);
            this.opCadastroCliente.Text = "Cadastro de Clientes";
            this.opCadastroCliente.Click += new System.EventHandler(this.cadastroDeClientesToolStripMenuItem_Click);
            // 
            // opConsultaClientes
            // 
            this.opConsultaClientes.Name = "opConsultaClientes";
            this.opConsultaClientes.Size = new System.Drawing.Size(182, 22);
            this.opConsultaClientes.Text = "Consulta de Clientes";
            this.opConsultaClientes.Click += new System.EventHandler(this.consultaDeClientesToolStripMenuItem_Click);
            // 
            // funcionáriosToolStripMenuItem
            // 
            this.funcionáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opCadastroFuncionario,
            this.opConsultaFuncionario});
            this.funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            this.funcionáriosToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.funcionáriosToolStripMenuItem.Text = "Funcionários";
            // 
            // opCadastroFuncionario
            // 
            this.opCadastroFuncionario.Name = "opCadastroFuncionario";
            this.opCadastroFuncionario.Size = new System.Drawing.Size(208, 22);
            this.opCadastroFuncionario.Text = "Cadastro de Funcionários";
            this.opCadastroFuncionario.Click += new System.EventHandler(this.cadastroDeFuncionáriosToolStripMenuItem_Click);
            // 
            // opConsultaFuncionario
            // 
            this.opConsultaFuncionario.Name = "opConsultaFuncionario";
            this.opConsultaFuncionario.Size = new System.Drawing.Size(208, 22);
            this.opConsultaFuncionario.Text = "Consulta de Funcionários";
            this.opConsultaFuncionario.Click += new System.EventHandler(this.consultaDeFuncionáriosToolStripMenuItem_Click);
            // 
            // fornecedoresToolStripMenuItem
            // 
            this.fornecedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opCadastroFornecedor,
            this.opConsultaFornecedores});
            this.fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            this.fornecedoresToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.fornecedoresToolStripMenuItem.Text = "Fornecedores";
            // 
            // opCadastroFornecedor
            // 
            this.opCadastroFornecedor.Name = "opCadastroFornecedor";
            this.opCadastroFornecedor.Size = new System.Drawing.Size(211, 22);
            this.opCadastroFornecedor.Text = "Cadastro de Fornecedores";
            this.opCadastroFornecedor.Click += new System.EventHandler(this.cadastroDeFornecedoresToolStripMenuItem_Click);
            // 
            // opConsultaFornecedores
            // 
            this.opConsultaFornecedores.Name = "opConsultaFornecedores";
            this.opConsultaFornecedores.Size = new System.Drawing.Size(211, 22);
            this.opConsultaFornecedores.Text = "Consulta de Fornecedores";
            this.opConsultaFornecedores.Click += new System.EventHandler(this.consultaDeFornecedoresToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opCadastroProduto,
            this.opConsultaProdutos});
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.produtosToolStripMenuItem.Text = "Produtos";
            // 
            // opCadastroProduto
            // 
            this.opCadastroProduto.Name = "opCadastroProduto";
            this.opCadastroProduto.Size = new System.Drawing.Size(188, 22);
            this.opCadastroProduto.Text = "Cadastro de Produtos";
            this.opCadastroProduto.Click += new System.EventHandler(this.cadastroDeProdutosToolStripMenuItem_Click);
            // 
            // opConsultaProdutos
            // 
            this.opConsultaProdutos.Name = "opConsultaProdutos";
            this.opConsultaProdutos.Size = new System.Drawing.Size(188, 22);
            this.opConsultaProdutos.Text = "Consulta de Produtos";
            this.opConsultaProdutos.Click += new System.EventHandler(this.consultaDeProdutosToolStripMenuItem_Click);
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opRegistroVendas,
            this.opHistoricoVendas});
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.vendasToolStripMenuItem.Text = "Vendas";
            // 
            // opRegistroVendas
            // 
            this.opRegistroVendas.Name = "opRegistroVendas";
            this.opRegistroVendas.Size = new System.Drawing.Size(178, 22);
            this.opRegistroVendas.Text = "Registro de Vendas";
            this.opRegistroVendas.Click += new System.EventHandler(this.registroDeVendasToolStripMenuItem_Click);
            // 
            // opHistoricoVendas
            // 
            this.opHistoricoVendas.Name = "opHistoricoVendas";
            this.opHistoricoVendas.Size = new System.Drawing.Size(178, 22);
            this.opHistoricoVendas.Text = "Histórico de Vendas";
            this.opHistoricoVendas.Click += new System.EventHandler(this.opHistoricoVendas_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lbllogado,
            this.toolStripStatusLabel2,
            this.txtdataatual,
            this.toolStripStatusLabel4,
            this.txthoraatual});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(90, 17);
            this.toolStripStatusLabel1.Text = "Usuário logado:";
            // 
            // lbllogado
            // 
            this.lbllogado.Name = "lbllogado";
            this.lbllogado.Size = new System.Drawing.Size(66, 17);
            this.lbllogado.Text = "Nome aqui";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(52, 17);
            this.toolStripStatusLabel2.Text = "      Data:";
            // 
            // txtdataatual
            // 
            this.txtdataatual.Name = "txtdataatual";
            this.txtdataatual.Size = new System.Drawing.Size(57, 17);
            this.txtdataatual.Text = "Data aqui";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(54, 17);
            this.toolStripStatusLabel4.Text = "      Hora:";
            // 
            // txthoraatual
            // 
            this.txthoraatual.Name = "txthoraatual";
            this.txthoraatual.Size = new System.Drawing.Size(59, 17);
            this.txthoraatual.Text = "Hora aqui";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        public System.Windows.Forms.ToolStripStatusLabel lbllogado;
        public System.Windows.Forms.ToolStripMenuItem opCadastroCliente;
        public System.Windows.Forms.ToolStripMenuItem opConsultaClientes;
        public System.Windows.Forms.ToolStripMenuItem opCadastroFuncionario;
        public System.Windows.Forms.ToolStripMenuItem opConsultaFuncionario;
        public System.Windows.Forms.ToolStripMenuItem opCadastroFornecedor;
        public System.Windows.Forms.ToolStripMenuItem opConsultaFornecedores;
        public System.Windows.Forms.ToolStripMenuItem opCadastroProduto;
        public System.Windows.Forms.ToolStripMenuItem opConsultaProdutos;
        public System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem opRegistroVendas;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel txtdataatual;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel txthoraatual;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem opHistoricoVendas;
    }
}