namespace Construction
{
    partial class Projects
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
            this.txtstate = new MaterialSkin.Controls.MaterialTextBox();
            this.txtcity = new MaterialSkin.Controls.MaterialTextBox();
            this.txtProject_name = new MaterialSkin.Controls.MaterialTextBox();
            this.txtprice = new MaterialSkin.Controls.MaterialTextBox();
            this.txtst_no = new MaterialSkin.Controls.MaterialTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdd = new MaterialSkin.Controls.MaterialButton();
            this.btnHold = new MaterialSkin.Controls.MaterialButton();
            this.btnComplete = new MaterialSkin.Controls.MaterialButton();
            this.btnCancel = new MaterialSkin.Controls.MaterialButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labDetails = new MaterialSkin.Controls.MaterialLabel();
            this.lab_c = new System.Windows.Forms.Label();
            this.lab_w = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtstate
            // 
            this.txtstate.AnimateReadOnly = false;
            this.txtstate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtstate.Depth = 0;
            this.txtstate.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtstate.Hint = "STATE";
            this.txtstate.LeadingIcon = null;
            this.txtstate.Location = new System.Drawing.Point(508, 109);
            this.txtstate.MaxLength = 50;
            this.txtstate.MouseState = MaterialSkin.MouseState.OUT;
            this.txtstate.Multiline = false;
            this.txtstate.Name = "txtstate";
            this.txtstate.Size = new System.Drawing.Size(196, 50);
            this.txtstate.TabIndex = 1;
            this.txtstate.Text = "";
            this.txtstate.TrailingIcon = null;
            this.txtstate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AlphabetsOnly);
            // 
            // txtcity
            // 
            this.txtcity.AnimateReadOnly = false;
            this.txtcity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcity.Depth = 0;
            this.txtcity.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtcity.Hint = "CITY";
            this.txtcity.LeadingIcon = null;
            this.txtcity.Location = new System.Drawing.Point(306, 109);
            this.txtcity.MaxLength = 50;
            this.txtcity.MouseState = MaterialSkin.MouseState.OUT;
            this.txtcity.Multiline = false;
            this.txtcity.Name = "txtcity";
            this.txtcity.Size = new System.Drawing.Size(196, 50);
            this.txtcity.TabIndex = 3;
            this.txtcity.Text = "";
            this.txtcity.TrailingIcon = null;
            this.txtcity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AlphabetsOnly);
            // 
            // txtProject_name
            // 
            this.txtProject_name.AnimateReadOnly = false;
            this.txtProject_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProject_name.Depth = 0;
            this.txtProject_name.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtProject_name.Hint = "PROJECT NAME";
            this.txtProject_name.LeadingIcon = null;
            this.txtProject_name.Location = new System.Drawing.Point(92, 47);
            this.txtProject_name.MaxLength = 50;
            this.txtProject_name.MouseState = MaterialSkin.MouseState.OUT;
            this.txtProject_name.Multiline = false;
            this.txtProject_name.Name = "txtProject_name";
            this.txtProject_name.Size = new System.Drawing.Size(196, 50);
            this.txtProject_name.TabIndex = 4;
            this.txtProject_name.Text = "";
            this.txtProject_name.TrailingIcon = null;
            this.txtProject_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AlphabetsOnly);
            // 
            // txtprice
            // 
            this.txtprice.AnimateReadOnly = false;
            this.txtprice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtprice.Depth = 0;
            this.txtprice.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtprice.Hint = "EST.PRICE";
            this.txtprice.LeadingIcon = null;
            this.txtprice.Location = new System.Drawing.Point(92, 165);
            this.txtprice.MaxLength = 50;
            this.txtprice.MouseState = MaterialSkin.MouseState.OUT;
            this.txtprice.Multiline = false;
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(196, 50);
            this.txtprice.TabIndex = 5;
            this.txtprice.Text = "";
            this.txtprice.TrailingIcon = null;
            this.txtprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersOnly);
            // 
            // txtst_no
            // 
            this.txtst_no.AnimateReadOnly = false;
            this.txtst_no.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtst_no.Depth = 0;
            this.txtst_no.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtst_no.Hint = "STREET NO.";
            this.txtst_no.LeadingIcon = null;
            this.txtst_no.Location = new System.Drawing.Point(92, 109);
            this.txtst_no.MaxLength = 50;
            this.txtst_no.MouseState = MaterialSkin.MouseState.OUT;
            this.txtst_no.Multiline = false;
            this.txtst_no.Name = "txtst_no";
            this.txtst_no.Size = new System.Drawing.Size(196, 50);
            this.txtst_no.TabIndex = 6;
            this.txtst_no.Text = "";
            this.txtst_no.TrailingIcon = null;
            this.txtst_no.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AlphanumericOnly);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 263);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1067, 236);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAdd.Depth = 0;
            this.btnAdd.HighEmphasis = true;
            this.btnAdd.Icon = null;
            this.btnAdd.Location = new System.Drawing.Point(960, 508);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAdd.Size = new System.Drawing.Size(118, 36);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add Project";
            this.btnAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAdd.UseAccentColor = false;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnHold
            // 
            this.btnHold.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHold.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnHold.Depth = 0;
            this.btnHold.HighEmphasis = true;
            this.btnHold.Icon = null;
            this.btnHold.Location = new System.Drawing.Point(170, 508);
            this.btnHold.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnHold.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHold.Name = "btnHold";
            this.btnHold.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnHold.Size = new System.Drawing.Size(116, 36);
            this.btnHold.TabIndex = 11;
            this.btnHold.Text = "Put On Hold";
            this.btnHold.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnHold.UseAccentColor = false;
            this.btnHold.UseVisualStyleBackColor = true;
            this.btnHold.Click += new System.EventHandler(this.btnHold_Click);
            // 
            // btnComplete
            // 
            this.btnComplete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnComplete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnComplete.Depth = 0;
            this.btnComplete.HighEmphasis = true;
            this.btnComplete.Icon = null;
            this.btnComplete.Location = new System.Drawing.Point(294, 509);
            this.btnComplete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnComplete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnComplete.Size = new System.Drawing.Size(174, 36);
            this.btnComplete.TabIndex = 12;
            this.btnComplete.Text = "Mark As Completed";
            this.btnComplete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnComplete.UseAccentColor = false;
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancel.Depth = 0;
            this.btnCancel.HighEmphasis = true;
            this.btnCancel.Icon = null;
            this.btnCancel.Location = new System.Drawing.Point(19, 508);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancel.Size = new System.Drawing.Size(145, 36);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel Project";
            this.btnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancel.UseAccentColor = false;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labDetails);
            this.panel1.Controls.Add(this.btnComplete);
            this.panel1.Controls.Add(this.lab_c);
            this.panel1.Controls.Add(this.lab_w);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1091, 560);
            this.panel1.TabIndex = 14;
            // 
            // labDetails
            // 
            this.labDetails.AutoSize = true;
            this.labDetails.Depth = 0;
            this.labDetails.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labDetails.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labDetails.Location = new System.Drawing.Point(765, 43);
            this.labDetails.MouseState = MaterialSkin.MouseState.HOVER;
            this.labDetails.Name = "labDetails";
            this.labDetails.Size = new System.Drawing.Size(137, 24);
            this.labDetails.TabIndex = 13;
            this.labDetails.Text = "Project Details:";
            this.labDetails.Visible = false;
            // 
            // lab_c
            // 
            this.lab_c.AutoSize = true;
            this.lab_c.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lab_c.Location = new System.Drawing.Point(765, 187);
            this.lab_c.Name = "lab_c";
            this.lab_c.Size = new System.Drawing.Size(65, 28);
            this.lab_c.TabIndex = 8;
            this.lab_c.Text = "label1";
            this.lab_c.Visible = false;
            // 
            // lab_w
            // 
            this.lab_w.AutoSize = true;
            this.lab_w.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lab_w.Location = new System.Drawing.Point(765, 109);
            this.lab_w.Name = "lab_w";
            this.lab_w.Size = new System.Drawing.Size(65, 28);
            this.lab_w.TabIndex = 9;
            this.lab_w.Text = "label2";
            this.lab_w.Visible = false;
            // 
            // Projects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1091, 560);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnHold);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtst_no);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txtProject_name);
            this.Controls.Add(this.txtcity);
            this.Controls.Add(this.txtstate);
            this.Controls.Add(this.panel1);
            this.Name = "Projects";
            this.Text = "Projects";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox txtstate;
        private MaterialSkin.Controls.MaterialTextBox txtcity;
        private MaterialSkin.Controls.MaterialTextBox txtProject_name;
        private MaterialSkin.Controls.MaterialTextBox txtprice;
        private MaterialSkin.Controls.MaterialTextBox txtst_no;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialButton btnAdd;
        private MaterialSkin.Controls.MaterialButton btnHold;
        private MaterialSkin.Controls.MaterialButton btnComplete;
        private MaterialSkin.Controls.MaterialButton btnCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lab_c;
        private System.Windows.Forms.Label lab_w;
        private MaterialSkin.Controls.MaterialLabel labDetails;
    }
}