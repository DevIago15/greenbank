using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenBank.Model.DAO
{
    class loginDAO
    {

        public bool tem = false;
        public String msg = ""; // se estiver vazia esta ok

        ConexaoDAO con = new ConexaoDAO();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;

        public bool verificarLogin(String login, String senha)
        {
            cmd.CommandText = "select * from logins where cpf = @login and senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows) // caso encontre
                {
                    tem = true;
                }

                con.Desconectar();
                dr.Close();
            }
            catch (SqlException)
            {
                this.msg = "Erro no Banco de Dados!";
            }

            return tem;
        }

        public String cadastrarPessoa(String cpf, String senha, String confSenha)
        {
            tem = false;

            if (senha.Equals(confSenha)) // verificando se senha = confsenha
            {
                cmd.CommandText = "insert into logins values (@cpf, @senha);";
                cmd.Parameters.AddWithValue("@cpf", cpf);
                cmd.Parameters.AddWithValue("@senha", senha);

                try
                {
                    cmd.Connection = con.Conectar();
                    cmd.ExecuteNonQuery();
                    con.Desconectar();
                    this.msg = "Cadastrado com Sucesso!";
                    tem = true;
                }
                catch (SqlException)
                {
                    this.msg = "Erro com Banco de Dados";
                }
            }
            else
            {
                this.msg = "Senhas Não Correspondem!";
            }
                    
            return msg;
        }

    }
}
