using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;
using System.Xml.Linq;
namespace Login
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            alphaBlendTextBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
         
            
            if (!Regex.IsMatch(name, @"^[a-zA-Z0-9]+$"))
            {
                MessageBox.Show("Tên chỉ được nhập các ký tự không dấu!");
                textBox1.Focus();
                return;
            }

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Tên không được để trống!");
                textBox1.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Tên không được để trống!");
                textBox1.Focus();
                return;
            }
           
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Email không được để trống!");
                textBox3.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Địa chỉ không được để trống!");
                textBox4.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("CMND không được để trống!");
                textBox5.Focus();
                return;
            }
            if (!Regex.IsMatch(textBox5.Text, "^[0-9]+$"))
            {
                MessageBox.Show("CMND/CCCD chỉ được sử dụng số");
                return;
            }
            if (!Regex.IsMatch(textBox3.Text, @"^[a-zA-Z0-9]+@[a-zA-Z0-9]+\.[a-zA-Z]+$"))
            {
                MessageBox.Show("Email không hợp lệ");
                return;
            }
            alphaBlendTextBox1.Text = $"Name: {textBox1.Text}\r\nEmail: {textBox3.Text}\r\nAddress: {textBox4.Text}\r\nCMND/CCCD: {textBox5.Text}";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

           
            
            
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void alphaBlendTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
