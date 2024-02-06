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
    public partial class Fibo : Form
    {
        public Fibo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

      
               int i, n, n1=0,n2=1,n3;
                n = Convert.ToInt32(txtnum.Text);
               
                listBox1.Items.Clear();
                listBox1.Items.Add(n1);
                listBox1.Items.Add(n2);
                for ( i=0; i<=n; i++)
                {
                    n3 = n1 + n2;
                    listBox1.Items.Add(n3);
                    n1 = n2;
                    n2 = n3;
                    
                }//for

        }//funtion of button
    }//form
}//namespace
