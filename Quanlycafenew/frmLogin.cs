using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlycafenew
{
    public partial class frmLogin : Form
    {
        
        public frmLogin()
        {
            InitializeComponent();
        }
        //Đăng nhập 
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string user = "admin";
            string pass = "1";
            if (user.Equals(txtTenDangNhap.Text) && pass.Equals(txtMatKhau.Text))
            {
                MessageBox.Show("XIN CHAO QUY KHACH");                
                frmmain form2 = new frmmain();
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Bạn nhập sai tài khoản hoặc mật khẩu \nVui lòng nhập lại");
                txtTenDangNhap.Text = "";
                txtMatKhau.Text = "";
                txtTenDangNhap.Focus();
            }           
        }
        //Các hiệu ứng khi click chuột v
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = true;

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = false;

        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = true;

        }

        private void btnQuenMatKhau_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đợi update đi bạn ơi");
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã có lỗi kỹ thuật \n Thử lại sau");
        }

        private void lblChuaCoTaiKhoan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã có lỗi kỹ thuật \n\t Thử lại sau");
        }

        private void pbmat_MouseUp_1(object sender, MouseEventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = true;
        }

        private void pbmat_MouseDown(object sender, MouseEventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = false;
        }

        private void txtMatKhau_TextChanged_1(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = true;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void pbmat_Click(object sender, EventArgs e)
        {

        }

        private void lblDangNhap_Click(object sender, EventArgs e)
        {

        }
    }
}
