using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using System.Windows.Forms;
namespace XML_DOM_2
{
    class Class_XL
    {
        //Tạo nút tài liệu
        XmlDocument doc = new XmlDocument();
        //Tạo nút luu đường dẫn file xml
        string tentep = @"C:\Users\FUCK YOU\Documents\Visual Studio 2013\Projects\XML-for-C\XML-DOM-2\XML_DOM_2\XML_DOM_2\nhanvien.xml";
        public void them(Class_TT nv) { 
            //load tài liệu xml
            doc.Load(tentep);
            //Tạo nút gốc luu tài liệu
            XmlElement goc = doc.DocumentElement;
            //Tạo nút nhanvien
            XmlElement nhanvien = doc.CreateElement("nhanvien");
            //Tạo các nút con tiếp theo
            XmlElement manv = doc.CreateElement("manv");
            XmlElement hoten = doc.CreateElement("hoten");
            XmlElement ngaysinh = doc.CreateElement("ngaysinh");
            XmlElement gioitinh = doc.CreateElement("gioitinh");
            XmlElement hsluong = doc.CreateElement("hsluong");
            //Gán giá trị cho chúng
            manv.InnerText = nv.Manv;
            hoten.InnerText = nv.Hoten;
            ngaysinh.InnerText = nv.Ngaysinh;
            gioitinh.InnerText = nv.Gioitinh;
            hsluong.InnerText = nv.Hsluong;
            //Add chúng vào các nút cha
            //Con vào cha
            nhanvien.AppendChild(manv);
            nhanvien.AppendChild(hoten);
            nhanvien.AppendChild(ngaysinh);
            nhanvien.AppendChild(gioitinh);
            nhanvien.AppendChild(hsluong);
            goc.AppendChild(nhanvien);
            //Luu dữ liêu xml
            doc.Save(tentep);
        }
        public void hienthi(DataGridView data) {
            doc.Load(tentep);
            data.Rows.Clear();
            //Tạo nút gốc
            XmlElement goc = doc.DocumentElement;
            //Tạo đối tương ds chứa danh sách các nút
            XmlNodeList ds = doc.SelectNodes("/congty/nhanvien");
            int sd = 0;
            data.ColumnCount = 5;
            data.Rows.Add();//Hàm tự động add thêm dòng dữ liệu
            //Dùng vòng foreach để duyệt và chèn dữ liệu
            foreach (XmlNode node in ds) { 
                //Chọn các phần tử và gán biến cho chúng
                XmlNode manv = node.SelectSingleNode("manv");
                XmlNode hoten = node.SelectSingleNode("hoten");
                XmlNode ngaysinh = node.SelectSingleNode("ngaysinh");
                XmlNode gioitinh = node.SelectSingleNode("gioitinh");
                XmlNode hsluong = node.SelectSingleNode("hsluong");
                //ADD nó vào các cột và hàng tương ứng
                data.Rows[sd].Cells[0].Value = manv.InnerText.ToString();
                data.Rows[sd].Cells[1].Value = hoten.InnerText.ToString();
                data.Rows[sd].Cells[2].Value = ngaysinh.InnerText.ToString();
                data.Rows[sd].Cells[3].Value = gioitinh.InnerText.ToString();
                data.Rows[sd].Cells[4].Value = hsluong.InnerText.ToString();
                data.Rows.Add();
                sd++;
            }
        }
        public void xoa(Class_TT nv) {
            doc.Load(tentep); //LOAD lại tài liệu
            XmlElement goc = doc.DocumentElement;//Tạo nút gốc
            XmlNode cu = goc.SelectSingleNode("/congty/nhanvien[manv='" + nv.Manv + "']");
            goc.RemoveChild(cu);
            doc.Save(tentep);
        }
        public void sua(Class_TT nv) {
            doc.Load(tentep);
            XmlElement goc = doc.DocumentElement;
            XmlNode cu = goc.SelectSingleNode("/congty/nhanvien[manv='" + nv.Manv + "']");
            XmlElement moi = doc.CreateElement("nhanvien");
            XmlAttribute manv = doc.CreateAttribute("manv");
            XmlElement hoten = doc.CreateElement("hoten");
            XmlElement ngaysinh = doc.CreateElement("ngaysinh");
            XmlElement gioitinh = doc.CreateElement("gioitinh");
            XmlElement hsluong = doc.CreateElement("hsluong");
            manv.InnerText = nv.Manv;
            hoten.InnerText = nv.Hoten;
            ngaysinh.InnerText = nv.Ngaysinh;
            gioitinh.InnerText = nv.Gioitinh;
            hsluong.InnerText = nv.Hsluong;
            moi.Attributes.Append(manv);
            moi.AppendChild(hoten);
            moi.AppendChild(ngaysinh);
            moi.AppendChild(gioitinh);
            moi.AppendChild(hsluong);
            goc.ReplaceChild(moi, cu);
            doc.Save(tentep);
        }
    }
}
