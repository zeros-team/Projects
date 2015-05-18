using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XMLDOM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ClassXL xl = new ClassXL();
        int d;
        private void btnclear_Click(object sender, EventArgs e)
        {
            txtdiachi.Clear();
            txtmanxb.Clear();
            txttennxb.Clear();
            Form1_Load(sender, e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            xl.hiendulieu(dataGridView);
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            ClassTT sach = new ClassTT();
            sach.Manxb = txtmanxb.Text;
            sach.Tennxb = txttennxb.Text;
            sach.Diachi = txtdiachi.Text;
            xl.themnxb(sach);
            Form1_Load(sender, e);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            ClassTT sach = new ClassTT();
            sach.Manxb = txtmanxb.Text;
            sach.Tennxb = txttennxb.Text;
            sach.Diachi = txtdiachi.Text;
            xl.suanxb(sach);
            Form1_Load(sender, e);
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            ClassTT sach = new ClassTT();
            sach.Manxb = txtmanxb.Text;
            sach.Tennxb = txttennxb.Text;
            sach.Diachi = txtdiachi.Text;
            xl.xoanxb(sach);
            Form1_Load(sender, e);
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
