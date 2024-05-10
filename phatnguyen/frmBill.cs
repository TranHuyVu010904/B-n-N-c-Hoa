using Microsoft.SqlServer.Server;
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
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nuochoa
{
    public partial class frmBill : Form

    {
        String strcon = @"Data Source=LAPTOP-6K3UA9B7\HUYVU;Initial Catalog=PNPdata;Integrated Security=True";
        SqlConnection conn = null;
        public frmBill()
        {
            InitializeComponent();
            connect();
        }
        void connect()
        {
            try
            {
                conn = new SqlConnection(strcon); // Khởi tạo kết nối
                conn.Open(); // Mở kết nối
                if (conn.State == ConnectionState.Open)
                {
                    Console.WriteLine("Kết nối đến cơ sở dữ liệu thành công.");
                }
                else
                {
                    Console.WriteLine("Không thể kết nối đến cơ sở dữ liệu.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi mở kết nối: " + ex.Message);
            }
        }
       
        DataTable getDSStaff()
        {
            string strSQL = "Select * from [tbStaff*]"; SqlDataAdapter adapter;
            adapter = new SqlDataAdapter(strSQL, conn);
            DataSet dataset = new DataSet();
            try
            {
                adapter.Fill(dataset); return dataset.Tables[0];
            }
            catch
            {
                return null;
            }
        }
        DataTable getDSCustomer()
        {
            string strSQL = "Select * from [tbCustomer*]"; SqlDataAdapter adapter;
            adapter = new SqlDataAdapter(strSQL, conn);
            DataSet dataset = new DataSet();
            try
            {
                adapter.Fill(dataset); return dataset.Tables[0];
            }
            catch
            {
                return null;
            }
        }
        DataTable getDSProduct()
        {
            string strSQL = "Select * from [tbProduct*]"; SqlDataAdapter adapter;
            adapter = new SqlDataAdapter(strSQL, conn);
            DataSet dataset = new DataSet();
            try
            {
                adapter.Fill(dataset); return dataset.Tables[0];
            }
            catch
            {
                return null;
            }
        }
        DataTable getDSBill()
        {
            string strSQL = "Select * from [tbBill*]"; SqlDataAdapter adapter;
            adapter = new SqlDataAdapter(strSQL, conn);
            DataSet dataset = new DataSet();
            try
            {
                adapter.Fill(dataset); return dataset.Tables[0];
            }
            catch
            {
                return null;
            }
        }




        private void LoadDataGridView(string staffCode)
        {
            using (SqlConnection connection = new SqlConnection(strcon))
            {
                connection.Open();

                string query = "SELECT  [tbBillDetails*].BillCode ,ProductCode, ProductName, Amount, UnitPrice, Discount, IntoMoney " +
                               "FROM [tbBillDetails*] " +
                               "INNER JOIN [tbBill*] ON [tbBillDetails*].BillID = [tbBill*].ID " +
                               "INNER JOIN [tbStaff*] ON [tbBill*].StaffID = [tbStaff*].ID " +
                               "WHERE [tbStaff*].StaffCode = @StaffCode";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    string StaffCode = cbxStaffCode.Text;
                    command.Parameters.AddWithValue("@StaffCode", StaffCode);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Hiển thị tất cả các cột trên DataGridView
                        dgvwBillDetails.AutoGenerateColumns = true;

                        // Gán DataTable làm nguồn dữ liệu cho DataGridView
                        dgvwBillDetails.DataSource = dataTable;
                    }
                }
            }
        }


        public void cbxsearchitem()
        {
            cbxSearchBillCode.Items.Add("Bill Code");

        }

        private bool enableTextChanged = true;
        private void txtUnitPrice_TextChanged(object sender, EventArgs e)
        {
            // Nếu biến cờ không được thiết lập, thoát sớm khỏi sự kiện
            if (!enableTextChanged)
            {
                return;
            }

            // Thực hiện xử lý khi sự kiện được kích hoạt
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
            decimal value = 0;
            if (decimal.TryParse(txtUnitPrice.Text, System.Globalization.NumberStyles.AllowThousands, culture, out value))
            {
                // Thay đổi giá trị biến cờ để ngăn sự kiện xảy ra khi thay đổi giá trị của TextBox
                enableTextChanged = false;

                txtUnitPrice.Text = String.Format(culture, "{0:N0}", value);
                txtUnitPrice.Select(txtUnitPrice.Text.Length, 0);

                // Khôi phục giá trị của biến cờ để cho phép sự kiện xảy ra tiếp tục
                enableTextChanged = true;
            }
        }
        private void txtIntoMoney_TextChanged(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
            decimal value = decimal.Parse(txtIntoMoney.Text, System.Globalization.NumberStyles.AllowThousands);
            txtIntoMoney.Text = String.Format(culture, "{0:N0}", value);
            txtIntoMoney.Select(txtIntoMoney.Text.Length, 0);
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
            decimal value = decimal.Parse(txtTotal.Text, System.Globalization.NumberStyles.AllowThousands);
            txtTotal.Text = String.Format(culture, "{0:N0}", value);
            txtTotal.Select(txtTotal.Text.Length, 0);
        }

        //SET VALUES


        private void cbxStaffCode_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;

            // Kiểm tra giá trị đã chọn từ ComboBox
            if (cb.SelectedValue != null)
            {
                // Lấy mã nhân viên đã chọn
                string selectedStaffID = cb.SelectedValue.ToString();

                // Chuyển đổi selectedStaffID sang kiểu int
                if (int.TryParse(selectedStaffID, out int staffID))
                {
                    if (cbxStaffCode.SelectedIndex == -1)
                    {
                        // Nếu không có mục nào được chọn trong ComboBox, xóa nội dung của TextBox
                        txtStaffName.Clear();
                    }
                    // Truy vấn cơ sở dữ liệu để lấy tên của nhân viên dựa trên mã nhân viên
                    string query = "SELECT Name FROM [tbStaff*] WHERE ID = @ID";

                    using (SqlConnection conn = new SqlConnection(strcon))
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", staffID); // Sử dụng staffID thay vì selectedStaffID
                        conn.Open();

                        // Thực thi truy vấn
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            // Hiển thị tên nhân viên vào TextBox
                            txtStaffName.Text = reader["Name"].ToString();
                            reader.Close();
                            // Đóng SqlDataReader sau khi đã sử dụng
                            AddUpIntoMoneyByID(staffID, conn);
                        }
                        else
                        {
                            // Nếu không tìm thấy thông tin về nhân viên, xóa nội dung của TextBox
                            txtStaffName.Clear();
                        }
                    }
                }
            }
        }

        private void AddUpIntoMoneyByID(int staffID, SqlConnection connection)
        {
            
            string query = "SELECT SUM(IntoMoney) AS TotalIntoMoney FROM [tbBillDetails*] " +
                               "INNER JOIN [tbBill*] ON [tbBillDetails*].BillID = [tbBill*].ID " +
                               "WHERE [tbBill*].StaffID = @StaffID";

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@StaffID", staffID); // Sử dụng tên tham số là @StaffID
                object result = cmd.ExecuteScalar();

                if (result != DBNull.Value)
                {
                    decimal totalIntoMoney = Convert.ToDecimal(result);
                    // Hiển thị tổng IntoMoney vào TextBox
                    txtTotal.Text = totalIntoMoney.ToString();
                }
            }
        }



        private void cbxCustomerCode_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;

            // Kiểm tra giá trị đã chọn từ ComboBox
            if (cb.SelectedValue != null)
            {
                // Lấy mã khách hàng đã chọn
                string selectedCustomerID = cb.SelectedValue.ToString();
                // Chuyển đổi selectedStaffID sang kiểu int
                if (int.TryParse(selectedCustomerID, out int CustomerID))
                {
                    // Truy vấn cơ sở dữ liệu để lấy thông tin của khách hàng dựa trên mã khách hàng
                    string query = "SELECT Name, PhoneNumber, Address FROM [tbCustomer*] WHERE ID = @CustomerID";

                    using (SqlConnection conn = new SqlConnection(strcon))
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CustomerID", CustomerID);
                        conn.Open();

                        // Thực thi truy vấn
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            // Hiển thị thông tin của khách hàng vào các TextBox tương ứng
                            txtCustomerName.Text = reader["Name"].ToString();
                            txtPhoneCustomer.Text = reader["PhoneNumber"].ToString();
                            txtAddressCustomer.Text = reader["Address"].ToString();
                        }
                        else
                        {
                            // Nếu không tìm thấy thông tin về khách hàng, xóa nội dung của các TextBox
                            txtCustomerName.Clear();
                            txtPhoneCustomer.Clear();
                            txtAddressCustomer.Clear();
                        }
                    }
                }
            }
        }
        private void cbxProductCode_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;

            // Kiểm tra giá trị đã chọn từ ComboBox
            if (cb.SelectedValue != null)
            {
                // Lấy mã sản phẩm đã chọn
                string selectedProductID = cb.SelectedValue.ToString();
                if (int.TryParse(selectedProductID, out int CustomerID))
                {


                    // Truy vấn cơ sở dữ liệu để lấy thông tin của sản phẩm dựa trên mã khách hàng
                    string query = "SELECT ProductName, Price FROM [tbProduct*] WHERE ID = @ProductID";

                    using (SqlConnection conn = new SqlConnection(strcon))
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ProductID", selectedProductID);
                        conn.Open();

                        // Thực thi truy vấn
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            // Hiển thị thông tin của sản phẩm vào các TextBox tương ứng
                            txtProductName.Text = reader["ProductName"].ToString();
                            txtUnitPrice.Text = reader["Price"].ToString();

                        }
                        else
                        {
                            // Nếu không tìm thấy thông tin về sản phẩm, xóa nội dung của các TextBox
                            txtProductName.Clear();
                            txtUnitPrice.Clear();

                        }
                    }
                }
            }
        }
        private void cbxSearchBillCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }



        private void frmBill_Load(object sender, EventArgs e)
        {
            // Mở kết nối đến cơ sở dữ liệu
            using (SqlConnection conn = new SqlConnection(strcon))
            {
                conn.Open();
                string staffCode = cbxStaffCode.Text;
                // Đặt DataSource cho ComboBox trước khi đặt SelectedIndex
                cbxStaffCode.DataSource = getDSStaff();
                cbxStaffCode.DisplayMember = "StaffCode";
                cbxStaffCode.ValueMember = "ID";
                
                // Đặt SelectedIndex của ComboBox thành -1 để không có mục nào được chọn ban đầu
                cbxStaffCode.SelectedIndex = -1;
                if (cbxStaffCode.SelectedIndex == -1)
                {
                    // Nếu không có mục nào được chọn trong ComboBox, xóa nội dung của TextBox
                    txtStaffName.Clear();
                }

                // Đổ dữ liệu lên combobox Customer
                cbxCustomerCode.DataSource = getDSCustomer();
                cbxCustomerCode.DisplayMember = "CustomerCode";
                cbxCustomerCode.ValueMember = "ID";
                cbxCustomerCode.SelectedIndex = -1;
                if (cbxCustomerCode.SelectedIndex == -1)
                {
                    // Nếu không có mục nào được chọn trong ComboBox, xóa nội dung của TextBox
                    txtCustomerName.Clear();
                    txtAddressCustomer.Clear();
                    txtPhoneCustomer.Clear();
                }
                // Đổ dữ liệu lên combobox Product
                cbxProductCode.DataSource = getDSProduct();
                cbxProductCode.DisplayMember = "ProductCode";
                cbxProductCode.ValueMember = "ID";
                cbxProductCode.SelectedIndex = -1;
                if (cbxProductCode.SelectedIndex == -1)
                {
                    // Nếu không có mục nào được chọn trong ComboBox, xóa nội dung của TextBox
                    txtProductName.Clear();
                    txtUnitPrice.Clear();
                }

                cbxStaffCode.SelectedIndexChanged += CbxStaffCode_SelectedIndexChanged;

               
                cbxSearchBillCode.DataSource = getDSBill();
                cbxSearchBillCode.DisplayMember = "BillCode";
                cbxSearchBillCode.ValueMember = "ID";
                cbxSearchBillCode.SelectedIndex = -1;

                

                // Load dữ liệu lên DataGridView ban đầu
                LoadDataGridView(staffCode);
            }
        }
        private void CbxStaffCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            string staffCode = cbxStaffCode.Text;
            LoadDataGridView(staffCode);
        }






        public void ClearFields()
        {

            txtAmount.Clear();
            txtAmount.Clear();
            txtBillCode.Clear();
            cbxStaffCode.SelectedIndex = -1;
            if (cbxStaffCode.SelectedIndex == -1)
            {
                // Nếu không có mục nào được chọn trong ComboBox, xóa nội dung của TextBox
                txtStaffName.Clear();
            }
            cbxCustomerCode.SelectedIndex = -1;
            if (cbxCustomerCode.SelectedIndex == -1)
            {
                // Nếu không có mục nào được chọn trong ComboBox, xóa nội dung của TextBox
                txtCustomerName.Clear();
                txtAddressCustomer.Clear();
                txtPhoneCustomer.Clear();
            }
            cbxProductCode.SelectedIndex = -1;
            if (cbxProductCode.SelectedIndex == -1)
            {
                // Nếu không có mục nào được chọn trong ComboBox, xóa nội dung của TextBox
                txtProductName.Clear();
                txtUnitPrice.Clear();
            }


        }

        private void panel2_MouseDown_1(object sender, MouseEventArgs e)
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


        //OFF FORM
        private void btnOffBill_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private int GetCustomerIDByCode(string customerCode)
        {
            int customerID = -1; // Giả sử -1 là giá trị mặc định nếu không tìm thấy

            // Kết nối đến cơ sở dữ liệu và thực hiện truy vấn để lấy CustomerID dựa trên CustomerCode
            string query = "SELECT ID FROM [tbCustomer*] WHERE CustomerCode = @CustomerCode";

            using (SqlConnection conn = new SqlConnection(strcon))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@CustomerCode", customerCode);
                conn.Open();

                // Thực thi truy vấn
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    // Chuyển đổi kết quả thành kiểu số nguyên
                    customerID = Convert.ToInt32(result);
                }
            }

            return customerID;
        }
        private int GetStaffIDByCode(string staffCode)
        {
            int staffID = -1; // Giả sử -1 là giá trị mặc định nếu không tìm thấy

            // Kết nối đến cơ sở dữ liệu và thực hiện truy vấn để lấy StaffID dựa trên StaffCode
            string query = "SELECT ID FROM [tbStaff*] WHERE StaffCode = @StaffCode";

            using (SqlConnection conn = new SqlConnection(strcon))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@StaffCode", staffCode);
                conn.Open();

                // Thực thi truy vấn
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    // Chuyển đổi kết quả thành kiểu số nguyên
                    staffID = Convert.ToInt32(result);
                }
            }

            return staffID;
        }
        private int GetProductIDByCode(string ProductCode)
        {
            int ProductID = -1; // Giả sử -1 là giá trị mặc định nếu không tìm thấy

            // Kết nối đến cơ sở dữ liệu và thực hiện truy vấn để lấy ProductID dựa trên ProductCode
            string query = "SELECT ID FROM [tbProduct*] WHERE ProductCode = @ProductCode";

            using (SqlConnection conn = new SqlConnection(strcon))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@ProductCode", ProductCode);
                conn.Open();

                // Thực thi truy vấn
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    // Chuyển đổi kết quả thành kiểu số nguyên
                    ProductID = Convert.ToInt32(result);
                }
            }

            return ProductID;
        }
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem các trường dữ liệu có đầy đủ không
            if (dtpDOS.Value == null || string.IsNullOrWhiteSpace(cbxStaffCode.Text) || string.IsNullOrWhiteSpace(cbxCustomerCode.Text) || string.IsNullOrWhiteSpace(txtIntoMoney.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }

            // Lấy thông tin từ các điều khiển trên giao diện người dùng
            DateTime DOS = dtpDOS.Value;
            string StaffCode = cbxStaffCode.Text;
            string CustomerCode = cbxCustomerCode.Text;
            string Total = txtIntoMoney.Text.Replace(".", "");
            float TotalFloat = float.Parse(Total);
            int CustomerID = GetCustomerIDByCode(CustomerCode);
            int StaffID = GetStaffIDByCode(StaffCode);
            string ProductCode = cbxProductCode.Text;
            int productID = GetProductIDByCode(ProductCode);
            string billCode = txtBillCode.Text;
            string productName = txtProductName.Text;
            string amount = txtAmount.Text;
            string UnitPrice = txtUnitPrice.Text.Replace(".", "");
            float UnitPriceFloat = float.Parse(UnitPrice);
            string discount = txtDiscount.Text;
            int staffID = GetStaffIDByCode(StaffCode);






            // Kiểm tra xem StaffID và CustomerID có hợp lệ không
            if (StaffID == -1 || CustomerID == -1)
            {
                MessageBox.Show("Mã nhân viên hoặc mã khách hàng không hợp lệ.");
                return;
            }

            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            // Thực hiện câu lệnh SQL để thêm sản phẩm vào bảng của bạn
            try
            {

                string strSQL = "INSERT INTO [tbBill*] (BillCode,CustomerID, StaffID, DOS, Total, CustomerCode, StaffCode) " +
                                "VALUES (@BillCode,@CustomerID, @StaffID, @DOS, @Total, @CustomerCode, @StaffCode)";
                SqlCommand cmd = new SqlCommand(strSQL, conn);
                cmd.Parameters.AddWithValue("@BillCode", billCode);
                cmd.Parameters.AddWithValue("@DOS", DOS);
                cmd.Parameters.AddWithValue("@StaffID", StaffID);
                cmd.Parameters.AddWithValue("@StaffCode", StaffCode);
                cmd.Parameters.AddWithValue("@CustomerID", CustomerID);
                cmd.Parameters.AddWithValue("@CustomerCode", CustomerCode);
                cmd.Parameters.AddWithValue("@Total", TotalFloat);
                cmd.ExecuteNonQuery();

                int insertedBillID;
                using (SqlCommand sqlcmd = new SqlCommand("SELECT ID FroM [tbBill*] where BillCode=@BillCode", conn))
                {
                    sqlcmd.Parameters.AddWithValue("@BillCode", billCode);
                  
                    //conn.Open();
                    var result = sqlcmd.ExecuteScalar();
                    if (result != null)
                    {
                        insertedBillID = Convert.ToInt32(result);
                        // Thêm dữ liệu vào bảng tbBillDetail
                        string strSQLDetail = "INSERT INTO [tbBillDetails*] (ProductID, ProductName,ProductCode, BillID, BillCode, Amount, UnitPrice, Discount, IntoMoney) " +
                                               "VALUES (@ProductID, @ProductName, @ProductCode, @BillID, @BillCode, @Amount, @UnitPrice, @Discount, @IntoMoney)";
                        SqlCommand cmdDetail = new SqlCommand(strSQLDetail, conn);
                        cmdDetail.Parameters.AddWithValue("@ProductID", productID);
                        cmdDetail.Parameters.AddWithValue("@ProductName", productName);
                        cmdDetail.Parameters.AddWithValue("@ProductCode", ProductCode);
                        cmdDetail.Parameters.AddWithValue("@BillID", insertedBillID);
                        cmdDetail.Parameters.AddWithValue("@BillCode", billCode);
                        cmdDetail.Parameters.AddWithValue("@Amount", amount);
                        cmdDetail.Parameters.AddWithValue("@UnitPrice", UnitPriceFloat);
                        cmdDetail.Parameters.AddWithValue("@Discount", discount);
                        cmdDetail.Parameters.AddWithValue("@IntoMoney", TotalFloat);
                        AddUpIntoMoneyByID(staffID, conn);
                        cmdDetail.ExecuteNonQuery();
                        MessageBox.Show("Thêm sản phẩm thành công");
                        LoadDataGridView(billCode);
                       

                    }
                    else
                    {
                        MessageBox.Show("Lỗi khi thêm sản phẩm: " );
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm sản phẩm: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }


        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            double unitprice, discount, intomoney;
            int Am;
            if (txtAmount.Text == "")

                Am = 0;

            else

                Am = Convert.ToInt32(txtAmount.Text);

            if (txtDiscount.Text == "")

                discount = 0;

            else

                discount = Convert.ToDouble(txtDiscount.Text);

            if (txtUnitPrice.Text == "")

                unitprice = 0;

            else
            {
                unitprice = Convert.ToDouble(txtUnitPrice.Text);
                intomoney = Am * unitprice - Am * unitprice * discount / 100;
                txtIntoMoney.Text = intomoney.ToString();
                //txtIntoMoney.Text=intomoney.ToString("N3").Replace(".000","");
            }

        }

        public void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            double unitprice, discount, intomoney;
            int Am;
            if (txtAmount.Text == "")

                Am = 0;

            else

                Am = Convert.ToInt32(txtAmount.Text);

            if (txtDiscount.Text == "")

                discount = 0;

            else

                discount = Convert.ToDouble(txtDiscount.Text);

            if (txtUnitPrice.Text == "")

                unitprice = 0;

            else
            {
                unitprice = Convert.ToDouble(txtUnitPrice.Text);
                intomoney = Am * unitprice - Am * unitprice * discount / 100;
                txtIntoMoney.Text = intomoney.ToString();
                txtIntoMoney.Text = intomoney.ToString("N3").Replace(".000", "");
            }
        }
        

       


       private void btnDeleteProduct_Click(object sender, EventArgs e)
{
        string billCode = txtBillCode.Text;

        string deleteDetailsQuery = "DELETE FROM [tbBillDetails*] WHERE BillCode = @BillCode";
        string deleteBillQuery = "DELETE FROM [tbBill*] WHERE [tbBill*].BillCode = @BillCode"; // Thêm [tbBill*]. trước BillCode

        try
        {
                using (SqlConnection connection = new SqlConnection(strcon))
                 {
                 connection.Open();
                using (SqlCommand command = new SqlCommand(deleteDetailsQuery, connection))
                {
                command.Parameters.AddWithValue("@BillCode", billCode);
                command.ExecuteNonQuery();
                }
                 }

                using (SqlConnection connection = new SqlConnection(strcon))
                 {
                 connection.Open();
                using (SqlCommand command = new SqlCommand(deleteBillQuery, connection))
                {
                command.Parameters.AddWithValue("@BillCode", billCode);
                command.ExecuteNonQuery();
                }
                }

                 MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Tải lại dữ liệu sau khi xóa thành công
                LoadDataGridView(billCode);
                }
            catch (Exception ex)
                {
                     MessageBox.Show("Xóa thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
            }
        
        private void btnAddBill_Click(object sender, EventArgs e)
        {
            string newBillCode = Functions.CreateKey("BILL");
            txtBillCode.Text = newBillCode;

            string staffCode = "your_staff_code"; // Thay bằng giá trị thực tế của staffCode
            LoadDataGridView(staffCode);
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Xác định mã BillCode được chọn từ ComboBox
            string selectedBillCode = cbxSearchBillCode.SelectedItem.ToString();

            // Tạo kết nối đến cơ sở dữ liệu
            using (SqlConnection connection = new SqlConnection(strcon))
            {
                // Mở kết nối
                connection.Open();
                string query = "SELECT * FROM [tbBillDetails*] WHERE BillCode = @BillCode";
                // Tạo đối tượng SqlCommand để thực thi câu truy vấn
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Thêm tham số cho câu truy vấn
                    command.Parameters.AddWithValue("@BillCode", selectedBillCode);

                    // Tạo đối tượng SqlDataAdapter để lấy dữ liệu từ câu truy vấn
                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    // Tạo DataTable để chứa dữ liệu từ câu truy vấn
                    DataTable dataTable = new DataTable();

                        
                    // Đổ dữ liệu từ SqlDataAdapter vào DataTable
                    adapter.Fill(dataTable);

                    Console.WriteLine("Số lượng dòng dữ liệu trả về từ câu truy vấn: " + dataTable.Rows.Count);

                    // Hiển thị dữ liệu trong DataGridView 
                    dgvwBillDetails.DataSource = dataTable;
                }
            }
        }
        

               

            


        private void lblID_Click_1(object sender, EventArgs e)
        {

        }

        

        private void dgvwBillDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem có phải là ô dữ liệu được nhấp vào không
            if (e.RowIndex >= 0 && dgvwBillDetails.Columns[e.ColumnIndex].Name == "BillCode")
            {
                // Lấy giá trị của cột "BillCode" ở hàng được nhấp vào
                string selectedBillCode = dgvwBillDetails.Rows[e.RowIndex].Cells["BillCode"].Value.ToString();

                // Thực hiện truy vấn SQL để lấy thông tin từ cả hai bảng tbBill và tbBillDetails dựa trên BillCode
                string query = "SELECT [tbCustomer*].CustomerCode, [tbStaff*].StaffCode, [tbBill*].DOS, [tbBill*].BillCode, [tbBillDetails*].ProductCode, [tbBillDetails*].ProductName, " +
               "[tbBillDetails*].Amount, [tbBillDetails*].UnitPrice, [tbBillDetails*].Discount, " +
               "[tbBillDetails*].IntoMoney " +
               "FROM [tbBill*] " +
               "INNER JOIN [tbBillDetails*] ON [tbBill*].ID = [tbBillDetails*].BillID " +
               "INNER JOIN [tbStaff*] ON [tbStaff*].ID = [tbBill*].StaffID " +
               "INNER JOIN [tbCustomer*] ON [tbCustomer*].ID = [tbBill*].CustomerID "+
               "WHERE [tbBill*].BillCode = @BillCode";

                // Thực thi truy vấn và lấy dữ liệu
                using (SqlConnection connection = new SqlConnection(strcon))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BillCode", selectedBillCode);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Lấy dữ liệu từ cơ sở dữ liệu
                                DateTime DOS = reader.GetDateTime(reader.GetOrdinal("DOS"));
                                string BillCode = reader["BillCode"].ToString();
                                string productID = reader["ProductCode"].ToString();
                                string productName = reader["ProductName"].ToString();
                                string amount = reader["Amount"].ToString();
                                string unitPrice = reader["UnitPrice"].ToString();
                                string discount = reader["Discount"].ToString();
                                string intoMoney = reader["IntoMoney"].ToString();
                                string StaffCode = reader["StaffCode"].ToString();
                                string CustomerCode = reader["CustomerCode"].ToString();

                                // Hiển thị dữ liệu lên các điều khiển trên giao diện người dùng
                                txtBillCode.Text = BillCode;
                                cbxProductCode.Text = productID;
                                txtProductName.Text = productName;
                                txtAmount.Text = amount;
                                txtUnitPrice.Text = unitPrice;
                                txtDiscount.Text = discount;
                                txtIntoMoney.Text = intoMoney;
                                dtpDOS.Value = DOS;
                                cbxStaffCode.Text = StaffCode;
                                cbxCustomerCode.Text = CustomerCode;
                            }
                        }
                    }
                }
            }
        }

        private void cbxCustomerCode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxStaffCode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelBill_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
