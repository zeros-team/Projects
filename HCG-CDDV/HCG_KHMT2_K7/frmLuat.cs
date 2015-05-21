using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace HCG_KHMT2_K7
{
    public partial class frmLuat : Form
    {
        int vt;
        bool cothem;
        public frmLuat()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        public void list_text(int vt)
        {
            txtVT.Text = listLuat.Items[vt].SubItems[0].Text;
            txtVP.Text = listLuat.Items[vt].SubItems[1].Text;

        }
        public void text_list(int vt)
        {
            listLuat.Items[vt].SubItems[0].Text = txtVT.Text;
            listLuat.Items[vt].SubItems[1].Text = txtVP.Text;
        }

        private void frmLuat_Load(object sender, EventArgs e)
        {

            StreamReader f = new StreamReader("dulieuluat.dat");
            while (f.Peek() != -1)
            {
                vt = vt + 1;

                Luat dt = new Luat();
                string s = f.ReadLine();
                string[] ss = s.Split('|');
                ListViewItem lv = new ListViewItem(ss);
                listLuat.Items.Add(lv);

            }
            f.Close();
            f = new StreamReader("dulieu.dat");//mo file
            while (f.Peek() != -1)//trong khi chua den cuoi file
            {
                vt = vt + 1;
                //SuKien dt = new SuKien();
                string s = f.ReadLine();//doc 1 dong tu file roi gan cho s
                string[] ss = s.Split('|');//cat s thanh 2 phan:ten va NN
                //khai bao va khoi tao doi tuong listviewitem
                ListViewItem lv = new ListViewItem(ss);
                listSukien.Items.Add(lv);
            }
            f.Close();
            if (vt != -1)
            {
                txtVT.Text = listLuat.Items[0].SubItems[0].Text;
                txtVP.Text = listLuat.Items[0].SubItems[1].Text;
                vt = 0;
            }
        }

        
        public void TextRong()
        {
            txtVT.Text = "";
            txtVP.Text = "";

        }
        public void LuuFile()
        {
            StreamWriter f = new StreamWriter("dulieuluat.dat", false);

            for (int i = 0; i <= listLuat.Items.Count - 1; i++)
            {
                string s = string.Format("{0}|{1}", listLuat.Items[i].SubItems[0].Text, listLuat.Items[i].SubItems[1].Text);
                f.WriteLine(s);

            }
            MessageBox.Show(" Lưu thành công ! ", "ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            f.Close();

        }
        

        

        
        private void listLuat_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            txtVT.Text = e.Item.SubItems[0].Text;
            txtVP.Text = e.Item.SubItems[1].Text;
            vt = e.ItemIndex;
        }

        private void listSukien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btThemVT_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < listSukien.SelectedIndices.Count; i++)
                txtVT.Text = txtVT.Text + " " + listSukien.Items[listSukien.SelectedIndices[i]].Text + " ";
        }

        private void btThemVP_Click_1(object sender, EventArgs e)
        {
            txtVP.Text = listSukien.Items[listSukien.SelectedIndices[2]].Text;
        }

        private void btHuyChon_Click_1(object sender, EventArgs e)
        {
            listSukien.CheckBoxes = false;
            txtVP.Text = "";
            txtVT.Text = "";
            btThem.Enabled = true;
            btLuu.Enabled = false;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            txtVT.Text = "";
            txtVP.Text = "";
            txtVT.Focus();
            cothem = true;
            btLuu.Enabled = true;
            btThem.Enabled = false;
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            txtVT.Focus();
            cothem = false;
            btLuu.Enabled = true;
            btSua.Enabled = false;
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            listLuat.Items.RemoveAt(vt);
            if (listLuat.Items.Count == 0)
            {
                TextRong();
                vt = -1;
            }
            else
            {
                if (vt != 0)
                    vt = vt - 1;
                list_text(vt);
            }
            StreamWriter f = new StreamWriter("dulieuluat.dat", false);
            for (int i = 0; i <= listLuat.Items.Count - 1; i++)
            {
                string s = string.Format("{0}|{1}", listLuat.Items[i].SubItems[0].Text, listLuat.Items[i].SubItems[1].Text);
                f.WriteLine(s);

            }
            // MessageBox.Show(" Lưu thành công ! ", "ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            f.Close();
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            if (cothem)
            {

                string[] s = new string[2];
                s[0] = txtVT.Text;
                s[1] = txtVP.Text;
                ListViewItem lv = new ListViewItem(s);
                listLuat.Items.Add(lv);
            }
            else
            {
                text_list(vt);
            }
            LuuFile();
            btThem.Enabled = true;
            btLuu.Enabled = false;
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            if (vt != -1)
                list_text(vt);
            else
                TextRong();
            btThem.Enabled = true;
            btLuu.Enabled = false;
            btSua.Enabled = true;
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}