using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using TelaLogin.Modelo_Controle_;
using System.Data;
using System.Data.SqlClient;

namespace TelaLogin.Apresentação_tela_
{
    public partial class CriarFicha : Form
    {
        private string _strConn = @"Data Source=DESKTOP-FRGH8PP\SQLEXPRESS;Initial Catalog=fichafit;Integrated Security=True";

        SqlConnection objConect = null;

        SqlCommand objCommand = null;


        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;

        public CriarFicha()
        {
            InitializeComponent();
        }

        public void listaGrid(string cpf)
        {
            string strSQL = "select * from cpf"+cpf+";";

            objConect = new SqlConnection(_strConn);

            objCommand = new SqlCommand(strSQL, objConect);

            try
            {
                SqlDataAdapter objAdp = new SqlDataAdapter(objCommand);

                DataTable dtLista = new DataTable();

                objAdp.Fill(dtLista);

                dgDados.DataSource = dtLista;

                
            }
            catch
            {
                MessageBox.Show("Erro");
            }
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txbCPF_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();//instanciando a classe controle
            controle.confirmaCPF(txbCPF.Text);

            if (controle.mensagem.Equals(""))
            {


                if (controle.tem)
                {
                    MessageBox.Show("CPF encontrado!", "ok", MessageBoxButtons.OK, MessageBoxIcon.Information);                   
                }
                else
                {
                    MessageBox.Show("CPF não existe", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }else
            {
                MessageBox.Show(controle.mensagem);
            }
        }

        private void CriarFicha_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();//ira enviar para o metodo cadastrar. 
            String mensagem = controle.cadastraFicha(txbCPF.Text, cbEx1.Text, cbEx2.Text, cbEx3.Text, cbEx4.Text, cbEx5.Text, sex1.Value.ToString(), sex2.Value.ToString(), sex3.Value.ToString(), sex4.Value.ToString(), sex5.Value.ToString(), rex1.Value.ToString(), rex2.Value.ToString(), rex3.Value.ToString(), rex4.Value.ToString(), rex5.Value.ToString());
            if (controle.tem)//Se for verdade mensagem de sucesso
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(controle.mensagem);//mensagem de erro
            }

            listaGrid(txbCPF.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
                    
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
