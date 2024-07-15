using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSanBongDaMini
{
    public partial class frmThongKe : Form
    {
        DBConnection db = new DBConnection();
        public frmThongKe()
        {
            InitializeComponent();
            loadThongKe();
        }

        private void loadThongKe()
        {
            DataTable listDatSanDaThanhToan = db.layDuLieu("select * from DatSan where DaThanhToan= 1");
            int tongTienDaThanhToan = 0;
            foreach (DataRow r in listDatSanDaThanhToan.Rows)
                tongTienDaThanhToan += Int32.Parse(r["TongTien"].ToString().Trim());
            lb_TongTienThuDuoc.Text = tongTienDaThanhToan.ToString();


            DataTable listDatSanChuaThanhToan = db.layDuLieu("select * from DatSan where DaThanhToan= 0");
            int tongTienChuaThanhToan = 0;
            foreach (DataRow r in listDatSanChuaThanhToan.Rows)
                tongTienChuaThanhToan += Int32.Parse(r["TongTien"].ToString().Trim());
            lb_TongTienChuaThanhToan.Text = tongTienChuaThanhToan.ToString();


            DataTable listSan = db.layDuLieu("select * from San");
            int tongSLSan = 0;
            foreach (DataRow r in listSan.Rows)
                tongSLSan += 1;
            lb_SLSanBai.Text = tongSLSan.ToString();


            DataTable listDatSan = db.layDuLieu("select * from DatSan");
            int tongSLDatSan = 0;
            foreach (DataRow r in listDatSan.Rows)
                tongSLDatSan += 1;
            lb_SLDatSan.Text = tongSLDatSan.ToString();


            DataTable listHuyDatSan = db.layDuLieu("select * from DatSan where DaHuy = 1");
            int tongSLHuyDatSan = 0;
            foreach (DataRow r in listHuyDatSan.Rows)
                tongSLHuyDatSan += 1;
            lb_SLHuyDatSan.Text = tongSLHuyDatSan.ToString();

            DataTable sanDuocDatNhieuNhat = db.layDuLieu("SELECT TOP 1 S.MaSan, S.TenSan, COUNT(*) AS SoLanDatSan FROM San S JOIN DatSan DS ON S.MaSan = DS.MaSan GROUP BY S.MaSan,S.TenSan ORDER BY COUNT(*) DESC");
            foreach (DataRow r in sanDuocDatNhieuNhat.Rows)
            {
                lb_SanDatNhieuNhat.Text = r["TenSan"].ToString().Trim() + " (" + r["SoLanDatSan"].ToString().Trim() + ")";
            }
        }

        private void btn_XuatRP_Click(object sender, EventArgs e)
        {
            
            string NgayThongKe = DateTime.Today.ToShortDateString();
            string TongTienThuDuoc = lb_TongTienThuDuoc.Text;
            string TienSanChuaThanhToan = lb_TongTienChuaThanhToan.Text;
            string SoLuongSanBai = lb_SLSanBai.Text;
            string SoLuongDatSan = lb_SLDatSan.Text;
            string SoLuongHuyDatSan = lb_SLHuyDatSan.Text;
            string SanDatNhieuNhat = lb_SanDatNhieuNhat.Text;

            db.themXoaSua("delete from ReportThongKe");
            db.themXoaSua("insert into ReportThongKe values('"+NgayThongKe+"', "+TongTienThuDuoc+" , "+TienSanChuaThanhToan+" , "+SoLuongSanBai+" ,"+SoLuongDatSan+","+SoLuongHuyDatSan+", N'"+SanDatNhieuNhat+"')");

            ReportThongKe report = new ReportThongKe();
            reportThongKe.ReportSource = report;
            report.SetDatabaseLogon(db.StrServerName, db.StrDatabaseName);
            reportThongKe.DisplayStatusBar = false;
            reportThongKe.DisplayToolbar = true;
            reportThongKe.Refresh();            

        }

    }
}
