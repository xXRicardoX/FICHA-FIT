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
    
    public partial class PesquisarUsuario : Form
    {
        public int id;
        public string exercicios;
        public string series;
        public string repeticoes;

        private SqlCommand _cmd;
        private SqlConnection _con;

        private string _strConn = @"Data Source=DESKTOP-FRGH8PP\SQLEXPRESS;Initial Catalog=fichafit;Integrated Security=True";

        SqlConnection objConect = null;

        SqlCommand objCommand = null;
        
        SqlCommand cmd = new SqlCommand();
        public PesquisarUsuario()
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

       

        /*public void atualizarTabela(int id, string cpf, string exercicio, string serie, string repeticao)
        {

            string strSQL = "select * from cpf" + cpf + ";";

            objConect = new SqlConnection(_strConn);

            objCommand = new SqlCommand(strSQL, objConect);

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText += "UPDATE cpf" + cpf + " SET  exercicios = '" + exercicio+ "', series = '" + serie + "', repeticoes = '" + repeticao + "' WHERE id = " + id + ";";


            }
            catch
            {
                MessageBox.Show("Erro");
            }
        }*/
        public void atualizarTabela()
        {

          


            try
            {
                string strSQL = "select * from cpf123456789101;";

                objConect = new SqlConnection(_strConn);

                objCommand = new SqlCommand(strSQL, objConect);

                StringBuilder sb = new StringBuilder();
                sb.Append("UPDATE cpf123456789101 SET  exercicios = 'exercicio 1', series = ' 99 ', repeticoes = ' 999' WHERE id = 100;");

                //cmd.CommandText = "UPDATE cpf123456789101 SET  exercicios = 'exercicio 1', series = ' 99 ', repeticoes = ' 999' WHERE id = 100;";


            }
            catch
            {
                MessageBox.Show("Erro");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txbCPF.Text.Contains(".") || txbCPF.Text.Contains("-"))
            {
                MessageBox.Show("Por favor, inserir CPF apenas com números.");
            }
            else 
            {
                

                listaGrid(txbCPF.Text);
            }

            
         }

        private void PesquisarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dgDados.CurrentRow.Cells[0].Value.ToString());
            exercicios = (dgDados.CurrentRow.Cells[1].Value.ToString());
            series = (dgDados.CurrentRow.Cells[2].Value.ToString());
            repeticoes = (dgDados.CurrentRow.Cells[3].Value.ToString());

           
            txbExercicio.Text = exercicios;
            txbSeries.Text = series;
            txbRepeticoes.Text = repeticoes;
            
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                _con = new SqlConnection(@"Data Source=DESKTOP-FRGH8PP\SQLEXPRESS;Initial Catalog=fichafit;Integrated Security=True");
                _con.Open();
                _cmd = new SqlCommand("UPDATE cpf" + txbCPF.Text + " SET  exercicios = @exercicio, series = @serie, repeticoes = @repeticao WHERE id = @id", _con);
                //_cmd.Parameters.AddWithValue("@cpf", txbCPF.Text);
                _cmd.Parameters.AddWithValue("@exercicio", txbExercicio.Text);
                _cmd.Parameters.AddWithValue("@serie", txbSeries.Text);
                _cmd.Parameters.AddWithValue("@repeticao", txbRepeticoes.Text);
                _cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txbId.Text));
                _cmd.ExecuteNonQuery();

                listaGrid(txbCPF.Text);
            }
            catch
            {
                MessageBox.Show("Erro");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dgDados.CurrentRow.Cells[0].Value.ToString());
            exercicios = (dgDados.CurrentRow.Cells[1].Value.ToString());
            series = (dgDados.CurrentRow.Cells[2].Value.ToString());
            repeticoes = (dgDados.CurrentRow.Cells[3].Value.ToString());

            txbId.Text = "" + id;
            txbExercicio.Text = exercicios;
            txbSeries.Text = series;
            txbRepeticoes.Text = repeticoes;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dgDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
