using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace HCG_HoaHoc
{
    class ClConnect
    {
        
        private static string  stringconnectxls1 = "Provider=Microsoft.Jet.OLEDB.4.0;Extended Properties=Excel 8.0;Data Source=";
        private static string  stringconnectxls2= " Provider=Microsoft.ACE.OLEDB.12.0;Extended Properties=Excel 12.0;Data Source=";
        private static string stringconnectxls3 = " Provider=Microsoft.ACE.OLEDB.14.0;Extended Properties=Excel 12.0;Data Source=";
        private static string stringconnectxls4 = " Provider=Microsoft.ACE.OLEDB.15.0;Extended Properties=Excel 12.0;Data Source=";

        public static OleDbConnection connect(string name)
        {  if(CauHinh.docfile()[1].CompareTo("0")==0)           
            return new OleDbConnection(stringconnectxls1+name) ;//connect file excel 2003;
            return new OleDbConnection(stringconnectxls2 + name);//connect file excel 2007;
            return new OleDbConnection(stringconnectxls3 + name);//connect file excel 2010;
            return new OleDbConnection(stringconnectxls4 + name);//connect file excel 2013;
        }
       
    }
}
