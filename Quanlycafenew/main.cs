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
using System.Data.Entity.ModelConfiguration.Conventions;
using Microsoft.Office.Core;

namespace Quanlycafenew
{
    public partial class frmmain : Form
    {
        public frmmain()
        {
            InitializeComponent();

        }

        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-Q2U43A9U;Initial Catalog=qlcf;Integrated Security=True");
        SqlCommand command;
        SqlDataAdapter da;
        DataTable dt;
        int id = 0;
        public void DisplayDrink()
        {
            da = new SqlDataAdapter("select * from tbSanpham", conn);
            dt = new DataTable();
            da.Fill(dt);
            cbProduct.DataSource = dt;
            cbProduct.DisplayMember = "TenSP";
            cbProduct.ValueMember = "ID";
        }
        private void cbProduct_SelectionChangeCommitted(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("select * from tbSanpham where ID ="+cbProduct.SelectedValue, conn);
            dt = new DataTable();
            da.Fill(dt);
            txtIDProduct.Text = dt.Rows[0]["ID"].ToString();
            txtPrice.Text = dt.Rows[0]["Dongia"].ToString();
        }
        
        private void frmmain_Load(object sender, EventArgs e)
        {
            DisplayDrink();
            UpdateBill();

        }
        public void setdefault()
        {
            cbProduct.SelectedValue = -1;
            txtIDProduct.Text = "";
            txtPrice.Text = "";
        }

        public void DisplayData()
        {
            da = new SqlDataAdapter("select tbSanpham.TenSP,format( tbHoadon.Dongia,'#,###,### VND') as 'Don gia', tbHoadon.SoLuong, format(tbHoadon.Tongtien,'#,###') as 'Thanh Tien' from dbo.tbHoadon, dbo.tbSanpham where tbHoadon.IDSanpham = tbSanpham.ID", conn);
            dt = new DataTable();
            da.Fill(dt);
            dgvMenu.DataSource = dt;
        }
    
        public void UpdateBill()
        {
            conn.Open();
            command = new SqlCommand("update dbo.tbHoadon set Dongia = tbSanpham.Dongia from tbSanpham, tbHoadon where tbSanpham.ID = tbHoadon.IDSanpham", conn);
            command.ExecuteNonQuery();
            command = new SqlCommand("update dbo.tbHoadon set tbHoadon.Tongtien = tbHoadon.SoLuong * tbHoadon.Dongia from tbSanpham, tbHoadon where tbSanpham.ID = tbHoadon.IDSanpham", conn);
            command.ExecuteNonQuery();
            conn.Close();
            DisplayData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            conn.Open();
            command = new SqlCommand("insert into dbo.tbHoadon (IDSanpham, Soluong)" +"values('" + Convert.ToInt32(cbProduct.SelectedValue) + "','" + Convert.ToInt32(nmAddDrink.Value.ToString()) + "')", conn) ;
            command.ExecuteNonQuery();
            MessageBox.Show("Added Sucessfully!..", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.Close();
            nmAddDrink.Value = 1;
            UpdateBill();
            setdefault();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            conn.Open();
            command = new SqlCommand("Delete from dbo.tbHoadon where IDSanpham = '" + cbProduct.SelectedValue + "'", conn);
            command.ExecuteNonQuery();
            MessageBox.Show("Deleted Sucessfully!..", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.Close();
            UpdateBill();
            setdefault();

        }
        private void dgvMenu_RowsAdded_1(object sender, DataGridViewRowsAddedEventArgs e)
        {
            da = new SqlDataAdapter("SELECT Convert(varchar, cast(SUM(Tongtien) as money), 1) FROM dbo.tbHoadon", conn);
            dt = new DataTable();
            da.Fill(dt);
            txtPay.Text = dt.Rows[0][0].ToString();
        }


        private void btnPay_Click(object sender, EventArgs e)
        {
            frmXuathoadon frm = new frmXuathoadon();
            frm.ShowDialog();
            txtPay.Text = "";
        }
        private void dgvMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbProduct.Text = dgvMenu.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtIDProduct.Text = Convert.ToString(cbProduct.SelectedValue);
            txtPrice.Text = dgvMenu.Rows[e.RowIndex].Cells[1].Value.ToString();
            nmAddDrink.Value = Convert.ToInt32(dgvMenu.Rows[e.RowIndex].Cells[2].Value.ToString());
        }

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
            frmBaocao baocao = new frmBaocao();
            baocao.ShowDialog();
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            frmmain frm = new frmmain();
            this.Close();
        }

        private void btnNewBill_Click(object sender, EventArgs e)
        {
            conn.Open();
            command = new SqlCommand("Delete from dbo.tbHoadon", conn);
            command.ExecuteNonQuery();
            conn.Close();
            DisplayData();
        }

        private void pbThunho_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbDong_Click(object sender, EventArgs e)
        {
            frmmain frm = new frmmain();
            this.Close();
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtIDProduct_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void dgvMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
