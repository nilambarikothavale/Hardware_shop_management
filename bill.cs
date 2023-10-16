using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
namespace HardwareShop
{
    public partial class bill : Form
    {
        public static bill instance;
        public bill()
        {
            InitializeComponent();
            instance = this;
        }
        OleDbConnection cn=new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\\Nilambari\\c#\\HardwareShop.accdb");
       public void bill_Load(object sender, EventArgs e)
        {
            OleDbCommand cmd=new OleDbCommand("select * from stock",cn);
            OleDbDataAdapter da=new OleDbDataAdapter(cmd);
            DataSet ds=new DataSet();
            da.Fill(ds,"tab1");
            
        }
        private void clear()
        {
            txtname.Clear();
            txtcompany.Clear();
            txtrate.Clear();
            txtquantity.Clear();
            txtsize.Clear();
            txttotal.Clear();
        }
        public void btnbill_Click(object sender, EventArgs e)
        {
            billprint form = new billprint();
            form.Show();
            this.Hide();
        }

        public void btnsubmit_Click(object sender, EventArgs e)
        {
          
            
        }

        
    }
}
