namespace Construction
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txtuser = new MaterialSkin.Controls.MaterialTextBox();
            this.txtpass = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnlogin = new MaterialSkin.Controls.MaterialButton();
            this.labeluser = new MaterialSkin.Controls.MaterialLabel();
            this.labelpass = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.txtuser.Location = new System.Drawing.Point(225, 230);
            this.txtuser.MaxLength = 50;
            this.txtuser.MouseState = MaterialSkin.MouseState.OUT;
            this.txtuser.Multiline = false;
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(324, 50);
            this.txtuser.TabIndex = 0;
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
            this.txtpass.Location = new System.Drawing.Point(225, 317);
            this.txtpass.MaxLength = 50;
            this.txtpass.MouseState = MaterialSkin.MouseState.OUT;
            this.txtpass.Multiline = false;
            this.txtpass.Name = "txtpass";
            this.txtpass.Password = true;
            this.txtpass.Size = new System.Drawing.Size(324, 50);
            this.txtpass.TabIndex = 1;
            this.txtpass.Text = "";
            this.txtpass.TrailingIcon = null;
            this.txtpass.UseAccent = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Light", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H2;
            this.materialLabel1.Location = new System.Drawing.Point(299, 81);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(161, 72);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Login ";
            // 
            // btnlogin
            // 
            this.btnlogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnlogin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnlogin.Depth = 0;
            this.btnlogin.HighEmphasis = true;
            this.btnlogin.Icon = null;
            this.btnlogin.Location = new System.Drawing.Point(351, 390);
            this.btnlogin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnlogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnlogin.Size = new System.Drawing.Size(64, 36);
            this.btnlogin.TabIndex = 3;
            this.btnlogin.Text = "Login";
            this.btnlogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnlogin.UseAccentColor = false;
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // labeluser
            // 
            this.labeluser.AutoSize = true;
            this.labeluser.BackColor = System.Drawing.Color.Transparent;
            this.labeluser.Depth = 0;
            this.labeluser.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labeluser.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.labeluser.ForeColor = System.Drawing.Color.Red;
            this.labeluser.Location = new System.Drawing.Point(555, 261);
            this.labeluser.MouseState = MaterialSkin.MouseState.HOVER;
            this.labeluser.Name = "labeluser";
            this.labeluser.Size = new System.Drawing.Size(92, 14);
            this.labeluser.TabIndex = 4;
            this.labeluser.Text = "Enter Username*";
            this.labeluser.Visible = false;
            // 
            // labelpass
            // 
            this.labelpass.AutoSize = true;
            this.labelpass.BackColor = System.Drawing.Color.Transparent;
            this.labelpass.Depth = 0;
            this.labelpass.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelpass.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.labelpass.ForeColor = System.Drawing.Color.Red;
            this.labelpass.Location = new System.Drawing.Point(555, 348);
            this.labelpass.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelpass.Name = "labelpass";
            this.labelpass.Size = new System.Drawing.Size(91, 14);
            this.labelpass.TabIndex = 5;
            this.labelpass.Text = "Enter Password*";
            this.labelpass.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Construction.Properties.Resources._6d73ea2b_9c03_e911_9444_0050569c41bf;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(274, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AcceptButton = this.btnlogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelpass);
            this.Controls.Add(this.labeluser);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtuser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txtuser;
        private MaterialSkin.Controls.MaterialTextBox txtpass;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton btnlogin;
        private MaterialSkin.Controls.MaterialLabel labeluser;
        private MaterialSkin.Controls.MaterialLabel labelpass;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}