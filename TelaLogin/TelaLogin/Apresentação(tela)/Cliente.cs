using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace TelaLogin.Apresentação_tela_
{
    
    public partial class Cliente : Form
    {
        private string _strConn = @"Data Source=DESKTOP-FRGH8PP\SQLEXPRESS;Initial Catalog=fichafit;Integrated Security=True";

        SqlConnection objConect = null;

        SqlCommand objCommand = null;

        public Cliente()
        {
            InitializeComponent();
        }

  

        public void listaGrid(string cpf)
        {
            string strSQL = "select * from cpf" + cpf + ";";

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
       
        

       

        private void button1_Click(object sender, EventArgs e)
        {
            listaGrid(txbCPF.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
