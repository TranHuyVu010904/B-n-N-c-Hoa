using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    
    public partial class Form4 : Form
    {
        private bool isLoggedIn = false;
        public Form4()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 formSignup = new Form2();
            formSignup.ShowDialog();
            
        }
       
        private void button7_Click(object sender, EventArgs e)
        {
            if (isLoggedIn)
            {
                Form3 loginForm = new Form3();
                loginForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng đăng nhập!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.ShowDialog();

            isLoggedIn = loginForm.IsLoggedIn;

            if (isLoggedIn)
            {
                
            }
            else
            {
                
            }

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
