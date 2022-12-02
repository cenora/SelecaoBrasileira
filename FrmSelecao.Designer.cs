
namespace SelecaoBrasileira
{
    partial class FrmSelecao
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtJogador = new System.Windows.Forms.TextBox();
            this.btnConvocar = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblTitular = new System.Windows.Forms.Label();
            this.lblReserva = new System.Windows.Forms.Label();
            this.lblQtdTitular = new System.Windows.Forms.Label();
            this.lblQtdReserva = new System.Windows.Forms.Label();
            this.lstTitular = new System.Windows.Forms.ListBox();
            this.lstReserva = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtJogador
            // 
            this.txtJogador.Font = new System.Drawing.Font("League Spartan", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJogador.Location = new System.Drawing.Point(28, 42);
            this.txtJogador.Name = "txtJogador";
            this.txtJogador.Size = new System.Drawing.Size(288, 41);
            this.txtJogador.TabIndex = 2;
            // 
            // btnConvocar
            // 
            this.btnConvocar.Font = new System.Drawing.Font("League Spartan", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvocar.Location = new System.Drawing.Point(354, 42);
            this.btnConvocar.Name = "btnConvocar";
            this.btnConvocar.Size = new System.Drawing.Size(192, 41);
            this.btnConvocar.TabIndex = 3;
            this.btnConvocar.Text = "Convocar";
            this.btnConvocar.UseVisualStyleBackColor = true;
            this.btnConvocar.Click += new System.EventHandler(this.btnConvocar_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("League Spartan", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(28, 15);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(76, 24);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome:";
            // 
            // lblTitular
            // 
            this.lblTitular.AutoSize = true;
            this.lblTitular.Font = new System.Drawing.Font("League Spartan", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitular.Location = new System.Drawing.Point(28, 96);
            this.lblTitular.Name = "lblTitular";
            this.lblTitular.Size = new System.Drawing.Size(75, 24);
            this.lblTitular.TabIndex = 4;
            this.lblTitular.Text = "Titular";
            // 
            // lblReserva
            // 
            this.lblReserva.AutoSize = true;
            this.lblReserva.Font = new System.Drawing.Font("League Spartan", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReserva.Location = new System.Drawing.Point(350, 97);
            this.lblReserva.Name = "lblReserva";
            this.lblReserva.Size = new System.Drawing.Size(89, 24);
            this.lblReserva.TabIndex = 4;
            this.lblReserva.Text = "Reserva";
            // 
            // lblQtdTitular
            // 
            this.lblQtdTitular.AutoSize = true;
            this.lblQtdTitular.Font = new System.Drawing.Font("League Spartan", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdTitular.Location = new System.Drawing.Point(110, 442);
            this.lblQtdTitular.Name = "lblQtdTitular";
            this.lblQtdTitular.Size = new System.Drawing.Size(169, 24);
            this.lblQtdTitular.TabIndex = 4;
            this.lblQtdTitular.Text = "Qtd. Jogadores:";
            this.lblQtdTitular.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblQtdReserva
            // 
            this.lblQtdReserva.AutoSize = true;
            this.lblQtdReserva.Font = new System.Drawing.Font("League Spartan", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdReserva.Location = new System.Drawing.Point(433, 442);
            this.lblQtdReserva.Name = "lblQtdReserva";
            this.lblQtdReserva.Size = new System.Drawing.Size(169, 24);
            this.lblQtdReserva.TabIndex = 4;
            this.lblQtdReserva.Text = "Qtd. Jogadores:";
            // 
            // lstTitular
            // 
            this.lstTitular.Font = new System.Drawing.Font("League Spartan", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTitular.FormattingEnabled = true;
            this.lstTitular.ItemHeight = 24;
            this.lstTitular.Location = new System.Drawing.Point(32, 123);
            this.lstTitular.Name = "lstTitular";
            this.lstTitular.Size = new System.Drawing.Size(284, 316);
            this.lstTitular.TabIndex = 5;
            // 
            // lstReserva
            // 
            this.lstReserva.Font = new System.Drawing.Font("League Spartan", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstReserva.FormattingEnabled = true;
            this.lstReserva.ItemHeight = 24;
            this.lstReserva.Location = new System.Drawing.Point(354, 123);
            this.lstReserva.Name = "lstReserva";
            this.lstReserva.Size = new System.Drawing.Size(284, 316);
            this.lstReserva.TabIndex = 5;
            this.lstReserva.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstReserva_MouseDoubleClick);
            // 
            // FrmSelecao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 516);
            this.Controls.Add(this.lstReserva);
            this.Controls.Add(this.lstTitular);
            this.Controls.Add(this.lblReserva);
            this.Controls.Add(this.lblTitular);
            this.Controls.Add(this.lblQtdReserva);
            this.Controls.Add(this.lblQtdTitular);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnConvocar);
            this.Controls.Add(this.txtJogador);
            this.Name = "FrmSelecao";
            this.Text = "Seleção Brasileira";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtJogador;
        private System.Windows.Forms.Button btnConvocar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblTitular;
        private System.Windows.Forms.Label lblReserva;
        private System.Windows.Forms.Label lblQtdTitular;
        private System.Windows.Forms.Label lblQtdReserva;
        private System.Windows.Forms.ListBox lstTitular;
        private System.Windows.Forms.ListBox lstReserva;
    }
}

