using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Construction
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Home_Click(object sender, EventArgs e)
        {
            try
            {
                if (panelLeft.Size.Width == 248)
                {
                    panelLeft.Size = new Size(100, 654);
                    Registration.Text = "";
                    Vendors.Text = "";
                    Login.Text = "";
                    Projects.Text = "";
                    btnAssignWork.Text = "";
                    }
                else 
                {
                    panelLeft.Size = new Size(248, 654);
                    Registration.Text = "Employees";
                    Vendors.Text = "Vendors";
                    Login.Text = "Sign Up";
                    Projects.Text = "Projects";
                    btnAssignWork.Text = "Assign Work";
                    
                }
                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Registration_Click(object sender, EventArgs e)
        {
            if (label1.Text !="Registration") {
                panelMain.Controls.Clear();
                Register myForm = new Register();
                myForm.FormBorderStyle = FormBorderStyle.None;
                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                panelMain.Controls.Add(myForm);
                myForm.Show();
                label1.Text = "Registration";
            }
        }

        private void Registration_MouseMove(object sender, MouseEventArgs e)
        {
            Registration.BackColor = Color.White;
            Cursor = System.Windows.Forms.Cursors.Hand;

        }

        private void Registration_MouseLeave(object sender, EventArgs e)
        {
            Registration.BackColor = Color.FromArgb(125, 185, 245);
            Cursor = System.Windows.Forms.Cursors.Default;
        }

        private void Projects_MouseMove(object sender, MouseEventArgs e)
        {
            Projects.BackColor = Color.White;
            Cursor = System.Windows.Forms.Cursors.Hand;
        }
        private void Projects_MouseLeave(object sender, EventArgs e)
        {
            Projects.BackColor = Color.FromArgb(125, 185, 245);
            Cursor= System.Windows.Forms.Cursors.Default;
        }
        private void Vendors_MouseMove(object sender, MouseEventArgs e)
        {
            Vendors.BackColor = Color.White;
            Cursor= System.Windows.Forms.Cursors.Hand;
        }
        private void Vendors_MouseLeave(object sender, EventArgs e)
        {
            Vendors.BackColor = Color.FromArgb(125, 185, 245);
            Cursor = System.Windows.Forms.Cursors.Default;

        }
        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            Login.BackColor = Color.White;
            Cursor = System.Windows.Forms.Cursors.Hand;
        }
        private void Login_MouseLeave(object sender, EventArgs e)
        {
            Login.BackColor = Color.FromArgb(125, 185, 245);
            Cursor = System.Windows.Forms.Cursors.Default;

        }

        private void Projects_Click(object sender, EventArgs e)
        {
            if (label1.Text != "Projects")
            {
                panelMain.Controls.Clear();
                
                Projects myForm = new Projects();
                myForm.FormBorderStyle = FormBorderStyle.None;
                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                panelMain.Controls.Add(myForm);
                myForm.Show();
                label1.Text = "Projects";
                
            }
        }

        private void Vendors_Click(object sender, EventArgs e)
        {
            if (label1.Text != "Vendors")
            {
                panelMain.Controls.Clear();
              
                Vendors myForm = new Vendors();
                myForm.FormBorderStyle = FormBorderStyle.None;
                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                panelMain.Controls.Add(myForm);
                myForm.Show();
                label1.Text = "Vendors";
            }
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (label1.Text != "Sign Up")
            {

                panelMain.Controls.Clear();

                SignUp myForm = new SignUp();
                myForm.FormBorderStyle = FormBorderStyle.None;
                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                panelMain.Controls.Add(myForm);
                myForm.Show();
                label1.Text = "Sign Up";
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Are you sure want to exit?",
                               "Exiting",
                                MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Information) == DialogResult.OK)
                    Environment.Exit(1);
                else
                    e.Cancel = true; // to don't close form is user change his mind
            }
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void btnAssignWork_Click(object sender, EventArgs e)
        {

            if (label1.Text != "Assign Work")
            {

                panelMain.Controls.Clear();

                AssignWork myForm = new AssignWork();
                myForm.FormBorderStyle = FormBorderStyle.None;
                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                panelMain.Controls.Add(myForm);
                myForm.Show();
                label1.Text = "Assign Work";
            }
        }

        private void btnAssignWork_MouseMove(object sender, MouseEventArgs e)
        {
            btnAssignWork.BackColor = Color.White;
            Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void btnAssignWork_MouseLeave(object sender, EventArgs e)
        {
            btnAssignWork.BackColor = Color.FromArgb(125, 185, 245);
            Cursor = System.Windows.Forms.Cursors.Default;
        }

        
        
    }
}
