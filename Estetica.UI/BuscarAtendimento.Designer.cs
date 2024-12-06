namespace Estetica.UI
{
    partial class BuscarAtendimento
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
            this.TXTTempo = new System.Windows.Forms.TextBox();
            this.TXTProduto = new System.Windows.Forms.TextBox();
            this.TXTProcedimento = new System.Windows.Forms.TextBox();
            this.TXTIdAtendente = new System.Windows.Forms.TextBox();
            this.TXTIdCliente = new System.Windows.Forms.TextBox();
            this.IDBuscaAtendimento = new System.Windows.Forms.TextBox();
            this.BTNBuscar = new System.Windows.Forms.Button();
            this.BTNBuscarSalvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TXTTempo
            // 
            this.TXTTempo.Location = new System.Drawing.Point(486, 220);
            this.TXTTempo.Name = "TXTTempo";
            this.TXTTempo.Size = new System.Drawing.Size(100, 23);
            this.TXTTempo.TabIndex = 36;
            this.TXTTempo.TextChanged += new System.EventHandler(this.TXTTempo_TextChanged);
            // 
            // TXTProduto
            // 
            this.TXTProduto.Location = new System.Drawing.Point(486, 191);
            this.TXTProduto.Name = "TXTProduto";
            this.TXTProduto.Size = new System.Drawing.Size(100, 23);
            this.TXTProduto.TabIndex = 35;
            this.TXTProduto.TextChanged += new System.EventHandler(this.TXTProduto_TextChanged);
            // 
            // TXTProcedimento
            // 
            this.TXTProcedimento.Location = new System.Drawing.Point(486, 162);
            this.TXTProcedimento.Name = "TXTProcedimento";
            this.TXTProcedimento.Size = new System.Drawing.Size(100, 23);
            this.TXTProcedimento.TabIndex = 29;
            this.TXTProcedimento.TextChanged += new System.EventHandler(this.TXTProcedimento_TextChanged);
            // 
            // TXTIdAtendente
            // 
            this.TXTIdAtendente.Location = new System.Drawing.Point(486, 133);
            this.TXTIdAtendente.Name = "TXTIdAtendente";
            this.TXTIdAtendente.Size = new System.Drawing.Size(100, 23);
            this.TXTIdAtendente.TabIndex = 28;
            this.TXTIdAtendente.TextChanged += new System.EventHandler(this.TXTIdAtendente_TextChanged);
            // 
            // TXTIdCliente
            // 
            this.TXTIdCliente.Location = new System.Drawing.Point(486, 104);
            this.TXTIdCliente.Name = "TXTIdCliente";
            this.TXTIdCliente.Size = new System.Drawing.Size(100, 23);
            this.TXTIdCliente.TabIndex = 27;
            this.TXTIdCliente.TextChanged += new System.EventHandler(this.TXTIdCliente_TextChanged);
            // 
            // IDBuscaAtendimento
            // 
            this.IDBuscaAtendimento.Location = new System.Drawing.Point(140, 162);
            this.IDBuscaAtendimento.Name = "IDBuscaAtendimento";
            this.IDBuscaAtendimento.Size = new System.Drawing.Size(100, 23);
            this.IDBuscaAtendimento.TabIndex = 26;
            this.IDBuscaAtendimento.TextChanged += new System.EventHandler(this.IDBuscaAtendimento_TextChanged);
            // 
            // BTNBuscar
            // 
            this.BTNBuscar.Location = new System.Drawing.Point(276, 164);
            this.BTNBuscar.Name = "BTNBuscar";
            this.BTNBuscar.Size = new System.Drawing.Size(75, 23);
            this.BTNBuscar.TabIndex = 25;
            this.BTNBuscar.Text = "Buscar";
            this.BTNBuscar.UseVisualStyleBackColor = true;
            this.BTNBuscar.Click += new System.EventHandler(this.BTNBuscar_Click);
            // 
            // BTNBuscarSalvar
            // 
            this.BTNBuscarSalvar.Location = new System.Drawing.Point(502, 281);
            this.BTNBuscarSalvar.Name = "BTNBuscarSalvar";
            this.BTNBuscarSalvar.Size = new System.Drawing.Size(75, 23);
            this.BTNBuscarSalvar.TabIndex = 24;
            this.BTNBuscarSalvar.Text = "Salvar";
            this.BTNBuscarSalvar.UseVisualStyleBackColor = true;
            this.BTNBuscarSalvar.Click += new System.EventHandler(this.BTNBuscarSalvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "Buscar ID";
            // 
            // BuscarAtendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TXTTempo);
            this.Controls.Add(this.TXTProduto);
            this.Controls.Add(this.TXTProcedimento);
            this.Controls.Add(this.TXTIdAtendente);
            this.Controls.Add(this.TXTIdCliente);
            this.Controls.Add(this.IDBuscaAtendimento);
            this.Controls.Add(this.BTNBuscar);
            this.Controls.Add(this.BTNBuscarSalvar);
            this.Controls.Add(this.label1);
            this.Name = "BuscarAtendimento";
            this.Text = "BuscarAtendimento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TXTTempo;
        private TextBox TXTProduto;
        private TextBox TXTProcedimento;
        private TextBox TXTIdAtendente;
        private TextBox TXTIdCliente;
        private TextBox IDBuscaAtendimento;
        private Button BTNBuscar;
        private Button BTNBuscarSalvar;
        private Label label1;
    }
}