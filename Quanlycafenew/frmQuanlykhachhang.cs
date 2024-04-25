using Quanlycafenew.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlycafenew
{
    public partial class frmQuanlykhachhang : Form
    {
        public frmQuanlykhachhang()
        {
            InitializeComponent();
            Display();

        }

        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-Q2U43A9U;Initial Catalog=qlcf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;


        public void Display()
        {
            da = new SqlDataAdapter("select * from dbo.tbKhachhang", conn);
            dt = new DataTable();
            da.Fill(dt);
            dgvCustomer.DataSource = dt;
        }

        public void SetDefault()
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("insert into dbo.tbKhachhang values" +
                "('" + txtName.Text + "','" + dtpBOD.Value.ConvertDatetimeToString() + "','" + cbGender.GetItemText(cbGender.SelectedItem) + "','" + 
                txtPhoneNumber.Text + "','" + txtAddress.Text + "')", conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Saved Sucessfully!..", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.Close();
            Display();
            //SetDefault();
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbl1.Text = dgvCustomer.Rows[e.RowIndex].Cells[0].Value.ToString(); 
            txtName.Text = dgvCustomer.Rows[e.RowIndex].Cells[1].Value.ToString();
            dtpBOD.Text = dgvCustomer.Rows[e.RowIndex].Cells[2].Value.ToString();
            cbGender.SelectedItem = dgvCustomer.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtPhoneNumber.Text = dgvCustomer.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtAddress.Text = dgvCustomer.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btnRepair_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("Update dbo.tbKhachhang set TenKH ='" + txtName.Text + "',Ngaysinh ='" + dtpBOD.Value.ConvertDatetimeToString() + "',Gioitinh ='" + cbGender.GetItemText(cbGender.SelectedItem) + "',SDT ='" + txtPhoneNumber.Text + "',Diachi ='" + txtAddress.Text + "' where ID = '" + Convert.ToInt32(lbl1.Text) + "'", conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Updated Sucessfully!..", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.Close();
            Display();
            //SetDefault();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("Delete from dbo.tbKhachhang where ID = '" + Convert.ToInt32(lbl1.Text) + "'", conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Deleted Sucessfully!..", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.Close();
            Display();
            //SetDefault();
        }

        private void pbCustomer_Click(object sender, EventArgs e)
        {
            string[] dttext = txtSearchCustomer.Text.Split('/');
            
            da = new SqlDataAdapter("select * from dbo.tbKhachHang where TenKH like '" + "%" + txtSearchCustomer.Text + "%" + "' or Ngaysinh like '" + "%" + txtSearchCustomer.Text + "%" + "' or Gioitinh = '"  + txtSearchCustomer.Text + "' or SDT like '" + "%" + txtSearchCustomer.Text + "%" + "' or Diachi like '" + "%" + txtSearchCustomer.Text + "%" + "'", conn);
            dt = new DataTable();
            da.Fill(dt);
            dgvCustomer.DataSource = dt;
        }

        private void txtSearchCustomer_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchCustomer.Text == "")
            {
                da = new SqlDataAdapter("select * from tbKhachhang", conn);
                dt = new DataTable();
                da.Fill(dt);
                dgvCustomer.DataSource = dt;
            }
        }
        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
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

        Bitmap bitmap;

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void btnDoanhthu_Click(object sender, EventArgs e)
        {
            frmBaocao f = new frmBaocao();
            f.ShowDialog();
        }

        private void frmQuanlykhachhang_Load(object sender, EventArgs e)
        {
            Display();
            cbGender.Items.Add("Male");
            cbGender.Items.Add("Female");
            cbGender.Items.Add("Other");
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            frmmain f = new frmmain();
            f.ShowDialog();
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

        private void btnIn_Click(object sender, EventArgs e)
        {
            int height = dgvCustomer.Height;
            dgvCustomer.Height = dgvCustomer.RowCount * dgvCustomer.RowTemplate.Height * 2;
            bitmap = new Bitmap(dgvCustomer.Width, dgvCustomer.Height);
            dgvCustomer.DrawToBitmap(bitmap, new Rectangle(0, 0, dgvCustomer.Width, dgvCustomer.Height));
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
            dgvCustomer.Height = height;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dtpBOD_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
