using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nuochoa
{
    public partial class StaffControl : UserControl
    {
        public StaffControl()
        {
            InitializeComponent();
        }

        private void btnManageInforProduct_Click(object sender, EventArgs e)
        {
            frmStaff frmstaff = new frmStaff();
            frmstaff.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSalary frm = new frmSalary();
            frm.Show();
        }
    }
}
