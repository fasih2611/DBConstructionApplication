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
using System.Text.RegularExpressions;

namespace Construction
{
    public partial class Materials : Form
    {
        string path = "Data Source=" + Environment.MachineName.ToString() + "\\SQLEXPRESS;Initial Catalog=construction;Integrated Security=True;";
        SqlConnection con;
        SqlDataAdapter adpt;
        DataTable dt;
        SqlCommand cmd;
        Regex regex;
        int ID;
        public Materials()
        {
            con = new SqlConnection(path);
            InitializeComponent();
            Location = new Point(0, 0);
            display();
            btnDelete.Enabled = btnUpdate.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtPrice.Text == "") 
            {
                MessageBox.Show("Please Fill out all fields!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string iso="None";
            if (checkISO.Checked) { iso = "ISO"; }
            con.Open();
            cmd = new SqlCommand("insert into Materials values('" + txtName.Text + "','" + txtPrice.Text + "','" + iso + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data has been added!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clear();
            display();
        }
        void display() 
        {
            dt = new DataTable();
            con.Open();
            adpt = new SqlDataAdapter("Select * from Materials", con);
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        void clear() 
        {
            txtName.Text = txtPrice.Text = "";
            checkISO.Checked = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string iso = "None";
                if (checkISO.Checked) { iso = "ISO"; }
                cmd = new SqlCommand("update Materials set MaterialName='" + txtName.Text + "',Price='" + txtPrice.Text + "',Quality='" + iso + "' where MaterialID = " + ID, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Your Data Has Been Updated!","Success!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                display();
                clear();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Something Went Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtPrice.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                string iso = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                if (iso == "ISO") { checkISO.Checked = true; }
                btnDelete.Enabled = btnUpdate.Enabled = true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Something Went Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("Delete from Materials where MaterialID='" + ID + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Entry Has Been Deleted", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                display();
                clear();
                btnDelete.Enabled = btnUpdate.Enabled = false;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Something Went Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                regex = new Regex("^[a-zA-Z]+$");
                if (regex.IsMatch(e.KeyChar.ToString()))
                {
                    e.Handled = false;
                }
                else { e.Handled = true; }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error Has Occured", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                regex = new Regex("^[0-9]+$");
                if (regex.IsMatch(e.KeyChar.ToString()))
                {
                    e.Handled = false;
                }
                else { e.Handled = true; }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error Has Occured", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }
    }
}
