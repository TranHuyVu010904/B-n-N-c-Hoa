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

namespace Nuochoa
{
    public partial class frmLogin : Form
    {
      
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //DialogResult tb = MessageBox.Show("")
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            /*this.Hide();
            Form2 frm = new Form2();
            frm.Show();*/
           //
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-Q2U43A9U;Initial Catalog=PNPdata;Integrated Security=True");
             try
             {
                 conn.Open();
                 string tk = txtUsername.Text;
                 string mk = txtPassword.Text;
                 string sql = "select *from tbLogin where Username= '" + tk + "' and Password='" + mk + "'";
                 SqlCommand cmd = new SqlCommand(sql, conn);
                 SqlDataReader dta = cmd.ExecuteReader();
                 if(dta.Read()== true)
                 {
                     this.Hide();                 
                     MessageBox.Show("Xin chào admin", "Notification",MessageBoxButtons.OK,MessageBoxIcon.Information);
                     FrmTK frm = new FrmTK();
                     frm.ShowDialog();

                 }
                 else
                 {
                     MessageBox.Show("XIN HÃY THỬ LẠI", "Notification",MessageBoxButtons.OK,MessageBoxIcon.Information);
                     txtUsername.Text = "";
                     txtPassword.Text = "";
                     txtUsername.Focus();
                 }

             }
             catch (Exception ex)
             {
                 MessageBox.Show("Xin thu lai!" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
             }
            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
