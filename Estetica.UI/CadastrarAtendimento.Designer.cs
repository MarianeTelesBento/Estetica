namespace Estetica.UI
{
    partial class CadastrarAtendimento
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TXTIdAtendenteAtendimento = new System.Windows.Forms.TextBox();
            this.TXTNomeAtendimento = new System.Windows.Forms.TextBox();
            this.TXTIdProdutosAtendimento = new System.Windows.Forms.TextBox();
            this.TXTIdTempoAtendimento = new System.Windows.Forms.TextBox();
            this.TXTIdClienteAtendimento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BTNCadastrarAtendimento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Atendente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome do Procedimento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Produtos ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(313, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tempo de Atendimento";
            // 
            // TXTIdAtendenteAtendimento
            // 
            this.TXTIdAtendenteAtendimento.Location = new System.Drawing.Point(155, 70);
            this.TXTIdAtendenteAtendimento.Name = "TXTIdAtendenteAtendimento";
            this.TXTIdAtendenteAtendimento.Size = new System.Drawing.Size(100, 23);
            this.TXTIdAtendenteAtendimento.TabIndex = 4;
            this.TXTIdAtendenteAtendimento.TextChanged += new System.EventHandler(this.TXTIdAtendenteAtendimento_TextChanged);
            // 
            // TXTNomeAtendimento
            // 
            this.TXTNomeAtendimento.Location = new System.Drawing.Point(313, 133);
            this.TXTNomeAtendimento.Name = "TXTNomeAtendimento";
            this.TXTNomeAtendimento.Size = new System.Drawing.Size(100, 23);
            this.TXTNomeAtendimento.TabIndex = 5;
            this.TXTNomeAtendimento.TextChanged += new System.EventHandler(this.TXTNomeAtendimento_TextChanged);
            // 
            // TXTIdProdutosAtendimento
            // 
            this.TXTIdProdutosAtendimento.Location = new System.Drawing.Point(155, 185);
            this.TXTIdProdutosAtendimento.Name = "TXTIdProdutosAtendimento";
            this.TXTIdProdutosAtendimento.Size = new System.Drawing.Size(100, 23);
            this.TXTIdProdutosAtendimento.TabIndex = 6;
            this.TXTIdProdutosAtendimento.TextChanged += new System.EventHandler(this.TXTIdProdutosAtendimento_TextChanged);
            // 
            // TXTIdTempoAtendimento
            // 
            this.TXTIdTempoAtendimento.Location = new System.Drawing.Point(313, 70);
            this.TXTIdTempoAtendimento.Name = "TXTIdTempoAtendimento";
            this.TXTIdTempoAtendimento.Size = new System.Drawing.Size(100, 23);
            this.TXTIdTempoAtendimento.TabIndex = 7;
            this.TXTIdTempoAtendimento.TextChanged += new System.EventHandler(this.TXTIdTempoAtendimento_TextChanged);
            // 
            // TXTIdClienteAtendimento
            // 
            this.TXTIdClienteAtendimento.Location = new System.Drawing.Point(155, 133);
            this.TXTIdClienteAtendimento.Name = "TXTIdClienteAtendimento";
            this.TXTIdClienteAtendimento.Size = new System.Drawing.Size(100, 23);
            this.TXTIdClienteAtendimento.TabIndex = 9;
            this.TXTIdClienteAtendimento.TextChanged += new System.EventHandler(this.TXTIdClienteAtendimento_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(155, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Id Cliente";
            // 
            // BTNCadastrarAtendimento
            // 
            this.BTNCadastrarAtendimento.Location = new System.Drawing.Point(424, 276);
            this.BTNCadastrarAtendimento.Name = "BTNCadastrarAtendimento";
            this.BTNCadastrarAtendimento.Size = new System.Drawing.Size(75, 23);
            this.BTNCadastrarAtendimento.TabIndex = 10;
            this.BTNCadastrarAtendimento.Text = "Enviar";
            this.BTNCadastrarAtendimento.UseVisualStyleBackColor = true;
            this.BTNCadastrarAtendimento.Click += new System.EventHandler(this.BTNCadastrarAtendimento_Click);
            // 
            // CadastrarAtendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTNCadastrarAtendimento);
            this.Controls.Add(this.TXTIdClienteAtendimento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TXTIdTempoAtendimento);
            this.Controls.Add(this.TXTIdProdutosAtendimento);
            this.Controls.Add(this.TXTNomeAtendimento);
            this.Controls.Add(this.TXTIdAtendenteAtendimento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CadastrarAtendimento";
            this.Text = "Atendimento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox TXTIdAtendenteAtendimento;
        private TextBox TXTNomeAtendimento;
        private TextBox TXTIdProdutosAtendimento;
        private TextBox TXTIdTempoAtendimento;
        private TextBox TXTIdClienteAtendimento;
        private Label label5;
        private Button BTNCadastrarAtendimento;
    }
}