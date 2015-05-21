using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Data.OleDb;
using System.IO;

namespace HCG_HoaHoc
{
    public partial class Form1 : Form
    {
        Data_Excel dex;
        string[] cauhinh;
        public Form1()
        {
            InitializeComponent();
        }
        static string filename = CauHinh.docfile()[0];
        OleDbConnection connect = ClConnect.connect(filename);
            
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                loadData();
            }
        }
        private bool getVision(string txt)
        {   int i;
            for ( i= txt.Length - 1; i >= 0; i--)            
                if (txt[i] == '.')
                    break;
         
            if (txt.Substring(i+1).CompareTo("xls") == 0)
            {               
                return true;
            } return false;
            
        }
        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (filename.Length != 0)
            loadData();
        }      
        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(CauHinh.docfile()[0]) == true)
                loadData();
            else{
                khoa(false);
            }
        } 
        
        private void loadData()
        {

                textBox1.Text = filename;
                connect = ClConnect.connect(filename);
                dex = new Data_Excel(connect);
                dataGridView1.DataSource = dex.getDataTable("Select [ID] ,[GiaThiet],[KetLuan] from [Luat$] where [ID]<>''");
                dataGridView1.Refresh();            
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            //loadData();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Excel_2003|*.xls|Excel_2007|*.xlsx";
            openFileDialog1.ShowDialog();
            filename = openFileDialog1.FileName;
            if (openFileDialog1.FileName.Length != 0)
            {
                cauhinh = new string[2];
                cauhinh[0] = openFileDialog1.FileName;
                if (getVision(openFileDialog1.FileName) == true)
                {
                    cauhinh[1] = 0 + "";

                }
                else
                {
                    cauhinh[1] = 1 + "";
                }
                textBox1.Text = filename;
                
                    CauHinh.ghifile(cauhinh);
                    khoa(true);
                    System.Windows.Forms.Application.Restart();
            }
            else
                if (MessageBox.Show("Khong chon duoc tap tin", "Error", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    khoa(false);
                    System.Windows.Forms.Application.Exit();
                }
        }
        private void khoa(bool bl)
        {
            tabLuat.SelectedIndex = 0;            
            tabLuat.Enabled = bl;           
        }      
        private void tabLuat_Selected(object sender, TabControlEventArgs e)
        {
            switch (e.TabPageIndex)
            {
                case 0: dataGridView1.DataSource = dex.getDataTable("Select [ID] ,[GiaThiet],[KetLuan] from [Luat$] where [ID]<>''"); break;
                case 1: dataGridView2.DataSource = dex.getDataTable("Select KyHieu,YNghia from [KyHieu$] where KyHieu <>''"); break;
                case 2: dataGridView3.DataSource = dex.getDataTable("Select ID,YNghia from [CongThuc$] where ID <>''"); break;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {           
        }
    }
}
