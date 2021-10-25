
namespace Projeto_Gioia.br.com.projeto.view
{
    partial class FrmHistorico
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
            this.dghistorico = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.btnpesquisar = new System.Windows.Forms.Button();
            this.lbldtinicio = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtdtfim = new System.Windows.Forms.DateTimePicker();
            this.lbldtfim = new System.Windows.Forms.Label();
            this.txtdtinicio = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dghistorico)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dghistorico
            // 
            this.dghistorico.AllowUserToAddRows = false;
            this.dghistorico.AllowUserToDeleteRows = false;
            this.dghistorico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dghistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dghistorico.Location = new System.Drawing.Point(21, 202);
            this.dghistorico.Name = "dghistorico";
            this.dghistorico.ReadOnly = true;
            this.dghistorico.Size = new System.Drawing.Size(758, 236);
            this.dghistorico.TabIndex = 0;
            this.dghistorico.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dghistorico_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.lbltitulo);
            this.panel1.Location = new System.Drawing.Point(12, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 95);
            this.panel1.TabIndex = 79;
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.ForeColor = System.Drawing.Color.White;
            this.lbltitulo.Location = new System.Drawing.Point(213, 28);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(374, 44);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "Histórico de Vendas";
            // 
            // btnpesquisar
            // 
            this.btnpesquisar.BackColor = System.Drawing.Color.White;
            this.btnpesquisar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnpesquisar.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.btnpesquisar.Location = new System.Drawing.Point(627, 141);
            this.btnpesquisar.Name = "btnpesquisar";
            this.btnpesquisar.Size = new System.Drawing.Size(152, 43);
            this.btnpesquisar.TabIndex = 3;
            this.btnpesquisar.Text = "Pesquisar";
            this.btnpesquisar.UseVisualStyleBackColor = false;
            this.btnpesquisar.Click += new System.EventHandler(this.btnpesquisar_Click);
            // 
            // lbldtinicio
            // 
            this.lbldtinicio.AutoSize = true;
            this.lbldtinicio.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.lbldtinicio.ForeColor = System.Drawing.Color.Black;
            this.lbldtinicio.Location = new System.Drawing.Point(25, 30);
            this.lbldtinicio.Name = "lbldtinicio";
            this.lbldtinicio.Size = new System.Drawing.Size(108, 21);
            this.lbldtinicio.TabIndex = 4;
            this.lbldtinicio.Text = "Data início:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtdtfim);
            this.groupBox2.Controls.Add(this.lbldtfim);
            this.groupBox2.Controls.Add(this.txtdtinicio);
            this.groupBox2.Controls.Add(this.lbldtinicio);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.groupBox2.Location = new System.Drawing.Point(32, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(576, 74);
            this.groupBox2.TabIndex = 81;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consulta";
            // 
            // txtdtfim
            // 
            this.txtdtfim.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.txtdtfim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtdtfim.Location = new System.Drawing.Point(434, 28);
            this.txtdtfim.Name = "txtdtfim";
            this.txtdtfim.Size = new System.Drawing.Size(111, 29);
            this.txtdtfim.TabIndex = 2;
            // 
            // lbldtfim
            // 
            this.lbldtfim.AutoSize = true;
            this.lbldtfim.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.lbldtfim.ForeColor = System.Drawing.Color.Black;
            this.lbldtfim.Location = new System.Drawing.Point(338, 30);
            this.lbldtfim.Name = "lbldtfim";
            this.lbldtfim.Size = new System.Drawing.Size(90, 21);
            this.lbldtfim.TabIndex = 6;
            this.lbldtfim.Text = "Data fim:";
            // 
            // txtdtinicio
            // 
            this.txtdtinicio.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.txtdtinicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtdtinicio.Location = new System.Drawing.Point(139, 28);
            this.txtdtinicio.Name = "txtdtinicio";
            this.txtdtinicio.Size = new System.Drawing.Size(111, 29);
            this.txtdtinicio.TabIndex = 1;
            // 
            // FrmHistorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnpesquisar);
            this.Controls.Add(this.dghistorico);
            this.Controls.Add(this.panel1);
            this.Name = "FrmHistorico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Histórico de Vendas";
            this.Load += new System.EventHandler(this.FrmHistorico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dghistorico)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dghistorico;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnpesquisar;
        private System.Windows.Forms.Label lbldtinicio;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbldtfim;
        private System.Windows.Forms.DateTimePicker txtdtinicio;
        private System.Windows.Forms.DateTimePicker txtdtfim;
    }
}