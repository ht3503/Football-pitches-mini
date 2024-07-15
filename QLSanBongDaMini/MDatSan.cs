using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSanBongDaMini
{
    public class MDatSan
    {
        public int maDatSan, gioBatDau, gioKetThuc, tongTien, maTaiKhoan;

        public int MaDatSan
        {
            get { return maDatSan; }
            set { maDatSan = value; }
        }
        public DateTime NgayDatSan
        {
            get { return ngayDatSan; }
            set { ngayDatSan = value; }
        }
        public int GioBatDau
        {
            get { return gioBatDau; }
            set { gioBatDau = value; }
        }
        public int GioKetThuc
        {
            get { return gioKetThuc; }
            set { gioKetThuc = value; }
        }

        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }

        public string SDTLienLac
        {
            get { return sDTLienLac; }
            set { sDTLienLac = value; }
        }

        public int TongTien
        {
            get { return tongTien; }
            set { tongTien = value; }
        }

        public bool DaThanhToan
        {
            get { return daThanhToan; }
            set { daThanhToan = value; }
        }

        public bool DaHuy
        {
            get { return daHuy; }
            set { daHuy = value; }
        }

        public int MaTaiKhoan
        {
            get { return maTaiKhoan; }
            set { maTaiKhoan = value; }
        }
        public string hoTen, sDTLienLac, maSan;

        

        public string MaSan
        {
            get { return maSan; }
            set { maSan = value; }
        }
        private DateTime ngayDatSan;

        
        public bool daThanhToan, daHuy;

        

    }
}
