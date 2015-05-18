using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;

namespace XMLDOM
{
    class ClassTT
    {
        string _manxb, _tennxb, _diachi;
        public string Manxb
        {
            get { return _manxb; }
            set { _manxb = value; }
        }
        public string Tennxb
        {
            get { return _tennxb; }
            set { _tennxb = value; }
        }
        public string Diachi
        {
            get { return _diachi; }
            set { _diachi = value; }
        }
    }
}
