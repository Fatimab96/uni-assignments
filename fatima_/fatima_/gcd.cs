using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fatima_
{
    public partial class gcd : Form
    {
        public gcd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int n1, n2, i, gcd;
                n1 = Convert.ToInt32(textBox1.Text);
                n2 = Convert.ToInt32(textBox2.Text);
                i = 1; gcd = 1;
                while (i <= n1 && i <= n2)
                {
                    if (n1 % i == 0 && n2 % i == 0)
                        gcd = i;
                    i++;

                    MessageBox.Show("gcd of " +
                        n1.ToString() + " and " + n2.ToString() + " is " + gcd.ToString());
                }
            }//try close
            catch(FormatException)
            {
                MessageBox.Show("please enter the correct format", "invalid entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }//Catch Close
        }
    }
}//name space close
