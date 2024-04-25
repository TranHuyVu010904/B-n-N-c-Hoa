using Quanlycafenew.Model;
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
    public partial class frmQuanlysanpham : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-Q2U43A9U;Initial Catalog=qlcf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        public frmQuanlysanpham()
        {
            InitializeComponent();
        }

        private void frmQuanlysanpham_Load(object sender, EventArgs e)
        {
            Display();
        }
        public void Display()
        {
            da = new SqlDataAdapter("select * from dbo.tbSanpham", con);
            dt = new DataTable();
            da.Fill(dt);
            dgvListProduct.DataSource = dt;
        }
        public void Setdefault()
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

                }
            }
        }
        /*-------------------------------CRUD--------------------------------------*/
        private void btnAdd_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("insert into dbo.tbSanpham values('" + txtNameProduct.Text + "','" + txtPrice.Text + "','" + txtInventory.Text + "','" + txtSold.Text + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Saved Sucessfully!..", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
            Display();
            Setdefault();
        }

        private void btnRepair_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("Update dbo.tbSanpham set TenSP ='" + txtNameProduct.Text + "',Dongia ='" + txtPrice.Text + "',SLTon = '" + txtInventory.Text + "',SLdaban = '" + txtSold.Text + "' where ID = '" + Convert.ToInt32(lbl1.Text) + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Updated Sucessfully!..", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
            Display();
            Setdefault();
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("Delete from dbo.tbSanpham where ID = '" + Convert.ToInt32(lbl1.Text) + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Deleted Sucessfully!..", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
            Display();
            Setdefault();
        }         
        private void dgvListProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbl1.Text = dgvListProduct.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNameProduct.Text = dgvListProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPrice.Text = dgvListProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtInventory.Text = dgvListProduct.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtSold.Text = dgvListProduct.Rows[e.RowIndex].Cells[4].Value.ToString();

        }

        private void pbProduct_Click(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("select * from dbo.tbSanpham where(TenSP like '" + "%" + txtProduct.Text + "%" + "' or Dongia like '" + "%" + txtProduct.Text + "%" + "' or SLTon like '" + "%" + txtProduct.Text + "%" + "' or SLdaban like '" + "%" + txtProduct.Text + "%" + "')", con);
            dt = new DataTable();
            da.Fill(dt);
            dgvListProduct.DataSource = dt;
        }

        private void txtProduct_TextChanged(object sender, EventArgs e)
        {
            if (txtProduct.Text == "")
            {
                da = new SqlDataAdapter("select * from tbSanpham", con);
                dt = new DataTable();
                da.Fill(dt);
                dgvListProduct.DataSource = dt;
            }
        }
        //Không cho nhập số   
        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void txtInventory_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void txtSold_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;

        }
        //Show all from trừ form san phẩm
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

        private void pbLogo_Click(object sender, EventArgs e)
        {
            frmmain f = new frmmain();
            f.ShowDialog();
        }
        //Thu nho va close
        private void pbThunho_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbDong_Click(object sender, EventArgs e)
        {
            frmmain frm = new frmmain();
            this.Close();
        }
       
        //Xuất ra print preview
        Bitmap bitmap;
        

        private void btnIn_Click(object sender, EventArgs e)
        {
            int height = dgvListProduct.Height;
            dgvListProduct.Height = dgvListProduct.RowCount *  dgvListProduct.RowTemplate.Height * 2;
            bitmap = new Bitmap( dgvListProduct.Width,  dgvListProduct.Height);
             dgvListProduct.DrawToBitmap(bitmap, new Rectangle(0, 0,  dgvListProduct.Width,  dgvListProduct.Height));
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
             dgvListProduct.Height = height;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSold_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
