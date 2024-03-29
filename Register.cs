﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace Construction
{
    public partial class Register : Form
    {
        string path = "Data Source=" + Environment.MachineName.ToString() + "\\SQLEXPRESS;Initial Catalog=construction;Integrated Security=True;";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;
        int ID;
        Regex regex;
        public Register()
        {
            InitializeComponent();
            con = new SqlConnection(path);
            Location = new Point(0, 0);
            button3.Enabled = false;
            button1.Enabled = false;
            display();
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (txtAddress.Text == "" || txtEmail.Text == "" || txtFName.Text == "" || txtLName.Text == "" || txtID.Text == "" || ComboRole.Text == "" || (!rdbtnMale.Checked && !rdbtnFemale.Checked))
            {
                MessageBox.Show("Please Fill out all fields!","Invalid!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            else
            {
                try
                {
                    string gender;
                    con.Open();
                    if (rdbtnFemale.Checked) { gender = "Female"; }
                    else { gender = "Male"; }
                    cmd = new SqlCommand("insert into Employees values('" + txtFName.Text + "','" + txtLName.Text + "','" + txtID.Text + "','" + gender + "','" + txtEmail.Text + "','" + txtAddress.Text +"','"+(ComboRole.SelectedIndex + 1)+ "')", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Data has been added!","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    clear();
                    display();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Something Went Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void clear()
        {
            txtAddress.Text = txtEmail.Text = txtFName.Text = txtID.Text = txtLName.Text = "";
            rdbtnMale.Checked = rdbtnFemale.Checked = false; 
        }
        public void display()
        {
            try
            {
                dt = new DataTable();
                con.Open();
                adpt = new SqlDataAdapter("Select EmployeeID,FirstName,LastName,EmpNum,Gender,Email,Address,RoleName from Employees join Roles on Roles.RoleID = Employees.RoleID", con);
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Something Went Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }


        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                String gender;
                if (txtAddress.Text == "" || txtEmail.Text == "" || txtFName.Text == "" || txtLName.Text == "" || txtID.Text == "" || ComboRole.Text == "" || (!rdbtnMale.Checked && !rdbtnFemale.Checked))
                {
                    MessageBox.Show("Please Fill out all fields!","Invalid",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }
                if (rdbtnMale.Checked) { gender = "Male"; }
                else { gender = "Female"; }
                con.Open();
                cmd = new SqlCommand("update Employees set FirstName='" + txtFName.Text + "',LastName='" + txtLName.Text + "',EmpNum=" + txtID.Text + ",gender='" + gender + "',Address='" + txtAddress.Text + "',RoleID='" + (ComboRole.SelectedIndex + 1) + "'where EmployeeID=" + ID, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Your Data Has Been Updated!","Success!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                display();
                button1.Enabled = button3.Enabled = false;
               

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Something Went Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("Delete from Employees where EmployeeID='" + ID+"'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Entry Has Been Deleted","Success!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                display();
                button1.Enabled = button3.Enabled = true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Something Went Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }


        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
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
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtFName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtLName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtID.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                if (dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString() == "Male") { rdbtnMale.Checked = true; }
                else { rdbtnFemale.Checked = true; }
                txtEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                ComboRole.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                button1.Enabled = button3.Enabled = true;
                
             
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Something Went Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
  
        private void txtFName_KeyPress(object sender, KeyPressEventArgs e)
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

       

        bool IsValidEmail(string eMail)
        {
            bool Result = false;

            try
            {
                var eMailValidator = new System.Net.Mail.MailAddress(eMail);

                Result = (eMail.LastIndexOf(".") > eMail.LastIndexOf("@"));
            }
            catch
            {
                Result = false;
            };

            return Result;
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (IsValidEmail(txtEmail.Text)) 
            {
                labEmail.Visible = false;
                button1.Enabled = button2.Enabled = button3.Enabled = true;
            }
            else 
            {
                labEmail.Visible = true;
                button1.Enabled = button2.Enabled = button3.Enabled = false;
            }
        }
    }
}
