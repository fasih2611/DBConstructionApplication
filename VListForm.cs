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
    public partial class VListForm : Form
    {
        string path = "Data Source=" + Environment.MachineName.ToString() + "\\SQLEXPRESS;Initial Catalog=construction;Integrated Security=True;";
        SqlConnection con;
        SqlDataAdapter adpt;
        DataTable dt;
        SqlCommand cmd;
        Regex regex;
        int ID;
        public VListForm()
        {
            con = new SqlConnection(path);
            InitializeComponent();
            Location = new Point(0, 0);
            display();
            btnDelete.Enabled = btnUpdate.Enabled = false;
            
        }
        void display() 
        {
            try
            {
                dt = new DataTable();
                con.Open();
                adpt = new SqlDataAdapter("Select * from Vendors", con);
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Something Went Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string query = " Where ";
                if (rbtnCompany.Checked == true) { query = query + ("CompanyName like '%" + txtSearch.Text + "%'"); }
                if (rbtnName.Checked == true) { query = query + ("Name like '%" + txtSearch.Text + "%'"); }
                if (rbtnContact.Checked == true) { query = query + ("ContactInfo like '%" + txtSearch.Text + "%'"); }
                if (query == " Where ") { query = ""; }
                dt = new DataTable();
                con.Open();
                adpt = new SqlDataAdapter("Select * from Vendors"+query, con);
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Something Went Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtVName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtVCompany.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtVContact.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                btnDelete.Enabled = btnUpdate.Enabled = true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Something Went Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtVCompany.Text == "" || txtVContact.Text == "" || txtVName.Text == "") 
            {
                MessageBox.Show("Please Fill out all fields!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            con.Open();
            cmd = new SqlCommand("insert into Vendors values('"+txtVName.Text+"','"+txtVCompany.Text+"','"+txtVContact.Text+"')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data has been added!","Success!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            clear();
            display();
        }
        void clear() 
        {
            txtVName.Text = txtVCompany.Text = txtVContact.Text = "";

        }

        private void VlistPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("update Vendors set Name='" + txtVName.Text + "',CompanyName='" + txtVCompany.Text + "',ContactInfo='" + txtVContact.Text + "' where VendorID = " + ID, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Your Data Has Been Updated!");
                display();
                btnDelete.Enabled = btnUpdate.Enabled = false;
                clear();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Something Went Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("Delete from Vendors where VendorID='" + ID + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Entry Has Been Deleted","Success!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                display();
                clear();
                btnDelete.Enabled = btnUpdate.Enabled = false;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Something Went Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void AlphabetsOnly(object sender, KeyPressEventArgs e)
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
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void txtVContact_KeyPress(object sender, KeyPressEventArgs e)
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
            catch (Exception ex) { MessageBox.Show(ex.Message,"Error Has Occured",MessageBoxButtons.OK,MessageBoxIcon.Exclamation); }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                regex = new Regex("^[a-zA-Z0-9]+$");
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
