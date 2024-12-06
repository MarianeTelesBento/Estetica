namespace Estetica.UI
{
    partial class ExcluirCliente
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
            this.TXTIDExcluirCliente = new System.Windows.Forms.TextBox();
            this.BTNExcluirCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TXTIDExcluirCliente
            // 
            this.TXTIDExcluirCliente.Location = new System.Drawing.Point(609, 175);
            this.TXTIDExcluirCliente.Name = "TXTIDExcluirCliente";
            this.TXTIDExcluirCliente.Size = new System.Drawing.Size(100, 23);
            this.TXTIDExcluirCliente.TabIndex = 0;
            this.TXTIDExcluirCliente.TextChanged += new System.EventHandler(this.TXTIDExcluirCliente_TextChanged);
            // 
            // BTNExcluirCliente
            // 
            this.BTNExcluirCliente.Location = new System.Drawing.Point(609, 246);
            this.BTNExcluirCliente.Name = "BTNExcluirCliente";
            this.BTNExcluirCliente.Size = new System.Drawing.Size(75, 23);
            this.BTNExcluirCliente.TabIndex = 1;
            this.BTNExcluirCliente.Text = "Excluir";
            this.BTNExcluirCliente.UseVisualStyleBackColor = true;
            this.BTNExcluirCliente.Click += new System.EventHandler(this.BTNExcluirCliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(609, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Insira o ID do Cliente";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ExcluirCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTNExcluirCliente);
            this.Controls.Add(this.TXTIDExcluirCliente);
            this.Name = "ExcluirCliente";
            this.Text = "ExcluirCliente";
            this.Load += new System.EventHandler(this.ExcluirCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TXTIDExcluirCliente;
        private Button BTNExcluirCliente;
        private Label label1;
    }
}