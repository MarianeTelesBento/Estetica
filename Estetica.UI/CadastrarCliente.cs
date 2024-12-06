using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Estetica.UI.Models;

namespace Estetica.UI
{
    public partial class CadastrarCliente : Form
    {
        public CadastrarCliente()
        {
            InitializeComponent();
        }

        public void LimparCampos()
        {
            TXTNomeCliente.Clear();
            TXTIdadeCliente.Clear();
            TXTEmailCliente.Clear();
            TXTTelefoneCliente.Clear();
            TXTCepCliente.Clear();
            TXTIdadeCliente.Clear();


            RDGenFeminino.Checked = false;
            RDGenMasculino.Checked = false;

            TXTFitzpatrickCliente.Clear(); 
            TXTEspessuraPeleCliente.Clear(); 
            TXTOleosidadePeleCliente.Clear(); 
            TXTHidratacaoPeleCliente.Clear(); 
            TXTLesoesCliente.Clear();

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void TXTNomeCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTIdadeCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTEmailCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTTelefoneCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTCepCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void RDGenFeminino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RDGenMasculino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TXTFitzpatrickCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTEspessuraPeleCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTOleosidadePeleCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTHidratacaoPeleCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTLesoesCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNEnviar_Click(object sender, EventArgs e)
        {
            int idCliente = 0;
            string genero;

            Cadastro cadastro = new Cadastro();


            bool validacao = cadastro.ValidarCampoVazio(TXTNomeCliente.Text, TXTIdadeCliente.Text, TXTEmailCliente.Text, TXTTelefoneCliente.Text, TXTCepCliente.Text);

            bool validarNumero = cadastro.ValidarNumero(TXTIdadeCliente.Text, TXTTelefoneCliente.Text, TXTCepCliente.Text);


            if (RDGenMasculino.Checked)
            {
                genero = "Masculino";
            }
            else if (RDGenFeminino.Checked)
            {
                genero = "Feminino";
            }
            else
            {
                MessageBox.Show("Selecione um Gênero");
                return;
            }

            if (validacao)
            {
                if (validarNumero)
                {
                    idCliente = cadastro.CadastrarDados("Cliente", TXTNomeCliente.Text, TXTIdadeCliente.Text, TXTEmailCliente.Text, TXTTelefoneCliente.Text, TXTCepCliente.Text, genero, TXTFitzpatrickCliente.Text, TXTEspessuraPeleCliente.Text, TXTOleosidadePeleCliente.Text, TXTHidratacaoPeleCliente.Text, TXTLesoesCliente.Text);
                }
                else
                {
                    MessageBox.Show("Número inválido");
                }
            }
            else
            {
                MessageBox.Show("O Campo não pode ser vazio");
            }

            if (idCliente > 0)
            {
                MessageBox.Show("Dados cadastrados com sucesso.");
                MessageBox.Show($"O ID do cliente é: {idCliente}");
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Nenhum dado foi cadastrado");
            }

        }


    }
}