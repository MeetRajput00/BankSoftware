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
    public partial class Dashboard : Form
    {
        Account obj3;
        public Dashboard()
        {
            InitializeComponent();
        }
        public void passObj(Account obj1)
        {
            obj3 = obj1;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked==true)
            {
                CreateAccount f2 = new CreateAccount();
                f2.Show();
            }
            else if (radioButton2.Checked==true)
            {
                Form3 f3 = new Form3();
                f3.Show();
            }
            else if (radioButton3.Checked==true)
            {
                Form4 f4 = new Form4();
                f4.Show();
            }
            else if (radioButton4.Checked==true)
            {
                ShowAccounts f5 = new ShowAccounts();
                f5.Show();
            }
        }
    }
}
