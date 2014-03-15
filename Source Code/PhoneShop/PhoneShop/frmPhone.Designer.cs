namespace PhoneShop
{
    partial class frmPhone
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
            this.Phone_IDLabel = new System.Windows.Forms.Label();
            this.Phone_BrandLabel = new System.Windows.Forms.Label();
            this.Phone_ModelLabel = new System.Windows.Forms.Label();
            this.Phone_ColorLabel = new System.Windows.Forms.Label();
            this.dg = new System.Windows.Forms.DataGridView();
            this.gbDetail = new System.Windows.Forms.GroupBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.btnCancelSearch = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cboSearchType = new System.Windows.Forms.ComboBox();
            this.gbAdd = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbSave = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSpec = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.gbDetail.SuspendLayout();
            this.gbSearch.SuspendLayout();
            this.gbAdd.SuspendLayout();
            this.gbSave.SuspendLayout();
            this.SuspendLayout();
            // 
            // Phone_IDLabel
            // 
            this.Phone_IDLabel.AutoSize = true;
            this.Phone_IDLabel.Location = new System.Drawing.Point(113, 28);
            this.Phone_IDLabel.Name = "Phone_IDLabel";
            this.Phone_IDLabel.Size = new System.Drawing.Size(55, 13);
            this.Phone_IDLabel.TabIndex = 9;
            this.Phone_IDLabel.Text = "Phone ID:";
            // 
            // Phone_BrandLabel
            // 
            this.Phone_BrandLabel.AutoSize = true;
            this.Phone_BrandLabel.Location = new System.Drawing.Point(113, 54);
            this.Phone_BrandLabel.Name = "Phone_BrandLabel";
            this.Phone_BrandLabel.Size = new System.Drawing.Size(72, 13);
            this.Phone_BrandLabel.TabIndex = 11;
            this.Phone_BrandLabel.Text = "Phone Brand:";
            // 
            // Phone_ModelLabel
            // 
            this.Phone_ModelLabel.AutoSize = true;
            this.Phone_ModelLabel.Location = new System.Drawing.Point(113, 80);
            this.Phone_ModelLabel.Name = "Phone_ModelLabel";
            this.Phone_ModelLabel.Size = new System.Drawing.Size(73, 13);
            this.Phone_ModelLabel.TabIndex = 13;
            this.Phone_ModelLabel.Text = "Phone Model:";
            // 
            // Phone_ColorLabel
            // 
            this.Phone_ColorLabel.AutoSize = true;
            this.Phone_ColorLabel.Location = new System.Drawing.Point(113, 106);
            this.Phone_ColorLabel.Name = "Phone_ColorLabel";
            this.Phone_ColorLabel.Size = new System.Drawing.Size(68, 13);
            this.Phone_ColorLabel.TabIndex = 15;
            this.Phone_ColorLabel.Text = "Phone Color:";
            // 
            // dg
            // 
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Location = new System.Drawing.Point(156, 112);
            this.dg.Name = "dg";
            this.dg.Size = new System.Drawing.Size(526, 179);
            this.dg.TabIndex = 1;
            this.dg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellContentClick);
            // 
            // gbDetail
            // 
            this.gbDetail.Controls.Add(this.label2);
            this.gbDetail.Controls.Add(this.txtPrice);
            this.gbDetail.Controls.Add(this.label1);
            this.gbDetail.Controls.Add(this.txtSpec);
            this.gbDetail.Controls.Add(this.Phone_IDLabel);
            this.gbDetail.Controls.Add(this.txtID);
            this.gbDetail.Controls.Add(this.Phone_BrandLabel);
            this.gbDetail.Controls.Add(this.txtName);
            this.gbDetail.Controls.Add(this.Phone_ModelLabel);
            this.gbDetail.Controls.Add(this.txtModel);
            this.gbDetail.Controls.Add(this.Phone_ColorLabel);
            this.gbDetail.Controls.Add(this.txtColor);
            this.gbDetail.Location = new System.Drawing.Point(156, 298);
            this.gbDetail.Name = "gbDetail";
            this.gbDetail.Size = new System.Drawing.Size(525, 235);
            this.gbDetail.TabIndex = 13;
            this.gbDetail.TabStop = false;
            this.gbDetail.Text = "Detail";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(216, 25);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 10;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(216, 51);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(195, 20);
            this.txtName.TabIndex = 12;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(216, 77);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(195, 20);
            this.txtModel.TabIndex = 14;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(216, 103);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(195, 20);
            this.txtColor.TabIndex = 16;
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.btnCancelSearch);
            this.gbSearch.Controls.Add(this.btnSearch);
            this.gbSearch.Controls.Add(this.txtSearch);
            this.gbSearch.Controls.Add(this.cboSearchType);
            this.gbSearch.Location = new System.Drawing.Point(156, 49);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(525, 45);
            this.gbSearch.TabIndex = 15;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Search";
            // 
            // btnCancelSearch
            // 
            this.btnCancelSearch.Location = new System.Drawing.Point(464, 15);
            this.btnCancelSearch.Name = "btnCancelSearch";
            this.btnCancelSearch.Size = new System.Drawing.Size(53, 23);
            this.btnCancelSearch.TabIndex = 3;
            this.btnCancelSearch.Text = "Cancel";
            this.btnCancelSearch.UseVisualStyleBackColor = true;
            this.btnCancelSearch.Click += new System.EventHandler(this.btnCancelSearch_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(464, 15);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(53, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Go";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(172, 16);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(286, 20);
            this.txtSearch.TabIndex = 1;
            // 
            // cboSearchType
            // 
            this.cboSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSearchType.FormattingEnabled = true;
            this.cboSearchType.Items.AddRange(new object[] {
            "Phone_ID",
            "Phone_Brand",
            "Phone_Model",
            "Phone_Color",
            "Phone_Spec",
            "Phone_Price"});
            this.cboSearchType.Location = new System.Drawing.Point(23, 15);
            this.cboSearchType.Name = "cboSearchType";
            this.cboSearchType.Size = new System.Drawing.Size(143, 21);
            this.cboSearchType.TabIndex = 0;
            // 
            // gbAdd
            // 
            this.gbAdd.Controls.Add(this.btnDelete);
            this.gbAdd.Controls.Add(this.btnEdit);
            this.gbAdd.Controls.Add(this.btnAdd);
            this.gbAdd.Location = new System.Drawing.Point(270, 528);
            this.gbAdd.Name = "gbAdd";
            this.gbAdd.Size = new System.Drawing.Size(245, 57);
            this.gbAdd.TabIndex = 16;
            this.gbAdd.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(162, 11);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(78, 42);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(85, 11);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(78, 42);
            this.btnEdit.TabIndex = 16;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(8, 11);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(78, 42);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gbSave
            // 
            this.gbSave.Controls.Add(this.btnCancel);
            this.gbSave.Controls.Add(this.btnSave);
            this.gbSave.Location = new System.Drawing.Point(515, 528);
            this.gbSave.Name = "gbSave";
            this.gbSave.Size = new System.Drawing.Size(167, 57);
            this.gbSave.TabIndex = 17;
            this.gbSave.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(83, 11);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 42);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(6, 11);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(78, 42);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Phone Spec:";
            // 
            // txtSpec
            // 
            this.txtSpec.Location = new System.Drawing.Point(216, 129);
            this.txtSpec.Multiline = true;
            this.txtSpec.Name = "txtSpec";
            this.txtSpec.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSpec.Size = new System.Drawing.Size(195, 60);
            this.txtSpec.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Phone Price (Baht):";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(216, 195);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(195, 20);
            this.txtPrice.TabIndex = 20;
            // 
            // frmPhone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 599);
            this.Controls.Add(this.gbDetail);
            this.Controls.Add(this.gbSave);
            this.Controls.Add(this.gbAdd);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.dg);
            this.Name = "frmPhone";
            this.Text = "Phone";
            this.Load += new System.EventHandler(this.frmPhone_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.gbDetail.ResumeLayout(false);
            this.gbDetail.PerformLayout();
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.gbAdd.ResumeLayout(false);
            this.gbSave.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        

        #endregion

        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.GroupBox gbDetail;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.ComboBox cboSearchType;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnCancelSearch;
        private System.Windows.Forms.GroupBox gbAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label Phone_IDLabel;
        private System.Windows.Forms.Label Phone_BrandLabel;
        private System.Windows.Forms.Label Phone_ModelLabel;
        private System.Windows.Forms.Label Phone_ColorLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSpec;
    }
}