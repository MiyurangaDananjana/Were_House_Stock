using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Were_House_Stock
{
    public partial class Loding : Form
    {
        public Loding()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;
            if(panel2.Width >= 482)
            {
                timer1.Stop();
                Login fm2 = new Login();
                fm2.Show();
                this.Hide();
            }
        }
    }
}
