using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelaLogin.DAL_Classe_de_Conexão_
{
    public class Conexao
    {
        //Iremos acrescentar 3 métodos nessa classe

        //Classe para se conectar com o banco de dados que ja tem no VS Sql
        SqlConnection con = new SqlConnection();

        //Metodo Construtor        
        public Conexao()
        {
           con.ConnectionString = @"Data Source=DESKTOP-FRGH8PP\SQLEXPRESS;Initial Catalog=fichafit;Integrated Security=True";//Acrescentar o banco de dados aqui.(Quando Criado)
        }

        public SqlConnection Conectar() //Ele retorna o Sql Connection
        {
            //verificar se ja esta conectado para evitar conectar 2x
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public void desconectar()//Não retorna nada
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }

    }
}
