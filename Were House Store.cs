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
    public partial class Were_House_Store : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-6FAC73U\SQLEXPRESS;Initial Catalog=Sasidu_Stock;Integrated Security=True");//database connection
        public Were_House_Store()
        {
            InitializeComponent();
            lodetabel();
        }
        private void lodetabel()
        {
            try
            {

                con.Open();


                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Store_Items";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridViewProduct.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Insert f2 = new Insert();
            f2.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Were_House_Store_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewProduct.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridViewProduct.CurrentRow.Selected = true;

                txtid.Text = dataGridViewProduct.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtName.Text = dataGridViewProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtItem.Text = dataGridViewProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtquantity.Text = dataGridViewProduct.Rows[e.RowIndex].Cells[3].Value.ToString();


            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lodetabel();
        }
    }
}
