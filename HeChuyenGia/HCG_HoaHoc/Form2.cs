using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Core;
using System.Data.OleDb;

namespace HCG_HoaHoc
{
    public partial class Form2 : Form
    {
        int chucnang = 4;           
        ThuatToan thuattoan;
        FileStream file;
        List<string> strsave;
        public Form2()
        {
            InitializeComponent();
        }
        Data_Excel dex;
      
        private void Form2_Load(object sender, EventArgs e)
        {
            if (File.Exists(CauHinh.docfile()[0]) == true)
            {
                progressBar1.Hide();
                dex = new Data_Excel(ClConnect.connect(CauHinh.docfile()[0]));
                dataHienThi.DataSource = dex.getDataTable("select [KyHieu],[YNghia] from [KyHieu$] where [KyHieu]<>''");
                toolduongdan.Text = CauHinh.docfile()[0];
                heuristicToolStripMenuItem.Checked = true;
                lbTheo.Text = "Theo Heuritic";
                textBox1.Text = "Fe,H2SO4";
                textBox2.Text="SO2";
                rtSuyDien.ReadOnly = true;
             
            }
            else
            {
                this.Show();
                if (MessageBox.Show("Lỗi không tìm thấy tập dữ liệu \n Chọn tập tin","Error",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    Form1 t = new Form1();
                    t.ShowDialog();
                    if (MessageBox.Show("Khởi động lại ứng dụng", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        Application.Restart();
                    }
                }
                else Application.Exit();
            }
            strsave = new List<string>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0 && textBox2.Text.Length != 0)
            {
                rtSuyDien.Clear();
                thuattoan = new ThuatToan(textBox1.Text, textBox2.Text);

                switch (chucnang)
                {
                    case 0: thuattoan.thuchien_min(); break;
                    case 1: thuattoan.thuchien_max(); break;
                    case 2: thuattoan.thuchien_stack(); break;
                    case 3: thuattoan.thuchien_query(); break;
                    case 4: thuattoan.thuchien_heuristic(); break;
                }

                if (thuattoan.getstatus == true)
                {

                    List<string> t = thuattoan.getvet();             
                    List<string> giathiet = thuattoan.getGiaThiet;
                    progressBar1.Minimum = 0;
                    if(t.Count>0)
                    progressBar1.Maximum = t.Count - 1;
                    else progressBar1.Maximum = t.Count ;
                    progressBar1.Show();
                    for (int i = 0; i < t.Count; i++)
                    {
                        progressBar1.Value = i;
                        //Thread.Sleep(100);
                       
                        rtSuyDien.Text += "\n*Bước " +(i+1) + ": Phát hiện được luật :" + t[i] + "\n"
                            +"\tTập giả thiết: "+giathiet[i]+                         
                            "\n\t -->Phương trình phản ứng: \t" + dex.getKetLuan("select YNghia from [CongThuc$] where ID='" + t[i] + "'" + "\n");
                        if (i < t.Count - 1)
                        {
                            rtSuyDien.Text += "\n \t(Chưa tạo ra được " + textBox2.Text + " )";
                        }
                        else
                            rtSuyDien.Text += "\n \t(Đã xuất hiện " + textBox2.Text + " )";
                    }
                    progressBar1.Hide();
                    button1.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Không tìm ra luật");
                    button1.Enabled = false;
                }
            }
        }
        #region cac su kien menu
        private void btLamLai_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            rtSuyDien.Clear();
            textBox1.Focus();
        }
        void clear()
        {
            minToolStripMenuItem.Checked = false;
            maxToolStripMenuItem.Checked = false;
            stackToolStripMenuItem.Checked = false;
            queryToolStripMenuItem.Checked = false;
            heuristicToolStripMenuItem.Checked = false;
        }
        private void minToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clear();
            minToolStripMenuItem.Checked = true ;
            chucnang = 0;
            lbTheo.Text = "Theo Min";
        }
        private void quanLyLuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();

        }

        private void maxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clear();
            maxToolStripMenuItem.Checked = true;
            chucnang = 1;
            lbTheo.Text = "Theo Max";
        }

        private void stackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clear();
            stackToolStripMenuItem.Checked = true;
            chucnang = 2;
            lbTheo.Text = "Theo Stack";
        }

        private void queryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clear();
            queryToolStripMenuItem.Checked = true;
            chucnang = 3;
            lbTheo.Text = "Theo Query";
        }
        #endregion

        private void heuristicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clear();
            heuristicToolStripMenuItem.Checked = true;
            chucnang = 4;
            lbTheo.Text = "Theo Heuristic";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            saveFileDialog1.ShowDialog();
        }
     
        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {   
            strsave.Clear();          
            strsave.Add("Gia thiết: " + textBox1.Text);
            strsave.Add("Kết luận: " + textBox2.Text);
            strsave.Add("Theo luật: " + lbTheo.Text);
            strsave.Add("Suy Diễn: ");           
            string [] temp=rtSuyDien.Text.Split('*');
            for (int i = 0; i < temp.Length; i++)
            {
                strsave.Add(temp[i]);
            }
            file = new FileStream(saveFileDialog1.FileName, FileMode.Create);
            CauHinh.ghifile(strsave, file);
        }       
    }
}
