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
    public partial class frmEmployee : Form
    {
       MySqlConnection conn = new MySqlConnection(Settings.Default.salephoneConnectionString);
       DataSet ds = new DataSet() ;
       MySqlDataAdapter da= new MySqlDataAdapter();
       DataTable dt = new DataTable();
       CurrencyManager cm;
       string currID;


        public frmEmployee()
        {
            InitializeComponent();
        }

      

        private void frmEmployee_Load(object sender, EventArgs e)
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
            da.SelectCommand = new MySqlCommand("select * from Employee", conn);
            try
            {
                da.Fill(ds, "Employee");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //-------------add datatable
            dt = ds.Tables["Employee"];
            dt.DefaultView.Sort = "Employee_ID";

            //-------------binding control
            cm = (CurrencyManager)this.BindingContext[dt];
            dg.DataSource = dt;
            txtID.DataBindings.Add("Text", dt, "Employee_ID");
            txtName.DataBindings.Add("Text", dt, "Employee_Name");
            txtTel.DataBindings.Add("Text", dt, "Employee_Tel");
            txtAddress.DataBindings.Add("Text", dt, "Employee_Address");


            //-------------set default control properties
            cboSearchType.SelectedIndex = 0;

             try
            {
                var _with1 = (DataGridView)dg;
                        

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

             btnSearch.Visible = true;
             btnCancelSearch.Visible = false;

             PrepareView();

             txtID.ReadOnly = true;
             txtID.BackColor = Color.PapayaWhip;
             txtID.TabStop = false;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            switch (cboSearchType.Text)
            {
                case "Employee_ID":
                    dt.DefaultView.RowFilter = string.Format("{0}={1}", cboSearchType.Text, txtSearch.Text);
                    break;
                default:  
                    dt.DefaultView.RowFilter = string.Format("{0} like '%{1}%'", cboSearchType.Text, txtSearch.Text);
                    break;
            }

            dg.ClearSelection();
            btnSearch.Visible = false;
            btnCancelSearch.Visible = true;
            cboSearchType.Enabled = false;
            cboSearchType.BackColor = Color.PapayaWhip;
            txtSearch.ReadOnly = true   ;
            txtSearch.BackColor = Color.PapayaWhip; // ให้ background เป็นสีส้ม
        }

        private void btnCancelSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            btnSearch.Visible = true;
            btnCancelSearch.Visible = false;
            dt.DefaultView.RowFilter = "";

            gbAdd.Enabled = true;

            cboSearchType.Enabled = true;
            cboSearchType.BackColor = Color.White;
            txtSearch.ReadOnly = false;
         
            txtSearch.BackColor = Color.White;
            //และให้ background เป็นสีขาว
            txtSearch.Focus();

            cm.Position = dt.DefaultView.Find(currID);
        }

        private void dg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                currID = dg.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                cm.CancelCurrentEdit();
                btnCancelSearch_Click(this, null);
            }


        }

        void cm_PositionChanged(object sender, System.EventArgs e)
        {
            
        }

        private void PrepareView()
        {
            Control gb = gbDetail;


            foreach (Control control in gb.Controls)
            {
                if (control is TextBox && control.Name.ToLower() != "txtid")
                {
                    control.BackColor = Color.PapayaWhip;
                    ((TextBox)control).ReadOnly = true;


                }
                else if (control is Button)
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
            }
            gbSave.Enabled = false;
            gbAdd.Enabled = true ;
            
        }

        private void PrepareEdit()
        {
            Control gb = gbDetail;


            foreach (Control control in gb.Controls)
            {
                if (control is TextBox && control.Name.ToLower() != "txtid")
                {
                    control.BackColor = Color.White;
                    ((TextBox)control).ReadOnly = false;


                }
                else if (control is Button)
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
            }

            gbSave.Enabled = true;
            gbAdd.Enabled = false;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PrepareEdit();
            cm.AddNew();
            txtID.Text = cm.Count.ToString();
            //txtID.Text = (dg.Rows.Count).ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
            PrepareEdit();
            txtName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
               
                cm.EndCurrentEdit();
                MySqlCommandBuilder cb = new MySqlCommandBuilder(da);
                da.Update(dt);
                // debug command generating
               // Console.WriteLine("delete cmd = " + cb.GetDeleteCommand().CommandText);
                //Console.WriteLine("insert cmd = " + cb.GetInsertCommand().CommandText);

                MessageBox.Show("Saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                // fix bug save blank id
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
                    MySqlCommandBuilder cb = new MySqlCommandBuilder(da);
                    da.Update(dt);
                    MessageBox.Show("deleted","Result",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("delete error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
