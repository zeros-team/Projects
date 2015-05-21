using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace HCG_KHMT2_K7
{
    class Sukien
    {
        string ten, ngunghia;
        public Sukien()
        {
            ten = ngunghia = "";
        }
        public Sukien(string ten, string ngunghia)
        {
            this.ten = ten;
            this.ngunghia = ngunghia;
        }
        public string Ten
        {
            get
            {
                return ten;
            }
            set
            {
                ten = value;
            }
        }
        public string Ngunghia
        {
            get
            {
                return ngunghia;
            }
            set
            {
                ngunghia = value;
            }
        }
    }
}
