using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelaLogin.Apresentação_tela_
{
    public partial class Painel_Coach : Form
    {
        public Painel_Coach()
        {
            InitializeComponent();
        }

        private void fghfghToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pesquisarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PesquisarUsuario pu = new PesquisarUsuario();
            pu.Show();
        }

        private void Painel_Coach_Load(object sender, EventArgs e)
        {

        }

        private void cadastrarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CriarFicha cf = new CriarFicha();
            cf.Show();
        }
    }
}
