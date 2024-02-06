using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fatima_.Properties
{
    public partial class LCM : Form
    {
        public LCM()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1, n2, a, b, LCM;
            LCM = 0;
            n1 = Convert.ToInt32(textBox1.Text);
            n2 = Convert.ToInt32(textBox2.Text);
            a = n1;
            b = n2;
            while(n1!=n2)
            {
                if(n1>n2)
                {
                    n1 = n1 - n2;
                }
                else 
                {
                    n2 = n2 - n1;
                }
            }
            LCM = (a * b) / n1;
            MessageBox.Show("LCM Is " + LCM);
        }
    }
}
