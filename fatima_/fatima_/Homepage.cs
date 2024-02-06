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
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void gcdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gcd g = new gcd();
                g.Show();
        }
    }
}
