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
    public partial class CadastrarAtendimento : Form
    {
        public CadastrarAtendimento()
        {
            InitializeComponent();
        }

        public void LimparCampos()
        {
            TXTIdAtendenteAtendimento.Clear();
            TXTIdClienteAtendimento.Clear();
            TXTIdProdutosAtendimento.Clear();
            TXTIdTempoAtendimento.Clear();
            TXTNomeAtendimento.Clear();
        }

        private void TXTIdAtendenteAtendimento_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTIdClienteAtendimento_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTIdProdutosAtendimento_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTIdTempoAtendimento_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTNomeAtendimento_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNCadastrarAtendimento_Click(object sender, EventArgs e)
        {
            int idAtedimenteo = 0;
            string genero;

            Cadastro cadastro = new Cadastro();

            bool validacao = cadastro.ValidarCampoVazio(TXTIdAtendenteAtendimento.Text, TXTIdClienteAtendimento.Text, TXTIdProdutosAtendimento.Text, TXTIdTempoAtendimento.Text, TXTNomeAtendimento.Text);

            bool validarNumero = cadastro.ValidarNumero(TXTIdAtendenteAtendimento.Text, TXTIdClienteAtendimento.Text, TXTIdTempoAtendimento.Text);


            if (validacao)
            {
                if (validarNumero)
                {
                    idAtedimenteo = cadastro.CadastrarDados("Atendimento", TXTIdAtendenteAtendimento.Text, TXTIdClienteAtendimento.Text, TXTIdProdutosAtendimento.Text, TXTIdTempoAtendimento.Text, TXTNomeAtendimento.Text);
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

            if (idAtedimenteo > 0)
            {
                MessageBox.Show("Dados cadastrados com sucesso.");
                MessageBox.Show($"O ID do Atendimento é: {idAtedimenteo}");
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Nenhum dado foi cadastrado");
            }
        }
    }
}
