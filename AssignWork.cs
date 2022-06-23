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
    public partial class AssignWork : Form
    {
        string path = "Data Source=" + Environment.MachineName.ToString() + "\\SQLEXPRESS;Initial Catalog=construction;Integrated Security=True;";
        SqlConnection con;
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter adpt;
        int EmployeeID,ProjectID;
        public AssignWork()
        {
            InitializeComponent();
            Location = new Point(0, 0);
            con = new SqlConnection(path);
            display();
        }

        void display() 
        {
            dt = new DataTable();
            con.Open();
            adpt = new SqlDataAdapter("Select EmployeeID,FirstName,LastName from Employees",con);
            adpt.Fill(dt);
            con.Close();
            dataGridView1.DataSource = dt;

            dt = new DataTable();
            con.Open();
            adpt = new SqlDataAdapter("select ProjectID,ProjectName,Assigned = case when ProjectID not in (select ProjectID from ProjectWork where EmployeeID=" + EmployeeID + ") then 'False' else 'True' end from Projects ", con);
            adpt.Fill(dt);
            con.Close();
            dataGridView2.DataSource = dt;

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                EmployeeID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                dt = new DataTable();
                con.Open();
                adpt = new SqlDataAdapter("select ProjectID,ProjectName,Assigned = case when ProjectID not in (select ProjectID from ProjectWork where EmployeeID="+EmployeeID+") then 'False' else 'True' end from Projects ", con);
                adpt.Fill(dt);
                con.Close();
                dataGridView2.Enabled = txtSearchProject.Enabled = true;
                dataGridView2.DataSource = dt;
            }
            catch(Exception ex) { MessageBox.Show(ex.Message, "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void dataGridView2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ProjectID = int.Parse(dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString()); 
            btnAssign.Enabled = btnDismiss.Enabled = true;
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            con.Open();
            adpt = new SqlDataAdapter("Select projectID,EmployeeID from projectwork where projectID="+ProjectID+" and EmployeeID="+EmployeeID, con);
            adpt.Fill(dt);
            con.Close();
            if (dt.Rows.Count==0)
            {

                con.Open();
                cmd = new SqlCommand("Insert into projectwork values(" + ProjectID + "," + EmployeeID + ")", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Employee Has Been Assigned Work", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                display();
                dataGridView2.Enabled = btnAssign.Enabled = btnDismiss.Enabled = false;
            }
            else 
            {
                MessageBox.Show("Employee is already assigned to this project!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDismiss_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            con.Open();
            adpt = new SqlDataAdapter("select ProjectID,ProjectName,Assigned = case when ProjectID not in (select ProjectID from ProjectWork where EmployeeID=" + EmployeeID + ") then 'False' else 'True' end from Projects ", con);
            adpt.Fill(dt);
            con.Close();
            DataRow dr = dt.Rows[0];
            if (dr["Assigned"].ToString() == "True")
            {

                con.Open();
                cmd = new SqlCommand("delete from projectwork where projectID=" + ProjectID + "and EmployeeID=" + EmployeeID, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Employee Has Been Dismissed", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                display();
                dataGridView2.Enabled = btnAssign.Enabled = btnDismiss.Enabled = false;
            }
            else
            {
                MessageBox.Show("Employee is already NOT assigned to this project!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearchProject_TextChanged(object sender, EventArgs e)
        {
            dt = new DataTable();
            con.Open();
            adpt = new SqlDataAdapter("select ProjectID, ProjectName, Assigned = case when ProjectID not in (select ProjectID from ProjectWork where EmployeeID = " + EmployeeID + ") then 'False' else 'True' end from Projects where ProjectName like '%" + txtSearchProject.Text + "%'", con);
            adpt.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            dt = new DataTable();
            con.Open();
            adpt = new SqlDataAdapter("Select EmployeeID,FirstName,LastName from Employees where FirstName like '%" + txtSearchName.Text + "%' or LastName like '%"+txtSearchName.Text+"%'", con);
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
