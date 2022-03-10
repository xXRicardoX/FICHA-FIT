using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelaLogin.Apresentação_tela_;
using TelaLogin.Modelo_Controle_;

namespace TelaLogin
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtEntrar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //colcar o using da janela requerida e logo em seguida instaciar
            frmCadastro cad = new frmCadastro();
            cad.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {

        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void lblSenha_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //colocar o using da janela requerida e logo em seguida instaciar
            frmCadastro cad = new frmCadastro();
            cad.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cliente cs = new Cliente();
            cs.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();//instanciando a classe controle
            controle.acessar2(txbLogin.Text, txbSenha.Text);

            if (controle.mensagem.Equals(""))
            {


                if (controle.tem)
                {
                    MessageBox.Show("Logado com Sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Painel_Coach pc = new Painel_Coach();

                    {
                        pc.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Login não encontrado, verifique login e senha", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }

        private void btnEmtrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();//instanciando a classe controle
            controle.acessar(txbLogin.Text, txbSenha.Text);

            if (controle.mensagem.Equals(""))
            {


                if (controle.tem)
                {
                    MessageBox.Show("Logado com Sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Cliente c = new Cliente();
                    
                    {
                        c.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Login não encontrado, verifique login e senha", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }else
            {
                MessageBox.Show(controle.mensagem);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Cliente cs = new Cliente();
            cs.Show();
        }
    }
}