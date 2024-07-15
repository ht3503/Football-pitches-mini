using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSanBongDaMini
{
    public class MTaiKhoan
    {
        private int maTaiKhoan;

        public int MaTaiKhoan
        {
            get { return maTaiKhoan; }
            set { maTaiKhoan = value; }
        }
        public string hoTen, email, soDienThoai, matKhau, maQuyen;

        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string SoDienThoai
        {
            get { return soDienThoai; }
            set { soDienThoai = value; }
        }

        public string MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }
        }
        public string MaQuyen
        {
            get { return maQuyen; }
            set { maQuyen = value; }
        }

        
        private bool biKhoa;

        public bool BiKhoa
        {
            get { return biKhoa; }
            set { biKhoa = value; }
        }
    }
}
