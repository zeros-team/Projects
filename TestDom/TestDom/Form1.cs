using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace TestDom
{
    public partial class Form1 : Form
    {
        public Form1() 
        { 
            InitializeComponent(); 
        }
        private void btnTaoFile_Click(object sender, EventArgs e)
        {
            if (txtTaoFile.Text == "") { MessageBox.Show("Tên file ko thể để trống"); }
            else
            {
                string s = txtTaoFile.Text + ".xml";
                XmlTextWriter writer = new XmlTextWriter(s, Encoding.UTF8);
                writer.WriteStartDocument();
                writer.WriteStartElement("QlDiem");
                writer.WriteComment("Chú thích nhé");
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Close();
                MessageBox.Show("Tạo thành công OKE");
            }
        }

        public void loadCombo(ComboBox cb)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(nguon);
            XmlNodeList lst = doc.SelectNodes("//hocsinh/@mahs");

            foreach (XmlNode nd in lst)
            {
                cbMHS.Items.Add(nd.InnerText);
            }
            cb.SelectedIndex = 0;
            cb.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            btnHienThi_Click(sender, e);
            loadCombo(cbMHS);
        }
        string nguon = "DuLieu.xml";
        private void btnHienThi_Click(object sender, EventArgs e)
        {
            dgvHienThi.Rows.Clear();
            XmlDocument doc = new XmlDocument();
            doc.Load(nguon);
            XmlElement goc = doc.DocumentElement;/*load gốc tài liệu*/
            XmlNodeList lst = goc.SelectNodes("//hocsinh");
            dgvHienThi.Rows.Add();
            dgvHienThi.ColumnCount = 3;
            int sd = 0;
            foreach (XmlNode nd in lst)
            {
                XmlNode mahs = nd.SelectSingleNode("@mahs");
                XmlNode hoten = nd.SelectSingleNode("hoten");
                XmlNode ngaysinh = nd.SelectSingleNode("ngaysinh");
                dgvHienThi.Rows[sd].Cells[0].Value = mahs.InnerText;
                dgvHienThi.Rows[sd].Cells[1].Value = hoten.InnerText;
                dgvHienThi.Rows[sd].Cells[2].Value = ngaysinh.InnerText;
                dgvHienThi.Rows.Add();
                sd++;/*tự động tăng số dòng cần thiết*/
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                dgvHienThi.Rows.Clear();
                XmlDocument doc = new XmlDocument();
                doc.Load(nguon);
                XmlElement goc = doc.DocumentElement;
                /*chuẩn hóa dữ liệu là duy nhất --> chỉ có 1 thông tin sinh viên*/
                XmlNode nd = goc.SelectSingleNode("//hocsinh[@mahs='" + txtTimKiem.Text + "']");
                dgvHienThi.Rows.Add();
                XmlNode mahs = nd.SelectSingleNode("@mahs");
                XmlNode hoten = nd.SelectSingleNode("hoten");
                XmlNode ngaysinh = nd.SelectSingleNode("ngaysinh");
                dgvHienThi.Rows[0].Cells[0].Value = mahs.InnerText.ToString();
                dgvHienThi.Rows[0].Cells[1].Value = hoten.InnerText.ToString();
                dgvHienThi.Rows[0].Cells[2].Value = ngaysinh.InnerText.ToString();
            }
            catch { MessageBox.Show("Không tìm thấy thông tin sinh viên này"); }
        }

        private void dgvHienThi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cbMHS.Text = dgvHienThi.CurrentRow.Cells[0].Value.ToString();
                txtTenHS.Text = dgvHienThi.CurrentRow.Cells[1].Value.ToString();
                dtNgaySinh.Text = dgvHienThi.CurrentRow.Cells[2].Value.ToString();
            }
            catch { MessageBox.Show("Dòng này ko có dữ liệu"); }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txt1MHS.Text == "" || txt1TenHS.Text == "" | dt1NgaySinh.Value.ToString() == "") { MessageBox.Show("Nhập đầy đủ OKE"); }
            else
            {
                /*Thông tin sinh viên với mã sinh viên ko thể trùng*/
                XmlDocument doc = new XmlDocument();
                doc.Load(nguon);
                XmlElement goc = doc.DocumentElement;
                XmlNodeList lst = goc.SelectNodes("//hocsinh/@mahs");
                int sd = 0, d = 0;
                foreach (XmlNode nd in lst)
                {
                    if (txt1MHS.Text == nd.InnerText) d++;
                }
                if (d >= 1) { MessageBox.Show("Mã Trùng OKE"); }
                else
                {
                    XmlElement hs = doc.CreateElement("hocsinh");
                    hs.SetAttribute("mahs", txt1MHS.Text);
                    XmlElement hoten = doc.CreateElement("hoten");
                    hoten.InnerText = txt1TenHS.Text;
                    XmlElement ngaysinh = doc.CreateElement("ngaysinh");
                    ngaysinh.InnerText = xuLyDate(dt1NgaySinh);
                    hs.AppendChild(hoten);
                    hs.AppendChild(ngaysinh);
                    goc.AppendChild(hs);
                    doc.Save(nguon);
                    MessageBox.Show("Thêm thành công OKE");
                    btnHienThi_Click(sender, e);
                }
            }
        }
        public string xuLyDate(DateTimePicker dt)
        {
            string ngay = dt.Value.Day.ToString();
            int ng = int.Parse(ngay.ToString());
            if (ng < 10) { ngay = "0" + ngay; }
            string thang = dt.Value.Month.ToString();
            int th = int.Parse(thang.ToString());
            if (th < 10) { thang = "0" + thang; }
            string nam = dt.Value.Year.ToString();
            string tg = (nam + "-" + thang + "-" + ngay).ToString();
            return tg;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(nguon);
                XmlElement goc = doc.DocumentElement;
                XmlNode huy = doc.SelectSingleNode("//hocsinh[@mahs='" + cbMHS.Text + "']");
                goc.RemoveChild(huy);
                doc.Save(nguon);
                btnHienThi_Click(sender, e);
            }
            catch { MessageBox.Show("Vui lòng kích bảng dữ liệu chọn dữ liệu cần xóa"); }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(nguon);
                XmlElement goc = doc.DocumentElement;
                XmlElement cu = (XmlElement)goc.SelectSingleNode("//hocsinh[@mahs='" + cbMHS.Text + "']");
                XmlElement hocsinh = doc.CreateElement("hocsinh");
                hocsinh.SetAttribute("mahs", cbMHS.Text);
                XmlElement hoten = doc.CreateElement("hoten");
                hoten.InnerText = txtTenHS.Text;
                XmlElement ngaysinh = doc.CreateElement("ngaysinh");
                ngaysinh.InnerText = xuLyDate(dtNgaySinh);
                hocsinh.AppendChild(hoten);
                hocsinh.AppendChild(ngaysinh);
                goc.ReplaceChild(hocsinh, cu);
                doc.Save(nguon);
                MessageBox.Show("Sửa Thành Công");
                btnHienThi_Click(sender, e);
            }
            catch { MessageBox.Show("Kich vào lưới và chọn dữ liệu cần sửa OKE"); }
        }

        //private void cbMHS_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        XmlDocument doc = new XmlDocument();
        //        doc.Load(nguon);
        //        XmlElement goc = doc.DocumentElement;
        //        XmlNode nd = goc.SelectSingleNode("//hocsinh[@mahs='" + cbMHS.Text + "']");
        //        dgvHienThi.Rows.Clear();
        //        dgvHienThi.Rows.Add();
        //        dgvHienThi.ColumnCount = 3;
        //        XmlNode mahs=nd.SelectSingleNode("@mahs");
        //        XmlNode hoten=nd.SelectSingleNode("hoten");
        //        XmlNode ngaysinh=nd.SelectSingleNode("ngaysinh");
        //        txtTenHS.Text = hoten.InnerText;
        //        dtNgaySinh.Text = ngaysinh.InnerText;
        //        dgvHienThi.Rows[0].Cells[0].Value = mahs.InnerText;
        //        dgvHienThi.Rows[0].Cells[1].Value = hoten.InnerText;
        //        dgvHienThi.Rows[0].Cells[2].Value = ngaysinh.InnerText;
        //        dgvHienThi.Rows.Add();
        //    }
        //    catch { MessageBox.Show("Hết dữ liệu để hiển thị"); }
        //}
    }
}
