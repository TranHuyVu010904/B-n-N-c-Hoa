using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;
using Nuochoa.Model;

namespace Nuochoa
{
    public partial class frmSalary : Form
    {
        public frmSalary()
        {
            InitializeComponent();
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
        const int WS_MINIMIZEBOX = 0x30000;
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
        public void Display()
        {
           /* using (PNPdataEntities _entity = new PNPdataEntities())
            {
                List<SalaryInfo> _salaryinfo = new List<SalaryInfo>();
                _salaryinfo = _entity.tbSalary_.Select(x => new SalaryInfo
                {
                    ID=x.ID,
                    StaffCode=x.StaffCode,
                    StaffName=x.StaffName,
                    HoursWork=x.Hours_work,
                    Bonus=x.Bonus,
                    TotalSalary=x.Total_Salary
                }).ToList();
                dgvwSalary.DataSource = _salaryinfo;
            }*/
        }
        private void DataGridViewLoad()
        {
            dgvwSalary.Columns[0].Visible = false;
            dgvwSalary.Columns[4].DefaultCellStyle.Format = "0,00.## VND";
            dgvwSalary.Columns[5].DefaultCellStyle.Format = "0,00.## VND";
        }

        private void txtTotalSalary_TextChanged(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
            decimal value = decimal.Parse(txtTotalSalary.Text, System.Globalization.NumberStyles.AllowThousands);
            txtTotalSalary.Text = String.Format(culture, "{0:N0}", value);
            txtTotalSalary.Select(txtTotalSalary.Text.Length, 0);
        }
        public void SetValueStaff()
        {
            /*using (PNPdataEntities _entity = new PNPdataEntities())
            {
                List<tbStaff_> _staff = new List<tbStaff_>();
                _staff = _entity.tbStaff_.ToList();
                cbxStaffCode.DataSource = _staff;
                cbxStaffCode.DisplayMember = "StaffCode";
                cbxStaffCode.ValueMember = "ID";
            }*/
        }

        private void cbxStaffCode_SelectedValueChanged(object sender, EventArgs e)
        {
            /*ComboBox cb = sender as ComboBox;
            using (PNPdataEntities _entity = new PNPdataEntities())
                if (cb.SelectedValue != null)
                {
                    tbStaff_ tbs = new tbStaff_();
                    tbs = cb.SelectedItem as tbStaff_;
                    txtStaffName.Text = tbs.Name;
                }*/
        }

        private void chkProbation_CheckedChanged(object sender, EventArgs e)
        {
            double luongcanban = 40000;
            double luongthuviec = 30000;
            double Tongluong,bouns ;
            int hours;
            if (txtHours.Text == "")
                hours = 0;
            else
                hours = Convert.ToInt32(txtHours.Text);
            if (txtBonus.Text == "")
                bouns = 0;
            else
                bouns = Convert.ToDouble(txtBonus.Text);
            if (chkProbation.Checked==true)
            {
                Tongluong = hours * luongthuviec + bouns;
                txtTotalSalary.Text = Tongluong.ToString();
            }
            else
            {
                Tongluong = hours * luongcanban + bouns;
                txtTotalSalary.Text = Tongluong.ToString();
            }
        }

        private void txtHours_TextChanged(object sender, EventArgs e)
        {
            double luongcanban = 40000;
            double luongthuviec = 30000;
            double Tongluong, bouns;
            int hours;
            if (txtHours.Text == "")
                hours = 0;
            else
                hours = Convert.ToInt32(txtHours.Text);
            if (txtBonus.Text == "")
                bouns = 0;
            else
                bouns = Convert.ToDouble(txtBonus.Text);
            if (chkProbation.Checked == true)
            {
                Tongluong = hours * luongthuviec + bouns;
                txtTotalSalary.Text = Tongluong.ToString();
            }
            else
            {
                Tongluong = hours * luongcanban + bouns;
                txtTotalSalary.Text = Tongluong.ToString();
            }
        }
        private void txtBonus_TextChanged(object sender, EventArgs e)
        {
            double luongcanban = 40000;
            double luongthuviec = 30000;
            double Tongluong, bouns;
            int hours;
            if (txtHours.Text == "")
                hours = 0;
            else
                hours = Convert.ToInt32(txtHours.Text);
            if (txtBonus.Text == "")
                bouns = 0;
            else
                bouns = Convert.ToDouble(txtBonus.Text);
            if (chkProbation.Checked == true)
            {
                Tongluong = hours * luongthuviec + bouns;
                txtTotalSalary.Text = Tongluong.ToString();
            }
            else
            {
                Tongluong = hours * luongcanban + bouns;
                txtTotalSalary.Text = Tongluong.ToString();
            }
        }

        public void ClearFields()
        {

            cbxStaffCode.SelectedIndex = -1;
            txtStaffName.Text = "";
            txtHours.Text = "";
            chkProbation.Checked = false;
            txtBonus.Text = "";
            txtTotalSalary.Text = "";
        }

        private void btnOffStaff_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSalary_Load(object sender, EventArgs e)
        {
            SetValueStaff();
            cbxStaffCode.SelectedIndex = -1;
            txtStaffName.Text = "";
            txtBonus.Text = "0";
            Display();
            DataGridViewLoad();
            Total();
        }

        /*public bool SaveSalary(tbSalary_ tbSalary_)
        {
            bool result = false;
            using (PNPdataEntities _entity = new PNPdataEntities())
            {
                _entity.tbSalary_.Add(tbSalary_);
                _entity.SaveChanges();
                result = true;
            }
            return result;
        }*/

        private void btnSave_Click(object sender, EventArgs e)
        {
            /*tbSalary_ tbSalary_ = new tbSalary_();
            tbSalary_.StaffCode = cbxStaffCode.Text;
            tbSalary_.StaffName = txtStaffName.Text;
            tbSalary_.Hours_work = Convert.ToInt32(txtHours.Text);
            tbSalary_.Bonus = Convert.ToDouble(txtBonus.Text);
            tbSalary_.Total_Salary = Convert.ToDouble(txtTotalSalary.Text);
            bool result = SaveSalary(tbSalary_);
            if (result == true)
            {
                MessageBox.Show("Thêm Thành Công", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Display();
            }
            else
            {
                MessageBox.Show("Please try again?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }*/
        }

        private void dgvwSalary_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvwSalary.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvwSalary.SelectedRows)
                {
                    lblID.Text = row.Cells[0].Value.ToString();
                    cbxStaffCode.Text = row.Cells[1].Value.ToString();
                    txtStaffName.Text = row.Cells[2].Value.ToString();
                    txtHours.Text = row.Cells[3].Value.ToString();
                    txtBonus.Text = row.Cells[4].Value.ToString();
                    txtTotalSalary.Text= row.Cells[5].Value.ToString();
                }
            }
        }

       /* public bool DeleteSalary(int id)
        {
            bool result = false;
            try
            {
                using (PNPdataEntities _entity = new PNPdataEntities())
                {
                    tbSalary_ _salary = _entity.tbSalary_.Find(id);
                    if (_salary != null)
                    {
                        _entity.tbSalary_.Remove(_salary);
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
                int idsalary = Convert.ToInt32(lblID.Text);
                bool result = DeleteSalary(idsalary);
                if (result == true)
                {
                    MessageBox.Show("Xóa Thành Công", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    Display();
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

      /*  public bool UpdateSalary(tbSalary_ sts)
        {
            bool result = false;
            using (PNPdataEntities _entity = new PNPdataEntities())
            {
                tbSalary_ _salary = _entity.tbSalary_.Where(x => x.ID == sts.ID).Select(x => x).FirstOrDefault();
                _salary.Hours_work = sts.Hours_work;
                _salary.Bonus = sts.Bonus;
                _salary.Total_Salary = sts.Total_Salary;
                _entity.SaveChanges();
                result = true;
            }
            return result;
        }*/

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            /*try
            {
                tbSalary_ sts = new tbSalary_();
                sts.ID = Convert.ToInt32(lblID.Text);
                sts.Hours_work = Convert.ToInt32(txtHours.Text);
                sts.Bonus = Convert.ToDouble(txtBonus.Text);
                sts.Total_Salary = Convert.ToDouble(txtTotalSalary.Text);
                bool result = UpdateSalary(sts);
                if (result == true)
                {
                    MessageBox.Show("Cập Nhật Thnhf Công", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Display();
                }
                else
                {
                    MessageBox.Show("Please try again?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please try again?\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }*/
        }

        private void btnHideForm_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void Total()
        {
            txtTotalSalayList.Text = "0";
            for (int i = 0; i < dgvwSalary.Rows.Count; i++)
            {
                txtTotalSalayList.Text = Convert.ToString(double.Parse(txtTotalSalayList.Text) + double.Parse(dgvwSalary.Rows[i].Cells[5].Value.ToString()));
            }
        }

        private void txtTotalSalayList_TextChanged(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
            decimal value = decimal.Parse(txtTotalSalayList.Text, System.Globalization.NumberStyles.AllowThousands);
            txtTotalSalayList.Text = String.Format(culture, "{0:N0}", value);
            txtTotalSalayList.Select(txtTotalSalayList.Text.Length, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }

        private void gbxInfoSalary_Enter(object sender, EventArgs e)
        {

        }
    }
}
