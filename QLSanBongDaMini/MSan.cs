using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSanBongDaMini
{
    public class MSan
    {
        public string maSan, tenSan, maLoaiSan;

        public string MaSan
        {
            get { return maSan; }
            set { maSan = value; }
        }

        public string TenSan
        {
            get { return tenSan; }
            set { tenSan = value; }
        }

        public bool DangSuaChua
        {
            get { return dangSuaChua; }
            set { dangSuaChua = value; }
        }
        public string MaLoaiSan
        {
            get { return maLoaiSan; }
            set { maLoaiSan = value; }
        }
        private bool dangSuaChua;

    }
}
