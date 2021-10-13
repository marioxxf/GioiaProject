
namespace Projeto_Gioia.br.com.projeto.view
{
    partial class FrmVendas
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
            this.btnpagamento = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgcarrinho = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btnadicionar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtqtd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtpreco = new System.Windows.Forms.TextBox();
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcodigoproduto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcpf = new System.Windows.Forms.MaskedTextBox();
            this.lblcpf = new System.Windows.Forms.Label();
            this.txtdata = new System.Windows.Forms.TextBox();
            this.lblnome = new System.Windows.Forms.Label();
            this.lbltitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgcarrinho)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnpagamento
            // 
            this.btnpagamento.BackColor = System.Drawing.Color.White;
            this.btnpagamento.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnpagamento.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.btnpagamento.Location = new System.Drawing.Point(471, 368);
            this.btnpagamento.Name = "btnpagamento";
            this.btnpagamento.Size = new System.Drawing.Size(144, 43);
            this.btnpagamento.TabIndex = 80;
            this.btnpagamento.Text = "Pagamento";
            this.btnpagamento.UseVisualStyleBackColor = false;
            this.btnpagamento.Click += new System.EventHandler(this.btnpagamento_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.White;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btncancelar.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.btncancelar.Location = new System.Drawing.Point(640, 368);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(144, 43);
            this.btncancelar.TabIndex = 79;
            this.btncancelar.Text = "Cancelar venda";
            this.btncancelar.UseVisualStyleBackColor = false;
            // 
            // txttotal
            // 
            this.txttotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttotal.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txttotal.Location = new System.Drawing.Point(640, 322);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(89, 26);
            this.txttotal.TabIndex = 76;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(539, 322);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 21);
            this.label7.TabIndex = 75;
            this.label7.Text = "Total (R$):";
            // 
            // dgcarrinho
            // 
            this.dgcarrinho.AllowUserToAddRows = false;
            this.dgcarrinho.AllowUserToDeleteRows = false;
            this.dgcarrinho.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgcarrinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgcarrinho.Location = new System.Drawing.Point(468, 21);
            this.dgcarrinho.Name = "dgcarrinho";
            this.dgcarrinho.Size = new System.Drawing.Size(319, 284);
            this.dgcarrinho.TabIndex = 78;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnexcluir);
            this.panel1.Controls.Add(this.btnadicionar);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.lbltitulo);
            this.panel1.Location = new System.Drawing.Point(12, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 402);
            this.panel1.TabIndex = 77;
            // 
            // btnexcluir
            // 
            this.btnexcluir.BackColor = System.Drawing.Color.White;
            this.btnexcluir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnexcluir.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.btnexcluir.Location = new System.Drawing.Point(281, 347);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(152, 43);
            this.btnexcluir.TabIndex = 71;
            this.btnexcluir.Text = "Excluir item";
            this.btnexcluir.UseVisualStyleBackColor = false;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btnadicionar
            // 
            this.btnadicionar.BackColor = System.Drawing.Color.White;
            this.btnadicionar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnadicionar.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.btnadicionar.Location = new System.Drawing.Point(13, 347);
            this.btnadicionar.Name = "btnadicionar";
            this.btnadicionar.Size = new System.Drawing.Size(152, 43);
            this.btnadicionar.TabIndex = 70;
            this.btnadicionar.Text = "Adicionar item";
            this.btnadicionar.UseVisualStyleBackColor = false;
            this.btnadicionar.Click += new System.EventHandler(this.btnadicionar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtqtd);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtpreco);
            this.groupBox2.Controls.Add(this.txtdescricao);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtcodigoproduto);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(3, 205);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(440, 122);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados do Produto";
            // 
            // txtqtd
            // 
            this.txtqtd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtqtd.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtqtd.Location = new System.Drawing.Point(375, 85);
            this.txtqtd.Name = "txtqtd";
            this.txtqtd.Size = new System.Drawing.Size(61, 26);
            this.txtqtd.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(246, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 21);
            this.label6.TabIndex = 20;
            this.label6.Text = "Quantidade:";
            // 
            // txtpreco
            // 
            this.txtpreco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpreco.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtpreco.Location = new System.Drawing.Point(124, 86);
            this.txtpreco.Name = "txtpreco";
            this.txtpreco.ReadOnly = true;
            this.txtpreco.Size = new System.Drawing.Size(89, 26);
            this.txtpreco.TabIndex = 19;
            // 
            // txtdescricao
            // 
            this.txtdescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdescricao.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtdescricao.Location = new System.Drawing.Point(124, 53);
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.ReadOnly = true;
            this.txtdescricao.Size = new System.Drawing.Size(256, 26);
            this.txtdescricao.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(51, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Preço:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(15, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "Descrição:";
            // 
            // txtcodigoproduto
            // 
            this.txtcodigoproduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcodigoproduto.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtcodigoproduto.Location = new System.Drawing.Point(124, 21);
            this.txtcodigoproduto.Name = "txtcodigoproduto";
            this.txtcodigoproduto.Size = new System.Drawing.Size(61, 26);
            this.txtcodigoproduto.TabIndex = 3;
            this.txtcodigoproduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodigoproduto_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(37, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Código:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtnome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtcpf);
            this.groupBox1.Controls.Add(this.lblcpf);
            this.groupBox1.Controls.Add(this.txtdata);
            this.groupBox1.Controls.Add(this.lblnome);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(3, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 122);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Cliente";
            // 
            // txtnome
            // 
            this.txtnome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnome.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtnome.Location = new System.Drawing.Point(90, 86);
            this.txtnome.Name = "txtnome";
            this.txtnome.ReadOnly = true;
            this.txtnome.Size = new System.Drawing.Size(346, 26);
            this.txtnome.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome:";
            // 
            // txtcpf
            // 
            this.txtcpf.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcpf.Location = new System.Drawing.Point(90, 54);
            this.txtcpf.Mask = "###,###,###-##";
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(111, 26);
            this.txtcpf.TabIndex = 16;
            this.txtcpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcpf_KeyPress);
            // 
            // lblcpf
            // 
            this.lblcpf.AutoSize = true;
            this.lblcpf.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.lblcpf.ForeColor = System.Drawing.Color.White;
            this.lblcpf.Location = new System.Drawing.Point(34, 54);
            this.lblcpf.Name = "lblcpf";
            this.lblcpf.Size = new System.Drawing.Size(50, 21);
            this.lblcpf.TabIndex = 17;
            this.lblcpf.Text = "CPF:";
            // 
            // txtdata
            // 
            this.txtdata.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdata.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtdata.Location = new System.Drawing.Point(90, 22);
            this.txtdata.Name = "txtdata";
            this.txtdata.ReadOnly = true;
            this.txtdata.Size = new System.Drawing.Size(111, 26);
            this.txtdata.TabIndex = 3;
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.lblnome.ForeColor = System.Drawing.Color.White;
            this.lblnome.Location = new System.Drawing.Point(25, 22);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(59, 21);
            this.lblnome.TabIndex = 4;
            this.lblnome.Text = "Data:";
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.ForeColor = System.Drawing.Color.White;
            this.lbltitulo.Location = new System.Drawing.Point(71, 16);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(312, 36);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "Cadastro de Vendas";
            // 
            // FrmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnpagamento);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgcarrinho);
            this.Controls.Add(this.panel1);
            this.Name = "FrmVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criação de Vendas";
            this.Load += new System.EventHandler(this.FrmVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgcarrinho)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnpagamento;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btnadicionar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtqtd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtpreco;
        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcodigoproduto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblcpf;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label lbltitulo;
        public System.Windows.Forms.DataGridView dgcarrinho;
        private System.Windows.Forms.TextBox txtdata;
        public System.Windows.Forms.MaskedTextBox txtcpf;
        public System.Windows.Forms.TextBox txtnome;
        public System.Windows.Forms.TextBox txttotal;
    }
}