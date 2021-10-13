
namespace Projeto_Gioia.br.com.projeto.view
{
    partial class FrmProdutos
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btncadastrar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbfornecedores = new System.Windows.Forms.ComboBox();
            this.txtprecovenda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtqtdestoque = new System.Windows.Forms.TextBox();
            this.txtprecocusto = new System.Windows.Forms.TextBox();
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.lblcelular = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblnome = new System.Windows.Forms.Label();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.tab2 = new System.Windows.Forms.TabPage();
            this.txtconsulta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgprodutos = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tab1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tab2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgprodutos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab1);
            this.tabControl1.Controls.Add(this.tab2);
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tabControl1.Location = new System.Drawing.Point(5, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(794, 444);
            this.tabControl1.TabIndex = 3;
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.btnlimpar);
            this.tab1.Controls.Add(this.btncadastrar);
            this.tab1.Controls.Add(this.btnexcluir);
            this.tab1.Controls.Add(this.btneditar);
            this.tab1.Controls.Add(this.panel1);
            this.tab1.Location = new System.Drawing.Point(4, 26);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(3);
            this.tab1.Size = new System.Drawing.Size(786, 414);
            this.tab1.TabIndex = 0;
            this.tab1.Text = "Cadastro de Produtos";
            this.tab1.UseVisualStyleBackColor = true;
            // 
            // btnlimpar
            // 
            this.btnlimpar.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btnlimpar.Location = new System.Drawing.Point(568, 6);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(115, 32);
            this.btnlimpar.TabIndex = 76;
            this.btnlimpar.Text = "Limpar dados";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btncadastrar
            // 
            this.btncadastrar.BackColor = System.Drawing.Color.White;
            this.btncadastrar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btncadastrar.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.btncadastrar.Location = new System.Drawing.Point(627, 316);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(108, 43);
            this.btncadastrar.TabIndex = 8;
            this.btncadastrar.Text = "Cadastrar";
            this.btncadastrar.UseVisualStyleBackColor = false;
            this.btncadastrar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.BackColor = System.Drawing.Color.White;
            this.btnexcluir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnexcluir.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.btnexcluir.Location = new System.Drawing.Point(705, 365);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(73, 43);
            this.btnexcluir.TabIndex = 10;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = false;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btneditar
            // 
            this.btneditar.BackColor = System.Drawing.Color.White;
            this.btneditar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btneditar.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.btneditar.Location = new System.Drawing.Point(568, 365);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(86, 43);
            this.btneditar.TabIndex = 9;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = false;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(103)))), ((int)(((byte)(113)))));
            this.panel1.Controls.Add(this.cbfornecedores);
            this.panel1.Controls.Add(this.txtprecovenda);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtqtdestoque);
            this.panel1.Controls.Add(this.txtprecocusto);
            this.panel1.Controls.Add(this.txtdescricao);
            this.panel1.Controls.Add(this.txtcodigo);
            this.panel1.Controls.Add(this.lblcelular);
            this.panel1.Controls.Add(this.lblemail);
            this.panel1.Controls.Add(this.lblnome);
            this.panel1.Controls.Add(this.lblcodigo);
            this.panel1.Controls.Add(this.lbltitulo);
            this.panel1.Location = new System.Drawing.Point(4, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 402);
            this.panel1.TabIndex = 54;
            // 
            // cbfornecedores
            // 
            this.cbfornecedores.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbfornecedores.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbfornecedores.FormattingEnabled = true;
            this.cbfornecedores.Location = new System.Drawing.Point(161, 251);
            this.cbfornecedores.Name = "cbfornecedores";
            this.cbfornecedores.Size = new System.Drawing.Size(150, 28);
            this.cbfornecedores.TabIndex = 7;
            // 
            // txtprecovenda
            // 
            this.txtprecovenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtprecovenda.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtprecovenda.Location = new System.Drawing.Point(451, 178);
            this.txtprecovenda.Name = "txtprecovenda";
            this.txtprecovenda.Size = new System.Drawing.Size(100, 26);
            this.txtprecovenda.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(282, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Preço de Venda:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(38, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Fornecedor:";
            // 
            // txtqtdestoque
            // 
            this.txtqtdestoque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtqtdestoque.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtqtdestoque.Location = new System.Drawing.Point(246, 214);
            this.txtqtdestoque.Name = "txtqtdestoque";
            this.txtqtdestoque.Size = new System.Drawing.Size(65, 26);
            this.txtqtdestoque.TabIndex = 6;
            // 
            // txtprecocusto
            // 
            this.txtprecocusto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtprecocusto.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtprecocusto.Location = new System.Drawing.Point(161, 178);
            this.txtprecocusto.Name = "txtprecocusto";
            this.txtprecocusto.Size = new System.Drawing.Size(100, 26);
            this.txtprecocusto.TabIndex = 4;
            // 
            // txtdescricao
            // 
            this.txtdescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdescricao.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtdescricao.Location = new System.Drawing.Point(161, 137);
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(310, 26);
            this.txtdescricao.TabIndex = 3;
            // 
            // txtcodigo
            // 
            this.txtcodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcodigo.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtcodigo.Location = new System.Drawing.Point(161, 95);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(67, 26);
            this.txtcodigo.TabIndex = 1;
            // 
            // lblcelular
            // 
            this.lblcelular.AutoSize = true;
            this.lblcelular.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.lblcelular.ForeColor = System.Drawing.Color.White;
            this.lblcelular.Location = new System.Drawing.Point(5, 216);
            this.lblcelular.Name = "lblcelular";
            this.lblcelular.Size = new System.Drawing.Size(235, 21);
            this.lblcelular.TabIndex = 5;
            this.lblcelular.Text = "Quantidade em estoque:";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.lblemail.ForeColor = System.Drawing.Color.White;
            this.lblemail.Location = new System.Drawing.Point(5, 179);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(150, 21);
            this.lblemail.TabIndex = 3;
            this.lblemail.Text = "Preço de custo:";
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.lblnome.ForeColor = System.Drawing.Color.White;
            this.lblnome.Location = new System.Drawing.Point(52, 138);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(103, 21);
            this.lblnome.TabIndex = 2;
            this.lblnome.Text = "Descrição:";
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.lblcodigo.ForeColor = System.Drawing.Color.White;
            this.lblcodigo.Location = new System.Drawing.Point(74, 96);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(81, 21);
            this.lblcodigo.TabIndex = 1;
            this.lblcodigo.Text = "Código:";
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.ForeColor = System.Drawing.Color.White;
            this.lbltitulo.Location = new System.Drawing.Point(122, 29);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(326, 36);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "Cadastro de Produtos";
            // 
            // tab2
            // 
            this.tab2.Controls.Add(this.txtconsulta);
            this.tab2.Controls.Add(this.label2);
            this.tab2.Controls.Add(this.dgprodutos);
            this.tab2.Location = new System.Drawing.Point(4, 26);
            this.tab2.Name = "tab2";
            this.tab2.Padding = new System.Windows.Forms.Padding(3);
            this.tab2.Size = new System.Drawing.Size(786, 414);
            this.tab2.TabIndex = 1;
            this.tab2.Text = "Consulta de Produtos";
            this.tab2.UseVisualStyleBackColor = true;
            // 
            // txtconsulta
            // 
            this.txtconsulta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtconsulta.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtconsulta.Location = new System.Drawing.Point(83, 19);
            this.txtconsulta.Name = "txtconsulta";
            this.txtconsulta.Size = new System.Drawing.Size(395, 26);
            this.txtconsulta.TabIndex = 4;
            this.txtconsulta.TextChanged += new System.EventHandler(this.txtconsulta_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            // 
            // dgprodutos
            // 
            this.dgprodutos.AllowUserToAddRows = false;
            this.dgprodutos.AllowUserToDeleteRows = false;
            this.dgprodutos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgprodutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgprodutos.Location = new System.Drawing.Point(6, 58);
            this.dgprodutos.Name = "dgprodutos";
            this.dgprodutos.ReadOnly = true;
            this.dgprodutos.Size = new System.Drawing.Size(774, 350);
            this.dgprodutos.TabIndex = 0;
            this.dgprodutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgprodutos_CellClick);
            // 
            // FrmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Produtos";
            this.Load += new System.EventHandler(this.FrmProdutos_Load);
            this.tabControl1.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tab2.ResumeLayout(false);
            this.tab2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgprodutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtprecocusto;
        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label lblcelular;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgprodutos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtqtdestoque;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.TextBox txtprecovenda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncadastrar;
        private System.Windows.Forms.ComboBox cbfornecedores;
        private System.Windows.Forms.TextBox txtconsulta;
        private System.Windows.Forms.Button btnlimpar;
        public System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.TabPage tab2;
        public System.Windows.Forms.TabPage tab1;
    }
}