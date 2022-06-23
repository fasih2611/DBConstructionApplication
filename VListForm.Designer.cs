namespace Construction
{
    partial class VListForm
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
            this.txtVName = new MaterialSkin.Controls.MaterialTextBox();
            this.txtVCompany = new MaterialSkin.Controls.MaterialTextBox();
            this.txtVContact = new MaterialSkin.Controls.MaterialTextBox();
            this.txtSearch = new MaterialSkin.Controls.MaterialTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rbtnName = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbtnCompany = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbtnContact = new MaterialSkin.Controls.MaterialRadioButton();
            this.btnAdd = new MaterialSkin.Controls.MaterialButton();
            this.btnUpdate = new MaterialSkin.Controls.MaterialButton();
            this.btnDelete = new MaterialSkin.Controls.MaterialButton();
            this.VlistPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.VlistPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtVName
            // 
            this.txtVName.AnimateReadOnly = false;
            this.txtVName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVName.Depth = 0;
            this.txtVName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtVName.Hint = "Name";
            this.txtVName.LeadingIcon = null;
            this.txtVName.Location = new System.Drawing.Point(34, 18);
            this.txtVName.MaxLength = 50;
            this.txtVName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtVName.Multiline = false;
            this.txtVName.Name = "txtVName";
            this.txtVName.Size = new System.Drawing.Size(245, 50);
            this.txtVName.TabIndex = 1;
            this.txtVName.Text = "";
            this.txtVName.TrailingIcon = null;
            this.txtVName.UseAccent = false;
            this.txtVName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AlphabetsOnly);
            // 
            // txtVCompany
            // 
            this.txtVCompany.AnimateReadOnly = false;
            this.txtVCompany.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVCompany.Depth = 0;
            this.txtVCompany.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtVCompany.Hint = "Company Name";
            this.txtVCompany.LeadingIcon = null;
            this.txtVCompany.Location = new System.Drawing.Point(34, 74);
            this.txtVCompany.MaxLength = 50;
            this.txtVCompany.MouseState = MaterialSkin.MouseState.OUT;
            this.txtVCompany.Multiline = false;
            this.txtVCompany.Name = "txtVCompany";
            this.txtVCompany.Size = new System.Drawing.Size(245, 50);
            this.txtVCompany.TabIndex = 3;
            this.txtVCompany.Text = "";
            this.txtVCompany.TrailingIcon = null;
            this.txtVCompany.UseAccent = false;
            this.txtVCompany.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AlphabetsOnly);
            // 
            // txtVContact
            // 
            this.txtVContact.AnimateReadOnly = false;
            this.txtVContact.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVContact.Depth = 0;
            this.txtVContact.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtVContact.Hint = "Contact";
            this.txtVContact.LeadingIcon = null;
            this.txtVContact.Location = new System.Drawing.Point(34, 130);
            this.txtVContact.MaxLength = 50;
            this.txtVContact.MouseState = MaterialSkin.MouseState.OUT;
            this.txtVContact.Multiline = false;
            this.txtVContact.Name = "txtVContact";
            this.txtVContact.Size = new System.Drawing.Size(245, 50);
            this.txtVContact.TabIndex = 5;
            this.txtVContact.Text = "";
            this.txtVContact.TrailingIcon = null;
            this.txtVContact.UseAccent = false;
            this.txtVContact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVContact_KeyPress);
            // 
            // txtSearch
            // 
            this.txtSearch.AnimateReadOnly = false;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Depth = 0;
            this.txtSearch.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearch.Hint = "Search";
            this.txtSearch.LeadingIcon = null;
            this.txtSearch.Location = new System.Drawing.Point(151, 227);
            this.txtSearch.MaxLength = 50;
            this.txtSearch.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(291, 50);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.Text = "";
            this.txtSearch.TrailingIcon = null;
            this.txtSearch.UseAccent = false;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 338);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(649, 188);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // rbtnName
            // 
            this.rbtnName.AutoSize = true;
            this.rbtnName.Depth = 0;
            this.rbtnName.Location = new System.Drawing.Point(151, 298);
            this.rbtnName.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnName.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtnName.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnName.Name = "rbtnName";
            this.rbtnName.Ripple = true;
            this.rbtnName.Size = new System.Drawing.Size(77, 37);
            this.rbtnName.TabIndex = 13;
            this.rbtnName.TabStop = true;
            this.rbtnName.Text = "Name";
            this.rbtnName.UseVisualStyleBackColor = true;
            // 
            // rbtnCompany
            // 
            this.rbtnCompany.AutoSize = true;
            this.rbtnCompany.Depth = 0;
            this.rbtnCompany.Location = new System.Drawing.Point(233, 298);
            this.rbtnCompany.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnCompany.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtnCompany.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnCompany.Name = "rbtnCompany";
            this.rbtnCompany.Ripple = true;
            this.rbtnCompany.Size = new System.Drawing.Size(103, 37);
            this.rbtnCompany.TabIndex = 14;
            this.rbtnCompany.TabStop = true;
            this.rbtnCompany.Text = "Company";
            this.rbtnCompany.UseVisualStyleBackColor = true;
            // 
            // rbtnContact
            // 
            this.rbtnContact.AutoSize = true;
            this.rbtnContact.Depth = 0;
            this.rbtnContact.Location = new System.Drawing.Point(336, 298);
            this.rbtnContact.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnContact.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtnContact.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnContact.Name = "rbtnContact";
            this.rbtnContact.Ripple = true;
            this.rbtnContact.Size = new System.Drawing.Size(150, 37);
            this.rbtnContact.TabIndex = 15;
            this.rbtnContact.TabStop = true;
            this.rbtnContact.Text = "Contact Number";
            this.rbtnContact.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAdd.Depth = 0;
            this.btnAdd.HighEmphasis = true;
            this.btnAdd.Icon = null;
            this.btnAdd.Location = new System.Drawing.Point(619, 535);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAdd.Size = new System.Drawing.Size(64, 36);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add";
            this.btnAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAdd.UseAccentColor = false;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnUpdate.Depth = 0;
            this.btnUpdate.HighEmphasis = true;
            this.btnUpdate.Icon = null;
            this.btnUpdate.Location = new System.Drawing.Point(534, 535);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnUpdate.Size = new System.Drawing.Size(77, 36);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnUpdate.UseAccentColor = false;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDelete.Depth = 0;
            this.btnDelete.HighEmphasis = true;
            this.btnDelete.Icon = null;
            this.btnDelete.Location = new System.Drawing.Point(453, 535);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDelete.Size = new System.Drawing.Size(73, 36);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDelete.UseAccentColor = false;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // VlistPanel
            // 
            this.VlistPanel.AutoSize = true;
            this.VlistPanel.Controls.Add(this.rbtnContact);
            this.VlistPanel.Controls.Add(this.rbtnCompany);
            this.VlistPanel.Controls.Add(this.rbtnName);
            this.VlistPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VlistPanel.Location = new System.Drawing.Point(0, 0);
            this.VlistPanel.MaximumSize = new System.Drawing.Size(748, 600);
            this.VlistPanel.MinimumSize = new System.Drawing.Size(748, 500);
            this.VlistPanel.Name = "VlistPanel";
            this.VlistPanel.Size = new System.Drawing.Size(748, 574);
            this.VlistPanel.TabIndex = 19;
            this.VlistPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.VlistPanel_Paint);
            // 
            // VListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(730, 574);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtVContact);
            this.Controls.Add(this.txtVCompany);
            this.Controls.Add(this.txtVName);
            this.Controls.Add(this.VlistPanel);
            this.Name = "VListForm";
            this.Text = "VListForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.VlistPanel.ResumeLayout(false);
            this.VlistPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox txtVName;
        private MaterialSkin.Controls.MaterialTextBox txtVCompany;
        private MaterialSkin.Controls.MaterialTextBox txtVContact;
        private MaterialSkin.Controls.MaterialTextBox txtSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialRadioButton rbtnName;
        private MaterialSkin.Controls.MaterialRadioButton rbtnCompany;
        private MaterialSkin.Controls.MaterialRadioButton rbtnContact;
        private MaterialSkin.Controls.MaterialButton btnAdd;
        private MaterialSkin.Controls.MaterialButton btnUpdate;
        private MaterialSkin.Controls.MaterialButton btnDelete;
        private System.Windows.Forms.Panel VlistPanel;
    }
}