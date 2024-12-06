namespace Estetica.UI
{
    partial class ExcluirAtendimento
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
            this.BTNExcluirAtendimento = new System.Windows.Forms.Button();
            this.TXTIDExcluirAtendimento = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(582, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Insira o ID do Atendimento";
            // 
            // BTNExcluirAtendimento
            // 
            this.BTNExcluirAtendimento.Location = new System.Drawing.Point(582, 259);
            this.BTNExcluirAtendimento.Name = "BTNExcluirAtendimento";
            this.BTNExcluirAtendimento.Size = new System.Drawing.Size(75, 23);
            this.BTNExcluirAtendimento.TabIndex = 4;
            this.BTNExcluirAtendimento.Text = "Excluir";
            this.BTNExcluirAtendimento.UseVisualStyleBackColor = true;
            this.BTNExcluirAtendimento.Click += new System.EventHandler(this.BTNExcluirAtendimento_Click);
            // 
            // TXTIDExcluirAtendimento
            // 
            this.TXTIDExcluirAtendimento.Location = new System.Drawing.Point(582, 188);
            this.TXTIDExcluirAtendimento.Name = "TXTIDExcluirAtendimento";
            this.TXTIDExcluirAtendimento.Size = new System.Drawing.Size(100, 23);
            this.TXTIDExcluirAtendimento.TabIndex = 3;
            this.TXTIDExcluirAtendimento.TextChanged += new System.EventHandler(this.TXTIDExcluirAtendimento_TextChanged);
            // 
            // ExcluirAtendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTNExcluirAtendimento);
            this.Controls.Add(this.TXTIDExcluirAtendimento);
            this.Name = "ExcluirAtendimento";
            this.Text = "ExcluirAtendimento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button BTNExcluirAtendimento;
        private TextBox TXTIDExcluirAtendimento;
    }
}