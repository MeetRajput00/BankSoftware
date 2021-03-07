using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSoftware
{
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Equals("")|| textBox2.Text.Equals("") || textBox3.Text.Equals("") || textBox4.Text.Equals(""))
            {
                label5.Text = "Please fill all the details!";
            }
            else
            {
                double accn = new Random().NextDouble()*1000000000000;
                long dj = Convert.ToInt64(accn);
                label7.Text = Convert.ToString(dj);
                Account account = new Account(textBox1.Text, Convert.ToInt32(textBox2.Text), textBox3.Text, Convert.ToInt64(textBox4.Text), dj);
                AccountDB.BackAccounts.Add(account);
            }
        }
    }
}
