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
    public partial class Vendors : Form
    {
        public Vendors()
        {
            InitializeComponent();
        }

        private void materialListBox1_SelectedIndexChanged(object sender, MaterialSkin.MaterialListBoxItem selectedItem)
        {
            try
            {
                VendorsPanel.Controls.Clear();
                if (materialListBox1.SelectedIndex == 0)
                {
                    VListForm myForm = new VListForm();
                    myForm.FormBorderStyle = FormBorderStyle.None;
                    myForm.TopLevel = false;
                    myForm.AutoScroll = true;
                    VendorsPanel.Controls.Add(myForm);
                    myForm.Show();
                    
                }
                if (materialListBox1.SelectedIndex == 1) 
                {
                    VendorsPanel.Controls.Clear();
                    Materials myForm = new Materials();
                    myForm.FormBorderStyle = FormBorderStyle.None;
                    myForm.TopLevel = false;
                    myForm.AutoScroll = true;
                    VendorsPanel.Controls.Add(myForm);
                    myForm.Show();
                }
                if (materialListBox1.SelectedIndex == 2) 
                {
                    VendorsPanel.Controls.Clear();
                    Orders myForm = new Orders();
                    myForm.FormBorderStyle = FormBorderStyle.None;
                    myForm.TopLevel = false;
                    myForm.AutoScroll = true;
                    VendorsPanel.Controls.Add(myForm);
                    myForm.Show();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void VendorsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void VendorsPanel_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
