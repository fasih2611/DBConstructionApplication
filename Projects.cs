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
    public partial class Projects : Form
    {
        string path = "Data Source=" + Environment.MachineName.ToString() + "\\SQLEXPRESS;Initial Catalog=construction;Integrated Security=True;";
        SqlConnection con;
        SqlDataAdapter adpt;
        DataTable dt;
        SqlCommand cmd;
        Regex regex;
        int ID;
        public Projects()
        {
            InitializeComponent();
            Location = new Point(0, 0);
            con = new SqlConnection(path);
            display();
            btnComplete.Enabled = btnCancel.Enabled = btnHold.Enabled = false;
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataTable dt= new DataTable();
                ID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                con.Open();
                adpt = new SqlDataAdapter("select TotalEmployees=count(ProjectWork.EmployeeID)from ProjectWork where ProjectID = " + ID, con);
                adpt.Fill(dt);
                con.Close();
                DataRow dr = dt.Rows[0];
                lab_w.Text = "Total Employees working on project: \n" + dr["TotalEmployees"].ToString();
                dr.Delete();
                con.Open();
                adpt = new SqlDataAdapter("select TotalOrders=count(orderid) from orders where projectid="+ID,con);
                dt = new DataTable();
                adpt.Fill(dt);
                con.Close();
                dr = dt.Rows[0];
                labDetails.Visible = true;
                lab_c.Text = "Total Orders Made for project: \n" + dr["TotalOrders"].ToString();
                lab_c.Visible = lab_w.Visible = true;
                
                btnComplete.Enabled = btnCancel.Enabled = btnHold.Enabled = true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Something Went Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        void display() 
        {
            try
            {
                dt = new DataTable();
                con.Open();
                adpt = new SqlDataAdapter("Select * from Projects", con);
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Something Went Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        void clear() 
        {
            txtcity.Text = txtProject_name.Text = txtprice.Text = txtstate.Text = txtst_no.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtProject_name.Text == "" || txtcity.Text == "" || txtstate.Text == "" || txtst_no.Text == "" || txtprice.Text == "") 
            {
                MessageBox.Show("Please Fill out all fields", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            con.Open();
            cmd = new SqlCommand("insert into projects values('" + txtProject_name.Text + "','" + txtcity.Text + "','" + txtstate.Text + "','" + txtst_no.Text + "','" + txtprice.Text + "',0,'In Progress')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data has been added!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clear();
            display();
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("update Projects set ProjectStatus='" + "Completed" + "' where ProjectID = " + ID, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Project Has Been Marked as Completed", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                display();
                btnComplete.Enabled = btnCancel.Enabled = btnHold.Enabled = false;

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Something Went Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnHold_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("update Projects set ProjectStatus='" + "On Hold" + "' where ProjectID = " + ID, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Project Has Been Marked as On Hold", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                display();
                btnComplete.Enabled = btnCancel.Enabled = btnHold.Enabled = false;

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Something Went Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("update Projects set ProjectStatus='" + "Cancelled" + "' where ProjectID = " + ID, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Project Has Been Marked as Cancelled", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                display();
                btnComplete.Enabled = btnCancel.Enabled = btnHold.Enabled = false;

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Something Went Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void NumbersOnly(object sender, KeyPressEventArgs e)
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

        private void AlphabetsOnly(object sender, KeyPressEventArgs e)
        {
            try
            {
                regex = new Regex("^[A-Za-z]+$");
                if (regex.IsMatch(e.KeyChar.ToString()))
                {
                    e.Handled = false;
                }
                else { e.Handled = true; }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error Has Occured", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }

        private void AlphanumericOnly(object sender, KeyPressEventArgs e)
        {
            try
            {
                regex = new Regex("^[A-Za-z0-9]+$");
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
