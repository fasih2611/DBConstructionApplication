using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Drawing.Printing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Construction
{
    public partial class Invoice : Form
    {
        public string InName, InMaterial, InCost, InQuality, InQuantity, InTotalCost, InOrderDate, InExpectedDate;

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible= materialButton1.Visible = false;
            this.Close();
            Panel panel = new Panel();
            this.Controls.Add(panel);
            Graphics grp = panel.CreateGraphics();
            Size formSize = this.ClientSize;
            bitmap = new Bitmap(formSize.Width, formSize.Height, grp);
            grp = Graphics.FromImage(bitmap);
            Point panelLocation = PointToScreen(panel.Location);
            grp.CopyFromScreen(panelLocation.X, panelLocation.Y, 0, 0, formSize);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
        }
        Bitmap bitmap;


        private void Invoice_Load(object sender, EventArgs e)
        {
            label4.Text = InName;
            label5.Text = InMaterial;
            label6.Text = InCost;
            label7.Text = InQuality;
            label8.Text = InQuantity;
            label9.Text = InTotalCost;
            label10.Text = InOrderDate;
            label11.Text = InExpectedDate;
        }

        public Invoice()
        {
            InitializeComponent();
        }
       
    }
}
