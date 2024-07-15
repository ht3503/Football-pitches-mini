using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSanBongDaMini
{
    public class MLoaiSan
    {
        public string maLoaiSan, tenLoaiSan;

        public string MaLoaiSan
        {
            get { return maLoaiSan; }
            set { maLoaiSan = value; }
        }
        public string TenLoaiSan
        {
            get { return tenLoaiSan; }
            set { tenLoaiSan = value; }
        }

        public int soNguoiToiDa, giaTrenGio;

        public int SoNguoiToiDa
        {
            get { return soNguoiToiDa; }
            set { soNguoiToiDa = value; }
        }

        public int GiaTrenGio
        {
            get { return giaTrenGio; }
            set { giaTrenGio = value; }
        }
    }
}
