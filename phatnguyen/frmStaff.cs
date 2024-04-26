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
           /* using (PNPdataEntities _entity = new PNPdataEntities())
            {
                List<StaffInfo> _StaffList = new List<StaffInfo>();
                _StaffList = _entity.tbStaff_.Select(x => new StaffInfo
                {
                    ID = x.ID,
                    Code = x.StaffCode,
                    Name = x.Name,
                    Age=x.Age,
                    Gender = x.Gender,
                    Phone = x.PhoneNumber,
                    Address = x.Address

                }).ToList();
                dgvwStaff.DataSource = _StaffList;

            }*/

        }
        private void DataGridViewWidth()
        {
            DataGridViewColumn column = dgvwStaff.Columns[6];
            column.Width = 350;
            DataGridViewColumn column1 = dgvwStaff.Columns[2];
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


        //SAVE
        private void btnSave_Click(object sender, EventArgs e)
        {
           /* tbStaff_ tbstaff = new tbStaff_();
            tbstaff.StaffCode= txtStaffCode.Text;
            tbstaff.Name = txtStaffName.Text;
            tbstaff.Gender = cbxGender.Text;
            tbstaff.Age = Convert.ToDateTime(dtpDOB.Text);
           // tbstaff.Age = Convert.ToDateTime(dtpDOB.Value.ToString("dd-MM-yyyy"));
            tbstaff.PhoneNumber = txtPhoneStaff.Text;
            tbstaff.Address = txtAddressStaff.Text;
            bool result = SaveStaff(tbstaff);
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

        private void dgvwStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvwStaff.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvwStaff.SelectedRows)
                {
                    lblID.Text = row.Cells[0].Value.ToString();
                    txtStaffCode.Text = row.Cells[1].Value.ToString();
                    txtStaffName.Text = row.Cells[2].Value.ToString();
                    cbxGender.SelectedItem = row.Cells[4].Value.ToString();
                    dtpDOB.Value = Convert.ToDateTime(row.Cells[3].Value);
                    txtPhoneStaff.Text = row.Cells[5].Value.ToString();
                    txtAddressStaff.Text = row.Cells[6].Value.ToString();
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
            /*try
            {
                int idstaff = Convert.ToInt32(lblID.Text);
                bool result = DeleteStaff(idstaff);
                if (result == true)
                {
                    MessageBox.Show("Xóa thành Công", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    Display();
                }
                else
                {
                    MessageBox.Show("Xóa Lỗi", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please try again?\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }*/
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
            /*try
            {
                tbStaff_ sta = new tbStaff_();
                sta.ID = Convert.ToInt32(lblID.Text);
                sta.StaffCode = txtStaffCode.Text;
                sta.Name = txtStaffName.Text;
                sta.Age = Convert.ToDateTime(dtpDOB.Text);
                sta.Gender = cbxGender.SelectedItem.ToString();
                sta.PhoneNumber = txtPhoneStaff.Text;
                sta.Address = txtAddressStaff.Text;
                bool result = UpdateStaff(sta);
                if (result == true)
                {
                    MessageBox.Show("Cập Nhạt Thành Công", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Display();
                }
                else
                {
                    MessageBox.Show("Please try again?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update failed.Please try again?\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
       
        
    }
}
