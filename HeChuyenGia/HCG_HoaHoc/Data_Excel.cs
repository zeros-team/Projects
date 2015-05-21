using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
namespace HCG_HoaHoc
{
    class Data_Excel
    {
        OleDbConnection connect;
        OleDbCommand cmd;
        OleDbDataAdapter dataAdapter;
        DataSet ds;
        
        public Data_Excel(OleDbConnection connect1)
        {
            connect = connect1;
        }
        public DataTable getDataTable(string command)
        {
            cmd = new OleDbCommand(command, connect);
            dataAdapter = new OleDbDataAdapter(cmd);
            ds = new DataSet();
            dataAdapter.Fill(ds);
            connect.Close();
            return ds.Tables[0];
        }
        public string getKetLuan(string commnad)
        {
            string giatri="";
            connect.Open();
            cmd = new OleDbCommand(commnad, connect);
            OleDbDataReader odr = cmd.ExecuteReader();
            while(odr.Read())
            {
                giatri= odr[0].ToString();
                break;
            }
            connect.Close();
            return giatri;
        }
       // public string
    }
}
