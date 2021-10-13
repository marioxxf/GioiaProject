
using System;

namespace Projeto_Gioia.br.com.projeto.view
{
    partial class FrmFornecedores
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
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbuf = new System.Windows.Forms.ComboBox();
            this.btneditar = new System.Windows.Forms.Button();
            this.btncadastrar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.txtcep = new System.Windows.Forms.MaskedTextBox();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.lblnumero = new System.Windows.Forms.Label();
            this.txtcomplemento = new System.Windows.Forms.TextBox();
            this.lblcomplemento = new System.Windows.Forms.Label();
            this.txtbairro = new System.Windows.Forms.TextBox();
            this.lblbairro = new System.Windows.Forms.Label();
            this.txtcidade = new System.Windows.Forms.TextBox();
            this.lblcidade = new System.Windows.Forms.Label();
            this.txtendereco = new System.Windows.Forms.TextBox();
            this.btnpesquisar = new System.Windows.Forms.Button();
            this.lblcep = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txttelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtcelular = new System.Windows.Forms.MaskedTextBox();
            this.txtcnpj = new System.Windows.Forms.MaskedTextBox();
            this.lblcpf = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.lblcelular = new System.Windows.Forms.Label();
            this.lbltelefone = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblnome = new System.Windows.Forms.Label();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.lblendereco = new System.Windows.Forms.Label();
            this.tab2 = new System.Windows.Forms.TabPage();
            this.txtconsulta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgfornecedores = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tab1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tab2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgfornecedores)).BeginInit();
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
            this.tabControl1.TabIndex = 2;
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.button2);
            this.tab1.Controls.Add(this.label1);
            this.tab1.Controls.Add(this.cbuf);
            this.tab1.Controls.Add(this.btneditar);
            this.tab1.Controls.Add(this.btncadastrar);
            this.tab1.Controls.Add(this.btnexcluir);
            this.tab1.Controls.Add(this.txtcep);
            this.tab1.Controls.Add(this.txtnumero);
            this.tab1.Controls.Add(this.lblnumero);
            this.tab1.Controls.Add(this.txtcomplemento);
            this.tab1.Controls.Add(this.lblcomplemento);
            this.tab1.Controls.Add(this.txtbairro);
            this.tab1.Controls.Add(this.lblbairro);
            this.tab1.Controls.Add(this.txtcidade);
            this.tab1.Controls.Add(this.lblcidade);
            this.tab1.Controls.Add(this.txtendereco);
            this.tab1.Controls.Add(this.btnpesquisar);
            this.tab1.Controls.Add(this.lblcep);
            this.tab1.Controls.Add(this.panel1);
            this.tab1.Controls.Add(this.lblendereco);
            this.tab1.Location = new System.Drawing.Point(4, 26);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(3);
            this.tab1.Size = new System.Drawing.Size(786, 414);
            this.tab1.TabIndex = 0;
            this.tab1.Text = "Cadastro de Fornecedores";
            this.tab1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.button2.Location = new System.Drawing.Point(461, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 32);
            this.button2.TabIndex = 76;
            this.button2.Text = "Limpar dados";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(475, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 21);
            this.label1.TabIndex = 74;
            this.label1.Text = "UF:";
            // 
            // cbuf
            // 
            this.cbuf.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbuf.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.cbuf.FormattingEnabled = true;
            this.cbuf.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbuf.Location = new System.Drawing.Point(514, 259);
            this.cbuf.Name = "cbuf";
            this.cbuf.Size = new System.Drawing.Size(50, 27);
            this.cbuf.TabIndex = 71;
            // 
            // btneditar
            // 
            this.btneditar.BackColor = System.Drawing.Color.White;
            this.btneditar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btneditar.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.btneditar.Location = new System.Drawing.Point(598, 365);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(86, 43);
            this.btneditar.TabIndex = 70;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = false;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click_1);
            // 
            // btncadastrar
            // 
            this.btncadastrar.BackColor = System.Drawing.Color.White;
            this.btncadastrar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btncadastrar.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.btncadastrar.Location = new System.Drawing.Point(468, 365);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(108, 43);
            this.btncadastrar.TabIndex = 69;
            this.btncadastrar.Text = "Cadastrar";
            this.btncadastrar.UseVisualStyleBackColor = false;
            this.btncadastrar.Click += new System.EventHandler(this.btncadastrar_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.BackColor = System.Drawing.Color.White;
            this.btnexcluir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnexcluir.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.btnexcluir.Location = new System.Drawing.Point(705, 365);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(73, 43);
            this.btnexcluir.TabIndex = 65;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = false;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // txtcep
            // 
            this.txtcep.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcep.Location = new System.Drawing.Point(556, 65);
            this.txtcep.Mask = "#####-###";
            this.txtcep.Name = "txtcep";
            this.txtcep.Size = new System.Drawing.Size(79, 26);
            this.txtcep.TabIndex = 57;
            // 
            // txtnumero
            // 
            this.txtnumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnumero.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.txtnumero.Location = new System.Drawing.Point(713, 261);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(67, 24);
            this.txtnumero.TabIndex = 60;
            // 
            // lblnumero
            // 
            this.lblnumero.AutoSize = true;
            this.lblnumero.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblnumero.ForeColor = System.Drawing.Color.Black;
            this.lblnumero.Location = new System.Drawing.Point(633, 262);
            this.lblnumero.Name = "lblnumero";
            this.lblnumero.Size = new System.Drawing.Size(76, 21);
            this.lblnumero.TabIndex = 68;
            this.lblnumero.Text = "Número:";
            // 
            // txtcomplemento
            // 
            this.txtcomplemento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcomplemento.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.txtcomplemento.Location = new System.Drawing.Point(609, 222);
            this.txtcomplemento.Name = "txtcomplemento";
            this.txtcomplemento.Size = new System.Drawing.Size(171, 24);
            this.txtcomplemento.TabIndex = 59;
            // 
            // lblcomplemento
            // 
            this.lblcomplemento.AutoSize = true;
            this.lblcomplemento.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblcomplemento.ForeColor = System.Drawing.Color.Black;
            this.lblcomplemento.Location = new System.Drawing.Point(475, 222);
            this.lblcomplemento.Name = "lblcomplemento";
            this.lblcomplemento.Size = new System.Drawing.Size(128, 21);
            this.lblcomplemento.TabIndex = 67;
            this.lblcomplemento.Text = "Complemento:";
            // 
            // txtbairro
            // 
            this.txtbairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbairro.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.txtbairro.Location = new System.Drawing.Point(556, 185);
            this.txtbairro.Name = "txtbairro";
            this.txtbairro.Size = new System.Drawing.Size(171, 24);
            this.txtbairro.TabIndex = 66;
            // 
            // lblbairro
            // 
            this.lblbairro.AutoSize = true;
            this.lblbairro.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblbairro.ForeColor = System.Drawing.Color.Black;
            this.lblbairro.Location = new System.Drawing.Point(493, 185);
            this.lblbairro.Name = "lblbairro";
            this.lblbairro.Size = new System.Drawing.Size(57, 21);
            this.lblbairro.TabIndex = 64;
            this.lblbairro.Text = "Bairro:";
            // 
            // txtcidade
            // 
            this.txtcidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcidade.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.txtcidade.Location = new System.Drawing.Point(556, 146);
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.Size = new System.Drawing.Size(171, 24);
            this.txtcidade.TabIndex = 63;
            // 
            // lblcidade
            // 
            this.lblcidade.AutoSize = true;
            this.lblcidade.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblcidade.ForeColor = System.Drawing.Color.Black;
            this.lblcidade.Location = new System.Drawing.Point(477, 146);
            this.lblcidade.Name = "lblcidade";
            this.lblcidade.Size = new System.Drawing.Size(73, 21);
            this.lblcidade.TabIndex = 62;
            this.lblcidade.Text = "Cidade:";
            // 
            // txtendereco
            // 
            this.txtendereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtendereco.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.txtendereco.Location = new System.Drawing.Point(556, 104);
            this.txtendereco.Name = "txtendereco";
            this.txtendereco.Size = new System.Drawing.Size(224, 24);
            this.txtendereco.TabIndex = 61;
            // 
            // btnpesquisar
            // 
            this.btnpesquisar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpesquisar.Location = new System.Drawing.Point(683, 62);
            this.btnpesquisar.Name = "btnpesquisar";
            this.btnpesquisar.Size = new System.Drawing.Size(97, 30);
            this.btnpesquisar.TabIndex = 58;
            this.btnpesquisar.Text = "Pesquisar";
            this.btnpesquisar.UseVisualStyleBackColor = true;
            this.btnpesquisar.Click += new System.EventHandler(this.btnpesquisar_Click_1);
            // 
            // lblcep
            // 
            this.lblcep.AutoSize = true;
            this.lblcep.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblcep.ForeColor = System.Drawing.Color.Black;
            this.lblcep.Location = new System.Drawing.Point(505, 67);
            this.lblcep.Name = "lblcep";
            this.lblcep.Size = new System.Drawing.Size(45, 21);
            this.lblcep.TabIndex = 56;
            this.lblcep.Text = "CEP:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(56)))), ((int)(((byte)(84)))));
            this.panel1.Controls.Add(this.txttelefone);
            this.panel1.Controls.Add(this.txtcelular);
            this.panel1.Controls.Add(this.txtcnpj);
            this.panel1.Controls.Add(this.lblcpf);
            this.panel1.Controls.Add(this.txtemail);
            this.panel1.Controls.Add(this.txtnome);
            this.panel1.Controls.Add(this.txtcodigo);
            this.panel1.Controls.Add(this.lblcelular);
            this.panel1.Controls.Add(this.lbltelefone);
            this.panel1.Controls.Add(this.lblemail);
            this.panel1.Controls.Add(this.lblnome);
            this.panel1.Controls.Add(this.lblcodigo);
            this.panel1.Controls.Add(this.lbltitulo);
            this.panel1.Location = new System.Drawing.Point(4, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 402);
            this.panel1.TabIndex = 54;
            // 
            // txttelefone
            // 
            this.txttelefone.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelefone.Location = new System.Drawing.Point(327, 257);
            this.txttelefone.Mask = "(##) ####-####";
            this.txttelefone.Name = "txttelefone";
            this.txttelefone.Size = new System.Drawing.Size(111, 26);
            this.txttelefone.TabIndex = 7;
            // 
            // txtcelular
            // 
            this.txtcelular.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcelular.Location = new System.Drawing.Point(92, 257);
            this.txtcelular.Mask = "(##) #####-####";
            this.txtcelular.Name = "txtcelular";
            this.txtcelular.Size = new System.Drawing.Size(122, 26);
            this.txtcelular.TabIndex = 6;
            // 
            // txtcnpj
            // 
            this.txtcnpj.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcnpj.Location = new System.Drawing.Point(92, 177);
            this.txtcnpj.Mask = "##,###,###/####-##";
            this.txtcnpj.Name = "txtcnpj";
            this.txtcnpj.Size = new System.Drawing.Size(151, 26);
            this.txtcnpj.TabIndex = 3;
            // 
            // lblcpf
            // 
            this.lblcpf.AutoSize = true;
            this.lblcpf.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.lblcpf.ForeColor = System.Drawing.Color.White;
            this.lblcpf.Location = new System.Drawing.Point(23, 179);
            this.lblcpf.Name = "lblcpf";
            this.lblcpf.Size = new System.Drawing.Size(63, 21);
            this.lblcpf.TabIndex = 15;
            this.lblcpf.Text = "CNPJ:";
            // 
            // txtemail
            // 
            this.txtemail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtemail.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtemail.Location = new System.Drawing.Point(92, 216);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(280, 26);
            this.txtemail.TabIndex = 5;
            // 
            // txtnome
            // 
            this.txtnome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnome.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtnome.Location = new System.Drawing.Point(92, 138);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(346, 26);
            this.txtnome.TabIndex = 2;
            // 
            // txtcodigo
            // 
            this.txtcodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcodigo.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtcodigo.Location = new System.Drawing.Point(92, 96);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(67, 26);
            this.txtcodigo.TabIndex = 1;
            // 
            // lblcelular
            // 
            this.lblcelular.AutoSize = true;
            this.lblcelular.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.lblcelular.ForeColor = System.Drawing.Color.White;
            this.lblcelular.Location = new System.Drawing.Point(10, 257);
            this.lblcelular.Name = "lblcelular";
            this.lblcelular.Size = new System.Drawing.Size(76, 21);
            this.lblcelular.TabIndex = 5;
            this.lblcelular.Text = "Celular:";
            // 
            // lbltelefone
            // 
            this.lbltelefone.AutoSize = true;
            this.lbltelefone.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.lbltelefone.ForeColor = System.Drawing.Color.White;
            this.lbltelefone.Location = new System.Drawing.Point(230, 259);
            this.lbltelefone.Name = "lbltelefone";
            this.lbltelefone.Size = new System.Drawing.Size(91, 21);
            this.lbltelefone.TabIndex = 4;
            this.lbltelefone.Text = "Telefone:";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.lblemail.ForeColor = System.Drawing.Color.White;
            this.lblemail.Location = new System.Drawing.Point(20, 216);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(66, 21);
            this.lblemail.TabIndex = 3;
            this.lblemail.Text = "E-mail:";
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.lblnome.ForeColor = System.Drawing.Color.White;
            this.lblnome.Location = new System.Drawing.Point(17, 138);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(69, 21);
            this.lblnome.TabIndex = 2;
            this.lblnome.Text = "Nome:";
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.lblcodigo.ForeColor = System.Drawing.Color.White;
            this.lblcodigo.Location = new System.Drawing.Point(5, 96);
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
            this.lbltitulo.Location = new System.Drawing.Point(34, 31);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(398, 36);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "Cadastro de Fornecedores";
            // 
            // lblendereco
            // 
            this.lblendereco.AutoSize = true;
            this.lblendereco.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblendereco.ForeColor = System.Drawing.Color.Black;
            this.lblendereco.Location = new System.Drawing.Point(461, 104);
            this.lblendereco.Name = "lblendereco";
            this.lblendereco.Size = new System.Drawing.Size(89, 21);
            this.lblendereco.TabIndex = 55;
            this.lblendereco.Text = "Endereço:";
            // 
            // tab2
            // 
            this.tab2.Controls.Add(this.txtconsulta);
            this.tab2.Controls.Add(this.label2);
            this.tab2.Controls.Add(this.dgfornecedores);
            this.tab2.Location = new System.Drawing.Point(4, 26);
            this.tab2.Name = "tab2";
            this.tab2.Padding = new System.Windows.Forms.Padding(3);
            this.tab2.Size = new System.Drawing.Size(786, 414);
            this.tab2.TabIndex = 1;
            this.tab2.Text = "Consulta de Fornecedores";
            this.tab2.UseVisualStyleBackColor = true;
            // 
            // txtconsulta
            // 
            this.txtconsulta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtconsulta.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtconsulta.Location = new System.Drawing.Point(81, 19);
            this.txtconsulta.Name = "txtconsulta";
            this.txtconsulta.Size = new System.Drawing.Size(395, 26);
            this.txtconsulta.TabIndex = 4;
            this.txtconsulta.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
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
            // dgfornecedores
            // 
            this.dgfornecedores.AllowUserToAddRows = false;
            this.dgfornecedores.AllowUserToDeleteRows = false;
            this.dgfornecedores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgfornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgfornecedores.Location = new System.Drawing.Point(6, 58);
            this.dgfornecedores.Name = "dgfornecedores";
            this.dgfornecedores.ReadOnly = true;
            this.dgfornecedores.Size = new System.Drawing.Size(774, 350);
            this.dgfornecedores.TabIndex = 0;
            this.dgfornecedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgfornecedores_CellClick);
            // 
            // FrmFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmFornecedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Fornecedores";
            this.Load += new System.EventHandler(this.FrmFornecedores_Load);
            this.tabControl1.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tab2.ResumeLayout(false);
            this.tab2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgfornecedores)).EndInit();
            this.ResumeLayout(false);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbuf;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btncadastrar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.MaskedTextBox txtcep;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Label lblnumero;
        private System.Windows.Forms.TextBox txtcomplemento;
        private System.Windows.Forms.Label lblcomplemento;
        private System.Windows.Forms.TextBox txtbairro;
        private System.Windows.Forms.Label lblbairro;
        private System.Windows.Forms.TextBox txtcidade;
        private System.Windows.Forms.Label lblcidade;
        private System.Windows.Forms.TextBox txtendereco;
        private System.Windows.Forms.Button btnpesquisar;
        private System.Windows.Forms.Label lblcep;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox txttelefone;
        private System.Windows.Forms.MaskedTextBox txtcelular;
        private System.Windows.Forms.MaskedTextBox txtcnpj;
        private System.Windows.Forms.Label lblcpf;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label lblcelular;
        private System.Windows.Forms.Label lbltelefone;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label lblendereco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgfornecedores;
        private System.Windows.Forms.TextBox txtconsulta;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TabPage tab2;
        public System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.TabPage tab1;
    }
}