namespace PhoneShop
{
    partial class frmOrder
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
            this.dg = new System.Windows.Forms.DataGridView();
            this.gbDetail = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.cboEmployee = new System.Windows.Forms.ComboBox();
            this.cboCustomer = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboPhone = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSpec = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtEmployee = new System.Windows.Forms.TextBox();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.gbAdd = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbSave = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.gbDetail.SuspendLayout();
            this.gbAdd.SuspendLayout();
            this.gbSave.SuspendLayout();
            this.SuspendLayout();
            // 
            // Phone_IDLabel
            // 
            this.Phone_IDLabel.AutoSize = true;
            this.Phone_IDLabel.Location = new System.Drawing.Point(73, 27);
            this.Phone_IDLabel.Name = "Phone_IDLabel";
            this.Phone_IDLabel.Size = new System.Drawing.Size(50, 13);
            this.Phone_IDLabel.TabIndex = 9;
            this.Phone_IDLabel.Text = "Order ID:";
            // 
            // Phone_BrandLabel
            // 
            this.Phone_BrandLabel.AutoSize = true;
            this.Phone_BrandLabel.Location = new System.Drawing.Point(73, 53);
            this.Phone_BrandLabel.Name = "Phone_BrandLabel";
            this.Phone_BrandLabel.Size = new System.Drawing.Size(74, 13);
            this.Phone_BrandLabel.TabIndex = 11;
            this.Phone_BrandLabel.Text = "Select Phone:";
            // 
            // dg
            // 
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Location = new System.Drawing.Point(156, 24);
            this.dg.Name = "dg";
            this.dg.Size = new System.Drawing.Size(526, 179);
            this.dg.TabIndex = 1;
            this.dg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellContentClick);
            // 
            // gbDetail
            // 
            this.gbDetail.Controls.Add(this.label7);
            this.gbDetail.Controls.Add(this.txtTotalPrice);
            this.gbDetail.Controls.Add(this.label6);
            this.gbDetail.Controls.Add(this.txtQty);
            this.gbDetail.Controls.Add(this.label5);
            this.gbDetail.Controls.Add(this.txtDate);
            this.gbDetail.Controls.Add(this.cboEmployee);
            this.gbDetail.Controls.Add(this.cboCustomer);
            this.gbDetail.Controls.Add(this.label4);
            this.gbDetail.Controls.Add(this.label3);
            this.gbDetail.Controls.Add(this.cboPhone);
            this.gbDetail.Controls.Add(this.label2);
            this.gbDetail.Controls.Add(this.txtPrice);
            this.gbDetail.Controls.Add(this.label1);
            this.gbDetail.Controls.Add(this.txtSpec);
            this.gbDetail.Controls.Add(this.Phone_IDLabel);
            this.gbDetail.Controls.Add(this.txtID);
            this.gbDetail.Controls.Add(this.Phone_BrandLabel);
            this.gbDetail.Controls.Add(this.txtEmployee);
            this.gbDetail.Controls.Add(this.txtCustomer);
            this.gbDetail.Controls.Add(this.txtPhone);
            this.gbDetail.Location = new System.Drawing.Point(157, 209);
            this.gbDetail.Name = "gbDetail";
            this.gbDetail.Size = new System.Drawing.Size(525, 268);
            this.gbDetail.TabIndex = 13;
            this.gbDetail.TabStop = false;
            this.gbDetail.Text = "Detail";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(266, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Total Price (Baht):";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(362, 167);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(76, 20);
            this.txtTotalPrice.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Qty (Pcs):";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(176, 167);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(76, 20);
            this.txtQty.TabIndex = 31;
            this.txtQty.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtQty_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(293, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Order Date:";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(362, 24);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(76, 20);
            this.txtDate.TabIndex = 29;
            // 
            // cboEmployee
            // 
            this.cboEmployee.FormattingEnabled = true;
            this.cboEmployee.Location = new System.Drawing.Point(176, 219);
            this.cboEmployee.Name = "cboEmployee";
            this.cboEmployee.Size = new System.Drawing.Size(262, 21);
            this.cboEmployee.TabIndex = 26;
            // 
            // cboCustomer
            // 
            this.cboCustomer.FormattingEnabled = true;
            this.cboCustomer.Location = new System.Drawing.Point(176, 193);
            this.cboCustomer.Name = "cboCustomer";
            this.cboCustomer.Size = new System.Drawing.Size(262, 21);
            this.cboCustomer.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Receive Order By:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Select Customer:";
            // 
            // cboPhone
            // 
            this.cboPhone.FormattingEnabled = true;
            this.cboPhone.Location = new System.Drawing.Point(176, 50);
            this.cboPhone.Name = "cboPhone";
            this.cboPhone.Size = new System.Drawing.Size(262, 21);
            this.cboPhone.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Phone Price (Baht):";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(176, 141);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(76, 20);
            this.txtPrice.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Phone Spec:";
            // 
            // txtSpec
            // 
            this.txtSpec.Location = new System.Drawing.Point(176, 75);
            this.txtSpec.Multiline = true;
            this.txtSpec.Name = "txtSpec";
            this.txtSpec.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSpec.Size = new System.Drawing.Size(262, 60);
            this.txtSpec.TabIndex = 18;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(176, 24);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(76, 20);
            this.txtID.TabIndex = 10;
            // 
            // txtEmployee
            // 
            this.txtEmployee.Location = new System.Drawing.Point(176, 220);
            this.txtEmployee.Name = "txtEmployee";
            this.txtEmployee.Size = new System.Drawing.Size(262, 20);
            this.txtEmployee.TabIndex = 27;
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(176, 193);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(262, 20);
            this.txtCustomer.TabIndex = 19;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(176, 49);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(262, 20);
            this.txtPhone.TabIndex = 18;
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
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 599);
            this.Controls.Add(this.gbDetail);
            this.Controls.Add(this.gbSave);
            this.Controls.Add(this.gbAdd);
            this.Controls.Add(this.dg);
            this.Name = "frmOrder";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.frmOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.gbDetail.ResumeLayout(false);
            this.gbDetail.PerformLayout();
            this.gbAdd.ResumeLayout(false);
            this.gbSave.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        

        #endregion

        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.GroupBox gbDetail;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.GroupBox gbAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label Phone_IDLabel;
        private System.Windows.Forms.Label Phone_BrandLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSpec;
        private System.Windows.Forms.ComboBox cboEmployee;
        private System.Windows.Forms.ComboBox cboCustomer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboPhone;
        private System.Windows.Forms.TextBox txtEmployee;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtQty;
    }
}