namespace Estetica.UI
{
    partial class Iniciar
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
            this.BTNCadastrarCliente = new System.Windows.Forms.Button();
            this.BTNExluirCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BTNBuscarCliente = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTNCadastrarCliente
            // 
            this.BTNCadastrarCliente.Location = new System.Drawing.Point(133, 202);
            this.BTNCadastrarCliente.Name = "BTNCadastrarCliente";
            this.BTNCadastrarCliente.Size = new System.Drawing.Size(75, 23);
            this.BTNCadastrarCliente.TabIndex = 0;
            this.BTNCadastrarCliente.Text = "Cadastrar";
            this.BTNCadastrarCliente.UseVisualStyleBackColor = true;
            this.BTNCadastrarCliente.Click += new System.EventHandler(this.BTNCadastrarCliente_Click);
            // 
            // BTNExluirCliente
            // 
            this.BTNExluirCliente.Location = new System.Drawing.Point(243, 202);
            this.BTNExluirCliente.Name = "BTNExluirCliente";
            this.BTNExluirCliente.Size = new System.Drawing.Size(75, 23);
            this.BTNExluirCliente.TabIndex = 1;
            this.BTNExluirCliente.Text = "Excluir";
            this.BTNExluirCliente.UseVisualStyleBackColor = true;
            this.BTNExluirCliente.Click += new System.EventHandler(this.BTNExluirCliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cliente";
            // 
            // BTNBuscarCliente
            // 
            this.BTNBuscarCliente.Location = new System.Drawing.Point(190, 246);
            this.BTNBuscarCliente.Name = "BTNBuscarCliente";
            this.BTNBuscarCliente.Size = new System.Drawing.Size(75, 23);
            this.BTNBuscarCliente.TabIndex = 5;
            this.BTNBuscarCliente.Text = "Pesquisar";
            this.BTNBuscarCliente.UseVisualStyleBackColor = true;
            this.BTNBuscarCliente.Click += new System.EventHandler(this.BTNBuscarCliente_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(560, 246);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 9;
            this.button6.Text = "Pesquisar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(558, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Atendimento";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(613, 202);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "Excluir";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(503, 202);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Cadastrar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Iniciar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.BTNBuscarCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTNExluirCliente);
            this.Controls.Add(this.BTNCadastrarCliente);
            this.Name = "Iniciar";
            this.Text = "Iniciar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BTNCadastrarCliente;
        private Button BTNExluirCliente;
        private Label label1;
        private Button BTNBuscarCliente;
        private Button button6;
        private Label label2;
        private Button button5;
        private Button button4;
    }
}