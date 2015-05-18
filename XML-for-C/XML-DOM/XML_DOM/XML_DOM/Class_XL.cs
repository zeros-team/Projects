using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Windows.Forms;
using System.IO;
namespace XML_DOM
{
    class Class_XL
    {
        //Tạo biến lưu tài liệu XML
        XmlDocument doc = new XmlDocument();
        //Tạo biến lưu đường dẫn của tài liệu XML
        string tentep = @"C:\Users\FUCK YOU\Documents\Visual Studio 2013\Projects\XML-for-C\XML-DOM\XML_DOM\XML_DOM\XML.xml";
        //Tạo các phương thức cần có
        public void them(Class_TT nxb) { 
            //LOAD tài liệu XL
            doc.Load(tentep);
            //Tạo nút gốc
            XmlElement goc = doc.DocumentElement;
            //Tạo nút phần tử có tên "nxb"
            XmlElement nhaxb = doc.CreateElement("nxb");
            /////////////////////////////////////////////////////
            //Tao nút con và thuộc tính của nxb
            //Tạo thuốc tính manxb
            XmlAttribute manxb = doc.CreateAttribute("manxb");
            //Tạo phần tử con tenxb
            XmlElement tenxb = doc.CreateElement("tenxb");
            //Tạo phần tử con diachi
            XmlElement diachi = doc.CreateElement("diachi");
            ///////////////////////////////////////////////////////
            //////////////////////////////////////////////////////
            //Xác định giá trị cho các thuộc tính và phần tử vừa tạo
            //Xác định giá trị của thuộc tính manxb
            manxb.InnerText = nxb.Manxb;
            //Xác định giá trị của phần tử tenxb
            tenxb.InnerText = nxb.Tennxb;
            //Xác định giá trị của phẩn tử diachi
            diachi.InnerText = nxb.Diachi;
            //////////////////////////////////////////////////////
            //////////////////////////////////////////////////////
            //Gán các nút con và thuộc tính vào nút mẹ và nút gốc
            //Gán thuộc tính manxb vào nxb
            nhaxb.Attributes.Append(manxb);
            //Gán nút con tenxb vào nxb
            nhaxb.AppendChild(tenxb);
            //Gán nút con diachi vào nxb
            nhaxb.AppendChild(diachi);
            //Gán nút nxb vào nút gốc
            goc.AppendChild(nhaxb);
            //Lưu các thứ vừa tạo
            doc.Save(tentep);
        }
        //Xấy dựng hàm hiện dữ liệu
        public void hien_du_lieu(DataGridView data) { 
            //Xóa hết dữ liệu trên data
            data.Rows.Clear();
            //Load dữ liệu từ file xml lên
            doc.Load(tentep);
            //Tạo đối tượng chứ d/s các nút nxb
            XmlNodeList ds = doc.SelectNodes("/danhmucnxb/nxb");//Chọn nhiều nút
            int sd = 0;
            data.ColumnCount = 3;//Gán số cột mặc định
            data.Rows.Add();//Số dòng sẽ tự động được add
            //Duyệt từng nút nxb bằng vòng lặp foreach
            /*XMLNode node

            tức là tạo 1 biến node có kiểu xmlNode tức là 1 node trong xml
            in ds tức là lấy từng giá trị trong biến ds để gán vào biến node*/
            foreach (XmlNode node in ds) { 
                ////////////////Tạo biến để gán giá trị///////////////////
                //Chọn thuôc tính @manxb gán cho biến ma
                XmlNode ma = node.SelectSingleNode("@manxb");//Chọn một nút
                //Chọn phần tử tenxb gán cho biến ten
                XmlNode ten = node.SelectSingleNode("tenxb");
                //Chọn phần tử diachi gán cho biến dc
                XmlNode dc = node.SelectSingleNode("diachi");
                ////////////////////////////////////////////////////
                //Sau khi tạo các biến thì ta lấy giá trị của chúng đưa lên Datagrid
                //Đưa giá trị của thuộc tính @manxb lên cột 1
                data.Rows[sd].Cells[0].Value = ma.InnerText.ToString();
                //Đưa giá trị của phần tử tenxb lên cột 2
                data.Rows[sd].Cells[1].Value = ten.InnerText.ToString();
                //Đưa giá trị của phần tử diachi lên cột 3
                data.Rows[sd].Cells[2].Value = dc.InnerText.ToString();
                ////////////////////////////////////////////////////////
                data.Rows.Add();//Tự động Add hàng
                sd++;//số đếm tăng dần sau mỗi lần lặp
            }
        }
        public void sua(Class_TT nxb) { 
            //Load dữ liệu từ file xml lên
            doc.Load(tentep);
            //Tạo nút gốc
            XmlElement goc = doc.DocumentElement;
            //Tạo nút cũ lưu thông tin thuộc tính @manxb
            XmlNode cu = goc.SelectSingleNode("/danhmucnxb/nxb[@manxb='"+nxb.Manxb+"']");
            //Tạo nút mới như phần thêm
            //Tạo nút nxb
            XmlElement moi = doc.CreateElement("nxb");
            XmlAttribute manxb = doc.CreateAttribute("manxb");
            XmlElement tenxb = doc.CreateElement("tenxb");
            XmlElement diachi = doc.CreateElement("diachi");
            //Gán giá trị cho các nút và thuộc tính
            manxb.InnerText = nxb.Manxb;
            tenxb.InnerText = nxb.Tennxb;
            diachi.InnerText = nxb.Diachi;
            //ADD các giá trị và thuôc tính vào các nút cha
            moi.Attributes.Append(manxb);
            moi.AppendChild(tenxb);
            moi.AppendChild(diachi);
            goc.ReplaceChild(moi,cu);//Thay thế cũ bằng mới
            doc.Save(tentep);
        }
        public void xoa(Class_TT nxb) {
            doc.Load(tentep);
            //Tạo nút gốc
            XmlNode goc = doc.DocumentElement;
            XmlNode cu = goc.SelectSingleNode("/danhmucnxb/nxb[@manxb='"+nxb.Manxb+"']");
            goc.RemoveChild(cu);
            doc.Save(tentep);
        }
    }
}
