namespace PhoneShop
{
    partial class frmInvoice
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
            this.cboOrderID = new System.Windows.Forms.ComboBox();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOrderDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmployee = new System.Windows.Forms.TextBox();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.gbAdd = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbSave = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbHeader = new System.Windows.Forms.GroupBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbInvoiceDetail = new System.Windows.Forms.GroupBox();
            this.cboInvoiceBy = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtInvoiceBy = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.txtCash = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.gbDetail.SuspendLayout();
            this.gbAdd.SuspendLayout();
            this.gbSave.SuspendLayout();
            this.gbHeader.SuspendLayout();
            this.gbInvoiceDetail.SuspendLayout();
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
            this.Phone_BrandLabel.Size = new System.Drawing.Size(41, 13);
            this.Phone_BrandLabel.TabIndex = 11;
            this.Phone_BrandLabel.Text = "Phone:";
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
            this.gbDetail.Controls.Add(this.cboOrderID);
            this.gbDetail.Controls.Add(this.txtOrderID);
            this.gbDetail.Controls.Add(this.label6);
            this.gbDetail.Controls.Add(this.txtQty);
            this.gbDetail.Controls.Add(this.label5);
            this.gbDetail.Controls.Add(this.txtOrderDate);
            this.gbDetail.Controls.Add(this.label4);
            this.gbDetail.Controls.Add(this.label3);
            this.gbDetail.Controls.Add(this.Phone_IDLabel);
            this.gbDetail.Controls.Add(this.Phone_BrandLabel);
            this.gbDetail.Controls.Add(this.txtEmployee);
            this.gbDetail.Controls.Add(this.txtCustomer);
            this.gbDetail.Controls.Add(this.txtPhone);
            this.gbDetail.Location = new System.Drawing.Point(156, 258);
            this.gbDetail.Name = "gbDetail";
            this.gbDetail.Size = new System.Drawing.Size(525, 153);
            this.gbDetail.TabIndex = 13;
            this.gbDetail.TabStop = false;
            this.gbDetail.Text = "Order Detail";
            // 
            // cboOrderID
            // 
            this.cboOrderID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrderID.FormattingEnabled = true;
            this.cboOrderID.Location = new System.Drawing.Point(176, 23);
            this.cboOrderID.Name = "cboOrderID";
            this.cboOrderID.Size = new System.Drawing.Size(76, 21);
            this.cboOrderID.TabIndex = 42;
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(176, 24);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(76, 20);
            this.txtOrderID.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Qty (Pcs):";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(176, 125);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(76, 20);
            this.txtQty.TabIndex = 31;
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
            // txtOrderDate
            // 
            this.txtOrderDate.Location = new System.Drawing.Point(362, 24);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.Size = new System.Drawing.Size(76, 20);
            this.txtOrderDate.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Receive Order by:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Customer:";
            // 
            // txtEmployee
            // 
            this.txtEmployee.Location = new System.Drawing.Point(176, 101);
            this.txtEmployee.Name = "txtEmployee";
            this.txtEmployee.Size = new System.Drawing.Size(262, 20);
            this.txtEmployee.TabIndex = 27;
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(176, 74);
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
            this.gbAdd.Controls.Add(this.btnAdd);
            this.gbAdd.Location = new System.Drawing.Point(346, 541);
            this.gbAdd.Name = "gbAdd";
            this.gbAdd.Size = new System.Drawing.Size(166, 57);
            this.gbAdd.TabIndex = 16;
            this.gbAdd.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(82, 11);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(78, 42);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(5, 11);
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
            this.gbSave.Location = new System.Drawing.Point(514, 541);
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
            // gbHeader
            // 
            this.gbHeader.Controls.Add(this.txtID);
            this.gbHeader.Controls.Add(this.label1);
            this.gbHeader.Controls.Add(this.txtDate);
            this.gbHeader.Controls.Add(this.label2);
            this.gbHeader.Location = new System.Drawing.Point(156, 209);
            this.gbHeader.Name = "gbHeader";
            this.gbHeader.Size = new System.Drawing.Size(526, 48);
            this.gbHeader.TabIndex = 18;
            this.gbHeader.TabStop = false;
            this.gbHeader.Text = "Invoice Header";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(177, 20);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(76, 20);
            this.txtID.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Invoice Date:";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(362, 20);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(76, 20);
            this.txtDate.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Invoice ID:";
            // 
            // gbInvoiceDetail
            // 
            this.gbInvoiceDetail.Controls.Add(this.cboInvoiceBy);
            this.gbInvoiceDetail.Controls.Add(this.label10);
            this.gbInvoiceDetail.Controls.Add(this.txtInvoiceBy);
            this.gbInvoiceDetail.Controls.Add(this.label7);
            this.gbInvoiceDetail.Controls.Add(this.txtTotalPrice);
            this.gbInvoiceDetail.Controls.Add(this.txtCash);
            this.gbInvoiceDetail.Controls.Add(this.label8);
            this.gbInvoiceDetail.Controls.Add(this.txtChange);
            this.gbInvoiceDetail.Controls.Add(this.label9);
            this.gbInvoiceDetail.Location = new System.Drawing.Point(155, 414);
            this.gbInvoiceDetail.Name = "gbInvoiceDetail";
            this.gbInvoiceDetail.Size = new System.Drawing.Size(526, 127);
            this.gbInvoiceDetail.TabIndex = 19;
            this.gbInvoiceDetail.TabStop = false;
            this.gbInvoiceDetail.Text = "Invoice Detail";
            // 
            // cboInvoiceBy
            // 
            this.cboInvoiceBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboInvoiceBy.FormattingEnabled = true;
            this.cboInvoiceBy.Location = new System.Drawing.Point(177, 18);
            this.cboInvoiceBy.Name = "cboInvoiceBy";
            this.cboInvoiceBy.Size = new System.Drawing.Size(262, 21);
            this.cboInvoiceBy.TabIndex = 46;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(74, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 44;
            this.label10.Text = "Invoice by:";
            // 
            // txtInvoiceBy
            // 
            this.txtInvoiceBy.Location = new System.Drawing.Point(177, 18);
            this.txtInvoiceBy.Name = "txtInvoiceBy";
            this.txtInvoiceBy.Size = new System.Drawing.Size(262, 20);
            this.txtInvoiceBy.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Total Price (Baht):";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(177, 45);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(76, 20);
            this.txtTotalPrice.TabIndex = 43;
            // 
            // txtCash
            // 
            this.txtCash.Location = new System.Drawing.Point(177, 71);
            this.txtCash.Name = "txtCash";
            this.txtCash.Size = new System.Drawing.Size(76, 20);
            this.txtCash.TabIndex = 38;
            this.txtCash.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCash_KeyUp);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(74, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Change (Baht):";
            // 
            // txtChange
            // 
            this.txtChange.Location = new System.Drawing.Point(177, 97);
            this.txtChange.Name = "txtChange";
            this.txtChange.Size = new System.Drawing.Size(76, 20);
            this.txtChange.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(75, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Cash (Baht):";
            // 
            // frmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 673);
            this.Controls.Add(this.gbInvoiceDetail);
            this.Controls.Add(this.gbHeader);
            this.Controls.Add(this.gbDetail);
            this.Controls.Add(this.gbSave);
            this.Controls.Add(this.gbAdd);
            this.Controls.Add(this.dg);
            this.Name = "frmInvoice";
            this.Text = "Invoice";
            this.Load += new System.EventHandler(this.frmInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.gbDetail.ResumeLayout(false);
            this.gbDetail.PerformLayout();
            this.gbAdd.ResumeLayout(false);
            this.gbSave.ResumeLayout(false);
            this.gbHeader.ResumeLayout(false);
            this.gbHeader.PerformLayout();
            this.gbInvoiceDetail.ResumeLayout(false);
            this.gbInvoiceDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        

        #endregion

        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.GroupBox gbDetail;
        private System.Windows.Forms.GroupBox gbAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label Phone_IDLabel;
        private System.Windows.Forms.Label Phone_BrandLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmployee;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOrderDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.GroupBox gbHeader;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbInvoiceDetail;
        private System.Windows.Forms.TextBox txtCash;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboOrderID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.ComboBox cboInvoiceBy;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtInvoiceBy;
    }
}