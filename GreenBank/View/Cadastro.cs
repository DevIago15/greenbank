using GreenBank.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenBank.View
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtConfirmSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
           
            string msg = controle.cadastrarAPP(txtLogin.Text, txtSenha.Text, txtConfirmSenha.Text);
           
            if (controle.tem)
            {
                MessageBox.Show(msg, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(controle.msg);
            }

            
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btVoltar_Click_1(object sender, EventArgs e)
        {
            LoginPage formLogin = new LoginPage();

            this.Close();
            formLogin.Show();
            


        }
    }
}
