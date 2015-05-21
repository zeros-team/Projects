using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HCG_HoaHoc
{
    public partial class formLoad : Form
    {
        public formLoad()
        {
            InitializeComponent();
        }

        private void btnzo_Click(object sender, EventArgs e)
        {
            Form frm_ = new Form2();
            frm_.Show();
        }
    }
}
