using GreenBank.Control;
using GreenBank.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenBank
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.acessarAPP(txtLogin.Text, txtSenha.Text);

            if (controle.msg.Equals(""))
            {
                if (controle.tem)
                {
                    MessageBox.Show("Logado com Sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Home home = new Home();

                    home.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Login Não Encontrado", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show(controle.msg);
            }


        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            Cadastro cad = new Cadastro();
            
            this.Hide();
            cad.Show();
        }
    }
}
