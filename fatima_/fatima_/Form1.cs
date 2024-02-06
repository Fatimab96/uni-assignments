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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int no, r;
            no = Convert.ToInt32(txtnum.Text);

            r = no % 2;
            if (r == 0)
            {
                MessageBox.Show(no+ " is even");
            }
            else
            {
                MessageBox.Show(no+ " is odd");
            }
        }
    }
}
