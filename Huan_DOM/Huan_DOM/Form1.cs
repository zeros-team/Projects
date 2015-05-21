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

namespace Huan_DOM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btntaofile_Click(object sender, EventArgs e)
        {
            if (txttaofile.Text=="")
            {
                MessageBox.Show("Tên file không được để trống");
            }
            else
            {
                string s = txttaofile.Text + ".xml";
                XmlTextWriter write = new XmlTextWriter(s,Encoding.UTF8);
                write.WriteStartDocument();
                write.WriteStartElement("QLHocSinh");
                write.WriteComment("Chú thích");
                write.WriteEndElement();
                write.WriteEndDocument();
                write.Close();
                MessageBox.Show("Tạo thành công");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(nguon);
                XmlElement goc = doc.DocumentElement;
                XmlNode xoa = doc.SelectSingleNode("//hocsinh/[@mahs='" + cbmmahs.Text + "']");
                goc.RemoveChild(xoa);
                doc.Save(nguon);
                Form1_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("Chọn dòng cần xóa");
            }
        }
        string nguon = "Dulieu.xml";
        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txtmahs.Text=="" || txtmahs.Text =="")
            {
                MessageBox.Show("Không được để trống");
            }
            else
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(nguon);
                XmlElement goc = doc.DocumentElement;
                XmlNodeList list = goc.SelectNodes("//hocsinh/@mahs");
                int sd = 0, d = 0;
                foreach (XmlNode nd in list)
                {
                    if (txtmahs.Text == nd.InnerText) d++;

                }
                if (d >= 1) { MessageBox.Show("Mã trùng"); }
                else
                {
                    XmlElement hs = doc.CreateElement("hocsinh");
                    hs.SetAttribute("mahs", txtmahs.Text);
                    XmlElement hoten = doc.CreateElement("hoten");
                    hoten.InnerText = txthoten.Text;
                    XmlElement ngaysinh = doc.CreateElement("ngaysinh");
                    ngaysinh.InnerText = dtngaysinh.Value.ToString();
                    hs.AppendChild(hoten);
                    hs.AppendChild(ngaysinh);
                    goc.AppendChild(hs);
                    doc.Save(nguon);
                    MessageBox.Show("Thêm thành công");
                    Form1_Load(sender, e);
                }
            }
        }
        public void loadcombobox(ComboBox cb)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(nguon);
            XmlNodeList list = doc.SelectNodes("//hocsinh/@mahs");
            foreach (XmlNode nd in list)
            {
                cbmmahs.Items.Add(nd.InnerText);
            }
            cb.SelectedIndex = 0;
            cb.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            loadcombobox(cbmmahs);
            dataGridView1.Rows.Clear();
            XmlDocument doc = new XmlDocument();
            doc.Load(nguon);
            XmlElement goc = doc.DocumentElement;
            XmlNodeList list = goc.SelectNodes("//hocsinh");
            dataGridView1.Rows.Add();
            dataGridView1.ColumnCount = 3;
            int sd = 0;
            foreach (XmlNode nd in list)
            {
                XmlNode mahs = nd.SelectSingleNode("@mahs");
                XmlNode hoten = nd.SelectSingleNode("hoten");
                XmlNode ngaysinh = nd.SelectSingleNode("ngaysinh");
                dataGridView1.Rows[sd].Cells[0].Value = mahs.InnerText;
                dataGridView1.Rows[sd].Cells[1].Value = hoten.InnerText;
                dataGridView1.Rows[sd].Cells[2].Value = ngaysinh.InnerText;
                dataGridView1.Rows.Add();
                sd++;
            }
        }
       // private void dataGridView1_CellClick(object sender,DataGridView)
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cbmmahs.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txt1hoten.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                dateTimePicker2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Dòng này rỗng");
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txthoten.Text = "";
            txtmahs.Text = "";
            Form1_Load(sender, e);
        }
    }
}
