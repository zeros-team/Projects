using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;
namespace XML_DOM_2
{
    public partial class Form_nhanvien : Form
    {
        public Form_nhanvien()
        {
            InitializeComponent();
        }
        Class_XL xl = new Class_XL();
        int d;

        private void btn_them_Click(object sender, EventArgs e)
        {
            Class_TT nhanvien = new Class_TT();
            nhanvien.Manv = txt_ma.Text;
            nhanvien.Hoten = txt_ten.Text;
            nhanvien.Ngaysinh = txt_ngay.Text;
            nhanvien.Gioitinh = txt_gioitinh.Text;
            nhanvien.Hsluong = txt_hsluong.Text;
            xl.them(nhanvien);
            Form_nhanvien_Load(sender,e);
        }

        private void Form_nhanvien_Load(object sender, EventArgs e)
        {
            xl.hienthi(dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            d = e.RowIndex;
            txt_ma.Text = dataGridView1.Rows[d].Cells[0].Value.ToString();
            txt_ten.Text = dataGridView1.Rows[d].Cells[1].Value.ToString();
            txt_ngay.Text = dataGridView1.Rows[d].Cells[2].Value.ToString();
            txt_gioitinh.Text = dataGridView1.Rows[d].Cells[3].Value.ToString();
            txt_hsluong.Text = dataGridView1.Rows[d].Cells[4].Value.ToString();
            Form_nhanvien_Load(sender,e);
        }
        
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            Class_TT nhanvien = new Class_TT();
            nhanvien.Manv = txt_ma.Text;
            nhanvien.Hoten = txt_ten.Text;
            nhanvien.Ngaysinh = txt_ngay.Text;
            nhanvien.Gioitinh = txt_gioitinh.Text;
            nhanvien.Hsluong = txt_hsluong.Text;
            xl.xoa(nhanvien);
            Form_nhanvien_Load(sender,e);
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            Class_TT nhanvien = new Class_TT();
            nhanvien.Manv = txt_ma.Text;
            nhanvien.Hoten = txt_ten.Text;
            nhanvien.Ngaysinh = txt_ngay.Text;
            nhanvien.Gioitinh = txt_gioitinh.Text;
            nhanvien.Hsluong = txt_hsluong.Text;
            ////////////////////////////////////////
            txt_ma.Enabled = true;
            xl.sua(nhanvien);
            //txt_ma.Enabled = true;
            Form_nhanvien_Load(sender,e);
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_nhap_Click(object sender, EventArgs e)
        {
            txt_gioitinh.Clear();
            txt_hsluong.Clear();
            txt_ma.Clear();
            txt_ngay.Clear();
            txt_ten.Clear();
        }
    }
}
