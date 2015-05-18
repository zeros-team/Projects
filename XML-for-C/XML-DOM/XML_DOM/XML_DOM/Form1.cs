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

namespace XML_DOM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Khởi tạo đối tượng xử lý của lớp "XỬ LÝ"
        Class_XL xl = new Class_XL();
        int d;
        private void Form1_Load(object sender, EventArgs e)
        {
            xl.hien_du_lieu(datasach);//Hiện dữ liệu
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            //Khởi tạo đối tượng sách của lớp "THỰc THỂ"
            Class_TT sach = new Class_TT();
            //Gán và lấy giá trị cho ô textbox
            sach.Manxb = txt_ma.Text;
            sach.Tennxb = txt_ten.Text;
            sach.Diachi = txt_dc.Text;
            xl.them(sach);//Gọi ham thêm với đối số truyền vào là "sach"
            Form1_Load(sender,e);
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            //Khởi tạo đối tượng của lớp "THỰC THỂ"
            Class_TT sach = new Class_TT();
            sach.Manxb = txt_ma.Text;
            sach.Tennxb = txt_ten.Text;
            sach.Diachi = txt_dc.Text;
            xl.sua(sach);
            txt_ma.Enabled = true;
            txt_ten.Enabled = true;
            txt_dc.Enabled = true;
            Form1_Load(sender,e);
        }

        private void datasach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            d = e.RowIndex;
            txt_ma.Enabled = false;
            txt_ten.Enabled = false;
            txt_dc.Enabled = false;
            txt_ten.Text = datasach.Rows[d].Cells[1].Value.ToString();
            txt_ma.Text = datasach.Rows[d].Cells[0].Value.ToString();
            txt_dc.Text = datasach.Rows[d].Cells[2].Value.ToString();
            Form1_Load(sender,e);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            //Khởi tạo đối tượng lớp thực thể
            Class_TT sach = new Class_TT();
            sach.Manxb = txt_ma.Text;
            sach.Tennxb = txt_ten.Text;
            sach.Diachi = txt_dc.Text;
            xl.xoa(sach);
            Form1_Load(sender,e);
        }

        private void btn_nhap_Click(object sender, EventArgs e)
        {
            txt_ma.Enabled = true;
            txt_ma.Text = "";//gán giá trị rỗng
            //Và xóa dữ liệu trong nó
            txt_ma.Clear();
            txt_dc.Clear();
            txt_ten.Clear();
            Form1_Load(sender,e);
        }

    }
}
