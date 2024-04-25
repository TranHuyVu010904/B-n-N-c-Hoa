using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlycafenew
{
    public partial class frmHoadon : Form
    {
        private string IDhoadon, TT, KT, TienTh, NV, day;
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-Q2U43A9U;Initial Catalog=qlcf;Integrated Security=True");
        SqlCommand command;
        SqlDataAdapter da;
        DataTable dt;
        public void DisplayData()
        {
            da = new SqlDataAdapter("select dbo.tbSanpham.TenSP, dbo.tbHoadon.Dongia, dbo.tbHoadon.SoLuong, dbo.tbHoadon.SoLuong*dbo.tbHoadon.Dongia as 'Thanh Tien' from dbo.tbHoadon, dbo.tbSanpham where tbHoadon.ID = tbSanpham.ID", conn);
            dt = new DataTable();
            da.Fill(dt);
            dgvPuduct.DataSource = dt;

        }
        public frmHoadon(string MSHD, string Tongtien, string Khachtra, string Tienthua, string Nhanvien, string Ngay)
        {
            InitializeComponent();
            this.IDhoadon = MSHD;
            this.TT = Tongtien;
            this.KT = Khachtra;
            this.TienTh = Tienthua;
            this.NV = Nhanvien;
            this.day = Ngay;

        }
        private void frmHoadon_Load(object sender, EventArgs e)
        {
            DisplayData();
            // TODO: This line of code loads data into the 'qLCoffeeDataSet.tbHoadon' table. You can move, or remove it, as needed.
            this.tbHoadonTableAdapter.Fill(this.qLCoffeeDataSet.tbHoadon);
            txtIDBill.Text = IDhoadon;
            txtTotal.Text = TT;
            txtGive.Text = KT;
            txtExchange.Text = KT;
            txtStaff.Text = NV;
            dtpDay.Value = DateTime.ParseExact(day, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            // dtpDay.Text = day;
        }
    }
}
