using Nuochoa.Model;
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
using System.Globalization;

namespace Nuochoa
{
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
        }
        private void DisplaytbProduct()
        {
            string query = "SELECT * FROM [tbProduct*]";
            DataTable dt = XemDL(query); 

            dgvwProduct.DataSource = dt;
        }
        private void DataGridViewWidth()
        {
            DataGridViewColumn column = dgvwProduct.Columns[7];
            column.Width = 250;
            DataGridViewColumn column1 = dgvwProduct.Columns[2];
            column1.Width = 200;
            dgvwProduct.Columns[0].Visible = false;
            dgvwProduct.Columns["Price"].DefaultCellStyle.Format = "0,00.## VND";
        }
        public void cbxsize()
        {
            cbxSize.Items.Add("FULL");
            cbxSize.Items.Add("10ml");
            cbxSize.Items.Add("20ml");
            cbxSize.Items.Add("30ml");
            cbxSize.Items.Add("40ml");
            cbxSize.Items.Add("50ml");
            cbxSize.Items.Add("60ml");
            cbxSize.Items.Add("70ml");
            cbxSize.Items.Add("80ml");
            cbxSize.Items.Add("90ml");
            cbxSize.Items.Add("100ml");
            cbxSize.Items.Add("120ml");
            cbxSize.Items.Add("130ml");
            cbxSize.Items.Add("140ml");
            cbxSize.Items.Add("200ml");
            cbxSize.Items.Add("300ml");
        }
        public void cbxcolor()
        {
            cbxColor.Items.Add("Den");
            cbxColor.Items.Add("Trang");
            cbxColor.Items.Add("Xanh");
            cbxColor.Items.Add("Hong");
            cbxColor.Items.Add("Do");
            cbxColor.Items.Add("Vang");
            cbxColor.Items.Add("Cam");
            cbxColor.Items.Add("Luc");
            cbxColor.Items.Add("Tim");
            cbxColor.Items.Add("Than");
            cbxColor.Items.Add("Kim");
            cbxColor.Items.Add("Bac");
        }
        public void cbxproducttype()
        {
            cbxProductTypee.Items.Add("Scandal");
            cbxProductTypee.Items.Add("Chanel");
            cbxProductTypee.Items.Add("Gucci");
            cbxProductTypee.Items.Add("Coco");
            cbxProductTypee.Items.Add("CK");
            cbxProductTypee.Items.Add("Burberry");
            cbxProductTypee.Items.Add("Versace");
            cbxProductTypee.Items.Add("Narciso");
            cbxProductTypee.Items.Add("Valentino");
            cbxProductTypee.Items.Add("Bvlgari");
            cbxProductTypee.Items.Add("Hermes");
            cbxProductTypee.Items.Add("TomFord");
            cbxProductTypee.Items.Add("Lelabo");
           
          


        }
        public void cbxsearchitem()
        {
            cbxSearchProduct.Items.Add("ID sản phẩm");
            cbxSearchProduct.Items.Add("Tên nước hoa");
            cbxSearchProduct.Items.Add("Loại");
            cbxSearchProduct.Items.Add("Color");
            cbxSearchProduct.Items.Add("Kiểu");
        }
        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
            decimal value = decimal.Parse(txtPrice.Text, System.Globalization.NumberStyles.AllowThousands);
            txtPrice.Text = string.Format(culture, "{0:N0}", value);
            txtPrice.Select(txtPrice.Text.Length, 0);
        }
        private void frmProduct_Load(object sender, EventArgs e)
        {
            cbxsize();
            cbxproducttype();
            cbxcolor();
            cbxsearchitem();
            DisplaytbProduct();
            DataGridViewWidth();
        }

        public void ClearFields()
        {
            txtProductCode.Text = "";
            txtProductName.Text = "";
            cbxSize.SelectedIndex = -1;
            cbxColor.SelectedIndex = -1;
            txtAmount.Text = "";
            cbxProductTypee.SelectedIndex = -1;
            txtPrice.Text = "0";
            ckb1.ResetText();
            ckb2.ResetText();
        }


        private void dgvwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvwProduct.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvwProduct.SelectedRows)
                {
                    lblID.Text = row.Cells[0].Value.ToString();
                    txtProductCode.Text = row.Cells[1].Value.ToString();
                    txtProductName.Text = row.Cells[2].Value.ToString();
                    cbxSize.SelectedItem = row.Cells[3].Value.ToString();
                    cbxColor.SelectedItem = row.Cells[4].Value.ToString();
                    txtAmount.Text = row.Cells[5].Value.ToString();
                    cbxProductTypee.Text = row.Cells[6].Value.ToString();
                    txtPrice.Text = row.Cells[7].Value.ToString();
                }
            }
        }





        private void btnSave_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    
                    string prCode = txtProductCode.Text;
                    string prName = txtProductName.Text;
                    string prSize = cbxSize.SelectedItem?.ToString();
                    string prColor = cbxColor.SelectedItem?.ToString();
                    string prType = cbxProductTypee.SelectedItem?.ToString();
                    string prAmount = txtAmount.Text;
                    double prPrice = Convert.ToDouble(txtPrice.Text);

                    // Kiểm tra các giá trị bắt buộc
                    if (String.IsNullOrEmpty(txtProductCode.Text) || String.IsNullOrEmpty(txtProductName.Text))
{
    MessageBox.Show("Vui lòng nhập đầy đủ thông tin sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    return;
}
                    if (IsProductCodeExists(prCode))
                    {
                        MessageBox.Show("Mã sản phẩm đã tồn tại trong cơ sở dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // Không thực hiện thêm nữa nếu mã sản phẩm đã tồn tại
                    }

                    // Xây dựng câu lệnh SQL INSERT
                    string sqlInsert = string.Format("INSERT INTO [tbProduct*] (ProductCode, ProductName, Size, Color, ProductType, Amount, Price) \r\nVALUES ('{0}', N'{1}', N'{2}', N'{3}', N'{4}', '{5}', '{6}')",
                                                      prCode, prName, prSize, prColor, prType, prAmount, prPrice);

                    // Thực thi câu lệnh INSERT
                    ThucThiDl(sqlInsert);

                    // Hiển thị thông báo khi thêm thành công
                    MessageBox.Show("Thêm thông tin sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Sau khi thêm, làm mới các trường nhập liệu
                    ClearFields();

                    // Sau khi thêm, hiển thị lại danh sách sản phẩm
                    DisplaytbProduct();

                    // Cập nhật lại chiều rộng của các cột trong DataGridView (nếu cần)
                    DataGridViewWidth();
                }
                catch (Exception ex)
                {
                    // Hiển thị thông báo khi có lỗi xảy ra
                    MessageBox.Show("Lỗi khi thêm thông tin sản phẩm: " + ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private bool IsProductCodeExists(string productCode, int productId = 0)
        {
            string query = string.Format("SELECT COUNT(*) FROM [tbProduct*] WHERE ProductCode = '{0}'", productCode);
            if (productId > 0)
            {
                query += string.Format(" AND ID <> {0}", productId);
            }

            DataTable dt = XemDL(query);
            int count = Convert.ToInt32(dt.Rows[0][0]);
            return count > 0;
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvwProduct.SelectedRows.Count > 0)
            {
                // Lấy ID của khách hàng từ hàng được chọn trong DataGridView
                int ProductID = Convert.ToInt32(dgvwProduct.SelectedRows[0].Cells["ID"].Value);

                // Xác nhận việc xóa khách hàng từ người dùng
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Tạo câu lệnh SQL DELETE
                        string sqlDelete = string.Format("DELETE FROM [tbProduct*] WHERE ID = {0}", ProductID);

                        // Thực thi câu lệnh DELETE
                        ThucThiDl(sqlDelete);

                        // Hiển thị thông báo khi xóa thành công
                        MessageBox.Show("Xóa khách hàng thành công!");

                        // Hiển thị lại danh sách khách hàng sau khi xóa
                        DisplaytbProduct();
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
        private bool IsCustomerCodeExists(string prCode, int ProductID = 0)
        {
            string query = string.Format("SELECT COUNT(*) FROM [tbProduct*] WHERE ProductCode = '{0}'", prCode);
            if (ProductID > 0)
            {
                query += string.Format(" AND ID <> {0}", ProductID);
            }

            DataTable dt = XemDL(query);
            int count = Convert.ToInt32(dt.Rows[0][0]);
            return count > 0;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblID.Text))
            {
                try
                {
                    int productId = int.Parse(lblID.Text);
                    string prCode = txtProductCode.Text;
                    string prName = txtProductName.Text;
                    string prSize = cbxSize.SelectedItem?.ToString();
                    string prColor = cbxColor.SelectedItem?.ToString();
                    string prType = cbxProductTypee.SelectedItem?.ToString();
                    string prAmount = txtAmount.Text;
                    double prPrice = Convert.ToDouble(txtPrice.Text);

                    // Kiểm tra các giá trị bắt buộc
                    if (String.IsNullOrEmpty(txtProductCode.Text) || String.IsNullOrEmpty(txtProductName.Text))
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Kiểm tra mã sản phẩm đã tồn tại trong cơ sở dữ liệu (trừ sản phẩm đang cập nhật)
                    if (IsProductCodeExists(prCode, productId))
                    {
                        MessageBox.Show("Mã sản phẩm đã tồn tại trong cơ sở dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Xây dựng câu lệnh SQL UPDATE
                    string sqlUpdate = string.Format("UPDATE [tbProduct*] SET ProductCode = '{0}', ProductName = N'{1}', Size = N'{2}', Color = N'{3}', ProductType = N'{4}', Amount = '{5}', Price = '{6}' WHERE ID = {7}",
                                                      prCode, prName, prSize, prColor, prType, prAmount, prPrice, productId);

                    // Thực thi câu lệnh UPDATE
                    ThucThiDl(sqlUpdate);

                    // Hiển thị thông báo khi cập nhật thành công
                    MessageBox.Show("Cập nhật thông tin sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Sau khi cập nhật, làm mới các trường nhập liệu
                    ClearFields();

                    // Sau khi cập nhật, hiển thị lại danh sách sản phẩm
                    DisplaytbProduct();

                    // Cập nhật lại chiều rộng của các cột trong DataGridView (nếu cần)
                    DataGridViewWidth();
                }
                catch (Exception ex)
                {
                    // Hiển thị thông báo khi có lỗi xảy ra
                    MessageBox.Show("Lỗi khi cập nhật thông tin sản phẩm: " + ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Hiển thị thông báo nếu không có sản phẩm nào được chọn để cập nhật
                MessageBox.Show("Vui lòng chọn một sản phẩm để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Close
        private void btnClose_Click(object sender, EventArgs e)
        {
            ClearFields();
        }


        //Reload form


        //Exit Form
        private void btnOffPRO_Click(object sender, EventArgs e)
        {
            this.Close();
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
            if (cbxSearchProduct.Text == "Product Code")
            {
                dgvwProduct.DataSource = XemDL("select * from [tbProduct*] where ProductCode like '%" + txtSearch.Text.Trim() + "%'");
            }
            if (cbxSearchProduct.Text == "Product Name")
            {
                dgvwProduct.DataSource = XemDL("select * from [tbProduct*] where ProductName like N'%" + txtSearch.Text.Trim() + "%'");
            }
            if (cbxSearchProduct.Text == "Size")
            {
                dgvwProduct.DataSource = XemDL("select * from [tbProduct*] where Size like '%" + txtSearch.Text.Trim() + "%'");
            }
            if (cbxSearchProduct.Text == "Color")
            {
                dgvwProduct.DataSource = XemDL("select * from [tbProduct*] where Color like N'%" + txtSearch.Text.Trim() + "%'");
            }
            if (cbxSearchProduct.Text == "Product Type")
            {
                dgvwProduct.DataSource = XemDL("select * from [tbProduct*] where ProductType like N'%" + txtSearch.Text.Trim() + "%'");
            }
        }

     

       

       

        private void cbxProductTypee_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvwProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbxSearchProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProductCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxSize_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxColor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void gbxIPIFProduct_Enter(object sender, EventArgs e)
        {

        }
    }
}
