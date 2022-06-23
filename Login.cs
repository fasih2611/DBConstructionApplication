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
    public partial class Login : Form
    {
        string path = "Data Source="+ Environment.MachineName.ToString() +"\\SQLEXPRESS;Initial Catalog=construction;Integrated Security=True;";
        SqlConnection con;
        SqlDataAdapter adpt;
        public Login()
        {
            InitializeComponent();
            con = new SqlConnection(path);
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtpass.Text == "") { labelpass.Visible = true; }
                else { labelpass.Visible = false; }
                if (txtuser.Text == "") { labeluser.Visible = true;  }
                else { labeluser.Visible = false; }
                if (txtpass.Text == "" || txtuser.Text == "") { return; }
                
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from Users where Username=@Name and Password=@Password",con);
                cmd.Parameters.AddWithValue("@Name", txtuser.Text);
                cmd.Parameters.AddWithValue("@Password", txtpass.Text);
                cmd.ExecuteNonQuery();
                adpt = new SqlDataAdapter(cmd);
                
                DataSet ds = new DataSet();
                adpt.Fill(ds);
                con.Close();

                int count = ds.Tables[0].Rows.Count;
                if (count == 1)
                {
                    MessageBox.Show("You've logged in successfully", "Logged In",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Hide();
                    Form main = new Main();
                    main.Show();

                }
                else {
                    MessageBox.Show("Retry Entering your password", "Invalid Login",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Something Went Wrong"); }
        }
    }
}
