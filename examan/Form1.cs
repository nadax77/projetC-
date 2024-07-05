using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examan
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void bt_connect_Click(object sender, EventArgs e)
        {
            string Login, Pwd;
            Login = Txt_login.Text;
            Pwd = Txt_pwd.Text;
            if (!string.IsNullOrEmpty(Login) && !string.IsNullOrEmpty(Pwd))
            {
                Class1 login = new Class1();
                if (login.Authentification(Login, Pwd))
                {
                    Form2 MenuP = new Form2();
                    MenuP.Show();
                }
                else
                {
                    MessageBox.Show("Verifier votre login et mot de passe !", "Authentification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Tapez votre login et mot de passe!", "Authentification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Txt_pwd_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_login_TextChanged(object sender, EventArgs e)
        {

        }

        private void pwd_Click(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {

        }
    }
        }
