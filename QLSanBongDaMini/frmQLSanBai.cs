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
    public partial class frmQLSanBai : Form
    {
        DBConnection db = new DBConnection();
        public frmQLSanBai()
        {
            InitializeComponent();
            loadDataDefault();
        }

        private void txt_GiaGio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void loadDataDefault()
        {
            DataTable dsLoaiSan = db.layDuLieu("select * from LoaiSan");
            DataTable dsSan = db.layDuLieu("select * from San");

            cbb_LoaiSan.Items.Clear();
            foreach (DataRow r in dsLoaiSan.Rows)
                cbb_LoaiSan.Items.Add(r["TenLoaiSan"].ToString().Trim());


            List<MLoaiSan> listLS = new List<MLoaiSan>();
            foreach (DataRow r in dsLoaiSan.Rows)
                listLS.Add(new MLoaiSan {
                    MaLoaiSan = r["MaLoaiSan"].ToString().Trim(),
                    TenLoaiSan = r["TenLoaiSan"].ToString().Trim(),
                    SoNguoiToiDa = Int32.Parse(r["SoNguoiToiDa"].ToString().Trim()),
                    GiaTrenGio = Int32.Parse(r["GiaTrenGio"].ToString().Trim())
                });
            gv_DSLoaiSan.DataSource = null;
            gv_DSLoaiSan.DataSource = listLS;


            List<MSan> listSan = new List<MSan>();
            foreach (DataRow r in dsSan.Rows)
                listSan.Add(new MSan
                {
                    MaSan = r["MaSan"].ToString().Trim(),
                    TenSan = r["TenSan"].ToString().Trim(),
                    DangSuaChua = bool.Parse(r["DangSuaChua"].ToString().Trim()),
                    MaLoaiSan = r["MaLoaiSan"].ToString().Trim()
                });
            gv_DSSan.DataSource = null;
            gv_DSSan.DataSource = listSan;
        }

        private void btn_LLamMoi_Click(object sender, EventArgs e)
        {
            txt_MaLoaiSan.Text = txt_TenLoaiSan.Text = txt_GiaGio.Text = string.Empty;
            num_SoNguoiToiDa.Value = 1;
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            txt_MaSan.Text = txt_TenSan.Text =string.Empty;
            cbb_LoaiSan.SelectedIndex = cbb_TrangThai.SelectedIndex = -1;
            cbb_LoaiSan.Text = cbb_TrangThai.Text = "--- Chọn ---";
        }

        private void gv_DSSan_SelectionChanged(object sender, EventArgs e)
        {
            if (gv_DSSan.SelectedRows.Count > 0)
            {
                DataGridViewRow r = gv_DSSan.SelectedRows[0];
                txt_MaSan.Text = r.Cells[0].Value.ToString().Trim();
                txt_TenSan.Text = r.Cells[1].Value.ToString().Trim();
                cbb_TrangThai.Text = r.Cells[2].Value.ToString().Trim() == "True" ? "Đang Sửa Chữa" : "Đang Hoạt Động";

                DataTable dsLoaiSan = db.layDuLieu("select * from LoaiSan where MaLoaiSan='"+r.Cells[3].Value.ToString().Trim()+"'");
                foreach (DataRow dr in dsLoaiSan.Rows)
                    cbb_LoaiSan.Text = dr["TenLoaiSan"].ToString().Trim();
            }
        }

        private void gv_DSLoaiSan_SelectionChanged(object sender, EventArgs e)
        {
            if (gv_DSLoaiSan.SelectedRows.Count > 0)
            {
                DataGridViewRow r = gv_DSLoaiSan.SelectedRows[0];
                txt_MaLoaiSan.Text = r.Cells[0].Value.ToString().Trim();
                txt_TenLoaiSan.Text = r.Cells[1].Value.ToString().Trim();
                num_SoNguoiToiDa.Value = Int32.Parse( r.Cells[2].Value.ToString().Trim() );
                txt_GiaGio.Text = r.Cells[3].Value.ToString().Trim();
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (txt_MaSan.Text.Trim() == string.Empty || txt_TenSan.Text.Trim() == string.Empty ||  cbb_LoaiSan.SelectedIndex < 0 || cbb_TrangThai.SelectedIndex < 0)
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                DataTable dsSan = db.layDuLieu("select * from San where MaSan='" + txt_MaSan.Text.Trim() + "'");
                if (dsSan.Rows.Count > 0)
                    MessageBox.Show("Mã sân thêm mới đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn Thêm sân mới?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (rs == DialogResult.Yes)
                    {
                        int dangSuaChua = cbb_TrangThai.SelectedItem.ToString().Trim() == "Đang Sửa Chữa" ? 1 : 0;
                        string maLoaiSan = "";
                        DataTable dsLoaiSan = db.layDuLieu("select * from LoaiSan where TenLoaiSan=N'" + cbb_LoaiSan.SelectedItem.ToString().Trim() + "'");
                        foreach (DataRow dr in dsLoaiSan.Rows)
                            maLoaiSan = dr["MaLoaiSan"].ToString().Trim();

                        db.themXoaSua("insert into San values('" + txt_MaSan.Text.Trim() + "' ,N'" + txt_TenSan.Text.Trim() + "', " + dangSuaChua + ", '" + maLoaiSan + "')");
                        MessageBox.Show("Thêm thông tin sân mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        loadDataDefault();
                    }
                }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (gv_DSSan.SelectedRows.Count > 0)
            {
                DataGridViewRow r = gv_DSSan.SelectedRows[0];

                string maSan = r.Cells[0].Value.ToString().Trim();

                DataTable dsDatSan = db.layDuLieu("select * from DatSan where MaSan='" + maSan + "'");
                if (dsDatSan.Rows.Count > 0)
                    MessageBox.Show("Sân đang giữ khóa ngoại không thể Xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn Xóa thông tin sân?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (rs == DialogResult.Yes)
                    {
                        db.themXoaSua("delete from San where MaSan ='"+maSan+"'");
                        MessageBox.Show("Xóa thông tin sân thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        loadDataDefault();
                    }
                }
            }
            else
                MessageBox.Show("Vui lòng chọn sân để Xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (gv_DSSan.SelectedRows.Count > 0)
            {
                DataGridViewRow r = gv_DSSan.SelectedRows[0];
                string maSan = r.Cells[0].Value.ToString().Trim();

                if (txt_TenSan.Text.Trim() == string.Empty || cbb_LoaiSan.SelectedIndex < 0 || cbb_TrangThai.SelectedIndex < 0)
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn Sửa thông tin sân?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (rs == DialogResult.Yes)
                    {
                        int dangSuaChua = cbb_TrangThai.SelectedItem.ToString().Trim() == "Đang Sửa Chữa" ? 1 : 0;
                        string maLoaiSan = "";
                        DataTable dsLoaiSan = db.layDuLieu("select * from LoaiSan where TenLoaiSan=N'" + cbb_LoaiSan.SelectedItem.ToString().Trim() + "'");
                        foreach (DataRow dr in dsLoaiSan.Rows)
                            maLoaiSan = dr["MaLoaiSan"].ToString().Trim();

                        string queryStr = "update San set TenSan=N'"+txt_TenSan.Text.Trim()+"', DangSuaChua="+dangSuaChua+", MaLoaiSan='"+maLoaiSan+"' where MaSan='"+maSan+"'";
                        db.themXoaSua(queryStr);
                        MessageBox.Show("Sửa thông tin sân thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        loadDataDefault();
                    }
                }
            }
            else
                MessageBox.Show("Vui lòng chọn sân để Sửa thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btn_LThem_Click(object sender, EventArgs e)
        {
            if (txt_MaLoaiSan.Text.Trim() == string.Empty || txt_TenLoaiSan.Text.Trim() == string.Empty || txt_GiaGio.Text.Trim() == string.Empty)
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                DataTable dsLoaiSan = db.layDuLieu("select * from LoaiSan where MaLoaiSan='" + txt_MaLoaiSan.Text.Trim() + "'");
                if (dsLoaiSan.Rows.Count > 0)
                    MessageBox.Show("Mã loại sân thêm mới đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn Thêm loại sân mới?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (rs == DialogResult.Yes)
                    {
                        db.themXoaSua("insert into LoaiSan values('" + txt_MaLoaiSan.Text.Trim() + "' ,N'" + txt_TenLoaiSan.Text.Trim() + "', " + Int32.Parse(num_SoNguoiToiDa.Value.ToString()) + ", " + Int32.Parse(txt_GiaGio.Text.Trim()) + ")");
                        MessageBox.Show("Thêm thông tin loại sân mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        loadDataDefault();
                    }
                }
            }
        }

        private void btn_LXoa_Click(object sender, EventArgs e)
        {
            if (gv_DSLoaiSan.SelectedRows.Count > 0)
            {
                DataGridViewRow r = gv_DSLoaiSan.SelectedRows[0];

                string maLoaiSan = r.Cells[0].Value.ToString().Trim();

                DataTable dsSan = db.layDuLieu("select * from San where MaLoaiSan='" + maLoaiSan + "'");
                if (dsSan.Rows.Count > 0)
                    MessageBox.Show("Loại sân đang giữ khóa ngoại không thể Xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn Xóa thông tin loại sân?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (rs == DialogResult.Yes)
                    {
                        db.themXoaSua("delete from LoaiSan where MaLoaiSan ='" + maLoaiSan + "'");
                        MessageBox.Show("Xóa thông tin loại sân thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        loadDataDefault();
                    }
                }
            }
            else
                MessageBox.Show("Vui lòng chọn loại sân để Xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btn_LSua_Click(object sender, EventArgs e)
        {
            if (gv_DSLoaiSan.SelectedRows.Count > 0)
            {
                DataGridViewRow r = gv_DSLoaiSan.SelectedRows[0];
                string maLoaiSan = r.Cells[0].Value.ToString().Trim();

                if (txt_TenLoaiSan.Text.Trim() == string.Empty || txt_GiaGio.Text.Trim() == string.Empty)
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn Sửa thông tin loại sân?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (rs == DialogResult.Yes)
                    {
                        string queryStr = "update LoaiSan set TenLoaiSan=N'" + txt_TenLoaiSan.Text.Trim() + "', SoNguoiToiDa=" + Int32.Parse(num_SoNguoiToiDa.Value.ToString()) + ", GiaTrenGio=" + Int32.Parse(txt_GiaGio.Text.Trim()) + " where MaLoaiSan='" + maLoaiSan + "'";
                        db.themXoaSua(queryStr);
                        MessageBox.Show("Sửa thông tin loại sân thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        loadDataDefault();
                    }
                }
            }
            else
                MessageBox.Show("Vui lòng chọn loại sân để Sửa thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
