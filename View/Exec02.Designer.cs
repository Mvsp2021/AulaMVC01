
namespace AulaMVC01.View
{
    partial class Exec02
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
            this.dgVagas = new System.Windows.Forms.DataGridView();
            this.NumeroVagaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlacaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraEntradaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbVagasLivres = new System.Windows.Forms.ComboBox();
            this.cbPlacas = new System.Windows.Forms.ComboBox();
            this.lblVagasLivres = new System.Windows.Forms.Label();
            this.lblPlacas = new System.Windows.Forms.Label();
            this.lblHoraEntrada = new System.Windows.Forms.Label();
            this.txtHoraEntrada = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.lblLavou = new System.Windows.Forms.Label();
            this.rbS = new System.Windows.Forms.RadioButton();
            this.rbN = new System.Windows.Forms.RadioButton();
            this.lblHoraSaida = new System.Windows.Forms.Label();
            this.txtHoraSaida = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgVagas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgVagas
            // 
            this.dgVagas.AllowUserToAddRows = false;
            this.dgVagas.AllowUserToDeleteRows = false;
            this.dgVagas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVagas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroVagaCol,
            this.PlacaCol,
            this.HoraEntradaCol});
            this.dgVagas.Location = new System.Drawing.Point(37, 34);
            this.dgVagas.Name = "dgVagas";
            this.dgVagas.ReadOnly = true;
            this.dgVagas.RowTemplate.Height = 50;
            this.dgVagas.Size = new System.Drawing.Size(690, 179);
            this.dgVagas.TabIndex = 0;
            // 
            // NumeroVagaCol
            // 
            this.NumeroVagaCol.HeaderText = "Vaga";
            this.NumeroVagaCol.Name = "NumeroVagaCol";
            this.NumeroVagaCol.ReadOnly = true;
            this.NumeroVagaCol.Width = 110;
            // 
            // PlacaCol
            // 
            this.PlacaCol.HeaderText = "Placa";
            this.PlacaCol.Name = "PlacaCol";
            this.PlacaCol.ReadOnly = true;
            this.PlacaCol.Width = 180;
            // 
            // HoraEntradaCol
            // 
            this.HoraEntradaCol.HeaderText = "Hora Entrada";
            this.HoraEntradaCol.Name = "HoraEntradaCol";
            this.HoraEntradaCol.ReadOnly = true;
            this.HoraEntradaCol.Width = 250;
            // 
            // cbVagasLivres
            // 
            this.cbVagasLivres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVagasLivres.FormattingEnabled = true;
            this.cbVagasLivres.Location = new System.Drawing.Point(37, 285);
            this.cbVagasLivres.Name = "cbVagasLivres";
            this.cbVagasLivres.Size = new System.Drawing.Size(220, 32);
            this.cbVagasLivres.TabIndex = 1;
            // 
            // cbPlacas
            // 
            this.cbPlacas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlacas.FormattingEnabled = true;
            this.cbPlacas.Location = new System.Drawing.Point(330, 285);
            this.cbPlacas.Name = "cbPlacas";
            this.cbPlacas.Size = new System.Drawing.Size(220, 32);
            this.cbPlacas.TabIndex = 2;
            // 
            // lblVagasLivres
            // 
            this.lblVagasLivres.AutoSize = true;
            this.lblVagasLivres.Location = new System.Drawing.Point(50, 246);
            this.lblVagasLivres.Name = "lblVagasLivres";
            this.lblVagasLivres.Size = new System.Drawing.Size(117, 24);
            this.lblVagasLivres.TabIndex = 3;
            this.lblVagasLivres.Text = "Vagas Livres";
            // 
            // lblPlacas
            // 
            this.lblPlacas.AutoSize = true;
            this.lblPlacas.Location = new System.Drawing.Point(326, 246);
            this.lblPlacas.Name = "lblPlacas";
            this.lblPlacas.Size = new System.Drawing.Size(65, 24);
            this.lblPlacas.TabIndex = 4;
            this.lblPlacas.Text = "Placas";
            // 
            // lblHoraEntrada
            // 
            this.lblHoraEntrada.AutoSize = true;
            this.lblHoraEntrada.Location = new System.Drawing.Point(50, 332);
            this.lblHoraEntrada.Name = "lblHoraEntrada";
            this.lblHoraEntrada.Size = new System.Drawing.Size(121, 24);
            this.lblHoraEntrada.TabIndex = 5;
            this.lblHoraEntrada.Text = "Hora Entrada";
            // 
            // txtHoraEntrada
            // 
            this.txtHoraEntrada.Location = new System.Drawing.Point(37, 369);
            this.txtHoraEntrada.Name = "txtHoraEntrada";
            this.txtHoraEntrada.Size = new System.Drawing.Size(191, 29);
            this.txtHoraEntrada.TabIndex = 2;
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(37, 469);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(174, 50);
            this.btnEntrar.TabIndex = 7;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // lblLavou
            // 
            this.lblLavou.AutoSize = true;
            this.lblLavou.Location = new System.Drawing.Point(362, 374);
            this.lblLavou.Name = "lblLavou";
            this.lblLavou.Size = new System.Drawing.Size(71, 24);
            this.lblLavou.TabIndex = 8;
            this.lblLavou.Text = "Lavou?";
            // 
            // rbS
            // 
            this.rbS.AutoSize = true;
            this.rbS.Location = new System.Drawing.Point(451, 374);
            this.rbS.Name = "rbS";
            this.rbS.Size = new System.Drawing.Size(40, 28);
            this.rbS.TabIndex = 9;
            this.rbS.TabStop = true;
            this.rbS.Text = "S";
            this.rbS.UseVisualStyleBackColor = true;
            // 
            // rbN
            // 
            this.rbN.AutoSize = true;
            this.rbN.Location = new System.Drawing.Point(508, 374);
            this.rbN.Name = "rbN";
            this.rbN.Size = new System.Drawing.Size(42, 28);
            this.rbN.TabIndex = 10;
            this.rbN.TabStop = true;
            this.rbN.Text = "N";
            this.rbN.UseVisualStyleBackColor = true;
            // 
            // lblHoraSaida
            // 
            this.lblHoraSaida.AutoSize = true;
            this.lblHoraSaida.Location = new System.Drawing.Point(330, 429);
            this.lblHoraSaida.Name = "lblHoraSaida";
            this.lblHoraSaida.Size = new System.Drawing.Size(103, 24);
            this.lblHoraSaida.TabIndex = 11;
            this.lblHoraSaida.Text = "Hora Saída";
            // 
            // txtHoraSaida
            // 
            this.txtHoraSaida.Location = new System.Drawing.Point(334, 469);
            this.txtHoraSaida.Name = "txtHoraSaida";
            this.txtHoraSaida.Size = new System.Drawing.Size(157, 29);
            this.txtHoraSaida.TabIndex = 12;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(334, 518);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(157, 31);
            this.btnSair.TabIndex = 13;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(653, 474);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 60);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(12, 419);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(56, 24);
            this.lblPlaca.TabIndex = 15;
            this.lblPlaca.Text = "Placa";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(74, 419);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(191, 29);
            this.txtPlaca.TabIndex = 3;
            // 
            // Exec02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtHoraSaida);
            this.Controls.Add(this.lblHoraSaida);
            this.Controls.Add(this.rbN);
            this.Controls.Add(this.rbS);
            this.Controls.Add(this.lblLavou);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txtHoraEntrada);
            this.Controls.Add(this.lblHoraEntrada);
            this.Controls.Add(this.lblPlacas);
            this.Controls.Add(this.lblVagasLivres);
            this.Controls.Add(this.cbPlacas);
            this.Controls.Add(this.cbVagasLivres);
            this.Controls.Add(this.dgVagas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Exec02";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exec02";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Exec02_FormClosed);
            this.Load += new System.EventHandler(this.Exec02_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgVagas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgVagas;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroVagaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlacaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraEntradaCol;
        private System.Windows.Forms.ComboBox cbVagasLivres;
        private System.Windows.Forms.ComboBox cbPlacas;
        private System.Windows.Forms.Label lblVagasLivres;
        private System.Windows.Forms.Label lblPlacas;
        private System.Windows.Forms.Label lblHoraEntrada;
        private System.Windows.Forms.TextBox txtHoraEntrada;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label lblLavou;
        private System.Windows.Forms.RadioButton rbS;
        private System.Windows.Forms.RadioButton rbN;
        private System.Windows.Forms.Label lblHoraSaida;
        private System.Windows.Forms.TextBox txtHoraSaida;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.TextBox txtPlaca;
    }
}