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
    public partial class frmOrder : Form
    {
        MySqlConnection conn = new MySqlConnection(Settings.Default.salephoneConnectionString);
        DataSet ds = new DataSet() ;
        MySqlDataAdapter daOrder= new MySqlDataAdapter();
        MySqlDataAdapter daPhone = new MySqlDataAdapter();
        MySqlDataAdapter daEmployee = new MySqlDataAdapter();
        MySqlDataAdapter daCustomer = new MySqlDataAdapter();

        DataTable dtOrder = new DataTable();
        DataTable dtPhone = new DataTable();
        DataTable dtEmployee = new DataTable();
        DataTable dtCustomer = new DataTable();

        CurrencyManager cm;
        string currID;


        public frmOrder()
        {
            InitializeComponent();
        }

      

        private void frmOrder_Load(object sender, EventArgs e)
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
            daOrder.SelectCommand = new MySqlCommand("select * from Orders", conn);
            daPhone.SelectCommand = new MySqlCommand("SELECT *,CONCAT_WS(' ',Phone_Brand,Phone_Model) AS Phone_Info FROM `phone`", conn);
            daCustomer.SelectCommand = new MySqlCommand("select * from Customer", conn);
            daEmployee.SelectCommand = new MySqlCommand("select * from Employee", conn);
            try
            {
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
            dtOrder = ds.Tables["Orders"];
            dtOrder.DefaultView.Sort = "Order_ID";

            dtPhone = ds.Tables["Phone"];
            dtCustomer = ds.Tables["Customer"];
            dtEmployee = ds.Tables["Employee"];

            dtOrder.PrimaryKey = new DataColumn[] { dtOrder.Columns["Order_ID"] };
            
            //-------------make relation
            try
            {
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
                dtOrder.Columns.Add(new DataColumn("Employee_Name", typeof(String), "Parent(EmpOrder).Employee_Name"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
            
            //-------------binding control
            cm = (CurrencyManager)this.BindingContext[dtOrder];
            cm.PositionChanged += new EventHandler(cm_PositionChanged);
            //cm.ItemChanged += new ItemChangedEventHandler(cm_ItemChanged);
            
            dg.DataSource = dtOrder;

            
            txtID.DataBindings.Add("Text", dtOrder, "Order_ID");
            txtDate.DataBindings.Add("Text", dtOrder, "Order_Date",true,DataSourceUpdateMode.OnValidation,null,"dd/MM/yyyy");
            txtPhone.DataBindings.Add("Text", dtOrder, "Phone_Info");
            txtCustomer.DataBindings.Add("Text", dtOrder, "Customer_Name");
            txtEmployee.DataBindings.Add("Text", dtOrder, "Employee_Name");
            txtQty .DataBindings.Add("Text", dtOrder, "Quantity");

            txtSpec.DataBindings.Add("Text", dtPhone, "Phone_Spec", true, DataSourceUpdateMode.OnValidation, "");
            txtPrice.DataBindings.Add("Text", dtPhone, "Phone_Price", false, DataSourceUpdateMode.OnValidation, "");

            cboPhone.DataSource = dtPhone;
            cboPhone.DisplayMember = "Phone_Info";
            cboPhone.ValueMember = "Phone_ID";

            cboCustomer.DataSource = dtCustomer;
            cboCustomer.DisplayMember = "Customer_Name";
            cboCustomer.ValueMember = "Customer_ID";

            cboEmployee.DataSource = dtEmployee;

            cboEmployee.DisplayMember = "Employee_Name";
            cboEmployee.ValueMember = "Employee_ID";

            cboPhone.DataBindings.Add("Text", dtOrder, "Phone_Info");
            cboPhone.DataBindings.Add("SelectedValue", dtOrder, "Phone_ID");

            cboCustomer.DataBindings.Add("Text", dtOrder, "Customer_Name");
            cboCustomer.DataBindings.Add("SelectedValue", dtOrder, "Customer_ID");

            cboEmployee.DataBindings.Add("Text", dtOrder, "Employee_Name");
            cboEmployee.DataBindings.Add("SelectedValue", dtOrder, "Employee_ID");


            //-------------set default control properties
           

             try
            {
                var _with1 = (DataGridView)dg;

                _with1.Columns["Employee_ID"].Visible = false;
                _with1.Columns["Phone_ID"].Visible = false;
                _with1.Columns["Customer_ID"].Visible = false;
                _with1.Columns["Quantity"].Visible = false;
                _with1.Columns["Phone_Price"].Visible = false;

                _with1.Columns["Order_ID"].DisplayIndex = 0;
                _with1.Columns["Order_Date"].DisplayIndex = 1;
                _with1.Columns["Phone_Info"].DisplayIndex = 2;
                _with1.Columns["Customer_Name"].DisplayIndex = 3;
                _with1.Columns["Total_Price"].DisplayIndex = 4;
                _with1.Columns["Employee_ID"].DisplayIndex = 5;



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

             foreach (Control control in gbDetail.Controls)
             {
                 if (control is TextBox && control.Name.ToLower() != "txtqty")
                 {
                     ((TextBox)control).ReadOnly = true;
                     control.BackColor = Color.PapayaWhip;
                     control.TabStop = false;
                 }
             }

             cm_PositionChanged(this, null); // fix bug for first TotalPrice Calculation

        }

        //void cm_ItemChanged(object sender, ItemChangedEventArgs e)
        //{
        //   // throw new NotImplementedException();
        //}

        void cm_PositionChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Position Changed"); 
            //throw new NotImplementedException();

            try
            {
                txtTotalPrice.Text = (Convert.ToInt16(txtQty.Text) * Convert.ToDecimal(txtPrice.Text)).ToString();
            }
            catch
            {
                txtTotalPrice.Text = "NaN";
            }

        }

        //void cm_PositionChanged(object sender, EventArgs e)
        //{

        //    try
        //    {
        //        txtTotalPrice.Text = (Convert.ToInt16(txtQty.Text) * Convert.ToDecimal(txtPrice.Text)).ToString();
        //    }
        //    catch
        //    {
        //        txtTotalPrice.Text = "NaN";
        //    }
        //    //throw new NotImplementedException();
        //}

     
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
            Control gb = gbDetail;


            txtQty.ReadOnly = true; 
            txtQty.BackColor = Color.PapayaWhip;
           


            foreach (Control control in gb.Controls)
            {
                
                if (control is Button)
                {
                    if (control.Name.ToLower() == ("btnsave") || control.Name.ToLower() == ("btncancel"))
                    {
                        control.Visible = false;
                    }
                    else
                    {
                        control.Visible = true;
                    }                                                                                                                                                                                                                                                  
                }
                else if (control is ComboBox)
                {
                    control.Visible = false;
                }
            }


            gbSave.Enabled = false;
            gbAdd.Enabled = true ;

            //txtSpec.DataBindings.Clear();
            //txtPrice.DataBindings.Clear();

            //txtSpec.DataBindings.Add("Text", dtOrder, "Phone_Spec", true, DataSourceUpdateMode.OnValidation, "");
            //txtPrice.DataBindings.Add("Text", dtOrder, "Phone_Price", false, DataSourceUpdateMode.OnValidation, "");
            
        }

        private void PrepareEdit()
        {
            Control gb = gbDetail;


            foreach (Control control in gb.Controls)
            {


                txtQty.ReadOnly = false;
                txtQty.BackColor = Color.White;

                if (control is Button)
                {
                    if (control.Name.ToLower() == ("btnsave") || control.Name.ToLower() == ("btncancel"))
                    {
                        control.Visible = true;
                    }
                    else
                    {
                        control.Visible = false;
                    }
                }
                else if (control is ComboBox)
                {
                    control.Visible = true;
                }
            }

            gbSave.Enabled = true;
            gbAdd.Enabled = false;

            cboPhone.Focus();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PrepareEdit();
            cm.AddNew();
            txtID.Text = cm.Count.ToString();
            txtDate.Text = DateTime.Now.ToString("dd/MM/yyyy");

            cboPhone.SelectedIndex = 0;
            cboEmployee.SelectedIndex = 0;
            cboCustomer.SelectedIndex = 0;

            //txtID.Text = (dg.Rows.Count).ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
            PrepareEdit();
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
               
                cm.EndCurrentEdit();
                MySqlCommandBuilder cb = new MySqlCommandBuilder(daOrder);
                daOrder.Update(dtOrder);
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
                    MySqlCommandBuilder cb = new MySqlCommandBuilder(daOrder);
                    daOrder.Update(dtOrder);
                    MessageBox.Show("deleted","Result",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("delete error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
       
        private void txtQty_KeyUp(object sender, KeyEventArgs e)
        {
            cm_PositionChanged(this, null);
        }
    }
}
