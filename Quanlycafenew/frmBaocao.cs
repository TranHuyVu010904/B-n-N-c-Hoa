using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlycafenew
{
    public partial class frmBaocao : Form
    {
        public frmBaocao()
        {
            InitializeComponent();
        }

        private void frmBaocao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLCoffeeDataSet1.tbHoadon' table. You can move, or remove it, as needed.
            this.tbHoadonTableAdapter.Fill(this.QLCoffeeDataSet1.tbHoadon);
            this.reportViewer1.RefreshReport();
        }
    }
}
