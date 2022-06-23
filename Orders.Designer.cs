namespace Construction
{
    partial class Orders
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
            this.comboVendor = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.comboMaterial = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.comboProject = new MaterialSkin.Controls.MaterialComboBox();
            this.btnAdd = new MaterialSkin.Controls.MaterialButton();
            this.btnCancel = new MaterialSkin.Controls.MaterialButton();
            this.btndelieverd = new MaterialSkin.Controls.MaterialButton();
            this.txtQuantity = new MaterialSkin.Controls.MaterialTextBox();
            this.btnInvoice = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 263);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(835, 188);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // comboVendor
            // 
            this.comboVendor.AutoResize = false;
            this.comboVendor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboVendor.Depth = 0;
            this.comboVendor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboVendor.DropDownHeight = 174;
            this.comboVendor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboVendor.DropDownWidth = 121;
            this.comboVendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboVendor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboVendor.FormattingEnabled = true;
            this.comboVendor.IntegralHeight = false;
            this.comboVendor.ItemHeight = 43;
            this.comboVendor.Location = new System.Drawing.Point(73, 12);
            this.comboVendor.MaxDropDownItems = 4;
            this.comboVendor.MouseState = MaterialSkin.MouseState.OUT;
            this.comboVendor.Name = "comboVendor";
            this.comboVendor.Size = new System.Drawing.Size(271, 49);
            this.comboVendor.StartIndex = 0;
            this.comboVendor.TabIndex = 1;
            this.comboVendor.UseAccent = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(4, 83);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(63, 19);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "Material:";
            // 
            // comboMaterial
            // 
            this.comboMaterial.AutoResize = false;
            this.comboMaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboMaterial.Depth = 0;
            this.comboMaterial.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboMaterial.DropDownHeight = 174;
            this.comboMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMaterial.DropDownWidth = 121;
            this.comboMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboMaterial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboMaterial.FormattingEnabled = true;
            this.comboMaterial.IntegralHeight = false;
            this.comboMaterial.ItemHeight = 43;
            this.comboMaterial.Location = new System.Drawing.Point(73, 67);
            this.comboMaterial.MaxDropDownItems = 4;
            this.comboMaterial.MouseState = MaterialSkin.MouseState.OUT;
            this.comboMaterial.Name = "comboMaterial";
            this.comboMaterial.Size = new System.Drawing.Size(271, 49);
            this.comboMaterial.StartIndex = 0;
            this.comboMaterial.TabIndex = 3;
            this.comboMaterial.UseAccent = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(12, 28);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(55, 19);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "Vendor:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(13, 137);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(54, 19);
            this.materialLabel3.TabIndex = 7;
            this.materialLabel3.Text = "Project:";
            // 
            // comboProject
            // 
            this.comboProject.AutoResize = false;
            this.comboProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboProject.Depth = 0;
            this.comboProject.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboProject.DropDownHeight = 174;
            this.comboProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProject.DropDownWidth = 121;
            this.comboProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboProject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboProject.FormattingEnabled = true;
            this.comboProject.IntegralHeight = false;
            this.comboProject.ItemHeight = 43;
            this.comboProject.Location = new System.Drawing.Point(73, 122);
            this.comboProject.MaxDropDownItems = 4;
            this.comboProject.MouseState = MaterialSkin.MouseState.OUT;
            this.comboProject.Name = "comboProject";
            this.comboProject.Size = new System.Drawing.Size(271, 49);
            this.comboProject.StartIndex = 0;
            this.comboProject.TabIndex = 6;
            this.comboProject.UseAccent = false;
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAdd.Depth = 0;
            this.btnAdd.HighEmphasis = true;
            this.btnAdd.Icon = null;
            this.btnAdd.Location = new System.Drawing.Point(782, 460);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAdd.Size = new System.Drawing.Size(64, 36);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAdd.UseAccentColor = false;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancel.Depth = 0;
            this.btnCancel.HighEmphasis = true;
            this.btnCancel.Icon = null;
            this.btnCancel.Location = new System.Drawing.Point(23, 460);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancel.Size = new System.Drawing.Size(128, 36);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel Order";
            this.btnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancel.UseAccentColor = false;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btndelieverd
            // 
            this.btndelieverd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btndelieverd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btndelieverd.Depth = 0;
            this.btndelieverd.HighEmphasis = true;
            this.btndelieverd.Icon = null;
            this.btndelieverd.Location = new System.Drawing.Point(159, 460);
            this.btndelieverd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btndelieverd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btndelieverd.Name = "btndelieverd";
            this.btndelieverd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btndelieverd.Size = new System.Drawing.Size(172, 36);
            this.btndelieverd.TabIndex = 10;
            this.btndelieverd.Text = "Mark as delievered ";
            this.btndelieverd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btndelieverd.UseAccentColor = false;
            this.btndelieverd.UseVisualStyleBackColor = true;
            this.btndelieverd.Click += new System.EventHandler(this.btndelieverd_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.AnimateReadOnly = false;
            this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuantity.Depth = 0;
            this.txtQuantity.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtQuantity.Hint = "Quanity";
            this.txtQuantity.LeadingIcon = null;
            this.txtQuantity.Location = new System.Drawing.Point(350, 66);
            this.txtQuantity.MaxLength = 50;
            this.txtQuantity.MouseState = MaterialSkin.MouseState.OUT;
            this.txtQuantity.Multiline = false;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(165, 50);
            this.txtQuantity.TabIndex = 11;
            this.txtQuantity.Text = "";
            this.txtQuantity.TrailingIcon = null;
            this.txtQuantity.UseAccent = false;
            // 
            // btnInvoice
            // 
            this.btnInvoice.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInvoice.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnInvoice.Depth = 0;
            this.btnInvoice.HighEmphasis = true;
            this.btnInvoice.Icon = null;
            this.btnInvoice.Location = new System.Drawing.Point(692, 218);
            this.btnInvoice.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnInvoice.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnInvoice.Size = new System.Drawing.Size(155, 36);
            this.btnInvoice.TabIndex = 12;
            this.btnInvoice.Text = "Generate Invoice";
            this.btnInvoice.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnInvoice.UseAccentColor = false;
            this.btnInvoice.UseVisualStyleBackColor = true;
            this.btnInvoice.Click += new System.EventHandler(this.btnInvoice_Click);
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(859, 518);
            this.Controls.Add(this.btnInvoice);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.btndelieverd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.comboProject);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.comboMaterial);
            this.Controls.Add(this.comboVendor);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Orders";
            this.Text = "Orders";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialComboBox comboVendor;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialComboBox comboMaterial;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialComboBox comboProject;
        private MaterialSkin.Controls.MaterialButton btnAdd;
        private MaterialSkin.Controls.MaterialButton btnCancel;
        private MaterialSkin.Controls.MaterialButton btndelieverd;
        private MaterialSkin.Controls.MaterialTextBox txtQuantity;
        private MaterialSkin.Controls.MaterialButton btnInvoice;
    }
}