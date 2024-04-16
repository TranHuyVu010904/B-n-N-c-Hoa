using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Text.RegularExpressions;
namespace Login
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public bool IsLoggedIn { get; private set; }
        String strCon = @"Data Source=LAPTOP-6K3UA9B7\HUYVU;Initial Catalog=QuanLySanBay;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void Login_Click(object sender, EventArgs e)
        {
            int failedLoginAttempts = 0;
            string username = textBox1.Text;
            string password = textBox2.Text;
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Username không được để trống");
                return;
            }

            

            if (!Regex.IsMatch(username, "^[a-zA-Z0-9]+$"))
            {
                MessageBox.Show("Username chỉ được sử dụng chữ và số");
                return;
            }

            
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Password không được để trống");
                return;
            }

            if (password.Length < 6 || password.Length > 12)
            {
                MessageBox.Show("Password phải có độ dài từ 6-12 ký tự");
                return;
            }
            if (username.Length < 6 || username.Length > 12)
            {
                MessageBox.Show("Us phải có độ dài từ 6-12 ký tự");
                return;
            }

            SqlConnection sqlCon = new SqlConnection(strCon);
            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM HanhKhach WHERE Name= @Name AND Password= @Password", sqlCon);
            sqlCmd.Parameters.AddWithValue("@Name", textBox1.Text);
            sqlCmd.Parameters.AddWithValue("@Password", textBox2.Text);
            sqlCon.Open();

            SqlDataReader reader = sqlCmd.ExecuteReader();
  
            if (reader.HasRows) // Check if there are any records
            {   
                sqlCmd.Parameters.AddWithValue("@Name", textBox1.Text);
                sqlCmd.Parameters.AddWithValue("@Password", textBox2.Text);
                IsLoggedIn = true;
                MessageBox.Show("Chào mừng trở lại!\nĐăng nhập thành công");
                this.Close();
            }
            else
            {
                failedLoginAttempts++;

                if (failedLoginAttempts >= 3)
                {
                    MessageBox.Show("Bạn đã đăng nhập sai quá 3 lần. Ứng dụng sẽ đóng.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.");
                }






            }

          
            
        }

        


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát?", "Thoát", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtName_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            Form2 formSignUp = new Form2();
            formSignUp.ShowDialog();
            this.Hide();
        }
    }
}