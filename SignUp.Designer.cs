namespace Construction
{
    partial class SignUp
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
            this.txtuser = new MaterialSkin.Controls.MaterialTextBox();
            this.txtpass = new MaterialSkin.Controls.MaterialTextBox();
            this.btnlogin = new MaterialSkin.Controls.MaterialButton();
            this.labelpass = new MaterialSkin.Controls.MaterialLabel();
            this.labeluser = new MaterialSkin.Controls.MaterialLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRemove = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtuser
            // 
            this.txtuser.AnimateReadOnly = false;
            this.txtuser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtuser.Depth = 0;
            this.txtuser.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtuser.Hint = "Username";
            this.txtuser.LeadingIcon = null;
            this.txtuser.Location = new System.Drawing.Point(12, 57);
            this.txtuser.MaxLength = 50;
            this.txtuser.MouseState = MaterialSkin.MouseState.OUT;
            this.txtuser.Multiline = false;
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(324, 50);
            this.txtuser.TabIndex = 4;
            this.txtuser.Text = "";
            this.txtuser.TrailingIcon = null;
            this.txtuser.UseAccent = false;
            // 
            // txtpass
            // 
            this.txtpass.AnimateReadOnly = false;
            this.txtpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpass.Depth = 0;
            this.txtpass.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtpass.Hint = "Password";
            this.txtpass.LeadingIcon = null;
            this.txtpass.Location = new System.Drawing.Point(12, 144);
            this.txtpass.MaxLength = 50;
            this.txtpass.MouseState = MaterialSkin.MouseState.OUT;
            this.txtpass.Multiline = false;
            this.txtpass.Name = "txtpass";
            this.txtpass.Password = true;
            this.txtpass.Size = new System.Drawing.Size(324, 50);
            this.txtpass.TabIndex = 5;
            this.txtpass.Text = "";
            this.txtpass.TrailingIcon = global::Construction.Properties.Resources.icons8_eye_96;
            this.txtpass.UseAccent = false;
            this.txtpass.TrailingIconClick += new System.EventHandler(this.txtpass_TrailingIconClick);
            // 
            // btnlogin
            // 
            this.btnlogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnlogin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnlogin.Depth = 0;
            this.btnlogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnlogin.HighEmphasis = true;
            this.btnlogin.Icon = null;
            this.btnlogin.Location = new System.Drawing.Point(395, 409);
            this.btnlogin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnlogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnlogin.Size = new System.Drawing.Size(90, 36);
            this.btnlogin.TabIndex = 7;
            this.btnlogin.Text = "Add User";
            this.btnlogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnlogin.UseAccentColor = false;
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // labelpass
            // 
            this.labelpass.AutoSize = true;
            this.labelpass.BackColor = System.Drawing.Color.Transparent;
            this.labelpass.Depth = 0;
            this.labelpass.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelpass.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.labelpass.ForeColor = System.Drawing.Color.Red;
            this.labelpass.Location = new System.Drawing.Point(342, 180);
            this.labelpass.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelpass.Name = "labelpass";
            this.labelpass.Size = new System.Drawing.Size(91, 14);
            this.labelpass.TabIndex = 9;
            this.labelpass.Text = "Enter Password*";
            this.labelpass.Visible = false;
            // 
            // labeluser
            // 
            this.labeluser.AutoSize = true;
            this.labeluser.BackColor = System.Drawing.Color.Transparent;
            this.labeluser.Depth = 0;
            this.labeluser.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labeluser.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.labeluser.ForeColor = System.Drawing.Color.Red;
            this.labeluser.Location = new System.Drawing.Point(342, 93);
            this.labeluser.MouseState = MaterialSkin.MouseState.HOVER;
            this.labeluser.Name = "labeluser";
            this.labeluser.Size = new System.Drawing.Size(92, 14);
            this.labeluser.TabIndex = 8;
            this.labeluser.Text = "Enter Username*";
            this.labeluser.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 212);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(473, 188);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnRemove
            // 
            this.btnRemove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRemove.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRemove.Depth = 0;
            this.btnRemove.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRemove.HighEmphasis = true;
            this.btnRemove.Icon = null;
            this.btnRemove.Location = new System.Drawing.Point(13, 409);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRemove.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRemove.Size = new System.Drawing.Size(120, 36);
            this.btnRemove.TabIndex = 12;
            this.btnRemove.Text = "Remove USer";
            this.btnRemove.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRemove.UseAccentColor = false;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelpass);
            this.Controls.Add(this.labeluser);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtuser);
            this.Name = "SignUp";
            this.Text = "SignUp";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txtuser;
        private MaterialSkin.Controls.MaterialTextBox txtpass;
        private MaterialSkin.Controls.MaterialButton btnlogin;
        private MaterialSkin.Controls.MaterialLabel labelpass;
        private MaterialSkin.Controls.MaterialLabel labeluser;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialButton btnRemove;
    }
}