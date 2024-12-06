namespace Estetica.UI
{
    partial class CadastrarCliente
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TXTEmailCliente = new System.Windows.Forms.TextBox();
            this.TXTTelefoneCliente = new System.Windows.Forms.TextBox();
            this.TXTCepCliente = new System.Windows.Forms.TextBox();
            this.TXTNomeCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RDGenFeminino = new System.Windows.Forms.RadioButton();
            this.RDGenMasculino = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TXTLesoesCliente = new System.Windows.Forms.TextBox();
            this.BTNEnviar = new System.Windows.Forms.Button();
            this.TXTFitzpatrickCliente = new System.Windows.Forms.TextBox();
            this.TXTEspessuraPeleCliente = new System.Windows.Forms.TextBox();
            this.TXTOleosidadePeleCliente = new System.Windows.Forms.TextBox();
            this.TXTHidratacaoPeleCliente = new System.Windows.Forms.TextBox();
            this.TXTIdadeCliente = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TXTEmailCliente
            // 
            this.TXTEmailCliente.Location = new System.Drawing.Point(137, 162);
            this.TXTEmailCliente.Name = "TXTEmailCliente";
            this.TXTEmailCliente.Size = new System.Drawing.Size(100, 23);
            this.TXTEmailCliente.TabIndex = 1;
            this.TXTEmailCliente.TextChanged += new System.EventHandler(this.TXTEmailCliente_TextChanged);
            // 
            // TXTTelefoneCliente
            // 
            this.TXTTelefoneCliente.Location = new System.Drawing.Point(137, 216);
            this.TXTTelefoneCliente.Name = "TXTTelefoneCliente";
            this.TXTTelefoneCliente.Size = new System.Drawing.Size(100, 23);
            this.TXTTelefoneCliente.TabIndex = 2;
            this.TXTTelefoneCliente.TextChanged += new System.EventHandler(this.TXTTelefoneCliente_TextChanged);
            // 
            // TXTCepCliente
            // 
            this.TXTCepCliente.Location = new System.Drawing.Point(137, 267);
            this.TXTCepCliente.Name = "TXTCepCliente";
            this.TXTCepCliente.Size = new System.Drawing.Size(100, 23);
            this.TXTCepCliente.TabIndex = 4;
            this.TXTCepCliente.TextChanged += new System.EventHandler(this.TXTCepCliente_TextChanged);
            // 
            // TXTNomeCliente
            // 
            this.TXTNomeCliente.Location = new System.Drawing.Point(137, 54);
            this.TXTNomeCliente.Name = "TXTNomeCliente";
            this.TXTNomeCliente.Size = new System.Drawing.Size(100, 23);
            this.TXTNomeCliente.TabIndex = 5;
            this.TXTNomeCliente.TextChanged += new System.EventHandler(this.TXTNomeCliente_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Idade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Telefone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(137, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cep";
            // 
            // RDGenFeminino
            // 
            this.RDGenFeminino.AutoSize = true;
            this.RDGenFeminino.Location = new System.Drawing.Point(137, 338);
            this.RDGenFeminino.Name = "RDGenFeminino";
            this.RDGenFeminino.Size = new System.Drawing.Size(75, 19);
            this.RDGenFeminino.TabIndex = 12;
            this.RDGenFeminino.TabStop = true;
            this.RDGenFeminino.Text = "Feminino";
            this.RDGenFeminino.UseVisualStyleBackColor = true;
            this.RDGenFeminino.CheckedChanged += new System.EventHandler(this.RDGenFeminino_CheckedChanged);
            // 
            // RDGenMasculino
            // 
            this.RDGenMasculino.AutoSize = true;
            this.RDGenMasculino.Location = new System.Drawing.Point(218, 338);
            this.RDGenMasculino.Name = "RDGenMasculino";
            this.RDGenMasculino.Size = new System.Drawing.Size(80, 19);
            this.RDGenMasculino.TabIndex = 13;
            this.RDGenMasculino.TabStop = true;
            this.RDGenMasculino.Text = "Masculino";
            this.RDGenMasculino.UseVisualStyleBackColor = true;
            this.RDGenMasculino.CheckedChanged += new System.EventHandler(this.RDGenMasculino_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(137, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Gênero";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(440, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "Classificação de Fitzpatrick";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(444, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "Espessura da Pele";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(445, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 15);
            this.label9.TabIndex = 21;
            this.label9.Text = "Oleosidade da Pele";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(440, 260);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 15);
            this.label10.TabIndex = 22;
            this.label10.Text = "Hidratação da pele";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(469, 342);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 15);
            this.label11.TabIndex = 23;
            this.label11.Text = "Lesões de pele";
            // 
            // TXTLesoesCliente
            // 
            this.TXTLesoesCliente.Location = new System.Drawing.Point(569, 334);
            this.TXTLesoesCliente.Name = "TXTLesoesCliente";
            this.TXTLesoesCliente.Size = new System.Drawing.Size(100, 23);
            this.TXTLesoesCliente.TabIndex = 36;
            this.TXTLesoesCliente.TextChanged += new System.EventHandler(this.TXTLesoesCliente_TextChanged);
            // 
            // BTNEnviar
            // 
            this.BTNEnviar.Location = new System.Drawing.Point(359, 393);
            this.BTNEnviar.Name = "BTNEnviar";
            this.BTNEnviar.Size = new System.Drawing.Size(75, 23);
            this.BTNEnviar.TabIndex = 37;
            this.BTNEnviar.Text = "Enviar";
            this.BTNEnviar.UseVisualStyleBackColor = true;
            this.BTNEnviar.Click += new System.EventHandler(this.BTNEnviar_Click);
            // 
            // TXTFitzpatrickCliente
            // 
            this.TXTFitzpatrickCliente.Location = new System.Drawing.Point(440, 69);
            this.TXTFitzpatrickCliente.Name = "TXTFitzpatrickCliente";
            this.TXTFitzpatrickCliente.Size = new System.Drawing.Size(100, 23);
            this.TXTFitzpatrickCliente.TabIndex = 38;
            this.TXTFitzpatrickCliente.TextChanged += new System.EventHandler(this.TXTFitzpatrickCliente_TextChanged);
            // 
            // TXTEspessuraPeleCliente
            // 
            this.TXTEspessuraPeleCliente.Location = new System.Drawing.Point(445, 136);
            this.TXTEspessuraPeleCliente.Name = "TXTEspessuraPeleCliente";
            this.TXTEspessuraPeleCliente.Size = new System.Drawing.Size(100, 23);
            this.TXTEspessuraPeleCliente.TabIndex = 39;
            this.TXTEspessuraPeleCliente.TextChanged += new System.EventHandler(this.TXTEspessuraPeleCliente_TextChanged);
            // 
            // TXTOleosidadePeleCliente
            // 
            this.TXTOleosidadePeleCliente.Location = new System.Drawing.Point(440, 216);
            this.TXTOleosidadePeleCliente.Name = "TXTOleosidadePeleCliente";
            this.TXTOleosidadePeleCliente.Size = new System.Drawing.Size(100, 23);
            this.TXTOleosidadePeleCliente.TabIndex = 40;
            this.TXTOleosidadePeleCliente.TextChanged += new System.EventHandler(this.TXTOleosidadePeleCliente_TextChanged);
            // 
            // TXTHidratacaoPeleCliente
            // 
            this.TXTHidratacaoPeleCliente.Location = new System.Drawing.Point(445, 278);
            this.TXTHidratacaoPeleCliente.Name = "TXTHidratacaoPeleCliente";
            this.TXTHidratacaoPeleCliente.Size = new System.Drawing.Size(100, 23);
            this.TXTHidratacaoPeleCliente.TabIndex = 41;
            this.TXTHidratacaoPeleCliente.TextChanged += new System.EventHandler(this.TXTHidratacaoPeleCliente_TextChanged);
            // 
            // TXTIdadeCliente
            // 
            this.TXTIdadeCliente.Location = new System.Drawing.Point(137, 107);
            this.TXTIdadeCliente.Name = "TXTIdadeCliente";
            this.TXTIdadeCliente.Size = new System.Drawing.Size(100, 23);
            this.TXTIdadeCliente.TabIndex = 42;
            this.TXTIdadeCliente.TextChanged += new System.EventHandler(this.TXTIdadeCliente_TextChanged);
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TXTIdadeCliente);
            this.Controls.Add(this.TXTHidratacaoPeleCliente);
            this.Controls.Add(this.TXTOleosidadePeleCliente);
            this.Controls.Add(this.TXTEspessuraPeleCliente);
            this.Controls.Add(this.TXTFitzpatrickCliente);
            this.Controls.Add(this.BTNEnviar);
            this.Controls.Add(this.TXTLesoesCliente);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RDGenMasculino);
            this.Controls.Add(this.RDGenFeminino);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXTNomeCliente);
            this.Controls.Add(this.TXTCepCliente);
            this.Controls.Add(this.TXTTelefoneCliente);
            this.Controls.Add(this.TXTEmailCliente);
            this.Name = "Cliente";
            this.Text = "Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox TXTEmailCliente;
        private TextBox TXTTelefoneCliente;
        private TextBox TXTCepCliente;
        private TextBox TXTNomeCliente;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private RadioButton RDGenFeminino;
        private RadioButton RDGenMasculino;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox TXTLesoesCliente;
        private Button BTNEnviar;
        private TextBox TXTFitzpatrickCliente;
        private TextBox TXTEspessuraPeleCliente;
        private TextBox TXTOleosidadePeleCliente;
        private TextBox TXTHidratacaoPeleCliente;
        private TextBox TXTIdadeCliente;
    }
}