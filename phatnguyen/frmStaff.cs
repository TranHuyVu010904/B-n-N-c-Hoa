using Nuochoa.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;
//using System.Globalization; //Thu vien de dinh danh datetime tu gridview hien len thanh datetime trong form 

namespace Nuochoa
{
    public partial class frmStaff : Form
    {

        public void Display()
        {
            string query = "SELECT * FROM [tbStaff*]";
            DataTable dt = XemDL(query); // Sử dụng hàm kết nối để thực thi câu lệnh SELECT

            dgvwStaff.DataSource = dt;

        }
        private void DataGridViewWidth()
        {
            DataGridViewColumn column = dgvwStaff.Columns[2];
            column.Width = 350;
            DataGridViewColumn column1 = dgvwStaff.Columns[6];
            column1.Width = 200;
            dgvwStaff.Columns[0].Visible = false;
        }

        public frmStaff()
        {
            InitializeComponent();
        }

        public void cbxsearchitem()
        {
            cbxSearchStaff.Items.Add("Mã NV");
            cbxSearchStaff.Items.Add("Tên NV");
            cbxSearchStaff.Items.Add("DOB");

        }
        public void cbxGenderitem()
        {
            cbxGender.Items.Add("Nam");
            cbxGender.Items.Add("Nu");
            cbxGender.Items.Add("Khác");
        }
        private void frmStaff_Load(object sender, EventArgs e)
        {
            cbxGenderitem();
            cbxsearchitem();
            Display();
            DataGridViewWidth();

        }

        public void ClearFields()
        {
            txtStaffCode.Text = "";
            txtStaffName.Text = "";
            cbxGender.SelectedIndex = -1;
            dtpDOB.Value = DateTime.Now; // sau khi nhap sua xoa khi thanh datetime se load ve ngay hien tai
            txtPhoneStaff.Text = "";
            txtAddressStaff.Text = "";
        }

        /* public bool SaveStaff(tbStaff_ tbStaff_)
         {
             bool result = false;
             using (PNPdataEntities _entity = new PNPdataEntities())
             {
                 _entity.tbStaff_.Add(tbStaff_);
                 _entity.SaveChanges();
                 result = true;
             }
             return result;
         }*/


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

        private void btnOffStaff_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool IsStaffCodeExists(string staffCode, int staffId = 0)
        {
            string query = string.Format("SELECT COUNT(*) FROM [tbStaff*] WHERE StaffCode = '{0}'", staffCode);
            if (staffId > 0)
            {
                query += string.Format(" AND ID <> {0}", staffId);
            }

            DataTable dt = XemDL(query);
            int count = Convert.ToInt32(dt.Rows[0][0]);
            return count > 0;
        }

        //SAVE
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ các textbox
                string staffCode = txtStaffCode.Text;
                string staffname = txtStaffName.Text;
                string gender = cbxGender.SelectedItem?.ToString(); // Đảm bảo giá trị không null
                DateTime dob = dtpDOB.Value;
                string phone = txtPhoneStaff.Text;
                string address = txtAddressStaff.Text;

                // Kiểm tra các giá trị bắt buộc
                if (string.IsNullOrWhiteSpace(staffCode) || string.IsNullOrWhiteSpace(staffname) || string.IsNullOrWhiteSpace(gender))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (IsStaffCodeExists(staffCode))
                {
                    MessageBox.Show("Mã khách hàng đã tồn tại trong cơ sở dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Không thực hiện thêm nữa nếu mã khách hàng đã tồn tại
                }

                // Xây dựng câu lệnh SQL INSERT
                string sqlInsert = string.Format("INSERT INTO [tbStaff*] (StaffCode, Name, Gender, Age, PhoneNumber, Address) \r\nVALUES ('{0}', N'{1}', N'{2}', '{3}', '{4}', N'{5}')",
                                                  staffCode, staffname, gender, dob.ToString("yyyy-MM-dd"), phone, address);

                // Thực thi câu lệnh INSERT
                ThucThiDl(sqlInsert);

                // Hiển thị thông báo khi thêm thành công
                MessageBox.Show("Thêm thông tin nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Sau khi thêm, làm mới các trường nhập liệu
                ClearFields();

                // Sau khi thêm, hiển thị lại danh sách khách hàng
                Display();
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo khi có lỗi xảy ra
                MessageBox.Show("Lỗi khi thêm thông tin nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void dgvwStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvwStaff.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvwStaff.SelectedRows)
                {
                    lblID.Text = row.Cells[0].Value != DBNull.Value ? row.Cells[0].Value.ToString() : ""; // Kiểm tra giá trị của cell trước khi chuyển đổi
                    txtStaffCode.Text = row.Cells[1].Value != DBNull.Value ? row.Cells[1].Value.ToString() : "";
                    txtStaffName.Text = row.Cells[2].Value != DBNull.Value ? row.Cells[2].Value.ToString() : "";
                    cbxGender.SelectedItem = row.Cells[4].Value != DBNull.Value ? row.Cells[4].Value.ToString() : "";
                    dtpDOB.Value = row.Cells[3].Value != DBNull.Value ? Convert.ToDateTime(row.Cells[3].Value) : DateTime.Now;
                    txtPhoneStaff.Text = row.Cells[5].Value != DBNull.Value ? row.Cells[5].Value.ToString() : "";
                    txtAddressStaff.Text = row.Cells[6].Value != DBNull.Value ? row.Cells[6].Value.ToString() : "";
                }
            }
        }

        //DELETE
        /*public bool DeleteStaff(int id)
        {
            bool result = false;
            try
            {
                using (PNPdataEntities _entity = new PNPdataEntities())
                {
                    tbStaff_ _staff = _entity.tbStaff_.Find(id);
                    if (_staff != null)
                    {
                        _entity.tbStaff_.Remove(_staff);
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
        }*/

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvwStaff.SelectedRows.Count > 0)
            {
                // Lấy ID của nhan vien từ hàng được chọn trong DataGridView
                int staffID = Convert.ToInt32(dgvwStaff.SelectedRows[0].Cells["ID"].Value);

                // Xác nhận việc xóa khách hàng từ người dùng
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Tạo câu lệnh SQL DELETE
                        string sqlDelete = string.Format("DELETE FROM [tbStaff*] WHERE ID = {0}", staffID);

                        // Thực thi câu lệnh DELETE
                        ThucThiDl(sqlDelete);

                        // Hiển thị thông báo khi xóa thành công
                        MessageBox.Show("Xóa nhân viên thành công!");

                        // Hiển thị lại danh sách khách hàng sau khi xóa
                        Display();
                    }
                    catch (Exception ex)
                    {
                        // Hiển thị thông báo khi có lỗi xảy ra
                        MessageBox.Show("Lỗi khi xóa nhân viên: " + ex.Message);
                    }
                }
            }
            else
            {
                // Hiển thị thông báo nếu không có khách hàng nào được chọn
                MessageBox.Show("Vui lòng chọn nhân viên để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //UPDATE

        /* public bool UpdateStaff(tbStaff_ sta)
         {
             bool result = false;
             using (PNPdataEntities _entity = new PNPdataEntities())
             {
                 tbStaff_ _staff = _entity.tbStaff_.Where(x => x.ID == sta.ID).Select(x => x).FirstOrDefault();
                 _staff.StaffCode = sta.StaffCode;
                 _staff.Name = sta.Name;
                 _staff.Age = sta.Age;
                 _staff.Gender = sta.Gender;
                 _staff.PhoneNumber = sta.PhoneNumber;
                 _staff.Address = sta.Address;
                 _entity.SaveChanges();
                 result = true;
             }
             return result;
         }*/

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblID.Text)) // Kiểm tra xem có dòng nào được chọn không
            {
                try
                {
                    // Lấy dữ liệu từ các textbox và combobox
                    int staffID = Convert.ToInt32(lblID.Text);
                    string staffCode = txtStaffCode.Text;
                    string staffName = txtStaffName.Text;
                    string gender = cbxGender.SelectedItem?.ToString(); // Đảm bảo giá trị không null
                    DateTime dob = dtpDOB.Value;
                    string phone = txtPhoneStaff.Text;
                    string address = txtAddressStaff.Text;
                    if (IsStaffCodeExists(staffCode, staffID))
                    {
                        MessageBox.Show("Mã nhân viên đã tồn tại trong cơ sở dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // Không thực hiện sửa nữa nếu nhân viên đã tồn tại
                    }
                    // Xây dựng câu lệnh SQL UPDATE
                    string sqlUpdate = string.Format("UPDATE [tbStaff*] SET staffCode = '{0}', Name = N'{1}', Gender = N'{2}', Age = '{3}', PhoneNumber = '{4}', Address = N'{5}' WHERE ID = {6}",
                                                      staffCode, staffName, gender, dob.ToString("yyyy-MM-dd"), phone, address, staffID);

                    // Thực thi câu lệnh UPDATE
                    ThucThiDl(sqlUpdate);

                    // Hiển thị thông báo khi cập nhật thành công
                    MessageBox.Show("Cập nhật thông tin nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Sau khi cập nhật, làm mới các trường nhập liệu và hiển thị lại danh sách nhân viên
                    ClearFields();
                    Display();
                }
                catch (Exception ex)
                {
                    // Hiển thị thông báo khi có lỗi xảy ra
                    MessageBox.Show("Lỗi khi cập nhật thông nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Hiển thị thông báo nếu không có dòng nào được chọn
                MessageBox.Show("Vui lòng chọn một nhân viên để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
                    cn.ConnectionString = @"Data Source=LAPTOP-VOLE2257\TRONGNHAN;Initial Catalog=PNPdata;Integrated Security=True";
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
            if (cbxSearchStaff.Text == "Staff Code")
            {
                dgvwStaff.DataSource = XemDL("select * from [tbStaff*] where StaffCode like '%" + txtSearch.Text.Trim() + "%'");
            }
            if (cbxSearchStaff.Text == "Staff Name")
            {
                dgvwStaff.DataSource = XemDL("select * from [tbStaff*] where Name like N'%" + txtSearch.Text.Trim() + "%'");
            }
            if (cbxSearchStaff.Text == "Staff DOB")
            {
                dgvwStaff.DataSource = XemDL("select * from [tbStaff*] where Age like N'%" + txtSearch.Text.Trim() + "%'");
            }
            if (cbxSearchStaff.Text == "Staff Address")
            {
                dgvwStaff.DataSource = XemDL("select * from [tbStaff*] where Address like N'%" + txtSearch.Text.Trim() + "%'");
            }
            if (cbxSearchStaff.Text == "Staff Gender")
            {
                dgvwStaff.DataSource = XemDL("select * from [tbStaff*] where Gender like N'%" + txtSearch.Text.Trim() + "%'");
            }

        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }

        private void cbxGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gbxIPIFStaff_Enter(object sender, EventArgs e)
        {

        }

        private void txtStaffCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStaffName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhoneStaff_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddressStaff_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpDOB_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dgvwStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbxSearchStaff_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
