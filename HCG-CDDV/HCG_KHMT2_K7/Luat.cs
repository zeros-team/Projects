using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HCG_KHMT2_K7
{
    class Luat
    {
        string left, right;
        public Luat()
        { left = right = ""; }
        public Luat(string vt, string vp)
        {
            left = vt;
            right = vp;
        }
        public string Left
        {
            get
            {
                return left;
            }
            set
            {
                left = value;
            }
        }
        public string Right
        {
            get
            {
                return right;
            }
            set
            {
                right = value;
            }
        }
    }
}

