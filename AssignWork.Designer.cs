namespace Construction
{
    partial class AssignWork
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txtSearchName = new MaterialSkin.Controls.MaterialTextBox();
            this.txtSearchProject = new MaterialSkin.Controls.MaterialTextBox();
            this.btnAssign = new MaterialSkin.Controls.MaterialButton();
            this.btnDismiss = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(457, 188);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Enabled = false;
            this.dataGridView2.Location = new System.Drawing.Point(488, 153);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(423, 188);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentDoubleClick);
            // 
            // txtSearchName
            // 
            this.txtSearchName.AnimateReadOnly = false;
            this.txtSearchName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchName.Depth = 0;
            this.txtSearchName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearchName.Hint = "Search Employees By Name";
            this.txtSearchName.LeadingIcon = null;
            this.txtSearchName.Location = new System.Drawing.Point(12, 97);
            this.txtSearchName.MaxLength = 50;
            this.txtSearchName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSearchName.Multiline = false;
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(300, 50);
            this.txtSearchName.TabIndex = 2;
            this.txtSearchName.Text = "";
            this.txtSearchName.TrailingIcon = null;
            this.txtSearchName.TextChanged += new System.EventHandler(this.txtSearchName_TextChanged);
            // 
            // txtSearchProject
            // 
            this.txtSearchProject.AnimateReadOnly = false;
            this.txtSearchProject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchProject.Depth = 0;
            this.txtSearchProject.Enabled = false;
            this.txtSearchProject.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearchProject.Hint = "Search Project By Name";
            this.txtSearchProject.LeadingIcon = null;
            this.txtSearchProject.Location = new System.Drawing.Point(488, 96);
            this.txtSearchProject.MaxLength = 50;
            this.txtSearchProject.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSearchProject.Multiline = false;
            this.txtSearchProject.Name = "txtSearchProject";
            this.txtSearchProject.Size = new System.Drawing.Size(300, 50);
            this.txtSearchProject.TabIndex = 3;
            this.txtSearchProject.Text = "";
            this.txtSearchProject.TrailingIcon = null;
            this.txtSearchProject.TextChanged += new System.EventHandler(this.txtSearchProject_TextChanged);
            // 
            // btnAssign
            // 
            this.btnAssign.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAssign.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAssign.Depth = 0;
            this.btnAssign.Enabled = false;
            this.btnAssign.HighEmphasis = true;
            this.btnAssign.Icon = null;
            this.btnAssign.Location = new System.Drawing.Point(829, 350);
            this.btnAssign.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAssign.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAssign.Size = new System.Drawing.Size(73, 36);
            this.btnAssign.TabIndex = 4;
            this.btnAssign.Text = "Assign";
            this.btnAssign.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAssign.UseAccentColor = false;
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // btnDismiss
            // 
            this.btnDismiss.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDismiss.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDismiss.Depth = 0;
            this.btnDismiss.Enabled = false;
            this.btnDismiss.HighEmphasis = true;
            this.btnDismiss.Icon = null;
            this.btnDismiss.Location = new System.Drawing.Point(13, 350);
            this.btnDismiss.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDismiss.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDismiss.Name = "btnDismiss";
            this.btnDismiss.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDismiss.Size = new System.Drawing.Size(190, 36);
            this.btnDismiss.TabIndex = 5;
            this.btnDismiss.Text = "Dismiss From Project";
            this.btnDismiss.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDismiss.UseAccentColor = false;
            this.btnDismiss.UseVisualStyleBackColor = true;
            this.btnDismiss.Click += new System.EventHandler(this.btnDismiss_Click);
            // 
            // AssignWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(915, 453);
            this.Controls.Add(this.btnDismiss);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.txtSearchProject);
            this.Controls.Add(this.txtSearchName);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AssignWork";
            this.Text = "AssignWork";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private MaterialSkin.Controls.MaterialTextBox txtSearchName;
        private MaterialSkin.Controls.MaterialTextBox txtSearchProject;
        private MaterialSkin.Controls.MaterialButton btnAssign;
        private MaterialSkin.Controls.MaterialButton btnDismiss;
    }
}