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
    public partial class frmCustomer : Form
    {
       MySqlConnection conn = new MySqlConnection(Settings.Default.salephoneConnectionString); // ตัวแปรสำหรับเชื่อมต่อ mysql database อ้างอิงตาม connectionstring
       DataSet ds = new DataSet() ; //ตัวแปร dataset
       MySqlDataAdapter da= new MySqlDataAdapter(); //ตัวแปร dataAdapter
       DataTable dt = new DataTable();  // ตัวแปร dataTable
       CurrencyManager cm;  //ตัวแปร CurrencyManager สำหรับควบคุมตัวชี้ข้อมูล(Pointer) ที่อยู่ใน Dataset
       string currID; //ตัวแปร string สำหรับเก็บตำแหน่งปัจจุบันที่ CurrencyManager ชี้อยู่


        public frmCustomer()
        {
            InitializeComponent();
        }

      

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            //---------connect database
            try //ฟังก์ชันให้ทดลองเขียนโปรแกรม ถ้าเกิด Error จะเด้งไปทำบรรทัดใต้ Catch
            {
                
                conn.Open();  //สั่งให้เชื่อมต่อกับ database 
            }
            catch (MySqlException ex)  // ตัวแปร ex เก็บข้อมูล Error กรณีเกิด Error 
            {
                MessageBox.Show(ex.Message); // ถ้าเกิด Error ให้แสดงข้อความของ Error นั้น
            }

            //------------fill dataset
            da.SelectCommand = new MySqlCommand("select * from Customer", conn); //เชื่อมต่อได้แล้ว ให้ตัวแปร DataAdapter เรียก SQL Query พื้นฐานเพื่อดึงข้อมูลจาก database มาเก็บไว้ใน DataSet
            try
            {
                da.Fill(ds, "Customer");// ถ้าดึงได้ให้เอามาใส่ DataTable ที่อยู่ใน Dataset ds ตั้งชื่อ DataTable ว่า "Customer"
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // ถ้าเกิด Error ให้แสดงข้อความของ Error นั้น
            }

            //-------------add datatable
            dt = ds.Tables["Customer"];     // ให้ตัวแปร dt แทนการอ้างถึง Datatable ชื่อ "Customer" ที่อยู่ใน DataSet เพื่อให้ง่ายต่อการเขียนโปรแกรมในภายภาคหน้า
            dt.DefaultView.Sort = "Customer_ID"; // ใช้ method DataTable.DefaultView.Sort เพื่อให้เรียงข้อมูลตาม Field "Customer_ID"

            //-------------binding control
            //ทำการ binding เพื่อให้ control ต่าง ๆ ผูกกับ Pointer ใน DataTable เพื่อสะดวกในการให้ control ต่าง ๆ แสดงข้อมูลที่ Pointer กำลังชี้อยู่----------------เป็นเทคนิคเฉพาะของ .NET
            cm = (CurrencyManager)this.BindingContext[dt];   //ทำการ binding CurrencyManager เข้ากับ DataTable
            dg.DataSource = dt; // ทำการ binding DataGridView เข้ากับ DataTable
            txtID.DataBindings.Add("Text", dt, "Customer_ID"); // ทำการ binding TextBox เข้ากับ DataTable
            txtName.DataBindings.Add("Text", dt, "Customer_Name");
            txtTel.DataBindings.Add("Text", dt, "Customer_Tel");
            txtAddress.DataBindings.Add("Text", dt, "Customer_Address");


            //-------------set default control properties
            cboSearchType.SelectedIndex = 0;  //ให้ combobox แสดงข้อมูลลำดับแรก --- ไม่เช่นนั้นจะแสดงช่องว่าง

             try
            {
                var _with1 = (DataGridView)dg;    // ตั้งค่า properties ใน DataGridview
                        

                _with1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing; //ไม่ให้ปรับขนาดเอง
                _with1.RowHeadersWidth = 28; //ตั้งความสูงของ row Header
                _with1.ReadOnly = true; //ไม่ให้แก้ไข ให้อ่านได้อย่างเดียว
                _with1.AllowUserToResizeRows = false;                 //ไม่ให้ผู้ใช้ปรับเปลี่ยนขนาดแถว
                _with1.AllowUserToResizeColumns = false;                //ไม่ให้ผู้ใช้ปรับเปลี่ยน Column
                _with1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;  //เลือก mode การ select ให้เลือกทั้งแถว (แถบไฮไลท์แถว)
                _with1.AllowUserToDeleteRows = false;               //ไม่ให้ลบแถวได้โดยการกดปุ่ม delete ที่คีย์บอร์ด
                _with1.AllowUserToAddRows = false;                //ไม่ให้เพิ่มแถวได้
                _with1.MultiSelect = false;                //ให้เลือกสีได้ทีละแถวเท่านั้น
                _with1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(224, 224, 224);         //สีพื้นหลังของแถวที่เป็นเลขคู่
                _with1.RowsDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);              //สีพื้นหลังของแถวที่เป็นเลขคี่
                _with1.GridColor = Color.Black;                //สีเส้น
                _with1.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular); // ตั้งค่า Font,ขนาด,ความหนา/เอียง
                _with1.DefaultCellStyle.ForeColor = Color.Black; // ตั้งค่าสี Font
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

             btnSearch.Visible = true;          //แสดง btnSearch ให้เห็น
             btnCancelSearch.Visible = false;   //ซ่อน btnCancelSearch

             PrepareView();                 // เรียกฟังก์ชัน PrepareView
                
             txtID.ReadOnly = true;         // ให้ txtID อ่านได้อย่างเดียวห้ามแก้ไข
             txtID.BackColor = Color.PapayaWhip;    // เปลียนสีพื้น txtID
             txtID.TabStop = false; // ไม่ต้องให้ tab หยุด

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            switch (cboSearchType.Text)             // ตรวจสอบเงื่อนไข cboSearchType.Text
            {
                case "Customer_ID":     // ถ้าเป็น "Customer_ID"
                    dt.DefaultView.RowFilter = string.Format("{0}={1}", cboSearchType.Text, txtSearch.Text); //ใช้ Method DataTable.DefaultView.RowFilter เพื่อกรองข้อมูล ให้แสดงเงื่อนไข "ชื่อฟิลด์=ค่าที่ต้องค้นเป็นตัวเลข"
                    break;
                default:  
                    dt.DefaultView.RowFilter = string.Format("{0} like '%{1}%'", cboSearchType.Text, txtSearch.Text);//ใช้ Method DataTable.DefaultView.RowFilter เพื่อกรองข้อมูล ให้แสดงเงื่อนไข "ชื่อฟิลด์=ข้อความที่อยู่ตำแหน่งใดตำแหน่งหนึ่งในค่าของฟิลด์ที่เลือก"
                    break;
            }

            dg.ClearSelection(); //ยกเลิกการเลือกแถว
            btnSearch.Visible = false; // :ซ่อน btnSearch
            btnCancelSearch.Visible = true;
            cboSearchType.Enabled = false;
            cboSearchType.BackColor = Color.PapayaWhip;
            txtSearch.ReadOnly = true   ;
            txtSearch.BackColor = Color.PapayaWhip; // ให้ background เป็นสีส้ม
        }

        private void btnCancelSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();  // ล้างค่าในช่อง txtSearch
            btnSearch.Visible = true;
            btnCancelSearch.Visible = false;
            dt.DefaultView.RowFilter = "";      // ล้างค่าการกรองข้อมูลเพื่อให้แสดงข้อมูลทั้งหมด

            gbAdd.Enabled = true;       //ยกเลิกการล็อค Groupbox gbAdd

            cboSearchType.Enabled = true;
            cboSearchType.BackColor = Color.White;
            txtSearch.ReadOnly = false;
         
            txtSearch.BackColor = Color.White;
            //และให้ background เป็นสีขาว
            txtSearch.Focus();      //ให้ cursor ไปเริ่มที่ txtSearch

            cm.Position = dt.DefaultView.Find(currID);          //ให้ตำแหน่ง Pointer ของ CurrencyManager ชี้ไปที่ตำแหน่งที่ currID
        }

        private void dg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)            // ถ้าไมได้คลิ้กแถวลำดับที่ 0 (หัวตารางนั่นเอง)
            {
                currID = dg.Rows[e.RowIndex].Cells[0].FormattedValue.ToString(); //ให้ currID เก็บค่าของแถว เพื่อใช้เป็นการระบุตำแหน่งให้ Pointer
                cm.CancelCurrentEdit();  // ยกเลิกการแก้ไขข้อมูล
                btnCancelSearch_Click(this, null);  //เรียกฟังก์ชัน btnCancelSearch_Click() พารามิเตอร์ this กับ null ใช้ตามที่ google บอก
            }


        }

        void cm_PositionChanged(object sender, System.EventArgs e)
        {
            
        }

        private void PrepareView()
        {
            //จะสั่งให้ Textbox ทุกตัวที่อยู่ใน Groupbox ชื่อ gb ยกเว้น txtid ตั้งค่าเป็น ReadOnly และพื้นหลังสีส้ม ขี้เกียจเขียนทีละบรรทัด เลยวน loop foreach control เอา
            Control gb = gbDetail; 


            foreach (Control control in gb.Controls) //ให้วน loop ไปหา control ทุกตัวที่อยู่ใน gb
            {
                if (control is TextBox && control.Name.ToLower() != "txtid") //ถ้า control เป็น textbox และชื่อที่ปรับเป็นตัวเล็กหมดไม่ได้ชื่อว่า "txtid"
                {
                    control.BackColor = Color.PapayaWhip;   //เปลี่ยนสีพื้นหลัง
                    ((TextBox)control).ReadOnly = true;     //ให้อ่านได้อย่างเดียว


                }
                else if (control is Button) // แต่ถ้า control เป็น Button
                {
                    if (control.Name.ToLower() == ("btnsave") || control.Name.ToLower() == ("btncancel")) //ถ้าชื่อที่ปรับตัวอักษรเป็นตัวเล็กหมดแล้ว เป็น btnsave หรือ btncancel 
                    {
                        control.Visible = false;        //ให้ซ่อนซะ
                    }
                    else //ถ้าไม่ใช่
                    {
                        control.Visible = true;     //ให้แสดง
                    }
                }
            }
            gbSave.Enabled = false;     // ล็อก gbSave
            gbAdd.Enabled = true ;      // ปลดล็อค gbAdd
            
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
            PrepareEdit(); // เรียกฟังก์ชัน PrepareEdit
            cm.AddNew();        // สั่ง Currency Manager.AddNew ให้สร้างแถวข้อมูลใหม่ใน DataTable จะเห็นว่า control จะเกิดข้อความว่าง ๆ เกิดขึ้น
            txtID.Text = cm.Count.ToString(); // ให้ txtID.Text แสดงค่าจำนวนรายการ (row) ใน DataTable ทำเหมือน เป็น autorunning number
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
               
                cm.EndCurrentEdit();  //สั่งให้จบการแก้ไข
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
