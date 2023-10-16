using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HardwareShop
{
    public partial class info : Form
    {
        public static info instance;
        public info()
        {
            InitializeComponent();
            instance = this;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            login form = new login();
            form.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            stock form = new stock();
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bill form = new bill();
            form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            shortage_stock form = new shortage_stock();
            form.Show();
            this.Hide();

        }

        private void info_Load(object sender, EventArgs e)
        {

        }
    }
}
