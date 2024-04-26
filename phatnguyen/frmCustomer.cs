using Nuochoa.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nuochoa
{
    public partial class frmCustomer : Form
    {
       /* public void Display()
        {
            using (PNPdataEntities _entity = new PNPdataEntities())
            {
                List<CustomerInfo> _CustomerList = new List<CustomerInfo>();
                _CustomerList = _entity.tbCustomer_.Select(x => new CustomerInfo
                {
                    ID = x.ID,
                    Code = x.CustomerCode,
                    Name = x.Name,
                    Age = x.Age,
                    Gender = x.Gender,
                    Phone = x.PhoneNumber,
                    Address = x.Address

                }).ToList();
                dgvwCus.DataSource = _CustomerList;

            }

        }*/

        
        private void DataGridViewWidth()
        {
            
            DataGridViewColumn column = dgvwCus.Columns[6];
            column.Width = 350;
            DataGridViewColumn column1 = dgvwCus.Columns[2];
            column1.Width = 200;
            dgvwCus.Columns[0].Visible = false;
        }
        public frmCustomer()
        {
            InitializeComponent();
        }

        public void cbxsearchitem()
        {
            cbxSearchCus.Items.Add("Customer Code");
            cbxSearchCus.Items.Add("Customer Name");
            cbxSearchCus.Items.Add("Customer DOB");
            cbxSearchCus.Items.Add("Customer Address");
            cbxSearchCus.Items.Add("Customer Gender");
        }
        public void cbxgenderitem()
        {
            cbxGender.Items.Add("Nam");
            cbxGender.Items.Add("Nữ");
            cbxGender.Items.Add("Khác");
        }
        private void frmCustomer_Load(object sender, EventArgs e)
        {
            cbxgenderitem();
            cbxsearchitem();
           // Display();
            DataGridViewWidth();
        }
        public void ClearFields()
        {
            txtCustomerCode.Text = "";
            txtCustomerName.Text = "";
            cbxGender.SelectedIndex = -1;
            dtpDOB.Value = DateTime.Now; // sau khi nhap sua xoa khi thanh datetime se load ve ngay hien tai
            txtPhoneCus.Text = "";
            txtAddressCus.Text = "";
            cbb.Text = "";
        }


        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Release the mouse capture started by the mouse down.
                panel2.Capture = false;

                // Create and send a WM_NCLBUTTONDOWN message.
                const int WM_NCLBUTTONDOWN = 0x00A1;
                const int HTCAPTION = 2;
                Message msg =
                    Message.Create(this.Handle, WM_NCLBUTTONDOWN,
                        new IntPtr(HTCAPTION), IntPtr.Zero);
                this.DefWndProc(ref msg);
            }
        }
        // Khoi tao 2 bien va tao hem co chua nang thu nho form khi click vao icon duoi thanh taskbar cua windows
        const int WS_MINIMIZEBOX = 0x20000;
        const int CS_DBLCLKS = 0x8;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= WS_MINIMIZEBOX;
                cp.ClassStyle |= CS_DBLCLKS;
                return cp;
            }
        }

        private void btnOffCustomer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      /*  public bool SaveCustomer(tbCustomer_ tbCustomer_)
        {
            bool result = false;
            using (PNPdataEntities _entity = new PNPdataEntities())
            {
                _entity.tbCustomer_.Add(tbCustomer_);
                _entity.SaveChanges();
                result = true;
            }
            return result;
        }*/



        private void btnSave_Click(object sender, EventArgs e)
        {
            /*tbCustomer_ tbcustomer = new tbCustomer_();
            tbcustomer.CustomerCode = txtCustomerCode.Text;
            tbcustomer.Name = txtCustomerName.Text;
            tbcustomer.Gender = cbxGender.Text;
            tbcustomer.Age = Convert.ToDateTime(dtpDOB.Text);
            // tbstaff.Age = Convert.ToDateTime(dtpDOB.Value.ToString("dd-MM-yyyy"));
            tbcustomer.PhoneNumber = txtPhoneCus.Text;
            tbcustomer.Address = txtAddressCus.Text;
            bool result = SaveCustomer(tbcustomer);
            if (result == true)
            {
                MessageBox.Show("Thêm Thành Công", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Display();
            }
            else
            {
                MessageBox.Show("Please try again?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            ClearFields();*/
        }

        private void dgvwCus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvwCus.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvwCus.SelectedRows)
                {
                    lblID.Text = row.Cells[0].Value.ToString();
                    txtCustomerCode.Text = row.Cells[1].Value.ToString();
                    txtCustomerName.Text = row.Cells[2].Value.ToString();
                    cbxGender.SelectedItem = row.Cells[4].Value.ToString();
                    dtpDOB.Value = Convert.ToDateTime(row.Cells[3].Value);
                    txtPhoneCus.Text = row.Cells[5].Value.ToString();
                    txtAddressCus.Text = row.Cells[6].Value.ToString();
                }
            }
        }

        //DELETE
       /* public bool DeleteStaff(int id)
        {
            bool result = false;
            try
            {
                using (PNPdataEntities _entity = new PNPdataEntities())
                {
                    tbCustomer_ _customer = _entity.tbCustomer_.Find(id);
                    if (_customer != null)
                    {
                        _entity.tbCustomer_.Remove(_customer);
                        _entity.SaveChanges();
                        result = true;
                    }
                    else
                    {
                        result = false;
                    }
                }
            }
            catch
            {
                result = false;
            }
            return result;
        }
*/
        private void btnDelete_Click(object sender, EventArgs e)
        {
           /* try
            {
                int idcustomer = Convert.ToInt32(lblID.Text);
                bool result = DeleteStaff(idcustomer);
                if (result == true)
                {
                    MessageBox.Show("Xóa Thành Công", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    //Display();
                }
                else
                {
                    MessageBox.Show("Lỗi", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please try again?\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }*/
        }


        //UPDATE
       /* public bool UpdateCustomer(tbCustomer_ stc)
        {
            bool result = false;
            using (PNPdataEntities _entity = new PNPdataEntities())
            {
                tbCustomer_ _customer = _entity.tbCustomer_.Where(x => x.ID == stc.ID).Select(x => x).FirstOrDefault();
                _customer.CustomerCode = stc.CustomerCode;
                _customer.Name = stc.Name;
                _customer.Age = stc.Age;
                _customer.Gender = stc.Gender;
                _customer.PhoneNumber = stc.PhoneNumber;
                _customer.Address = stc.Address;
                _entity.SaveChanges();
                result = true;
            }
            return result;
        }*/

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           /* try
            {
                tbCustomer_ stc = new tbCustomer_();
                stc.ID = Convert.ToInt32(lblID.Text);
                stc.CustomerCode = txtCustomerCode.Text;
                stc.Name = txtCustomerName.Text;
                stc.Age = Convert.ToDateTime(dtpDOB.Text);
                stc.Gender = cbxGender.SelectedItem.ToString();
                stc.PhoneNumber = txtPhoneCus.Text;
                stc.Address = txtAddressCus.Text;
                bool result = UpdateCustomer(stc);
                if (result == true)
                {
                    MessageBox.Show("Cập Nhật Thành Công", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Display();
                }
                else
                {
                    MessageBox.Show("Cập Nhật Lỗi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please try again?\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }*/
        }


        //CLOSE
        private void btnClose_Click(object sender, EventArgs e)
        {
            ClearFields();

        }


        //HIDE FORM
        private void btnHideForm_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        //SEARCH
        public SqlConnection cn = new SqlConnection();
        public void ketnoi()
        {
            try
            {
                if (cn.State == 0)
                {
                    cn.ConnectionString = @"Data Source=LAPTOP-Q2U43A9U;Initial Catalog=PNPdata;Integrated Security=True";
                    cn.Open();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Ngatketnoi()
        {
            if (cn.State != 0)
            {
                cn.Close();
            }
        }

        public DataTable XemDL(string sql)
        {
            ketnoi();

            SqlDataAdapter adap = new SqlDataAdapter(sql, cn);
            DataTable dt = new DataTable();
            adap.Fill(dt);

            return dt;

            //Ngatketnoi();
        }
        public SqlCommand ThucThiDl(string sql)
        {
            ketnoi();

            SqlCommand cm = new SqlCommand(sql, cn);
            cm.ExecuteNonQuery();

            return cm;

            //Ngatketnoi();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cbxSearchCus.Text == "Customer Code")
            {
                dgvwCus.DataSource = XemDL("select * from [tbCustomer*] where CustomerCode like '%" + txtSearch.Text.Trim() + "%'");
            }
            if (cbxSearchCus.Text == "Customer Name")
            {
                dgvwCus.DataSource = XemDL("select * from [tbCustomer*] where Name like N'%" + txtSearch.Text.Trim() + "%'");
            }
            if (cbxSearchCus.Text == "Customer DOB")
            {
                dgvwCus.DataSource = XemDL("select * from [tbCustomer*] where Age like N'%" + txtSearch.Text.Trim() + "%'");
            }
            if (cbxSearchCus.Text == "Customer Address")
            {
                dgvwCus.DataSource = XemDL("select * from [tbCustomer*] where Address like N'%" + txtSearch.Text.Trim() + "%'");
            }
            if (cbxSearchCus.Text == "Customer Gender")
            {
                dgvwCus.DataSource = XemDL("select * from [tbCustomer*] where Gender like N'%" + txtSearch.Text.Trim() + "%'");
            }
        }

        private void cbxGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCustomerCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvwCus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxSearchCus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
