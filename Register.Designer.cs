
namespace Construction
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labEmail = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.rdbtnFemale = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdbtnMale = new MaterialSkin.Controls.MaterialRadioButton();
            this.ComboRole = new MaterialSkin.Controls.MaterialComboBox();
            this.txtID = new MaterialSkin.Controls.MaterialTextBox();
            this.txtAddress = new MaterialSkin.Controls.MaterialTextBox();
            this.txtEmail = new MaterialSkin.Controls.MaterialTextBox();
            this.txtLName = new MaterialSkin.Controls.MaterialTextBox();
            this.txtFName = new MaterialSkin.Controls.MaterialTextBox();
            this.button3 = new MaterialSkin.Controls.MaterialButton();
            this.button1 = new MaterialSkin.Controls.MaterialButton();
            this.button2 = new MaterialSkin.Controls.MaterialButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.labEmail);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Controls.Add(this.rdbtnFemale);
            this.panel1.Controls.Add(this.rdbtnMale);
            this.panel1.Controls.Add(this.ComboRole);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtLName);
            this.panel1.Controls.Add(this.txtFName);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1181, 698);
            this.panel1.TabIndex = 4;
            // 
            // labEmail
            // 
            this.labEmail.AutoSize = true;
            this.labEmail.Depth = 0;
            this.labEmail.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labEmail.Location = new System.Drawing.Point(798, 627);
            this.labEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.labEmail.Name = "labEmail";
            this.labEmail.Size = new System.Drawing.Size(99, 19);
            this.labEmail.TabIndex = 44;
            this.labEmail.Text = "*Email Invalid";
            this.labEmail.Visible = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(223, 250);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(36, 19);
            this.materialLabel1.TabIndex = 43;
            this.materialLabel1.Text = "Role:";
            // 
            // rdbtnFemale
            // 
            this.rdbtnFemale.AutoSize = true;
            this.rdbtnFemale.Depth = 0;
            this.rdbtnFemale.Location = new System.Drawing.Point(23, 276);
            this.rdbtnFemale.Margin = new System.Windows.Forms.Padding(0);
            this.rdbtnFemale.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdbtnFemale.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdbtnFemale.Name = "rdbtnFemale";
            this.rdbtnFemale.Ripple = true;
            this.rdbtnFemale.Size = new System.Drawing.Size(87, 37);
            this.rdbtnFemale.TabIndex = 42;
            this.rdbtnFemale.TabStop = true;
            this.rdbtnFemale.Text = "Female";
            this.rdbtnFemale.UseVisualStyleBackColor = true;
            // 
            // rdbtnMale
            // 
            this.rdbtnMale.AutoSize = true;
            this.rdbtnMale.Depth = 0;
            this.rdbtnMale.Location = new System.Drawing.Point(23, 239);
            this.rdbtnMale.Margin = new System.Windows.Forms.Padding(0);
            this.rdbtnMale.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdbtnMale.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdbtnMale.Name = "rdbtnMale";
            this.rdbtnMale.Ripple = true;
            this.rdbtnMale.Size = new System.Drawing.Size(70, 37);
            this.rdbtnMale.TabIndex = 41;
            this.rdbtnMale.TabStop = true;
            this.rdbtnMale.Text = "Male";
            this.rdbtnMale.UseVisualStyleBackColor = true;
            // 
            // ComboRole
            // 
            this.ComboRole.AutoResize = false;
            this.ComboRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ComboRole.Depth = 0;
            this.ComboRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ComboRole.DropDownHeight = 174;
            this.ComboRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboRole.DropDownWidth = 121;
            this.ComboRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ComboRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ComboRole.FormattingEnabled = true;
            this.ComboRole.IntegralHeight = false;
            this.ComboRole.ItemHeight = 43;
            this.ComboRole.Items.AddRange(new object[] {
            "Construction Manager",
            "Estimator",
            "Architect",
            "Supervisor",
            "Expeditor",
            "Worker",
            "Engineer",
            "Electrician",
            "Foreman"});
            this.ComboRole.Location = new System.Drawing.Point(265, 227);
            this.ComboRole.MaxDropDownItems = 4;
            this.ComboRole.MouseState = MaterialSkin.MouseState.OUT;
            this.ComboRole.Name = "ComboRole";
            this.ComboRole.Size = new System.Drawing.Size(248, 49);
            this.ComboRole.StartIndex = 0;
            this.ComboRole.TabIndex = 40;
            this.ComboRole.UseAccent = false;
            // 
            // txtID
            // 
            this.txtID.AnimateReadOnly = false;
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Depth = 0;
            this.txtID.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtID.Hint = "ID";
            this.txtID.LeadingIcon = null;
            this.txtID.Location = new System.Drawing.Point(318, 115);
            this.txtID.MaxLength = 50;
            this.txtID.MouseState = MaterialSkin.MouseState.OUT;
            this.txtID.Multiline = false;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(248, 50);
            this.txtID.TabIndex = 39;
            this.txtID.Text = "";
            this.txtID.TrailingIcon = null;
            this.txtID.UseAccent = false;
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // txtAddress
            // 
            this.txtAddress.AnimateReadOnly = false;
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddress.Depth = 0;
            this.txtAddress.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAddress.Hint = "Address";
            this.txtAddress.LeadingIcon = null;
            this.txtAddress.Location = new System.Drawing.Point(23, 171);
            this.txtAddress.MaxLength = 50;
            this.txtAddress.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAddress.Multiline = false;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(543, 50);
            this.txtAddress.TabIndex = 38;
            this.txtAddress.Text = "";
            this.txtAddress.TrailingIcon = null;
            this.txtAddress.UseAccent = false;
            // 
            // txtEmail
            // 
            this.txtEmail.AnimateReadOnly = false;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Depth = 0;
            this.txtEmail.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmail.Hint = "Email";
            this.txtEmail.LeadingIcon = null;
            this.txtEmail.Location = new System.Drawing.Point(23, 115);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(216, 50);
            this.txtEmail.TabIndex = 37;
            this.txtEmail.Text = "";
            this.txtEmail.TrailingIcon = null;
            this.txtEmail.UseAccent = false;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtLName
            // 
            this.txtLName.AnimateReadOnly = false;
            this.txtLName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLName.Depth = 0;
            this.txtLName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtLName.Hint = "Last Name";
            this.txtLName.LeadingIcon = null;
            this.txtLName.Location = new System.Drawing.Point(318, 59);
            this.txtLName.MaxLength = 50;
            this.txtLName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtLName.Multiline = false;
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(248, 50);
            this.txtLName.TabIndex = 36;
            this.txtLName.Text = "";
            this.txtLName.TrailingIcon = null;
            this.txtLName.UseAccent = false;
            this.txtLName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFName_KeyPress);
            // 
            // txtFName
            // 
            this.txtFName.AnimateReadOnly = false;
            this.txtFName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFName.Depth = 0;
            this.txtFName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFName.Hint = "First Name";
            this.txtFName.LeadingIcon = null;
            this.txtFName.Location = new System.Drawing.Point(23, 59);
            this.txtFName.MaxLength = 50;
            this.txtFName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtFName.Multiline = false;
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(216, 50);
            this.txtFName.TabIndex = 35;
            this.txtFName.Text = "";
            this.txtFName.TrailingIcon = null;
            this.txtFName.UseAccent = false;
            this.txtFName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFName_KeyPress);
            // 
            // button3
            // 
            this.button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.button3.Depth = 0;
            this.button3.HighEmphasis = true;
            this.button3.Icon = null;
            this.button3.Location = new System.Drawing.Point(33, 610);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button3.MouseState = MaterialSkin.MouseState.HOVER;
            this.button3.Name = "button3";
            this.button3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.button3.Size = new System.Drawing.Size(73, 36);
            this.button3.TabIndex = 34;
            this.button3.Text = "Delete";
            this.button3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.button3.UseAccentColor = false;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Delete_Click);
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.button1.Depth = 0;
            this.button1.HighEmphasis = true;
            this.button1.Icon = null;
            this.button1.Location = new System.Drawing.Point(113, 610);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button1.MouseState = MaterialSkin.MouseState.HOVER;
            this.button1.Name = "button1";
            this.button1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.button1.Size = new System.Drawing.Size(77, 36);
            this.button1.TabIndex = 33;
            this.button1.Text = "Update";
            this.button1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.button1.UseAccentColor = false;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.update_Click);
            // 
            // button2
            // 
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.button2.Depth = 0;
            this.button2.HighEmphasis = true;
            this.button2.Icon = null;
            this.button2.Location = new System.Drawing.Point(904, 610);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button2.MouseState = MaterialSkin.MouseState.HOVER;
            this.button2.Name = "button2";
            this.button2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.button2.Size = new System.Drawing.Size(64, 36);
            this.button2.TabIndex = 32;
            this.button2.Text = "Save";
            this.button2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.button2.UseAccentColor = false;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.save_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(23, 348);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(945, 253);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1181, 698);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRadioButton rdbtnFemale;
        private MaterialSkin.Controls.MaterialRadioButton rdbtnMale;
        private MaterialSkin.Controls.MaterialComboBox ComboRole;
        private MaterialSkin.Controls.MaterialTextBox txtID;
        private MaterialSkin.Controls.MaterialTextBox txtAddress;
        private MaterialSkin.Controls.MaterialTextBox txtEmail;
        private MaterialSkin.Controls.MaterialTextBox txtLName;
        private MaterialSkin.Controls.MaterialTextBox txtFName;
        private MaterialSkin.Controls.MaterialButton button3;
        private MaterialSkin.Controls.MaterialButton button1;
        private MaterialSkin.Controls.MaterialButton button2;
        private MaterialSkin.Controls.MaterialLabel labEmail;
    }
}