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
    public partial class Orders : Form
    {
        string path = "Data Source=" + Environment.MachineName.ToString() + "\\SQLEXPRESS;Initial Catalog=construction;Integrated Security=True;";
        SqlConnection con;
        SqlDataAdapter adpt;
        DataTable dt;
        SqlCommand cmd;
        int ID;
        public Orders()
        {
            InitializeComponent();
            Location = new Point(0, 0);
            con = new SqlConnection(path);
            FillBoxes();
            display();
            btnInvoice.Enabled = btnCancel.Enabled = btndelieverd.Enabled = false;
        }

        void FillBoxes() 
        {
            //Vendors
            DataSet dsVendors = new DataSet();
            con.Open();
            adpt = new SqlDataAdapter("Select VendorID,Name from Vendors", con);
            adpt.Fill(dsVendors);
            con.Close();
            comboVendor.DataSource = dsVendors.Tables[0];
            comboVendor.DisplayMember = "Name";
            comboVendor.ValueMember = "VendorID";

            //Materials
            DataSet dsMaterials = new DataSet();
            con.Open();
            adpt = new SqlDataAdapter("Select MaterialID,MaterialName from Materials", con);
            adpt.Fill(dsMaterials);
            con.Close();
            comboMaterial.DataSource = dsMaterials.Tables[0];
            comboMaterial.DisplayMember = "MaterialName";
            comboMaterial.ValueMember = "MaterialID";
            

            //Projects
            DataSet dsProjects = new DataSet();
            con.Open();
            adpt = new SqlDataAdapter("Select ProjectID,ProjectName from Projects where projects.ProjectStatus != 'Cancelled'", con);
            adpt.Fill(dsProjects);
            con.Close();
            comboProject.DataSource = dsProjects.Tables[0];
            comboProject.DisplayMember = "ProjectName";
            comboProject.ValueMember = "ProjectID";
          
        }

        void display()
        {
            try
            {
                dt = new DataTable();
                con.Open();
                adpt = new SqlDataAdapter("Select * from orderinfo", con);
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Something Went Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtQuantity.Text == "") 
            {
                MessageBox.Show("Please Fill out all fields","Warning!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            con.Open();
            cmd = new SqlCommand("insert into Orders values(GETDATE(),DATEADD(day,7,GETDATE()),"+comboMaterial.SelectedValue+","+comboVendor.SelectedValue+","+comboProject.SelectedValue+","+txtQuantity.Text+",'In Progress')" ,con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Order Has Been Placed", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtQuantity.Text = "";
            display();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            btnInvoice.Enabled =  btndelieverd.Enabled = btnCancel.Enabled = true;
        }

        private void btndelieverd_Click(object sender, EventArgs e)
        { 
            try
            {
                con.Open();
                cmd = new SqlCommand("update Orders set Status='"+"Delievered"+ "' where OrderID = " + ID, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Order Has Been Marked as Completed","Success!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                display();
                btnInvoice.Enabled = btndelieverd.Enabled = btnCancel.Enabled = false;

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Something Went Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("update Orders set Status='" + "Cancelled" + "' where OrderID = " + ID, con);
                cmd.ExecuteNonQuery();
                SqlCommand cmd2 = new SqlCommand("update Projects set CurrentCost=CurrentCost-(select TOP 1 ordercost from orderinfo where OrderID="+ID+ " ) where ProjectID = (select ProjectID from Orders where OrderID=" + ID + ")", con);
                cmd2.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Order Has Been Cancelled", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                display();
                btnInvoice.Enabled= btndelieverd.Enabled = btnCancel.Enabled = false;

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Something Went Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Invoice form = new Invoice();
            adpt = new SqlDataAdapter("Select * from orderinfo where OrderID=" +ID , con);
            adpt.Fill(dt);
            DataRow row = dt.Rows[0];
            form.InName = row["ProjectName"].ToString();
            form.InMaterial = row["MaterialName"].ToString();
            form.InCost = row["Price"].ToString();
            form.InQuality = row["Quality"].ToString();
            form.InQuantity = row["Quantity"].ToString();
            form.InTotalCost = row["OrderCost"].ToString();
            form.InOrderDate = row["OrderDate"].ToString();
            form.InExpectedDate = row["ExpectedDate"].ToString();
            form.ShowDialog();
            btndelieverd.Enabled = btnInvoice.Enabled = btnCancel.Enabled = false;
        }
    }
}
