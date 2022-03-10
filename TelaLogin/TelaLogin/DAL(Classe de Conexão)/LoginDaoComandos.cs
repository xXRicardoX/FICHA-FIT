using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelaLogin.DAL_Classe_de_Conexão_
{
    class LoginDaoComandos
    {
        //Classe controle só serve para controlar  com outros formularios
        //Criar 2 metodos de controle
       
        public bool tem = false;
        public String mensagem = "";//tudo ok
        SqlCommand cmd = new SqlCommand(); //intanciada
        Conexao con = new Conexao();
        SqlDataReader dr;

        public bool verificarLogin(String login, String senha)//verificar se tem o dados no banco de dados
        {
            //comandos sql verificar se tem no Banco
            cmd.CommandText = "select * from logins where email = @login and senha = @senha";//ComandoText e onde vai escrever o comando que seria no banco de dados
            //parametros para comparar
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = con.Conectar(); //realmente onde irar execurtar e o dr
                dr = cmd.ExecuteReader(); //todas informaçoes foi salva no dr que foi lido e escrito
                if (dr.HasRows)//se for verdadeiro irar receber true
                {
                    tem = true;
                }
                con.desconectar();//desconectar
                dr.Close();//fechando o hider
            }
            catch
            {

                this.mensagem = "Erro com Banco de Dados";
            }
            return tem;
        }

        public bool verificarLogin2(String login, String senha)//verificar se tem o dados no banco de dados
        {
            //comandos sql verificar se tem no Banco
            cmd.CommandText = "select * from funcionarios where email = @login and senha = @senha";//ComandoText e onde vai escrever o comando que seria no banco de dados
            //parametros para comparar
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = con.Conectar(); //realmente onde irar execurtar e o dr
                dr = cmd.ExecuteReader(); //todas informaçoes foi salva no dr que foi lido e escrito
                if (dr.HasRows)//se for verdadeiro irar receber true
                {
                    tem = true;
                }
                con.desconectar();//desconectar
                dr.Close();//fechando o hider
            }
            catch
            {

                this.mensagem = "Erro com Banco de Dados";
            }
            return tem;
        }
        public String cadastrar(String nome, String cpf, String telefone, String email, String senha, String confSenha)
        {
            tem = false;
            //comando para inserir
            if (nome.Equals("") || cpf.Equals("") || email.Equals("") || senha.Equals("") || confSenha.Equals(""))
            {
                this.mensagem = "Campo não preenchido";

            }
            else
            {
                if (senha.Equals(confSenha))
                {
                    cmd.CommandText = "insert into logins (nome, cpf, telefone, email, senha)values(@n,@c,@t,@e,@s);";//n = nome. c = cpf. t = telefone. e = email. E s = senha
                    cmd.Parameters.AddWithValue("@n", nome);
                    cmd.Parameters.AddWithValue("@c", cpf);
                    cmd.Parameters.AddWithValue("@t", telefone);
                    cmd.Parameters.AddWithValue("@e", email);
                    cmd.Parameters.AddWithValue("@s", senha);

                    try//se passar pelas 3 cmd do try quer dizer que passou com sucesso
                    {
                        cmd.Connection = con.Conectar();
                        cmd.ExecuteNonQuery();
                        con.desconectar();
                        this.mensagem = "Cadastrado com Sucesso";
                        tem = true;//caso não passe por aqui, continua sendo falso(Confirmando o cadastro)
                    }
                    catch (SqlException)
                    {
                        this.mensagem = "Erro com banco de dados";
                    }
                }
                else
                {
                    this.mensagem = "Senha não correspondem";
                }
            }
            return mensagem;
        }

        public bool confirmarCPF(String cpf)//verificar se tem o dados no banco de dados
        {     
            //comandos sql verificar se tem no Banco
            cmd.CommandText = "select * from logins where cpf = @cpf";
            //parametros para comparar
            cmd.Parameters.AddWithValue("@cpf", cpf);
 
            //cmd.CommandText = "use fichafit create table cpf"+cpf+ "(exercicios varchar(50) not null, series varchar(30) not null, repeticoes varchar(30) not null)";
            
           

            try
            {
                cmd.Connection = con.Conectar(); //realmente onde irar execurtar e o dr
                dr = cmd.ExecuteReader(); //todas informaçoes foi salva no dr que foi lido e escrito
                if (dr.HasRows)//se for verdadeiro irar receber true
                {
                    tem = true;
                }
                con.desconectar();//desconectar
                dr.Close();//fechando o hider
            }
            catch
            {

                this.mensagem = "Erro com Banco de Dados";
            }
            return tem;
        }

        public String cadastrarFicha(String cpf, String ex1, String ex2, String ex3, String ex4, String ex5, String sex1, String sex2, String sex3, String sex4, String sex5, String rex1, String rex2, String rex3, String rex4, String rex5)
        {
            tem = false;
            //comando para inserir
            if (cpf.Equals("") || ex1.Equals("") || ex2.Equals("") || ex3.Equals("") || ex4.Equals(""))
            {
                this.mensagem = "Campo não preenchido";

            }
            else
            {
                    cmd.CommandText += "use fichafit create table cpf"+cpf+ "(id smallint primary key identity (100,1), exercicios varchar(50) not null, series varchar(30) not null, repeticoes varchar(30) not null);";


                    cmd.CommandText += "insert into cpf" + cpf + " values('" + ex1 + "', " + sex1 + ", " + rex1 + ");";
                    cmd.CommandText += "insert into cpf" + cpf + "(exercicios, series, repeticoes) values('" + ex2 + "', " + sex2 + ", " + rex2 + ");";
                    cmd.CommandText += "insert into cpf" + cpf + "(exercicios, series, repeticoes) values('" + ex3 + "', " + sex3 + ", " + rex3 + ");";
                    cmd.CommandText += "insert into cpf" + cpf + "(exercicios, series, repeticoes) values('" + ex4 + "', " + sex4 + ", " + rex4 + ");";
                    cmd.CommandText += "insert into cpf" + cpf + "(exercicios, series, repeticoes) values('" + ex5 + "', " + sex5 + ", " + rex5 + ");";
              

                try//se passar pelas 3 cmd do try quer dizer que passou com sucesso
                    {
                        cmd.Connection = con.Conectar();
                        cmd.ExecuteNonQuery();
                        con.desconectar();
                        this.mensagem = "Ficha cadastrada com Sucesso";
                        tem = true;//caso não passe por aqui, continua sendo falso(Confirmando o cadastro)
                    }
                    catch (SqlException)
                    {
                        this.mensagem = "Erro com banco de dados";
                    }
                
            }
            return mensagem;
        }

       
    }   
}
