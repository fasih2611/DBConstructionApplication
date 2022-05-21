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
        private void panel1_Paint(object sender, PaintEventArgs e)
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
            Register myForm = new Register();
            myForm.FormBorderStyle = FormBorderStyle.None;
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            panelMain.Controls.Add(myForm);
            myForm.Show();
            label1.Text = "Registration";
        }
    }
}
