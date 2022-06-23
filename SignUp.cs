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

namespace Construction
{
    public partial class SignUp : Form
    {
        string path = "Data Source=" + Environment.MachineName.ToString() + "\\SQLEXPRESS;Initial Catalog=construction;Integrated Security=True;";
        SqlConnection con;
        DataTable dt;
        SqlDataAdapter adpt;
        SqlCommand cmd;
        int ID;
        public SignUp()
        {
            InitializeComponent();
            con = new SqlConnection(path);
            Location = new Point(0, 0);
            display();
            btnRemove.Enabled = false;
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtpass.Text == "") { labelpass.Visible = true; }
                else { labelpass.Visible = false; }
                if (txtuser.Text == "") { labeluser.Visible = true; }
                else { labeluser.Visible = false; }
                if (txtpass.Text == "" || txtuser.Text == "") { return; }

                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Users values(@Name,@Password", con);
                cmd.Parameters.AddWithValue("@Name", txtuser.Text);
                cmd.Parameters.AddWithValue("@Password", txtpass.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("User Has Been Added", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Something Went Wrong"); }
        }
        void display() 
        {
            try
            {
                dt = new DataTable();
                con.Open();
                adpt = new SqlDataAdapter("Select * from users", con);
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Something Went Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(dataGridView1.RowCount == 1) 
            {
                MessageBox.Show("Cannot remove all users!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            con.Open();
            cmd = new SqlCommand("Delete from Users where AcountID='" + ID + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("User Has Been Deleted", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            display();
            btnRemove.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtuser.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtpass.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            btnRemove.Enabled = true;
        }

        private void txtpass_TrailingIconClick(object sender, EventArgs e)
        {
            if (txtpass.Password)
            {
                txtpass.Password = false;
                return;
            }
            if (!txtpass.Password)
            {
                txtpass.Password = true;
            }
        }
    }
}
