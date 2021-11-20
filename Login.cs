using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Were_House_Stock
{
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-6FAC73U\SQLEXPRESS;Initial Catalog=Sasidu_Stock;Integrated Security=True");//database connection
        public Login()
        {
            InitializeComponent();
            this.ActiveControl = txtusername;
            txtusername.Focus();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM User_Name WHERE username='" + txtusername.Text + "' AND password='" + txtpassword.Text + "'", con);
            /* in above line the program is selecting the whole data from table and the matching it with the user name and password provided by user. */
            DataTable dt = new DataTable(); //this is creating a virtual table  
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {

                this.Hide();
                new Were_House_Store().Show();
                txtusername.Text = "";
                txtpassword.Text = "";



            }

            else
            {
                MessageBox.Show("Invalid username or password");
                txtusername.Text = "";
                txtpassword.Text = "";
            }
        }

        private void txtusername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtpassword.Focus();
            }
        }

        private void txtpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnlogin.PerformClick();
            }
        }
    }
}
