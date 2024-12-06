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
    public partial class ExcluirCliente : Form
    {
        public ExcluirCliente()
        {
            InitializeComponent();
        }

        private void ExcluirCliente_Load(object sender, EventArgs e)
        {

        }

        private void TXTIDExcluirCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNExcluirCliente_Click(object sender, EventArgs e)
        {
            Exclusao exclusao = new Exclusao();

            bool validacao = exclusao.ValidarCampoVazio(TXTIDExcluirCliente.Text);
            int DadoExcluido = 0;

            if (validacao)
            {
                DadoExcluido = exclusao.ExcluirDados("Cliente", TXTIDExcluirCliente.Text);

                if (DadoExcluido > 0)
                {
                    MessageBox.Show("Dados excluidos com sucesso.");
                }
                else
                {
                    MessageBox.Show("ID não encontrado");
                    MessageBox.Show("Nenhum dado foi excluido.");
                }
            }
            else
            {
                MessageBox.Show("Os Campos não podem ser vazio");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
