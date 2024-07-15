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
    public partial class frmQLTaiKhoan : Form
    {
        DBConnection db = new DBConnection();
        int maTaiKhoanDN = 0;
        public frmQLTaiKhoan(int maTaiKhoanDN)
        {
            InitializeComponent();
            this.maTaiKhoanDN = maTaiKhoanDN;
            loadThongTinTaiKhoanDN(this.maTaiKhoanDN);
            checkQuyenDN(this.maTaiKhoanDN);
        }

        public frmQLTaiKhoan()
        {
            InitializeComponent();
        }

        private void txt_SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void loadThongTinTaiKhoanDN(int maTKDN)
        {
            DataTable taiKhoanDN = db.layDuLieu("select * from TaiKhoan where MaTaiKhoan = "+ maTKDN);
            foreach (DataRow d in taiKhoanDN.Rows)
            {
                lbl_Email.Text = d["Email"].ToString().Trim();
                lbl_HoTen.Text = d["HoTen"].ToString().Trim();
                lbl_MaTK.Text = d["MaTaiKhoan"].ToString().Trim();

                DataTable quyenDN = db.layDuLieu("select * from Quyen where MaQuyen = '" + d["MaQuyen"].ToString().Trim() + "'");
                foreach (DataRow dr in quyenDN.Rows)
                {
                    lbl_Quyen.Text = dr["TenQuyen"].ToString().Trim();
                }
                lbl_SDT.Text = d["SoDienThoai"].ToString().Trim();
            }
        }

        private void btn_LamMoiDoiMK_Click(object sender, EventArgs e)
        {
            txt_MKCu.Text = txt_MKMoi.Text = txt_MKXacNhan.Text = string.Empty;
        }

        private void btn_DoiMK_Click(object sender, EventArgs e)
        {
            if(txt_MKCu.Text.Trim() == string.Empty || txt_MKMoi.Text.Trim() == string.Empty ||  txt_MKXacNhan.Text.Trim() == string.Empty)
                MessageBox.Show("Vui lòng điền đầy đủ thông tin để đổi mật khẩu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if(txt_MKMoi.Text.Trim() !=  txt_MKXacNhan.Text.Trim())
                    MessageBox.Show("Xác nhận mật khẩu mới không trùng khớp!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    string oldPasswordInput = txt_MKCu.Text.Trim();
                    DataTable dsTaiKhoan = db.layDuLieu("select * from TaiKhoan where MaTaiKhoan = " + maTaiKhoanDN + " and MatKhau= '" + oldPasswordInput + "'");

                    if (dsTaiKhoan.Rows.Count < 1)
                        MessageBox.Show("Mật khẩu cũ không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn Đổi mật khẩu?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                        if (rs == DialogResult.Yes)
                        {
                            string newPasswordInput = txt_MKMoi.Text.Trim();
                            string queryStr = "update TaiKhoan set MatKhau = '" + newPasswordInput + "' where MaTaiKhoan =" + maTaiKhoanDN;
                            db.themXoaSua(queryStr);
                            MessageBox.Show("Đã đổi mật khẩu thành công!", "Xác Nhận", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                    }
                }
            }
        }


        private void checkQuyenDN(int maTKDN)
        {
            DataTable dsTaiKhoan = db.layDuLieu("select * from TaiKhoan where MaTaiKhoan = " + maTKDN);
            
            foreach(DataRow r in dsTaiKhoan.Rows)
            {
                if (r["MaQuyen"].ToString().Trim() == "staff")
                    grp_dstk.Enabled = false;
                else
                {
                    loadDataGridView();
                }
            }
        }

        private void loadDataGridView()
        {
            DataTable dsTaiKhoan = db.layDuLieu("select * from TaiKhoan");
            List<MTaiKhoan> listTaiKhoan = new List<MTaiKhoan>();
            foreach (DataRow r in dsTaiKhoan.Rows)
            {
                listTaiKhoan.Add(new MTaiKhoan { 
                    MaTaiKhoan = Int32.Parse(r["MaTaiKhoan"].ToString().Trim()),
                    HoTen = r["HoTen"].ToString().Trim(),
                    Email = r["Email"].ToString().Trim(),
                    SoDienThoai = r["SoDienThoai"].ToString().Trim(),
                    MatKhau = r["MatKhau"].ToString().Trim(),
                    BiKhoa = bool.Parse(r["BiKhoa"].ToString().Trim()),
                    MaQuyen = r["MaQuyen"].ToString().Trim(),
                });
            }
            gv_DSTaiKhoan.DataSource = null;
            gv_DSTaiKhoan.DataSource = listTaiKhoan;
        }

        private void gv_DSTaiKhoan_SelectionChanged(object sender, EventArgs e)
        {
            if(gv_DSTaiKhoan.SelectedRows.Count > 0)
            {
                DataGridViewRow r = gv_DSTaiKhoan.SelectedRows[0];
                txt_MaTK.Text = r.Cells[0].Value.ToString().Trim();
                txt_HoTen.Text = r.Cells[1].Value.ToString().Trim();
                txt_Email.Text = r.Cells[2].Value.ToString().Trim();
                txt_SDT.Text = r.Cells[3].Value.ToString().Trim();
                txt_MatKhau.Text = r.Cells[4].Value.ToString().Trim();
                cbb_BiKhoa.Text = r.Cells[6].Value.ToString().Trim();
                cbb_Quyen.Text = (r.Cells[5].Value.ToString().Trim() == "staff") ? "Nhân Viên" : "Quản Lý";
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if(txt_HoTen.Text.Trim() == string.Empty ||txt_Email.Text.Trim() == string.Empty ||txt_SDT.Text.Trim() == string.Empty ||txt_MatKhau.Text.Trim() == string.Empty || cbb_Quyen.SelectedIndex < 0 ||cbb_BiKhoa.SelectedIndex < 0)
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                string sdtInput = txt_SDT.Text.Trim();

                if (sdtInput.Length > 11)
                    MessageBox.Show("Vui lòng điền số điện thoại hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    if (txt_MatKhau.Text.Trim().Length < 6)
                        MessageBox.Show("Vui lòng điền mật khẩu >= 6 kí tự!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        DataTable dsTaiKhoan = db.layDuLieu("select * from TaiKhoan where SoDienThoai = '" + sdtInput + "'");
                        if (dsTaiKhoan.Rows.Count > 0)
                            MessageBox.Show("Số điện thoại này đã được đăng ký!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        else
                        {
                            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn Thêm tài khoản mới?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                            if (rs == DialogResult.Yes)
                            {
                                int biKhoa = cbb_BiKhoa.SelectedItem.ToString().Trim() == "True" ? 1 : 0;
                                string maQuyen = cbb_Quyen.SelectedItem.ToString().Trim() == "Nhân Viên" ? "staff" : "owner";
                                string queryStr = "insert into TaiKhoan(HoTen, Email, SoDienThoai, MatKhau, BiKhoa, MaQuyen) values (N'" + txt_HoTen.Text.Trim() + "','" + txt_Email.Text.Trim() + "', '" + txt_SDT.Text.Trim() + "', '" + txt_MatKhau.Text.Trim() + "', " + biKhoa + ",'" + maQuyen + "')";
                                db.themXoaSua(queryStr);
                                MessageBox.Show("Thêm tài khoản mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                loadDataGridView();
                            }
                        }
                    }
                }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (gv_DSTaiKhoan.SelectedRows.Count > 0)
            {
                DataGridViewRow r = gv_DSTaiKhoan.SelectedRows[0];
                int maTKXoa = Int32.Parse( r.Cells[0].Value.ToString().Trim() );

                DataTable checkForeign = db.layDuLieu("select * from DatSan where MaTaiKhoan =" + maTKXoa);
                if(checkForeign.Rows.Count > 0)
                    MessageBox.Show("Tài khoản đang giữ khóa ngoại, không thể Xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn Xóa tài khoản?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (rs == DialogResult.Yes)
                    {
                        db.themXoaSua("delete from TaiKhoan where MaTaiKhoan = " + maTKXoa);
                        MessageBox.Show("Xóa thông tin tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        loadDataGridView();
                    }
                }
            }
            else
                MessageBox.Show("Vui lòng chọn tài khoản muốn Xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            txt_Email.Text = txt_HoTen.Text = txt_MaTK.Text = txt_SDT.Text = txt_MatKhau.Text = string.Empty;
            cbb_BiKhoa.SelectedIndex = cbb_Quyen.SelectedIndex = -1;
            cbb_BiKhoa.Text = cbb_Quyen.Text = "--- Chọn ---";
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (gv_DSTaiKhoan.SelectedRows.Count > 0)
            {
                DataGridViewRow r = gv_DSTaiKhoan.SelectedRows[0];
                int maTKSua = Int32.Parse(r.Cells[0].Value.ToString().Trim());

                if (txt_HoTen.Text.Trim() == string.Empty || txt_Email.Text.Trim() == string.Empty || txt_SDT.Text.Trim() == string.Empty || txt_MatKhau.Text.Trim() == string.Empty || cbb_Quyen.SelectedIndex < 0 || cbb_BiKhoa.SelectedIndex < 0)
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                     string sdtInput = txt_SDT.Text.Trim();

                     if (sdtInput.Length > 11)
                         MessageBox.Show("Vui lòng điền số điện thoại hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                     else
                     {
                         if (txt_MatKhau.Text.Trim().Length < 6)
                             MessageBox.Show("Vui lòng điền mật khẩu >= 6 kí tự!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                         else
                         {
                             DataTable dsTaiKhoan = db.layDuLieu("select * from TaiKhoan where SoDienThoai = '" + sdtInput + "' and MaTaiKhoan !=" + maTKSua);
                             if (dsTaiKhoan.Rows.Count > 0)
                                 MessageBox.Show("Số điện thoại này đã được đăng ký!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                             else
                             {
                                 DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn Sửa thông tin tài khoản?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                                 if (rs == DialogResult.Yes)
                                 {
                                     int biKhoa = cbb_BiKhoa.SelectedItem.ToString().Trim() == "True" ? 1 : 0;
                                     string maQuyen = cbb_Quyen.SelectedItem.ToString().Trim() == "Nhân Viên" ? "staff" : "owner";
                                     string queryStr = "update TaiKhoan set HoTen = N'" + txt_HoTen.Text.Trim() + "', Email='" + txt_Email.Text.Trim() + "', SoDienThoai = '" + txt_SDT.Text.Trim() + "', MatKhau = '" + txt_MatKhau.Text.Trim() + "', BiKhoa ="+ biKhoa+ ", MaQuyen ='"+maQuyen+"' where MaTaiKhoan =" + maTKSua;
                                     db.themXoaSua(queryStr);
                                     MessageBox.Show("Sửa thông tin tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                     loadDataGridView();
                                 }
                             }
                         }
                     }
                }
            }
            else
                MessageBox.Show("Vui lòng chọn tài khoản muốn Sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
