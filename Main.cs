using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                }
                else 
                {
                    panelLeft.Size = new Size(248, 654);
                    Registration.Text = "Registration";
                    Vendors.Text = "Vendors";
                    Login.Text = "Login";
                    Projects.Text = "Projects";
                }
                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Registration_Click(object sender, EventArgs e)
        {
            if (label1.Text !="Registration") {
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
            
        }

        private void Registration_MouseLeave(object sender, EventArgs e)
        {
            Registration.BackColor = Color.FromArgb(125, 185, 245);
        }

        private void Projects_MouseMove(object sender, MouseEventArgs e)
        {
            Projects.BackColor = Color.White;
        }
        private void Projects_MouseLeave(object sender, EventArgs e)
        {
            Projects.BackColor = Color.FromArgb(125, 185, 245);
        }
        private void Vendors_MouseMove(object sender, MouseEventArgs e)
        {
            Vendors.BackColor = Color.White;
        }
        private void Vendors_MouseLeave(object sender, EventArgs e)
        {
            Vendors.BackColor = Color.FromArgb(125, 185, 245);
        }
        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            Login.BackColor = Color.White;
        }
        private void Login_MouseLeave(object sender, EventArgs e)
        {
            Login.BackColor = Color.FromArgb(125, 185, 245);
        }
    }
}
