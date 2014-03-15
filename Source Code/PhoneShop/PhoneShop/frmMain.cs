using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PhoneShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CloseAllWindows()
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
        
        private void mnuEmployee_Click(object sender, EventArgs e)
        {
            CloseAllWindows();
            frmEmployee f = new frmEmployee { MdiParent = this };
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        private void mnuCustomer_Click(object sender, EventArgs e)
        {
            CloseAllWindows();
            frmCustomer f = new frmCustomer { MdiParent = this };
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        private void mnuPhone_Click(object sender, EventArgs e)
        {
            CloseAllWindows();
            frmPhone f = new frmPhone { MdiParent = this };
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        private void mnuOrder_Click(object sender, EventArgs e)
        {
            CloseAllWindows();
            frmOrder f = new frmOrder { MdiParent = this };
            f.Show();
            f.WindowState = FormWindowState.Maximized;

        }

        private void mnuInvoice_Click(object sender, EventArgs e)
        {
            CloseAllWindows();
            frmInvoice f = new frmInvoice { MdiParent = this };
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

    }
}
