using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace HCG_HoaHoc
{
    class ThuatToan
    {       
        bool status=true;
        List<string> tapluat;
        List<List<string>> tap_luat;
        List<string> vet;
        List<List<string>> luat;
        DataTable dt;        
        Data_Excel dex;
        OleDbConnection connect;
        string[] giathiet;
        List<string> tapgiathiet;
        string ketluan;        
        public ThuatToan(string giathiet, string ketluan)
        {
            connect = ClConnect.connect(CauHinh.docfile()[0]);
            dex = new Data_Excel(connect);
            tapluat = new List<string>();
            this.giathiet = converStringToArray(giathiet, ',');
            this.ketluan = ketluan;
            luat = getTapLuat();
            vet = new List<string>();
            tapgiathiet = new List<string>();
        }       
        #region  tra ve danh sach luat R dang List
        private List<List<string>> getTapLuat()
        {
            List<List<string>> tems = new List<List<string>>();
            List<string> temp;
            dex = new Data_Excel(connect);
            dt = new DataTable();
            dt = dex.getDataTable("Select ID,GiaThiet,KetLuan  from [Luat$] where ID<>'' ");
            foreach (DataRow a in dt.Rows)
            {
                temp = new List<string>();
                temp.Add(a[0].ToString());
                temp.Add(a[1].ToString());
                temp.Add(a[2].ToString());
                tems.Add(temp);
            }
            return tems;
        }
        #endregion

        #region convert chuoi thanh mang
        public string[] converStringToArray(string chuoi,char kyhieu)
        {
            string[] bien=chuoi.Split(kyhieu);
            for (int i = 0; i < bien.Length; i++)
            {
                bien[i] = bien[i].Trim();
            }
                return bien;           
        }
        public string converArrayToString(string[] val)
        {
            string temp="";
            for (int i = 0; i < val.Length; i++)
            {
                if(i<val.Length-1)
                temp += val[i]+",";
                else temp += val[i] ;
            }
            return temp;
        }
        #endregion
        public void thuchien_stack()
        {
            timluat();           
            while (tapluat.Count != 0 || kiemtra(ketluan) == false)
            {
                if (kiemtra(ketluan) == true)
                {
                    status = true;
                    break;
                }
                if (tapluat.Count == 0)
                {
                    status = false;
                    break;
                }
               
                addgiathiet(0);
                vet.Add(tapluat[0]);
                tapluat.RemoveAt(0);
                timluat();
            }
        
        }
        public void thuchien_query()
        {
            timluat();
            int i;
            while (tapluat.Count != 0 || kiemtra(ketluan) == false)
            {
                if (kiemtra(ketluan) == true)
                {
                    status = true;
                    break;
                }
                if (tapluat.Count == 0)
                {
                    status = false;
                    break;
                }
                i = tapluat.Count - 1;
                addgiathiet(i);
                vet.Add(tapluat[i]);
                tapluat.RemoveAt(i);
                timluat();
            }
        }
        public void thuchien_min()
        {
            timluat();
            int i;
            while (tapluat.Count != 0 || kiemtra(ketluan) == false)
            {
                if (kiemtra(ketluan) == true)
                {
                    status = true;
                    break;
                }
                if (tapluat.Count == 0)
                {
                    status = false;
                    break;
                }
                i = min_max(false);
                addgiathiet(i);
                vet.Add(tapluat[i]);
                tapluat.RemoveAt(i);
                timluat();
            }
        } 
        
        public void thuchien_max()
        {
            timluat();
            int i;
            while (tapluat.Count != 0 || kiemtra(ketluan) == false)
            {
                if (kiemtra(ketluan) == true)
                {
                    status = true;
                    break;
                }
                if (tapluat.Count == 0)
                {
                    status = false;
                    break;
                }
                i = min_max(true);
                addgiathiet(i);
                vet.Add(tapluat[i]);
                tapluat.RemoveAt(i);
                timluat();
            }
        }
       
     
        private int min_max(bool m)
        {
            int mx = 0;
            int maxm = int.Parse(tapluat[0].Substring(1));
            if (m == true)
            {
                for (int i = 0; i < tapluat.Count(); i++)
                {
                    if (int.Parse(tapluat[i].Substring(1)) > maxm)
                    {
                        maxm = int.Parse(tapluat[i].Substring(1));
                        mx = i;
                    }
                }
            }
            else
            {
                for (int i = 0; i < tapluat.Count(); i++)
                {
                    if (int.Parse(tapluat[i].Substring(1)) < maxm)
                    {
                        maxm = int.Parse(tapluat[i].Substring(1));
                        mx = i;
                    }
                }
            }
            return mx;
        }
        private void addgiathiet(int i)
        {
           string[] strtemp = converStringToArray(dex.getKetLuan("select KetLuan from [Luat$] where ID='" + tapluat[i] + "'"), '^');
           int x = giathiet.Length;
           Array.Resize<string>(ref giathiet,(strtemp.Length+giathiet.Length));
           strtemp.CopyTo(giathiet, x);
           tapgiathiet.Add(converArrayToString(giathiet));  
        }
        private void timluat()
        {           
            for (int i = 0; i < luat.Count; i++)
            {                
                if (kiemtra(luat[i][1]) == true)
                {
                    tapluat.Add(luat[i][0]);                   
                    luat.RemoveAt(i);
                    i = i - 1;
                }
            }
        }
        private bool kiemtra( string strCheck)
        {
            int dem = 0,i,j;
            string[] temp = converStringToArray(strCheck, '^');
            for(i=0;i<temp.Length;i++)
                for (j = 0; j < giathiet.Length; j++)
                { 
                    if(temp[i].ToUpper().CompareTo(giathiet[j].ToUpper())==0)
                    {
                        dem++;
                        break;
                    }
                }
            if (dem == i) return true;
            return false;
        }
        public bool getstatus
        {
            get { return status; }
        }
        public List<string> getvet()
        {
            return vet;
        }
        public List<string> getGiaThiet
        {
            get { return tapgiathiet; }
        }
        public List<List<string>> getLuat
        {
            get { return luat; }
        }
       // thuc hien heuritic 

        public void thuchien_heuristic()
        {
            int xx=0;
            List<int> luutrongso= new List<int>();
            int luu_vitri = 0;
            tap_luat = new List<List<string>>();
            timluat(ref tap_luat);
            while (tap_luat.Count != 0 || kiemtra(ketluan) == false)
            {
                if (kiemtra(ketluan) == true)
                {
                    status = true;
                    break;
                }
                if (tap_luat.Count == 0)
                {
                    status = false;
                    break;
                }
                // kiem tra trong so xem cai tap luat nao co trong so be hon thi thuc hien buoc di theo no               

                luu_vitri = -1;
                for (int j = 0; j < tap_luat.Count; j++)
                {
                    xx = danhtrongso(tap_luat[j]);                 
                    if (xx >= 0)
                    {
                        luu_vitri = j;
                        break;
                    }
                }
               
                luutrongso.Clear();
                for (int j = 0; j < tap_luat.Count; j++)
                {
                    luutrongso.Add(danhtrongso(tap_luat[j]));          
                    if (luutrongso[j]>=0)
                    {
                        if (xx > luutrongso[j])
                        {
                            xx = luutrongso[j];
                            luu_vitri = j;
                        }
                    }
                }
                if (luu_vitri == -1) { status = false; break; }
                add_giathiet(luu_vitri);
                vet.Add(tap_luat[luu_vitri][0]);               
                loai_bo_luat(ref luat, tap_luat[luu_vitri][0]);
                tap_luat.RemoveAt(luu_vitri);
                timluat(ref tap_luat);
                loaibogiongnhau(ref tap_luat);
            }
        }
        private void loaibogiongnhau(ref List<List<string>> a)
        {
            int i = 0;
            while (i < a.Count)
            {
                int j = i + 1;
                while (j < a.Count)
                {
                    if (a[i][0].ToUpper().CompareTo(a[j][0].ToUpper())==0)
                    {
                        a.RemoveAt(j);
                        j--;
                    }
                    j++;
                }
                i++;
            }
        }
        private void loai_bo_luat(ref List<List<string>> luat, string check)
        {
            for (int i = 0; i < luat.Count; i++)
            {
                if (check.ToUpper().CompareTo(luat[i][0].ToUpper()) == 0)
                {
                    luat.RemoveAt(i);
                    break;
                }
            }
        }
        private void add_giathiet(int i)
        {
            string[] strtemp = converStringToArray(tap_luat[i][2], '^');
            int x = giathiet.Length;
            Array.Resize<string>(ref giathiet, (strtemp.Length + giathiet.Length));
            strtemp.CopyTo(giathiet, x);
            tapgiathiet.Add(converArrayToString(giathiet));
        }

        public int danhtrongso(List<string> luat_curent)
        {
            int dem = 0;
            List<List<string>> luat_tamthoi = new List<List<string>>();
            luat_tamthoi.AddRange(luat);
            List<string> temp_ketluat1 = converStringToArray(luat_curent[2], '^').ToList<string>();
            List<string> temp_ketluat2 = new List<string>();
            bool cachchon = true;
            if (kiemtra(temp_ketluat1) == true) // neu kiem tra thay ket luan nam trong tap ket luan suy dien thi dung;
                return 0;

            while (true)
            {
                if (temp_ketluat1.Count == 0 && temp_ketluat2.Count == 0)
                    break;
                if (temp_ketluat2.Count == 0) cachchon = false;
                else cachchon = true;
                dem++;
                if (cachchon == true)
                {
                    if (kiemtra(ref luat_tamthoi, ref temp_ketluat2, ref temp_ketluat1) == true)                        
                        break;                   
                }
                else
                {
                    if (kiemtra(ref luat_tamthoi, ref temp_ketluat1, ref temp_ketluat2) == true)                       
                        break;                    
                }
            }
            if (temp_ketluat2.Count == 0 && temp_ketluat1.Count == 0)
                return -1;
            return dem;
        }
        public bool kiemtra(ref List<List<string>> temp_luat, ref List<string> temp_giathiet, ref List<string> temp_ketluan)
        {           
            int i;
            List<string> trung_gian;
            for (int j = 0; j < temp_giathiet.Count; j++)
            {
               
                for (i = 0; i < temp_luat.Count; i++)
                {
                    if (kiemtra(temp_luat[i][1], temp_giathiet[j]) == true)
                    {                    
                            trung_gian = converStringToArray(temp_luat[i][2], '^').ToList<string>();
                            temp_ketluan.AddRange(trung_gian); // them tap gia
                            temp_luat.RemoveAt(i);
                            i -= 1;
                            if (kiemtra(temp_ketluan) == true)
                                return true;                        
                    }
                }                                         
            }
            temp_giathiet.Clear();
            return false;
        }
        // kiem tra mot ket luan co nam trong tap gia thiet suy dien ra khong ca 2 deu la string
        private bool kiemtra(string str, string strCheck)
        {
            string[] strtemp = converStringToArray(str, '^');
            for (int i = 0; i < strtemp.Length; i++)
            {
                if (strtemp[i].ToUpper().CompareTo(strCheck.ToUpper()) == 0)
                    return true;
            }
            return false;
        }
        // kiem tra ket luan co nam trong list gia thiet khong
        private bool kiemtra(List<string> ket_luan)
        {
            foreach (string a in ket_luan)
            {
                if (a.ToUpper().CompareTo(ketluan.ToUpper()) == 0)
                    return true;
            }
            return false;
        }
        private void timluat(ref List<List<string>> tap_luat)
        {
            for (int i = 0; i < luat.Count; i++)            
                if (kiemtra(luat[i][1]) == true)                
                    tap_luat.Add(luat[i]);                                             
        }
    }
}
