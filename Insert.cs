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
    public partial class Insert : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-6FAC73U\SQLEXPRESS;Initial Catalog=Sasidu_Stock;Integrated Security=True");//database connection
        
        public Insert()
        {
            InitializeComponent();
            clear();
            this.ActiveControl = txtproduct;
            txtproduct.Focus();
        }
        private void clear()
        {
            txtitem.Clear();
            txtproduct.Clear();
            txtquantity.Clear();
            txtPrice.Clear();
            txtSave_Price.Clear();
        }
        private void Save()
        {
            int quantity, Price, Save_Price;
            quantity = int.Parse(txtquantity.Text);
            Price = int.Parse(txtPrice.Text);
            Save_Price = (quantity * Price);
            txtSave_Price.Text = Save_Price.ToString();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtproduct.Text != "" && txtitem.Text != "" && txtquantity.Text !="" )
            {
                Save();
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Store_Items(Item_Name,Item,Quantity,Price) values ('" + txtproduct.Text + "', '" +txtitem.Text + "', '" + txtquantity.Text + "', '" + txtSave_Price.Text + "'   )";
                //insert Data to data base 
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record has been inserted!");
                clear();
                
            }
            else
            {

                MessageBox.Show("Data Not Insert Pleas Fill tha data!", "Message");
            }
        }

        private void txtproduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtitem.Focus();
            }
        }

        private void txtitem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               txtquantity.Focus();
            }
        }

        private void txtquantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
                txtPrice.Focus();

            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtquantity.Clear();
            txtproduct.Clear();
            txtitem.Clear();
        }

        private void txtPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Save();
                btnsave.PerformClick();
            }
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
