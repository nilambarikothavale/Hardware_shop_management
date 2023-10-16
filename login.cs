using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HardwareShop
{
    public partial class login : Form
    {
        public static login instance;
        public login()
        {

            InitializeComponent();
            instance = this;
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtuser.Text == "Shop@123" && txtpassword.Text == "password")
            {
                info form = new info();
                form.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Please enter correct username and password");
            }
        }
        private void btnshow_Click(object sender, EventArgs e)
        {
            if (txtpassword.PasswordChar == '*')
            {
                btnshow.Text = "Hide";
                txtpassword.PasswordChar = '\0';
            }
            else
            {
                btnshow.Text = "show";
                txtpassword.PasswordChar = '*';
            }

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
