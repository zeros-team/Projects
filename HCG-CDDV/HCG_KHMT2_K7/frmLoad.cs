using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HCG_KHMT2_K7
{
    public partial class frmLoad : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmLoad()
        {
            InitializeComponent();
        }

        private void btnzo_Click(object sender, EventArgs e)
        {
            Form _frm = new frmSuydien();
            _frm.Show();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm_ = new frmSuydien();
            frm_.Show();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm1 = new frmLuat();
            frm1.Show();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm2 = new frmsukien();
            frm2.Show();
        }
    }
}
