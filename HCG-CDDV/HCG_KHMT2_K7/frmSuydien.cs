using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Collections;


namespace HCG_KHMT2_K7
{

    public partial class frmSuydien : Form
    {

        public frmSuydien()
        {
            InitializeComponent();
        }

        string factsbase;//Gia thiet
        // string ketluan;  //ket luan 
        int soluat = 0;
        int sosk = 0;
        //string dtkt;
        string[] tapkl;
        string[] tapskt;
        string[] tapsk;
        // string giaithich;
        string huyluat = "";//chua cac luat bi huy trong suy dien tien
        string vet = ""; //Chứa các luật trong quá trình sd, dùng để inkq
        ArrayList rulesbase = new ArrayList();//khai báo biến để chứa tập luật
        ArrayList facts = new ArrayList();//Khai báo biến để chứa tập sự kiện



        private void loadtapkl()
        {
            StreamReader f = new StreamReader("dulieuluat.dat");//mở file
            int i = 0;
            tapkl = new string[soluat];
            while (f.Peek() != -1)//trong khi chưa kết thúc file
            {
                string s = f.ReadLine();//đọc 1 dòng từ file
                string[] ss = s.Split('|');
                //  dt = new Luat(ss[0], ss[1]);
                tapkl[i] = ss[1];
                i++;
            }
            f.Close();
        }

        private void loadsk()
        {
            StreamReader f = new StreamReader("dulieu.dat");//mở file
            int i = 0;
            tapsk = new string[sosk];
            while (f.Peek() != -1)//trong khi chưa kết thúc file
            {
                string s = f.ReadLine();//đọc 1 dòng từ file
                string[] ss = s.Split('|');
                //  dt = new Luat(ss[0], ss[1]);
                tapsk[i] = ss[1];
                i++;
            }
            f.Close();
        }

        private void loadskTP()
        {
            StreamReader f = new StreamReader("dulieu.dat");//mở file
            int i = 0;
            tapsk = new string[sosk];
            tapskt = new string[sosk];
            while (f.Peek() != -1)//trong khi chưa kết thúc file
            {
                string s = f.ReadLine();//đọc 1 dòng từ file
                string[] ss = s.Split('|');
                //  dt = new Luat(ss[0], ss[1]);
                tapsk[i] = ss[1];
                tapskt[i] = ss[0];
                i++;
            }
            f.Close();

        }



        private int FileCount()
        {
            StreamReader f = new StreamReader("dulieuluat.dat");//mở file
            int i = 0;
            while (f.Peek() != -1)//trong khi chưa kết thúc file
            {
                string s = f.ReadLine();//đọc 1 dòng từ file
                i++;
            }
            f.Close();
            return i;
        }
        private int FileCountsk()
        {
            StreamReader f = new StreamReader("dulieu.dat");//mở file
            int i = 0;
            while (f.Peek() != -1)//trong khi chưa kết thúc file
            {
                string s = f.ReadLine();//đọc 1 dòng từ file
                i++;
            }
            f.Close();
            return i;
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmSuydien_Load(object sender, EventArgs e)
        {
            imageList1 = new ImageList();
            imageList1.ImageSize = new Size(255, 255);
            soluat = FileCount();
            sosk = FileCountsk();
            loadtapkl();

            //mở file để đọc tập luật vào biến rulesbase
            StreamReader f = new StreamReader("dulieu.dat");//mở file
            Sukien sk;
            while (f.Peek() != -1)//trong khi chưa kết thúc file
            {
                string s = f.ReadLine();//đọc 1 dòng từ file
                string[] ss = s.Split('|');//tách vế trái (ss[0]) và vế phải (ss[1])                
                sk = new Sukien(ss[0], ss[1]);
                facts.Add(sk);
                //khởi tạo đối tượng Luật dt
                // ss[0] = ss[0] + " ->"; //nối -> vào cuối vế trái
                ListViewItem lv = new ListViewItem(ss);//khởi tạo dt listviewitem
                listSukien.Items.Add(lv);// thêm 1 dòng vào listview1
                //rulesbase.Add(dt);//thêm 1 luật vào rulesbase
            }
            f.Close();//đóng file

            //mở file để đọc tập sự kiện vào biến facts
            f = new StreamReader("dulieuluat.dat");//mở file
            Luat dt;//khai báo dt là đối tượng  của lớp Luat

            while (f.Peek() != -1)
            {
                string s = f.ReadLine();
                string[] ss = s.Split('|');
                dt = new Luat(ss[0], ss[1]);
                rulesbase.Add(dt);
                // sk = new SuKien(ss[0], ss[1]);
                // facts.Add(sk);
            }
            f.Close();
        }


        public void TimLuat(ArrayList tapluat, string tg, ref ArrayList sat)
        {
            for (int i = 0; i < tapluat.Count; i++)
            {
                //khai báo dt là đối tượng Luật và lấy luật thứ i về gán cho dt
                Luat dt = (Luat)tapluat[i];
                string[] ss = dt.Left.Split(' ');//tách vế trái thành các sự kiện
                int j = 0;
                while (!huyluat.Contains(i.ToString()) && //luật chưa bị xóa
                       !sat.Contains(i) && //tập sat chưa chứa luật i
                       j < ss.Length && // chưa duyệt hết sự kiện ở vế trái
                       tg.IndexOf(ss[j]) != -1)//trung gian có chứa sự kiện ss[j]
                    j++;
                if (j == ss.Length) sat.Add(i);//vế trái thuộc tg nên thêm luật i vào sat
            }
        }
        public struct CauHinh
        {
            public string sk;
            public int cs;
        }
        private void suydientien()
        {
            ArrayList sat = new ArrayList();//khai báo tập sat để chứa các luật     
            loadskTP();
            //gán biến tg bằng giả thiết factsbase
            foreach (string a in tapkl)
            {
                string tg = factsbase;
                vet = ""; //gán vết bằng rỗng
                txtKetqua.Text = "";
                huyluat = "";//khởi tạo hủy luật bằng rỗng
                TimLuat(rulesbase, tg, ref sat);//tìm luật có vt thuộc tg đưa vào sat
                while (sat.Count > 0)//trong khi tập sat khác rỗng
                {
                    int cs = (int)sat[0];//lấy trong tập sat 1 chỉ số luật và gán cho cs
                    Luat r = (Luat)rulesbase[cs];//lấy luật ứng với cs và gán cho r
                    sat.RemoveAt(0);//xóa luật ở vị trí đầu tiên trong sat
                    tg = tg + " " + r.Right;//thêm vế phải của luật r vào tg
                    huyluat = huyluat + " " + cs.ToString();//hủy luật r
                    vet = vet + cs.ToString() + " ";//thêm cs luật r vào vết
                    if (tg.Contains(a)) //nếu kết luận thuộc tg thì inkq
                    {
                        txtKetqua.Text = "Thanh cong\r\n";
                        vet = vet.Trim();
                        string[] ss = vet.Split(' ');//tách vet thành các cs luật 
                        for (int i = 0; i < ss.Length; i++)
                        {
                            int vt = int.Parse(ss[i]);//chuyển chuỗi ss[i] thành số
                            Luat l = (Luat)rulesbase[vt];//lấy luật tại vt về gán cho l
                            string s = string.Format("{0}->{1}\r\n", l.Left, l.Right);//định dạng để in luật
                            txtKetqua.Text = txtKetqua.Text + s;//thêm s vào textbox3
                        }
                        foreach (string tempkl in tapskt)
                        {
                            if (factsbase.Contains(tempkl))
                            {
                                int ii = Array.IndexOf(tapskt, tempkl);
                                string kl = tapsk[ii];
                                txtKetqua.Text = txtKetqua.Text + tempkl + "->" + kl + "\r\n";
                            }

                        }
                        txtKetqua.Text = txtKetqua.Text + "--------------------\r\n";
                        int iii = Array.IndexOf(tapskt, a);
                        string kl1 = tapsk[iii];
                        txtKetqua.Text = txtKetqua.Text + "Chẩn đoán: " + kl1 + "\r\n";
                        string images = "images/" + kl1 + ".jpg";
                        pictureBox1.Image = Image.FromFile(images);
                        return; //kết thúc suy diễn
                    }
                    TimLuat(rulesbase, tg, ref sat);//tìm luật lại
                }//while
                txtKetqua.Text = " Không trùng trong tập luật !";
            }

        }

        private void listSukien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < listSukien.SelectedIndices.Count; i++)
                txtLoi.Text = txtLoi.Text + " " + listSukien.Items[listSukien.SelectedIndices[i]].Text + " ";
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            txtLoi.Text = "";
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            frmLuat fr1 = new frmLuat();
            fr1.Show();
        }

        private void btnchuandoan_Click(object sender, EventArgs e)
        {
            factsbase = txtLoi.Text;
            suydientien();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
