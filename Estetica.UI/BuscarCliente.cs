using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Estetica.UI.Models;

namespace Estetica.UI
{
    public partial class BuscarCliente : Form
    {
        public BuscarCliente()
        {
            InitializeComponent();
        }


        private void IDBuscaCliente_TextChanged(object sender, EventArgs e)
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

        private void TXTGeneroCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTClassificacaoFitzpatrickCliente_TextChanged(object sender, EventArgs e)
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

        private void TXTLesoesPeleCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNBuscar_Click(object sender, EventArgs e)
        {

            Editar editar = new Editar();

            bool validacaoCampoVazio = editar.ValidarCampoVazio(IDBuscaCliente.Text);
            bool validacaoNumero = editar.ValidarNumero(IDBuscaCliente.Text);

            if (validacaoCampoVazio && validacaoNumero)
            {
                List<string> listCliente = editar.EditarDados("Cliente", Convert.ToInt32(IDBuscaCliente.Text));

                if (listCliente[0] != "ID, não encontrado")
                {

                    TXTNomeCliente.Text = listCliente[0];
                    TXTIdadeCliente.Text = listCliente[1];
                    TXTEmailCliente.Text = listCliente[2];

                    TXTTelefoneCliente.Text = listCliente[3];
                    TXTCepCliente.Text = listCliente[4];
                    TXTGeneroCliente.Text = listCliente[5];
                    TXTClassificacaoFitzpatrickCliente.Text = listCliente[6];
                    TXTEspessuraPeleCliente.Text = listCliente[7];
                    TXTOleosidadePeleCliente.Text = listCliente[8];
                    TXTHidratacaoPeleCliente.Text = listCliente[9];
                    TXTLesoesPeleCliente.Text = listCliente[10];
                }
                else
                {
                    MessageBox.Show(listCliente[0]);
                }
            }
            else
            {
                MessageBox.Show("No(s) campo(s) Idade, Telefone, Cep são aceitos apenas números...");
            }
        }

        private void BTNBuscarSalvar_Click(object sender, EventArgs e)
        {

        }

    }
}
