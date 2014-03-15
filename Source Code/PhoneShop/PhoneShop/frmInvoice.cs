using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PhoneShop.Properties;
using MySql.Data.MySqlClient;



namespace PhoneShop
{
    public partial class frmInvoice : Form
    {
        MySqlConnection conn = new MySqlConnection(Settings.Default.salephoneConnectionString);
        DataSet ds = new DataSet() ;

        MySqlDataAdapter daInvoice = new MySqlDataAdapter();
        MySqlDataAdapter daOrder= new MySqlDataAdapter();
        MySqlDataAdapter daPhone = new MySqlDataAdapter();
        MySqlDataAdapter daEmployee = new MySqlDataAdapter();
        MySqlDataAdapter daCustomer = new MySqlDataAdapter();

        DataTable dtInvoice = new DataTable();
        DataTable dtOrder = new DataTable();
        DataTable dtPhone = new DataTable();
        DataTable dtEmployee = new DataTable();
        DataTable dtCustomer = new DataTable();

        CurrencyManager cm,cmOrder;
        string currID;


        public frmInvoice()
        {
            InitializeComponent();
        }

      

        private void frmInvoice_Load(object sender, EventArgs e)
        {

          
            
            //---------connect database
            try
            {
                
                conn.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            //------------fill dataset
            daInvoice.SelectCommand = new MySqlCommand("select * from Invoice", conn);
            daOrder.SelectCommand = new MySqlCommand("select * from Orders", conn);
            daPhone.SelectCommand = new MySqlCommand("SELECT *,CONCAT_WS(' ',Phone_Brand,Phone_Model) AS Phone_Info FROM `phone`", conn);
            daCustomer.SelectCommand = new MySqlCommand("select * from Customer", conn);
            daEmployee.SelectCommand = new MySqlCommand("select * from Employee", conn);
            try
            {
                daInvoice.Fill(ds, "Invoice");
                daOrder.Fill(ds, "Orders");
                daPhone.Fill(ds,"Phone");
                daCustomer.Fill(ds,"Customer");
                daEmployee.Fill(ds,"Employee");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //-------------add datatable
            dtInvoice = ds.Tables["Invoice"];
            dtInvoice.DefaultView.Sort = "Order_ID";

            dtOrder = ds.Tables["Orders"];
            

            dtPhone = ds.Tables["Phone"];
            dtCustomer = ds.Tables["Customer"];
            dtEmployee = ds.Tables["Employee"];

            dtInvoice.PrimaryKey = new DataColumn[] { dtInvoice.Columns["Invoice_ID"] };
            
            //-------------make relation
            try
            {
                ds.Relations.Add(new DataRelation("EmpInvoice", dtEmployee.Columns["Employee_ID"], dtInvoice.Columns["Employee_ID"]));
                ds.Relations.Add(new DataRelation("OrderInvoice", dtOrder.Columns["Order_ID"], dtInvoice.Columns["Invoice_ID"]));

                ds.Relations.Add(new DataRelation("PhoneOrder", dtPhone.Columns["Phone_ID"], dtOrder.Columns["Phone_ID"]));
                ds.Relations.Add(new DataRelation("CusOrder", dtCustomer.Columns["Customer_ID"], dtOrder.Columns["Customer_ID"]));
                ds.Relations.Add(new DataRelation("EmpOrder", dtEmployee.Columns["Employee_ID"], dtOrder.Columns["Employee_ID"]));
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //-------------add child datacolumn
            try
            {
                dtOrder.Columns.Add(new DataColumn("Phone_Info", typeof(String), "Parent(PhoneOrder).Phone_Info"));
                dtOrder.Columns.Add(new DataColumn("Phone_Price", typeof(Decimal), "Parent(PhoneOrder).Phone_Price"));
                dtOrder.Columns.Add(new DataColumn("Total_Price", typeof(Decimal), "Phone_Price * Quantity"));

                dtOrder.Columns.Add(new DataColumn("Customer_Name", typeof(String), "Parent(CusOrder).Customer_Name"));
                dtOrder.Columns.Add(new DataColumn("Employee_Receive", typeof(String), "Parent(EmpOrder).Employee_Name"));

                dtInvoice.Columns.Add(new DataColumn("Phone_Info", typeof(String), "Parent(OrderInvoice).Phone_Info"));
                dtInvoice.Columns.Add(new DataColumn("Quantity", typeof(decimal), "Parent(OrderInvoice).Quantity"));
                dtInvoice.Columns.Add(new DataColumn("Total_Price", typeof(decimal), "Parent(OrderInvoice).Total_Price"));
                dtInvoice.Columns.Add(new DataColumn("Employee_Invoice", typeof(String), "Parent(EmpInvoice).Employee_Name"));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
            
            //-------------binding control
            cm = (CurrencyManager)this.BindingContext[dtInvoice];
           // cm.PositionChanged += new EventHandler(cm_PositionChanged);

            cmOrder = (CurrencyManager)this.BindingContext[dtOrder];

            dg.DataSource = dtInvoice;

            //dataGridView1.DataSource = dtOrder;
           

            txtID.DataBindings.Add("Text", dtInvoice, "Invoice_ID");
            txtDate.DataBindings.Add("Text", dtInvoice, "Invoice_Date", true, DataSourceUpdateMode.OnValidation, null, "dd/MM/yyyy");
            txtInvoiceBy.DataBindings.Add("Text", dtInvoice, "Employee_Invoice");

            txtOrderID.DataBindings.Add("Text", dtOrder, "Order_ID");
            txtOrderDate.DataBindings.Add("Text", dtOrder, "Order_Date",true,DataSourceUpdateMode.OnValidation,null,"dd/MM/yyyy");
            txtPhone.DataBindings.Add("Text", dtOrder, "Phone_Info");
            txtCustomer.DataBindings.Add("Text", dtOrder, "Customer_Name");
            txtEmployee.DataBindings.Add("Text", dtOrder, "Employee_Receive");
            txtQty .DataBindings.Add("Text", dtOrder, "Quantity");
            txtTotalPrice.DataBindings.Add("Text", dtOrder, "Total_Price", false, DataSourceUpdateMode.OnValidation, "");

            cboOrderID.DataSource = dtOrder;
            cboOrderID.DisplayMember = "Order_ID";
            cboOrderID.ValueMember = "Order_ID";

            cboInvoiceBy.DataSource = dtEmployee;
            cboInvoiceBy.DisplayMember = "Employee_Name";
            cboInvoiceBy.ValueMember = "Employee_ID";

            cboOrderID.DataBindings.Add("Text", dtInvoice, "Order_ID");
            cboOrderID.DataBindings.Add("SelectedValue", dtInvoice, "Order_ID");

            cboInvoiceBy.DataBindings.Add("Text", dtInvoice, "Employee_Invoice");
            cboInvoiceBy.DataBindings.Add("SelectedValue", dtInvoice, "Employee_ID");


            //-------------set default control properties
           

             try
            {
                var _with1 = (DataGridView)dg;

                _with1.Columns["Employee_ID"].Visible = false;
                //_with1.Columns["Phone_ID"].Visible = false;
                //_with1.Columns["Customer_ID"].Visible = false;
                //_with1.Columns["Quantity"].Visible = false;
                //_with1.Columns["Phone_Price"].Visible = false;

                //_with1.Columns["Invoice_ID"].DisplayIndex = 0;
                //_with1.Columns["Order_Date"].DisplayIndex = 1;
                //_with1.Columns["Phone_Info"].DisplayIndex = 2;
                //_with1.Columns["Customer_Name"].DisplayIndex = 3;
                //_with1.Columns["Total_Price"].DisplayIndex = 4;
                //_with1.Columns["Employee_ID"].DisplayIndex = 5;



                _with1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
                _with1.RowHeadersWidth = 28;
                _with1.ReadOnly = true;
                _with1.AllowUserToResizeRows = false;
                //ไม่ให้ผู้ใช้ปรับเปลี่ยนขนาดแถว
                _with1.AllowUserToResizeColumns = false;
                //ไม่ให้ผู้ใช้ปรับเปลี่ยน Column
                _with1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                //เลือก mode การ select ให้เลือกทั้งแถว (แถบไฮไลท์แถว)
                _with1.AllowUserToDeleteRows = false;
                //ไม่ให้ลบแถวได้โดยการกดปุ่ม delete ที่คีย์บอร์ด
                _with1.AllowUserToAddRows = false;
                //ไม่ให้เพิ่มแถวได้
                _with1.MultiSelect = false;
                //ให้เลือกสีได้ทีละแถวเท่านั้น
                _with1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(224, 224, 224);
                //สีพื้นหลังของแถวที่เป็นเลขคู่
                _with1.RowsDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
                //สีพื้นหลังของแถวที่เป็นเลขคี่
                _with1.GridColor = Color.Black;
                //สีเส้น
                _with1.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular);
                _with1.DefaultCellStyle.ForeColor = Color.Black;
          //      using (Font font = new Font(
          //_with1.DefaultCellStyle.Font.FontFamily, 25, FontStyle.Regular))
          //      {
          //          //dataGridView1.Columns["Rating"].DefaultCellStyle.Font = font;
          //      }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in PrepareList\n" + ex.Message);
            }

             
            PrepareView();

            txtID.ReadOnly = true;
            txtID.BackColor = Color.PapayaWhip;
            txtID.TabStop = false;

            txtDate.ReadOnly = true;
            txtDate.BackColor = Color.PapayaWhip;
            txtDate.TabStop = false;

            foreach (Control control in gbInvoiceDetail.Controls)
            {
                if (control is TextBox && control.Name.ToLower() != "txtcash")
                {
                    ((TextBox)control).ReadOnly = true;
                    control.BackColor = Color.PapayaWhip;
                    control.TabStop = false;
                }
            }

            foreach (Control control in gbDetail.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).ReadOnly = true;
                    control.BackColor = Color.PapayaWhip;
                    control.TabStop = false;
                }
            }

        }

       

        

        private void dg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                currID = dg.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                cm.CancelCurrentEdit();
                
            }


        }


        private void PrepareView()
        {


            txtCash.Clear();
            txtCash.ReadOnly = true; 
            txtCash.BackColor = Color.PapayaWhip;

            txtChange.Clear();

            cboOrderID.Visible = false;
            cboInvoiceBy.Visible = false;


            dtOrder.DefaultView.RowFilter="";

            gbSave.Enabled = false;
            gbAdd.Enabled = true ;

        }

        private void PrepareEdit()
        {
            Control gb = gbDetail;


            txtCash.ReadOnly = false;
            txtCash.BackColor = Color.White;

            cboOrderID.Visible = true ;
            cboInvoiceBy.Visible = true;

           // dtOrder.DefaultView.RowFilter = "Count(Child(OrderInvoice).Invoice_ID) < 1";

            gbSave.Enabled = true;
            gbAdd.Enabled = false;

            cboOrderID.Focus();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PrepareEdit();
            cm.AddNew();
            txtID.Text = cm.Count.ToString();
            txtDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            dtOrder.DefaultView.RowFilter = "Count(Child(OrderInvoice).Invoice_ID) < 1";

            try
            {
                cboOrderID.SelectedIndex = 0;
                cboInvoiceBy.SelectedIndex = 0;
            }
            catch
            {
                MessageBox.Show("Order is Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cm.CancelCurrentEdit();
                PrepareView();
            }
           
        }

       

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
               
                cm.EndCurrentEdit();
                MySqlCommandBuilder cb = new MySqlCommandBuilder(daInvoice);
                daInvoice.Update(dtInvoice);
                //----------------------debug command generating
               // Console.WriteLine("delete cmd = " + cb.GetDeleteCommand().CommandText);
                //Console.WriteLine("insert cmd = " + cb.GetInsertCommand().CommandText);

                MessageBox.Show("Saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                //-----------------fix bug save blank id
                //dg.DataSource = null;
                //dg.DataSource = dt;
                //cm.Position = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error : " + ex.Message);
            }
            finally
            {
                PrepareView();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            PrepareView();
            cm.CancelCurrentEdit();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("confirm to delete?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign) == DialogResult.OK)
            {
                try
                {
                    cm.RemoveAt(cm.Position);
                    cm.EndCurrentEdit();
                    MySqlCommandBuilder cb = new MySqlCommandBuilder(daInvoice);
                    daInvoice.Update(dtInvoice);
                    MessageBox.Show("deleted","Result",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("delete error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtCash_KeyUp(object sender, KeyEventArgs e)
        {

            try
            {
                txtChange.Text = (Convert.ToInt16(txtCash .Text) - Convert.ToDecimal(txtTotalPrice.Text)).ToString();
            }
            catch
            {
                txtTotalPrice.Text = "NaN";
            }

        }
       
     
    }
}
