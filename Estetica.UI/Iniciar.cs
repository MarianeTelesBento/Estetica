using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estetica.UI
{
    public partial class Iniciar : Form
    {
        public Iniciar()
        {
            InitializeComponent();
        }

        private void BTNCadastrarCliente_Click(object sender, EventArgs e)
        {
            CadastrarCliente cadastrarCliente = new CadastrarCliente();
            cadastrarCliente.Show();
        }
        private void BTNExluirCliente_Click(object sender, EventArgs e)
        {
            ExcluirCliente excluirCliente = new ExcluirCliente();
            excluirCliente.Show();
        }


        private void BTNBuscarCliente_Click(object sender, EventArgs e)
        {
            BuscarCliente buscarCliente = new BuscarCliente();
            buscarCliente.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CadastrarAtendimento cadastrarAtendimento = new CadastrarAtendimento();
            cadastrarAtendimento.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ExcluirAtendimento excluirAtendimento = new ExcluirAtendimento();
            excluirAtendimento.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BuscarAtendimento buscarAtendimento = new BuscarAtendimento();
            buscarAtendimento.Show();
        }
    }
}
