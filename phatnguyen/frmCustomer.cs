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
            DisplayCustomers();
            DataGridViewWidth();
        }
        public void ClearFields()
        {
            txtCustomerCode.Text = "";
            txtCustomerName.Text = "";
            cbxGender.SelectedIndex = -1;
            dtpDOB.Value = DateTime.Now; 
            txtPhoneCus.Text = "";
            txtAddressCus.Text = "";
            cbb.Text = "";
        }


        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            
        }
       
       

        

        private void btnOffCustomer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool IsCustomerCodeExists(string customerCode, int customerId = 0)
        {
            string query = string.Format("SELECT COUNT(*) FROM [tbCustomer*] WHERE CustomerCode = '{0}'", customerCode);
            if (customerId > 0)
            {
                query += string.Format(" AND ID <> {0}", customerId);
            }

            DataTable dt = XemDL(query);
            int count = Convert.ToInt32(dt.Rows[0][0]);
            return count > 0;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ các textbox
                string customerCode = txtCustomerCode.Text;
                string customerName = txtCustomerName.Text;
                string gender = cbxGender.SelectedItem?.ToString(); // Đảm bảo giá trị không null
                DateTime dob = dtpDOB.Value;
                string phone = txtPhoneCus.Text;
                string address = txtAddressCus.Text;

                // Kiểm tra các giá trị bắt buộc
                if (string.IsNullOrWhiteSpace(customerCode) || string.IsNullOrWhiteSpace(customerName) || string.IsNullOrWhiteSpace(gender))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (IsCustomerCodeExists(customerCode))
                {
                    MessageBox.Show("Mã khách hàng đã tồn tại trong cơ sở dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Không thực hiện thêm nữa nếu mã khách hàng đã tồn tại
                }
                // Xây dựng câu lệnh SQL INSERT
                string sqlInsert = string.Format("INSERT INTO [tbCustomer*] (CustomerCode, Name, Gender, Age, PhoneNumber, Address) \r\nVALUES ('{0}', N'{1}', N'{2}', '{3}', '{4}', N'{5}')",
                                                  customerCode, customerName, gender, dob.ToString("yyyy-MM-dd"), phone, address);

                // Thực thi câu lệnh INSERT
                ThucThiDl(sqlInsert);

                // Hiển thị thông báo khi thêm thành công
                MessageBox.Show("Thêm thông tin khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Sau khi thêm, làm mới các trường nhập liệu
                ClearFields();

                // Sau khi thêm, hiển thị lại danh sách khách hàng
                DisplayCustomers();
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo khi có lỗi xảy ra
                MessageBox.Show("Lỗi khi thêm thông tin khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvwCus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvwCus.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvwCus.SelectedRows)
                {
                    lblID.Text = row.Cells[0].Value != DBNull.Value ? row.Cells[0].Value.ToString() : ""; // Kiểm tra giá trị của cell trước khi chuyển đổi
                    txtCustomerCode.Text = row.Cells[1].Value != DBNull.Value ? row.Cells[1].Value.ToString() : "";
                    txtCustomerName.Text = row.Cells[2].Value != DBNull.Value ? row.Cells[2].Value.ToString() : "";
                    cbxGender.SelectedItem = row.Cells[4].Value != DBNull.Value ? row.Cells[4].Value.ToString() : "";
                    dtpDOB.Value = row.Cells[3].Value != DBNull.Value ? Convert.ToDateTime(row.Cells[3].Value) : DateTime.Now;
                    txtPhoneCus.Text = row.Cells[5].Value != DBNull.Value ? row.Cells[5].Value.ToString() : "";
                    txtAddressCus.Text = row.Cells[6].Value != DBNull.Value ? row.Cells[6].Value.ToString() : "";
                }
            }
        }

        

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvwCus.SelectedRows.Count > 0)
            {
                // Lấy ID của khách hàng từ hàng được chọn trong DataGridView
                int customerID = Convert.ToInt32(dgvwCus.SelectedRows[0].Cells["ID"].Value);

                // Xác nhận việc xóa khách hàng từ người dùng
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Tạo câu lệnh SQL DELETE
                        string sqlDelete = string.Format("DELETE FROM [tbCustomer*] WHERE ID = {0}", customerID);

                        // Thực thi câu lệnh DELETE
                        ThucThiDl(sqlDelete);

                        // Hiển thị thông báo khi xóa thành công
                        MessageBox.Show("Xóa khách hàng thành công!");

                        // Hiển thị lại danh sách khách hàng sau khi xóa
                        DisplayCustomers();
                    }
                    catch (Exception ex)
                    {
                        // Hiển thị thông báo khi có lỗi xảy ra
                        MessageBox.Show("Lỗi khi xóa khách hàng: " + ex.Message);
                    }
                }
            }
            else
            {
                // Hiển thị thông báo nếu không có khách hàng nào được chọn
                MessageBox.Show("Vui lòng chọn một khách hàng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


       

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblID.Text)) // Kiểm tra xem có dòng nào được chọn không
            {
                try
                {
                    // Lấy dữ liệu từ các textbox và combobox
                    int customerID = Convert.ToInt32(lblID.Text);
                    string customerCode = txtCustomerCode.Text;
                    string customerName = txtCustomerName.Text;
                    string gender = cbxGender.SelectedItem?.ToString(); // Đảm bảo giá trị không null
                    DateTime dob = dtpDOB.Value;
                    string phone = txtPhoneCus.Text;
                    string address = txtAddressCus.Text;
                    if (IsCustomerCodeExists(customerCode, customerID))
                    {
                        MessageBox.Show("Mã khách hàng đã tồn tại trong cơ sở dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // Không thực hiện sửa nữa nếu mã khách hàng đã tồn tại
                    }
                    // Xây dựng câu lệnh SQL UPDATE
                    string sqlUpdate = string.Format("UPDATE [tbCustomer*] SET CustomerCode = '{0}', Name = N'{1}', Gender = N'{2}', Age = '{3}', PhoneNumber = '{4}', Address = N'{5}' WHERE ID = {6}",
                                                      customerCode, customerName, gender, dob.ToString("yyyy-MM-dd"), phone, address, customerID);

                    // Thực thi câu lệnh UPDATE
                    ThucThiDl(sqlUpdate);

                    // Hiển thị thông báo khi cập nhật thành công
                    MessageBox.Show("Cập nhật thông tin khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Sau khi cập nhật, làm mới các trường nhập liệu và hiển thị lại danh sách khách hàng
                    ClearFields();
                    DisplayCustomers();
                }
                catch (Exception ex)
                {
                    // Hiển thị thông báo khi có lỗi xảy ra
                    MessageBox.Show("Lỗi khi cập nhật thông tin khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Hiển thị thông báo nếu không có dòng nào được chọn
                MessageBox.Show("Vui lòng chọn một khách hàng để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public SqlCommand ThucThiDl(string sql)
        {
            ketnoi();

            SqlCommand cm = new SqlCommand(sql, cn);
            cm.ExecuteNonQuery();

            return cm;

            //Ngatketnoi();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ClearFields();

        }


        
        private void btnHideForm_Click(object sender, EventArgs e)
        {
            
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
        private void DisplayCustomers()
        {
            string query = "SELECT * FROM [tbCustomer*]";
            DataTable dt = XemDL(query); // Sử dụng hàm kết nối để thực thi câu lệnh SELECT

            dgvwCus.DataSource = dt;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gbxIPIFCustomer_Enter(object sender, EventArgs e)
        {

        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cbb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpDOB_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
