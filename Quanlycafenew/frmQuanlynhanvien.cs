using Quanlycafenew.Extensions;
using Quanlycafenew.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlycafenew
{
    public partial class frmQuanlynhanvien : Form
    {
        public frmQuanlynhanvien()
        {
            InitializeComponent();
        }
    
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-Q2U43A9U;Initial Catalog=qlcf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        int ID = 0;
        public void Display()
        {
            da = new SqlDataAdapter("select * from dbo.tbNhanvien", con);
            dt = new DataTable();
            da.Fill(dt);
            dgvStaff.DataSource = dt;
        }
        //add 2 combobox 
        private void frmQuanlynhanvien_Load(object sender, EventArgs e)
        {
            cbGender.Items.Add("Male");
            cbGender.Items.Add("Female");
            cbGender.Items.Add("Orther");

            cbCalam.Items.Add("Ca 1");
            cbCalam.Items.Add("Ca 2");
            cbCalam.Items.Add("Ca 3");
            cbCalam.Items.Add("Ca 4");
            cbCalam.Items.Add("Ca 5");

            Display();
            //setdefault();

        }       
        private void btnAdd_Click(object sender, EventArgs e)
        {
            con.Open();


            var test = "insert into dbo.tbNhanvien (TenNV, Ngaysinh, Gioitinh, Quequan, CMND, Email, SDT, Ngaybatdau, Calam) values('" +
                txtName.Text + "','" + dtpDOB.Value.ConvertDatetimeToString() + "','" + cbGender.GetItemText(cbGender.SelectedItem) + "','" + txtQuequan.Text + "','" +
                txtCmnd.Text + "','" + txtEmail.Text + "','" + txtPhoneNumber.Text + "','" + dtpDay.Value.ConvertDatetimeToString() + "','" +
                cbCalam.GetItemText(cbCalam.SelectedItem) + "')";
            cmd = new SqlCommand(test, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Saved Sucessfully!..", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
            Display();
            //setdefault();

        }


        //nhap xong tro lai trang thai rong
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
     

        private void btnDelete_Click(object sender, EventArgs e)
        {
           
            con.Open();
            cmd = new SqlCommand("Delete from dbo.tbNhanvien where ID = '" + Convert.ToInt32(lbl1.Text) + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Deleted Sucessfully!..", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
            Display();
            //setdefault();

        }

        private void btnRepair_Click(object sender, EventArgs e)
        {
           
            con.Open();
            cmd = new SqlCommand("Update dbo.tbNhanvien set TenNV ='" + txtName.Text + "',Gioitinh = '" + cbGender.GetItemText(cbGender.SelectedItem) + "',Ngaysinh = '" + dtpDOB.Value.ConvertDatetimeToString() + "',Quequan ='" + txtQuequan.Text + "',CMND = '" + txtCmnd.Text + "',Email = '" + txtEmail.Text + "',SDT = '" + txtPhoneNumber.Text + "',Ngaybatdau='" + dtpDay.Value.ConvertDatetimeToString() + "',Calam = '"+ cbCalam.GetItemText(cbCalam.SelectedItem) + "' where ID = '" + Convert.ToInt32(lbl1.Text) + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Updated Sucessfully!..", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
            Display();
           // setdefault();

        }
        //Set tim kiem
      



        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string[] dttext = txtTimkiem.Text.Split('/');

            da = new SqlDataAdapter("select * from dbo.tbNhanvien where TenNV like '" + "%" + dttext[0] + "%" + "' or Gioitinh = '" + txtTimkiem.Text + "' or Ngaysinh like '" + "%" + txtTimkiem.Text + "%" + "' or Quequan like'"+"%"+txtTimkiem.Text+"%"+ "' or CMND like'" + "%" + txtTimkiem.Text + "%" + "'or  Email like'" + "%" + txtTimkiem.Text + "%" + "' or SDT like '" + "%" + txtTimkiem.Text + "%" + "' or Ngaybatdau like'" + "%" + txtTimkiem.Text + "%" + "' or Calam like '" + "%" + txtTimkiem.Text + "%" + "'", con);
            dt = new DataTable();
            da. Fill(dt);
            dgvStaff.DataSource = dt;
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimkiem.Text == "")
            {  
                 da = new SqlDataAdapter("select * from tbNhanvien", con);
                 dt = new DataTable();
                 da.Fill(dt);
                 dgvStaff.DataSource = dt;
     
            }
        }

        private void txtCmnd_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            e.Handled = true;
        }
        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void dgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvStaff.Rows.Count)
            {
                int ID;
                if (dgvStaff.Rows[e.RowIndex].Cells[0].Value != null && int.TryParse(dgvStaff.Rows[e.RowIndex].Cells[0].Value.ToString(), out ID))
                {
                    lbl1.Text = ID.ToString();
                }
                else
                {
                    lbl1.Text = "";
                }

                txtName.Text = dgvStaff.Rows[e.RowIndex].Cells[1].Value?.ToString() ?? "";
                cbGender.Text = dgvStaff.Rows[e.RowIndex].Cells[3].Value?.ToString() ?? "";

                DateTime DOB;
                if (dgvStaff.Rows[e.RowIndex].Cells[2].Value != null && DateTime.TryParse(dgvStaff.Rows[e.RowIndex].Cells[2].Value.ToString(), out DOB))
                {
                    dtpDOB.Value = DOB;
                }
                else
                {
                    dtpDOB.Value = DateTime.Now; // Or set to a default date
                }

                txtQuequan.Text = dgvStaff.Rows[e.RowIndex].Cells[4].Value?.ToString() ?? "";
                txtCmnd.Text = dgvStaff.Rows[e.RowIndex].Cells[5].Value?.ToString() ?? "";
                txtEmail.Text = dgvStaff.Rows[e.RowIndex].Cells[6].Value?.ToString() ?? "";
                txtPhoneNumber.Text = dgvStaff.Rows[e.RowIndex].Cells[7].Value?.ToString() ?? "";

                DateTime Day;
                if (dgvStaff.Rows[e.RowIndex].Cells[8].Value != null && DateTime.TryParse(dgvStaff.Rows[e.RowIndex].Cells[8].Value.ToString(), out Day))
                {
                    dtpDay.Value = Day;
                }
                else
                {
                    dtpDay.Value = DateTime.Now; // Or set to a default date
                }

                cbCalam.Text = dgvStaff.Rows[e.RowIndex].Cells[9].Value?.ToString() ?? "";
            }
        }
        public DateTime ConvertDate(string text)
        {
            string[] dt = text.Split('/');
            DateTime dtnew = new DateTime(Convert.ToInt32(dt[2]), Convert.ToInt32(dt[1]), Convert.ToInt32(dt[0]));
            return dtnew;
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
            frmBaocao f = new frmBaocao();
            f.ShowDialog();
        }
        Bitmap bitmap;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap ,0,0);
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            int height = dgvStaff.Height;
            dgvStaff.Height = dgvStaff.RowCount * dgvStaff.RowTemplate.Height * 2;
            bitmap = new Bitmap(dgvStaff.Width, dgvStaff.Height);
            dgvStaff.DrawToBitmap(bitmap, new Rectangle(0, 0, dgvStaff.Width, dgvStaff.Height));
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
            dgvStaff.Height = height;
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            frmmain f = new frmmain();
            f.ShowDialog();
        }

        private void pbThunho_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbDong_Click(object sender, EventArgs e)
        {
            frmmain frm = new frmmain();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dtpDay_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
