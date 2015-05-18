using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;

namespace XMLDOM
{
    class ClassXL
    {
        XmlDocument doc = new XmlDocument();
        string tep = @"C:\Users\FUCK YOU\Documents\Visual Studio 2013\Projects\XMLDOM\XMLDOM\lvh.xml";

        public void themnxb(ClassTT nxb)
        {
            doc.Load(tep);
            XmlElement goc = doc.DocumentElement;
            XmlElement nhaxb = doc.CreateElement("nxb");
            XmlAttribute manxb = doc.CreateAttribute("manxb");
            XmlElement tennxb = doc.CreateElement("tennxb");
            XmlElement diachi = doc.CreateElement("diachi");
            manxb.InnerText = nxb.Manxb;
            tennxb.InnerText = nxb.Tennxb;
            diachi.InnerText = nxb.Diachi;
            nhaxb.Attributes.Append(manxb);
            nhaxb.AppendChild(tennxb);
            nhaxb.AppendChild(diachi);
            goc.AppendChild(nhaxb);
            doc.Save(tep);
        }

        public void suanxb(ClassTT nxb)
        {
            doc.Load(tep);
            XmlElement goc = doc.DocumentElement;
            XmlNode cu=goc.SelectSingleNode("/danhmucnxb/nxb[@manxb='"+nxb.Manxb+"']");
            XmlElement moi = doc.CreateElement("nxb");
            XmlAttribute manxb = doc.CreateAttribute("manxb");
            XmlElement tennxb = doc.CreateElement("tennxb");
            XmlElement diachi = doc.CreateElement("diachi"); 
            manxb.InnerText = nxb.Manxb;
            tennxb.InnerText = nxb.Tennxb;
            diachi.InnerText = nxb.Diachi;
            moi.Attributes.Append(manxb);
            moi.AppendChild(tennxb);
            moi.AppendChild(diachi);
            goc.ReplaceChild(moi, cu);
            doc.Save(tep);
        }

        public void xoanxb(ClassTT nxb)
        {
            doc.Load(tep);
            XmlNode goc = doc.DocumentElement;
            XmlNode cu = goc.SelectSingleNode("/danhmucnxb/nxb[@manxb='" + nxb.Manxb + "']");
            goc.RemoveChild(cu);
            doc.Save(tep);
        }


        public void hiendulieu(DataGridView data)
        {
            data.Rows.Clear();
            doc.Load(tep);
            XmlNodeList ds = doc.SelectNodes("/danhmucnxb/nxb");
            int sd = 0;
            data.ColumnCount = 3;
            data.Rows.Add();
            foreach (XmlNode node in ds)
            {
                XmlNode ma = node.SelectSingleNode("@manxb");
                XmlNode ten = node.SelectSingleNode("tennxb");
                XmlNode dc = node.SelectSingleNode("diachi");
                data.Rows[sd].Cells[0].Value = ma.InnerText.ToString();
                data.Rows[sd].Cells[1].Value = ten.InnerText.ToString();
                data.Rows[sd].Cells[2].Value = dc.InnerText.ToString();
                data.Rows.Add();
                sd++;
            }
        }
    }
}
