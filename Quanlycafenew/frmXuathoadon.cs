using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Quanlycafenew
{
    public partial class frmXuathoadon : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-46AV8RF4\SQLEXPRESS;Initial Catalog=QLCoffee;Integrated Security=True");
        SqlCommand command;
        SqlDataAdapter da;
        DataTable dt;
        public frmXuathoadon()
        {
            InitializeComponent();
        }
        //Tổng =Số lượng nhân đơn giá
        public void DisplayData()
        {
            da = new SqlDataAdapter("select dbo.tbSanpham.TenSP, dbo.tbHoadon.Dongia, dbo.tbHoadon.SoLuong, dbo.tbHoadon.SoLuong*dbo.tbHoadon.Dongia as 'Thanh Tien' from dbo.tbHoadon, dbo.tbSanpham where tbHoadon.IDSanpham = tbSanpham.IDSanpham", conn);
            dt = new DataTable();
            da.Fill(dt);
            dgvOrder.DataSource = dt;
        
        }      
        //Chỉ cho phép nhập số
        private void txtExchange_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void txtGive_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void cbIDStaff_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void txtIDBill_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        public void setdefault()
        {

            foreach (Control ctr in this.Controls)
            {
                if (ctr is TextBox)
                {
                    TextBox txt = (TextBox)ctr;
                    txt.Text = "";
                }
                else
                {
                    if (ctr is ComboBox)
                    {
                        ComboBox cb = (ComboBox)ctr;
                        cb.SelectedValue = -1;
                    }
                    else
                    {
                        if (ctr is DateTimePicker)
                        {
                            DateTimePicker dtp = (DateTimePicker)ctr;
                            dtp.Value = DateTime.Now;
                        }
                    }
                }
            }
        }
        //Đưa ra hóa đơn
        private void btnShowBill_Click(object sender, EventArgs e)
        {
            frmHoadon frm = new frmHoadon(txtIDBill.Text, txtTotal.Text, txtGive.Text, txtExchange.Text,cbStaff.Text,dtpDay.Text);
            frm.ShowDialog();

        }
        public void DisplayEmployees()
        {
            da = new SqlDataAdapter("select * from dbo.tbNhanvien", conn);
            dt = new DataTable();
            da.Fill(dt);
            cbStaff.DataSource = dt;
            cbStaff.DisplayMember= "TenNV";
            cbStaff.ValueMember = "ID";
        }

        private void frmXuathoadon_Load(object sender, EventArgs e)
        {
            DisplayData();
            DisplayEmployees();
            
            da = new SqlDataAdapter("select * from dbo.tbHoadon", conn);
            dt = new DataTable();
            da.Fill(dt);
            txtIDBill.Text = dt.Rows[0][0].ToString();
            
            da = new SqlDataAdapter("SELECT Convert(varchar, cast(SUM(Dongia * SoLuong) as money), 1) FROM dbo.tbHoadon", conn);
            dt = new DataTable();
            da.Fill(dt);
            txtTotal.Text = dt.Rows[0][0].ToString();

            cbSurcharge.Items.Add("Ban Ngày");
            cbSurcharge.Items.Add("Ban Đêm");
        }
        //Nếu là ban đêm thì số tiền sẻ được tính thêm 10000 vào tong tien 
        private void btnShowExchange_Click(object sender, EventArgs e)
        {          
            if (cbSurcharge.SelectedItem == "Ban Đêm")
            {      
                da = new SqlDataAdapter("SELECT Convert(varchar, cast('" + Convert.ToInt32(txtGive.Text) + "' - (SUM(Dongia * SoLuong) + 10000) as money), 1)  FROM dbo.tbHoadon", conn);
            }
            else
            {
                da = new SqlDataAdapter("SELECT Convert(varchar, cast('" + Convert.ToInt32(txtGive.Text) + "' - SUM(Dongia * SoLuong) as money), 1)  FROM dbo.tbHoadon", conn);
            }
            
            dt = new DataTable();
            da.Fill(dt);
            txtExchange.Text = dt.Rows[0][0].ToString();
        }

        private void cbSurcharge_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbSurcharge.SelectedItem == "Ban Đêm")
            {
                da = new SqlDataAdapter("SELECT Convert(varchar, cast(SUM(Dongia * SoLuong)+10000 as money), 1)  FROM dbo.tbHoadon", conn);
            }
            else
            {
                da = new SqlDataAdapter("SELECT Convert(varchar, cast(SUM(Dongia * SoLuong) as money), 1)  FROM dbo.tbHoadon", conn);
            }
            dt = new DataTable();
            da.Fill(dt);
            txtTotal.Text = dt.Rows[0][0].ToString();
        }
        //kết nối và show với các form 
        private void btnNhanvien_Click(object sender, EventArgs e)
        {
            frmQuanlynhanvien f2 = new frmQuanlynhanvien();
            f2.ShowDialog();
        }

        private void btnKhachhang_Click(object sender, EventArgs e)
        {
            frmQuanlykhachhang frm = new frmQuanlykhachhang();
            frm.ShowDialog();
        }

        private void btnSanpham_Click(object sender, EventArgs e)
        {
            frmQuanlysanpham frm = new frmQuanlysanpham();
            frm.ShowDialog();
        }

        private void btnBacklogin_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
        }

        private void btnDoanhthu_Click(object sender, EventArgs e)
        {
            frmBaocao f = new frmBaocao();
            f.ShowDialog();
        }
        //nut close 
        private void pbDong_Click(object sender, EventArgs e)
        {
            frmmain frm = new frmmain();
            this.Close();
        }
        //nut thu nho
        private void pbThunho_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //Khi click vào logo sẻ ra from main

        private void pbLogo_Click(object sender, EventArgs e)
        {
            frmmain f = new frmmain();
            f.ShowDialog();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cbSurcharge_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
