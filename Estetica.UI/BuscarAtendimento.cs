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
    public partial class BuscarAtendimento : Form
    {
        public BuscarAtendimento()
        {
            InitializeComponent();
        }

        private void TXTIdCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTIdAtendente_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTProcedimento_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTTempo_TextChanged(object sender, EventArgs e)
        {

        }

        private void IDBuscaAtendimento_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNBuscar_Click(object sender, EventArgs e)
        {
            Editar editar = new Editar();

            bool validacaoCampoVazio = editar.ValidarCampoVazio(IDBuscaAtendimento.Text);
            bool validacaoNumero = editar.ValidarNumero(IDBuscaAtendimento.Text);

            if (validacaoCampoVazio && validacaoNumero)
            {
                List<string> listAtendimento = editar.EditarDados("Atendimento", Convert.ToInt32(IDBuscaAtendimento.Text));

                if (listAtendimento[0] != "ID, não encontrado")
                {
                    TXTIdCliente.Text = listAtendimento[0];
                    TXTIdAtendente.Text = listAtendimento[1];
                    TXTProcedimento.Text = listAtendimento[2];
                    TXTProduto.Text = listAtendimento[3];
                    TXTTempo.Text = listAtendimento[4];
                }
                else
                {
                    MessageBox.Show(listAtendimento[0]);
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
