using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelaLogin.Modelo_Controle_;

namespace TelaLogin.Apresentação_tela_
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtCPF.Text.Contains(".") || txtCPF.Text.Contains("-"))
            {
                MessageBox.Show("Apenas números no CPF", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);            
            }
            else
            {


                Controle controle = new Controle();//ira enviar para o metodo cadastrar. 
                String mensagem = controle.cadastra(txtNome.Text, txtCPF.Text, txtTelefone.Text, txtEmail.Text, txtSenha.Text, txtSenhaC.Text);
                if (controle.tem)//Se for verdade mensagem de sucesso
                {
                    MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(controle.mensagem);//mensagem de erro
                }
            }

            //...............Acrescentar............................
            //senhas tem que conter caracteres e numeros(regras)(quantidade de numero)
            //antes de cadastrar ver se ja existe email com este nome
            //verificar se realmente e um e-mail verificar se tem @ e .com e.com.br
            //......................................................
        }
    }
}
