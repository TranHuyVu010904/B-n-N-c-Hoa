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



      /*  public void Display()
        {
            using (PNPdataEntities _entity = new PNPdataEntities())
            {
                List<ProductInfo> _ProductList = new List<ProductInfo>();
                _ProductList = _entity.tbProduct_.Select(x => new ProductInfo
                {
                    ID = x.ID,
                    ProductCode = x.ProductCode,
                    ProductName = x.ProductName,
                    Size = x.Size,
                    Color = x.Color,
                    Amount = x.Amount,
                    ProductType = x.ProductType,
                    Price=x.Price
                }).ToList();
                dgvwProduct.DataSource = _ProductList;

            }

        }*/
        private void DataGridViewWidth()
        {
            DataGridViewColumn column = dgvwProduct.Columns[2];
            column.Width = 250;
            DataGridViewColumn column1 = dgvwProduct.Columns[7];
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
            //Display();
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


        //Save

       /* public bool SaveProduct(tbProduct_ tbProduct_)
        {
            bool result = false;
            using (PNPdataEntities _entity = new PNPdataEntities())
            {
                _entity.tbProduct_.Add(tbProduct_);
                _entity.SaveChanges();
                result = true;
            }
            return result;
        }*/

        private void btnSave_Click(object sender, EventArgs e)
        {
            /*tbProduct_ tbproduct = new tbProduct_();
            tbproduct.ProductCode = txtProductCode.Text;
            tbproduct.ProductName = txtProductName.Text;
            tbproduct.Size = cbxSize.Text;
            tbproduct.Amount = Convert.ToInt32(txtAmount.Text);
            tbproduct.Color = cbxColor.Text;
            tbproduct.ProductType = cbxProductTypee.Text;
            tbproduct.Price = Convert.ToDouble(txtPrice.Text);
            bool result = SaveProduct(tbproduct);
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

        //DELETE
       /* public bool DeleteProduct(int id)
        {
            bool result = false;
            try
            {
                using (PNPdataEntities _entity = new PNPdataEntities())
                {
                    tbProduct_ _product = _entity.tbProduct_.Find(id);
                    if (_product != null)
                    {
                        _entity.tbProduct_.Remove(_product);
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
                int idproduct = Convert.ToInt32(lblID.Text);
                bool result = DeleteProduct(idproduct);
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

        //UPDATE
/*        public bool UpdateProduct(tbProduct_ stp)
        {
            bool result = false;
            using (PNPdataEntities _entity = new PNPdataEntities())
            {
                tbProduct_ _product = _entity.tbProduct_.Where(x => x.ID == stp.ID).Select(x => x).FirstOrDefault();
                _product.ProductCode = stp.ProductCode;
                _product.ProductName = stp.ProductName;
                _product.Size = stp.Size;
                _product.Color = stp.Color;
                _product.Amount = stp.Amount;
                _product.ProductType = stp.ProductType;
                _product.Price = stp.Price;
                _entity.SaveChanges();
                result = true;
            }
            return result;
        }
*/
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            /*try
            {
                tbProduct_ stp = new tbProduct_();
                stp.ID = Convert.ToInt32(lblID.Text);
                stp.ProductCode = txtProductCode.Text;
                stp.ProductName = txtProductName.Text;
                stp.Size = cbxSize.SelectedItem.ToString();
                stp.Color = cbxColor.SelectedItem.ToString();
                stp.Amount = Convert.ToInt32(txtAmount.Text);
                stp.ProductType = cbxProductTypee.SelectedItem.ToString();
                stp.Price = Convert.ToDouble(txtPrice.Text);
                bool result = UpdateProduct(stp);
                if (result == true)
                {
                    MessageBox.Show("Cập Nhật Thành Công", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
