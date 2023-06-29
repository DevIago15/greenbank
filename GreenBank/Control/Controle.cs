using GreenBank.Model.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenBank.Control
{
    public class Controle
    {
        public bool tem;
        public String msg = "";

        public bool acessarAPP(String login, String senha)
        {
            loginDAO logDAO = new loginDAO();
            tem = logDAO.verificarLogin(login, senha);

            if (!logDAO.msg.Equals(""))
            {
                this.msg = logDAO.msg;
            }


            return tem;
        }

        public String cadastrarAPP(String cpf, String senha, String confSenha)
        {
            loginDAO logDAO = new loginDAO();

            this. msg = logDAO.cadastrarPessoa(cpf, senha, confSenha);

            if (logDAO.tem) // msg de sucesso
            {
                this.tem = true;
            }


            return msg;
        }

    }
}
