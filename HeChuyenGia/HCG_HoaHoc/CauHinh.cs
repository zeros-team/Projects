using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace HCG_HoaHoc
{
    class CauHinh
    {
      private   static  FileStream foud;
      private static  StreamReader sr;
      private static StreamWriter sw;
      private static String name = Application.StartupPath + "\\cauhinh.txt";
        //public CauHinh()
        //{
        //    openfile();
        //    sr = new StreamReader(foud);
        //}
        private static void openfile()
        {
            if (File.Exists(name) == false)
            {
                foud = File.Open(name, FileMode.Create);
            }
            else
                foud = File.Open(name, FileMode.Open);
                              
        }
       
        public static string[] docfile()
        {
            string[] txt = new string[2];
            int dem = 0;
            string text;
            openfile();
            sr = new StreamReader(foud);
            while ((text= sr.ReadLine()) != null)
            {
                txt[dem] = text;
                dem++;
                if (dem == 2) break;
            }
            foud.Close();           
            return txt;
        }
        public static void ghifile(string[] value)
        {
            openfile();          
            sw = new StreamWriter(foud);                        
            sw.WriteLine(value[0]);
            sw.WriteLine(value[1]);
            sw.Flush();
            foud.Close();
            
        }
        public static void ghifile(List<string> value,FileStream file)
        {            
            sw = new StreamWriter(file);
            for (int i = 0; i < value.Count; i++)
            {
                sw.WriteLine(value[i]);
            }
            sw.Flush();
            file.Close();
        }
      
    }
}
