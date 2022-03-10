using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelaLogin.DAL_Classe_de_Conexão_;

namespace TelaLogin.Modelo_Controle_
{
    public class Controle
    {
        //criando metodo para 1 para acessar e 1 para cadastrar
        public bool tem;
        public String mensagem = "";// public string porque ira retornar caso houver algum erro

        public bool acessar(string login, String senha)
        {//classe Instaciada login
            LoginDaoComandos loginDao = new LoginDaoComandos();
            //Metodo verificar login que pega as 2 informaçoes do formulario que foi digitado
            //Verificar se o login foi encontrado e vai retornar na variavel tem
            tem = loginDao.verificarLogin(login, senha);
            /*Verificação se a mensagem foi preenchida com uma string de erro. Caso ao Contrario
             * Ela continuara vazia e assim saberemos como lidar com os erros do programa
            */
            if(!loginDao.mensagem.Equals(""))
            {
                this.mensagem = loginDao.mensagem;
            }
            return tem;
        }

        public bool acessar2(string login, String senha)
        {//classe Instaciada login
            LoginDaoComandos loginDao = new LoginDaoComandos();
            //Metodo verificar login que pega as 2 informaçoes do formulario que foi digitado
            //Verificar se o login foi encontrado e vai retornar na variavel tem
            tem = loginDao.verificarLogin2(login, senha);
            /*Verificação se a mensagem foi preenchida com uma string de erro. Caso ao Contrario
             * Ela continuara vazia e assim saberemos como lidar com os erros do programa
            */
            if (!loginDao.mensagem.Equals(""))
            {
                this.mensagem = loginDao.mensagem;
            }
            return tem;
        }

        public bool confirmaCPF(string cpf)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            //Metodo verificar login que pega as 2 informaçoes do formulario que foi digitado
            //Verificar se o login foi encontrado e vai retornar na variavel tem
            tem = loginDao.confirmarCPF(cpf);
            //Verificação se a mensagem foi preenchida com uma string de erro. Caso ao Contrario
            // Ela continuara vazia e assim saberemos como lidar com os erros do programa
            
            if (!loginDao.mensagem.Equals(""))
            {
                this.mensagem = loginDao.mensagem;
            }
            return tem;
        }

        public String cadastra (String nome, String cpf, String telefone, String email, String senha, String confSenha)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            this.mensagem = loginDao.cadastrar(nome, cpf, telefone, email, senha, confSenha);
            if(loginDao.tem)//a mensagem que vai vir e de sucesso
            {
                this.tem = true;//reaproveitando a variavel tem que esta no loginDaoComandos
            }
            return mensagem;
        }

        public String cadastraFicha(String cpf, String ex1, String ex2, String ex3, String ex4, String ex5, String sex1, String sex2, String sex3, String sex4, String sex5, String rex1, String rex2, String rex3, String rex4, String rex5)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            this.mensagem = loginDao.cadastrarFicha(cpf, ex1, ex2, ex3, ex4, ex5, sex1, sex2, sex3, sex4, sex5, rex1, rex2, rex3, rex4, rex5);
            if (loginDao.tem)//a mensagem que vai vir e de sucesso
            {
                this.tem = true;//reaproveitando a variavel tem que esta no loginDaoComandos
            }
            return mensagem;
        }
    }
}
