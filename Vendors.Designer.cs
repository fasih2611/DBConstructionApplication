namespace Construction
{
    partial class Vendors
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MaterialSkin.MaterialListBoxItem materialListBoxItem1 = new MaterialSkin.MaterialListBoxItem();
            MaterialSkin.MaterialListBoxItem materialListBoxItem2 = new MaterialSkin.MaterialListBoxItem();
            MaterialSkin.MaterialListBoxItem materialListBoxItem3 = new MaterialSkin.MaterialListBoxItem();
            this.materialListBox1 = new MaterialSkin.Controls.MaterialListBox();
            this.VendorsPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // materialListBox1
            // 
            this.materialListBox1.BackColor = System.Drawing.Color.White;
            this.materialListBox1.BorderColor = System.Drawing.Color.LightGray;
            this.materialListBox1.Depth = 0;
            this.materialListBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.materialListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialListBoxItem1.SecondaryText = "(Add, Remove, Delete)";
            materialListBoxItem1.Tag = null;
            materialListBoxItem1.Text = "Vendors";
            materialListBoxItem2.SecondaryText = "";
            materialListBoxItem2.Tag = null;
            materialListBoxItem2.Text = "Materials";
            materialListBoxItem3.SecondaryText = "";
            materialListBoxItem3.Tag = null;
            materialListBoxItem3.Text = "Orders";
            this.materialListBox1.Items.Add(materialListBoxItem1);
            this.materialListBox1.Items.Add(materialListBoxItem2);
            this.materialListBox1.Items.Add(materialListBoxItem3);
            this.materialListBox1.Location = new System.Drawing.Point(0, 0);
            this.materialListBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialListBox1.Name = "materialListBox1";
            this.materialListBox1.SelectedIndex = -1;
            this.materialListBox1.SelectedItem = null;
            this.materialListBox1.Size = new System.Drawing.Size(150, 761);
            this.materialListBox1.TabIndex = 0;
            this.materialListBox1.SelectedIndexChanged += new MaterialSkin.Controls.MaterialListBox.SelectedIndexChangedEventHandler(this.materialListBox1_SelectedIndexChanged);
            // 
            // VendorsPanel
            // 
            this.VendorsPanel.BackColor = System.Drawing.Color.White;
            this.VendorsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.VendorsPanel.Location = new System.Drawing.Point(156, 0);
            this.VendorsPanel.Name = "VendorsPanel";
            this.VendorsPanel.Size = new System.Drawing.Size(877, 761);
            this.VendorsPanel.TabIndex = 1;
            this.VendorsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.VendorsPanel_Paint_1);
            // 
            // Vendors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1033, 761);
            this.Controls.Add(this.materialListBox1);
            this.Controls.Add(this.VendorsPanel);
            this.Name = "Vendors";
            this.Text = "Vendors";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialListBox materialListBox1;
        private System.Windows.Forms.Panel VendorsPanel;
    }
}