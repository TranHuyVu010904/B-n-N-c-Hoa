using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nuochoa
{
    public partial class FrmTK : Form
    {
        public FrmTK()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmBill frm = new frmBill();
            frm.ShowDialog();
        }

        private void btnThongkecuahang_Click(object sender, EventArgs e)
        {
            frmStaff frm = new frmStaff();
            frm.ShowDialog();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            frmCustomer frm = new frmCustomer();
            frm.ShowDialog();
        }

        private void btnHoadon_Click(object sender, EventArgs e)
        {
            frmProduct frm = new frmProduct();
            frm.ShowDialog();
        }

        private void btnQuanly_Click(object sender, EventArgs e)
        {
            frmBill frm = new frmBill();
            frm.ShowDialog();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmBill frm = new frmBill();
            frm.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            frmSalary frm = new frmSalary();
            frm.ShowDialog();
        }

        private void btnBaocao_Click(object sender, EventArgs e)
        {
        
            frmCustomer frm = new frmCustomer();
            frm.ShowDialog();
            
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStaff frm = new frmStaff();
            frm.ShowDialog();
            frm = null;
            this.Show();
        }

        private void btnQlnhanvien_Click(object sender, EventArgs e)
        {
            this.Hide();    
            frmProduct frm = new frmProduct();
            frm.ShowDialog();
            frm = null;
            this.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();    
            frmProduct frm = new frmProduct();
            frm.ShowDialog();
            frm = null;
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void btnOffStaff_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblCnhoadonbanhang_Click(object sender, EventArgs e)
        {
        }

        private void lblCnthongke_Click(object sender, EventArgs e)
        {
        }

        private void lblCnkhohang_Click(object sender, EventArgs e)
        {
           

        }

        private void label23_Click(object sender, EventArgs e)
        {
        }

        private void btnChuongtrinhsale_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
    }

