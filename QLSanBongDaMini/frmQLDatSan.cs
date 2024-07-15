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
    public partial class frmQLDatSan : Form
    {
        DBConnection db = new DBConnection();
        int maTaiKhoanDN = 0;
        public frmQLDatSan(int maTKDN)
        {
            InitializeComponent();
            maTaiKhoanDN = maTKDN;
            loadDataDefault();
        }

        public frmQLDatSan()
        {
            InitializeComponent();
        }

        private void loadDataDefault()
        {
            DataTable dsLoaiSan = db.layDuLieu("select * from LoaiSan");
            foreach (DataRow r in dsLoaiSan.Rows)
                cbb_LoaiSan.Items.Add(r["TenLoaiSan"].ToString().Trim());


            DataTable dsDatSan = db.layDuLieu("select * from DatSan");
            List<MDatSan> listDatSan = new List<MDatSan>();
            foreach (DataRow r in dsDatSan.Rows)
                listDatSan.Add(new MDatSan
                {
                    MaDatSan = Int32.Parse(r["MaDatSan"].ToString().Trim()),
                    NgayDatSan = DateTime.Parse(r["NgayDatSan"].ToString().Trim()),
                    GioBatDau = Int32.Parse(r["GioBatDau"].ToString().Trim()),
                    GioKetThuc = Int32.Parse(r["GioKetThuc"].ToString().Trim()),
                    HoTen = r["HoTen"].ToString().Trim(),
                    SDTLienLac = r["SDTLienLac"].ToString().Trim(),
                    TongTien = Int32.Parse(r["TongTien"].ToString().Trim()),
                    DaThanhToan = bool.Parse(r["DaThanhToan"].ToString().Trim()),
                    DaHuy = bool.Parse(r["DaHuy"].ToString().Trim()),
                    MaTaiKhoan = Int32.Parse(r["MaTaiKhoan"].ToString().Trim()),
                    MaSan = r["MaSan"].ToString().Trim()
                });
            gv_DSDatSan.DataSource = null;
            gv_DSDatSan.DataSource = listDatSan;


            cbb_SanDatTK.Items.Clear();
            DataTable dsSan = db.layDuLieu("select * from San");
            foreach (DataRow r in dsSan.Rows)
                cbb_SanDatTK.Items.Add(r["TenSan"].ToString().Trim());
        }


        private void txt_SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }


        private void cbb_LoaiSan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbb_LoaiSan.SelectedIndex >= 0)
            {
                string maLoaiSan = "";
                int giaTrenGio = 0;
                DataTable dsLoaiSan = db.layDuLieu("select * from LoaiSan where TenLoaiSan=N'"+cbb_LoaiSan.SelectedItem.ToString().Trim()+"'");
                foreach (DataRow r in dsLoaiSan.Rows)
                {
                    maLoaiSan = r["MaLoaiSan"].ToString().Trim();
                    giaTrenGio = Int32.Parse(r["GiaTrenGio"].ToString().Trim());
                }

                txt_TongTien.Text = (giaTrenGio * (Int32.Parse(txt_GioKT.Text.Trim()) - Int32.Parse(num_GioBD.Value.ToString().Trim()))).ToString();

                cbb_San.Items.Clear();
                DataTable dsSan = db.layDuLieu("select * from San where MaLoaiSan ='" + maLoaiSan + "' and DangSuaChua= 0");
                foreach (DataRow r in dsSan.Rows)
                    cbb_San.Items.Add(r["TenSan"].ToString().Trim());

            }
        }

        private void num_GioBD_ValueChanged(object sender, EventArgs e)
        {
            txt_GioKT.Text = (Int32.Parse(num_GioBD.Value.ToString()) + 1).ToString();
        }


        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            refreshAllData();
        }

        private void refreshAllData()
        {
            txt_MaDS.Text = txt_HoTen.Text = txt_SDT.Text = txt_TongTien.Text = string.Empty;
            date_NgayDS.Value = DateTime.Today;

            num_GioBD.Value = 0;
            txt_GioKT.Text = string.Empty;

            cbb_LoaiSan.Text = cbb_San.Text = cbb_ThanhToan.Text = cbb_TrangThaiDS.Text = "--- Chọn ---";
            cbb_LoaiSan.SelectedIndex = cbb_San.SelectedIndex = cbb_ThanhToan.SelectedIndex = cbb_TrangThaiDS.SelectedIndex = -1;
        }


        private void gv_DSDatSan_SelectionChanged(object sender, EventArgs e)
        {
            if (gv_DSDatSan.SelectedRows.Count > 0)
            {
                DataGridViewRow r = gv_DSDatSan.SelectedRows[0];
                txt_MaDS.Text = r.Cells[0].Value.ToString().Trim();
                txt_HoTen.Text = r.Cells[4].Value.ToString().Trim();
                txt_SDT.Text = r.Cells[5].Value.ToString().Trim();
                txt_TongTien.Text = r.Cells[6].Value.ToString().Trim();
                txt_GioKT.Text = r.Cells[3].Value.ToString().Trim();
                num_GioBD.Value = Int32.Parse(r.Cells[2].Value.ToString().Trim());
                date_NgayDS.Value = DateTime.Parse(r.Cells[1].Value.ToString().Trim());

                DataTable dsSan = db.layDuLieu("select * from San where MaSan ='" + r.Cells[10].Value.ToString().Trim() + "'");
                foreach (DataRow dr in dsSan.Rows)
                {
                    cbb_San.Text = dr["TenSan"].ToString().Trim();

                    DataTable dsLoaiSan = db.layDuLieu("select * from LoaiSan where MaLoaiSan ='" + dr["MaLoaiSan"].ToString().Trim() + "'");
                    foreach (DataRow row in dsLoaiSan.Rows)
                    {
                        cbb_LoaiSan.Text = row["TenLoaiSan"].ToString().Trim();
                    }
                }

                cbb_ThanhToan.Text = r.Cells[7].Value.ToString().Trim() == "True" ? "Đã Thanh Toán" : "Chưa Thanh Toán";
                cbb_TrangThaiDS.Text = r.Cells[8].Value.ToString().Trim() == "True" ? "Đã Hủy" : "Đang Hoạt Động";
            }
        }

        private void btn_DanhSach_Click(object sender, EventArgs e)
        {
            loadDataDefault();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if(txt_MaDS.Text.Trim() == string.Empty ||txt_TongTien.Text.Trim() == string.Empty || cbb_LoaiSan.SelectedIndex < 0 ||cbb_San.SelectedIndex < 0 ||cbb_ThanhToan.SelectedIndex < 0 )
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                string maSan = "";
                DataTable dsSan = db.layDuLieu("select * from San where TenSan =N'" + cbb_San.SelectedItem.ToString().Trim() + "'");
                foreach (DataRow r in dsSan.Rows)
                    maSan = r["MaSan"].ToString().Trim();
                if(checkTrungLichDatSan(maSan, date_NgayDS.Value, Int32.Parse( num_GioBD.Value.ToString()), Int32.Parse( txt_GioKT.Text.Trim())))
                    MessageBox.Show("Sân tại thời điểm này đã bị trùng lịch đặt sân!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    string ngayDS = date_NgayDS.Value.ToShortDateString();
                    int gioBD = Int32.Parse(num_GioBD.Value.ToString());
                    int gioKT = Int32.Parse(txt_GioKT.Text.Trim());
                    string hoTen = txt_HoTen.Text.Trim();
                    string sdtLienLac = txt_SDT.Text.Trim();
                    int tongTien = Int32.Parse(txt_TongTien.Text.Trim());
                    int daThanhToan = cbb_ThanhToan.SelectedItem.ToString().Trim() == "Đã Thanh Toán" ? 1 : 0;

                    DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn Thêm đặt sân mới?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (rs == DialogResult.Yes)
                    {
                        string queryStr = "INSERT INTO DatSan(NgayDatSan, GioBatDau, GioKetThuc, HoTen, SDTLienLac, TongTien, DaThanhToan, DaHuy, MaTaiKhoan, MaSan) VALUES ('" + ngayDS + "', " + gioBD + ", " + gioKT + ", N'" + hoTen + "', '" + sdtLienLac + "', " + tongTien + ", " + daThanhToan + ", 0, " + maTaiKhoanDN + ",'" + maSan + "')";
                        db.themXoaSua(queryStr);
                        MessageBox.Show("Thêm đặt sân mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        loadDataDefault();
                    }
                    
                }
            }
        }

        private bool checkTrungLichDatSan(string maSan, DateTime ngayDS, int gioBD, int gioKT)
        {
            string checkNgay = ngayDS.ToShortDateString();
            DataTable dsDatSan = db.layDuLieu("select * from DatSan where NgayDatSan='" + checkNgay + "' and GioBatDau=" + gioBD + " and GioKetThuc="+gioKT +" and MaSan='"+maSan+"'");
            if (dsDatSan.Rows.Count > 0)
                return true;
            return false;
        }

        private bool checkUpdateTrungLichDatSan(int maDS, string maSan, DateTime ngayDS, int gioBD, int gioKT)
        {
            string checkNgay = ngayDS.ToShortDateString();
            DataTable dsDatSan = db.layDuLieu("select * from DatSan where NgayDatSan='" + checkNgay + "' and GioBatDau=" + gioBD + " and GioKetThuc=" + gioKT + " and MaSan='"+maSan+ "' and MaDatSan !=" + maDS);
            if (dsDatSan.Rows.Count > 0)
                return true;
            return false;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (gv_DSDatSan.SelectedRows.Count > 0)
            {
                DataGridViewRow r = gv_DSDatSan.SelectedRows[0];
                int maDS = Int32.Parse( r.Cells[0].Value.ToString().Trim());
                DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn Xóa thông tin đặt sân?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (rs == DialogResult.Yes)
                {
                    db.themXoaSua("delete from DatSan where MaDatSan=" + maDS);
                    MessageBox.Show("Xóa thông tin đặt sân thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    loadDataDefault();
                }
            }
            else
                MessageBox.Show("Vui lòng chọn lịch đặt sân để thao tác Xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (gv_DSDatSan.SelectedRows.Count > 0)
            {
                DataGridViewRow r = gv_DSDatSan.SelectedRows[0];
                int maDS = Int32.Parse(r.Cells[0].Value.ToString().Trim());

                string ngayDS = date_NgayDS.Value.ToShortDateString();
                int gioBD = Int32.Parse(num_GioBD.Value.ToString());
                int gioKT = Int32.Parse(txt_GioKT.Text.Trim());
                string hoTen = txt_HoTen.Text.Trim();
                string sdtLienLac = txt_SDT.Text.Trim();
                int tongTien = Int32.Parse(txt_TongTien.Text.Trim());
                int daThanhToan = cbb_ThanhToan.SelectedItem.ToString().Trim() == "Đã Thanh Toán" ? 1 : 0;
                int daHuy = cbb_TrangThaiDS.SelectedItem.ToString().Trim() == "Đã Hủy" ? 1 : 0;

                string queryStr = "";
                string maSan = r.Cells[10].Value.ToString().Trim();
                if(cbb_San.SelectedIndex > -1)
                {
                    DataTable dsSan = db.layDuLieu("select * from San where TenSan =N'" + cbb_San.SelectedItem.ToString().Trim() + "'");
                    foreach (DataRow dr in dsSan.Rows)
                        maSan = dr["MaSan"].ToString().Trim();

                    queryStr = "update DatSan set NgayDatSan='" + ngayDS + "', GioBatDau=" + gioBD + " , GioKetThuc=" + gioKT + " , HoTen=N'" + hoTen + "', SDTLienLac='" + sdtLienLac + "', TongTien=" + tongTien + " ,DaThanhToan=" + daThanhToan + " , DaHuy=" + daHuy + "  , MaTaiKhoan=" + maTaiKhoanDN + "  , MaSan='" + maSan + "' where MaDatSan=" + maDS;
                }
                else
                {
                    queryStr = "update DatSan set NgayDatSan='" + ngayDS + "', GioBatDau=" + gioBD + " , GioKetThuc=" + gioKT + " , HoTen=N'" + hoTen + "', SDTLienLac='" + sdtLienLac + "', TongTien=" + tongTien + " ,DaThanhToan=" + daThanhToan + " , DaHuy=" + daHuy + "  , MaTaiKhoan=" + maTaiKhoanDN + " where MaDatSan=" + maDS;
                }

                if (checkUpdateTrungLichDatSan(maDS, maSan, date_NgayDS.Value, gioBD, gioKT))
                    MessageBox.Show("Sân tại thời điểm này đã bị trùng lịch đặt sân!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn Sửa thông tin đặt sân?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (rs == DialogResult.Yes)
                    {
                        db.themXoaSua(queryStr);
                        MessageBox.Show("Sửa thông tin đặt sân thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        loadDataDefault();
                    }
                }
            }
            else
                MessageBox.Show("Vui lòng chọn lịch đặt sân để thao tác Xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btn_LamMoiTK_Click_1(object sender, EventArgs e)
        {
            txt_SDTTimKiem.Text = string.Empty;
            cbb_SanDatTK.Text = "--- Chọn ---";
            cbb_SanDatTK.SelectedIndex = -1;
        }

        private void cbb_SanDatTK_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbb_SanDatTK.SelectedIndex >= 0)
            {
                string maSan = "";
                DataTable dsSan = db.layDuLieu("select * from San where TenSan =N'" + cbb_SanDatTK.SelectedItem.ToString().Trim() + "'");
                foreach (DataRow r in dsSan.Rows)
                    maSan = r["MaSan"].ToString().Trim();

                DataTable dsDatSan = db.layDuLieu("select * from DatSan where MaSan='" + maSan + "'");
                if (dsDatSan.Rows.Count < 1)
                    MessageBox.Show("Không tìm thấy thông tin Đặt sân của sân!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    List<MDatSan> listDatSan = new List<MDatSan>();
                    foreach (DataRow r in dsDatSan.Rows)
                        listDatSan.Add(new MDatSan
                        {
                            MaDatSan = Int32.Parse(r["MaDatSan"].ToString().Trim()),
                            NgayDatSan = DateTime.Parse(r["NgayDatSan"].ToString().Trim()),
                            GioBatDau = Int32.Parse(r["GioBatDau"].ToString().Trim()),
                            GioKetThuc = Int32.Parse(r["GioKetThuc"].ToString().Trim()),
                            HoTen = r["HoTen"].ToString().Trim(),
                            SDTLienLac = r["SDTLienLac"].ToString().Trim(),
                            TongTien = Int32.Parse(r["TongTien"].ToString().Trim()),
                            DaThanhToan = bool.Parse(r["DaThanhToan"].ToString().Trim()),
                            DaHuy = bool.Parse(r["DaHuy"].ToString().Trim()),
                            MaTaiKhoan = Int32.Parse(r["MaTaiKhoan"].ToString().Trim()),
                            MaSan = r["MaSan"].ToString().Trim()
                        });
                    gv_DSDatSan.DataSource = null;
                    gv_DSDatSan.DataSource = listDatSan;
                }
            }
        }

        private void btn_TimKiem_Click_1(object sender, EventArgs e)
        {
            if (txt_SDTTimKiem.Text.Trim() == string.Empty)
                MessageBox.Show("Vui lòng điền số điện thoại khách hàng đặt sân!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                DataTable dsDatSan = db.layDuLieu("select * from DatSan where SDTLienLac='" + txt_SDTTimKiem.Text.Trim() + "'");
                if (dsDatSan.Rows.Count < 1)
                {
                    MessageBox.Show("Không tìm thấy thông tin Đặt sân của số điện thoại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    List<MDatSan> listDatSan = new List<MDatSan>();
                    foreach (DataRow r in dsDatSan.Rows)
                        listDatSan.Add(new MDatSan
                        {
                            MaDatSan = Int32.Parse(r["MaDatSan"].ToString().Trim()),
                            NgayDatSan = DateTime.Parse(r["NgayDatSan"].ToString().Trim()),
                            GioBatDau = Int32.Parse(r["GioBatDau"].ToString().Trim()),
                            GioKetThuc = Int32.Parse(r["GioKetThuc"].ToString().Trim()),
                            HoTen = r["HoTen"].ToString().Trim(),
                            SDTLienLac = r["SDTLienLac"].ToString().Trim(),
                            TongTien = Int32.Parse(r["TongTien"].ToString().Trim()),
                            DaThanhToan = bool.Parse(r["DaThanhToan"].ToString().Trim()),
                            DaHuy = bool.Parse(r["DaHuy"].ToString().Trim()),
                            MaTaiKhoan = Int32.Parse(r["MaTaiKhoan"].ToString().Trim()),
                            MaSan = r["MaSan"].ToString().Trim()
                        });
                    gv_DSDatSan.DataSource = null;
                    gv_DSDatSan.DataSource = listDatSan;
                }
            }
        }

        private void txt_SDTTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
