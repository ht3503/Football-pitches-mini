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
    public partial class frmMain : Form
    {
        int maTaiKhoanDN = 0;
        DBConnection db = new DBConnection();
        public frmMain(int maTaiKhoanDN)
        {
            InitializeComponent();
            this.maTaiKhoanDN = maTaiKhoanDN;
        }
        public frmMain()
        {
            InitializeComponent();
        }

        private void btn_QLDatSan_Click(object sender, EventArgs e)
        {
            setOnClickButtonChange(btn_QLDatSan);
            frmQLDatSan _frm = new frmQLDatSan(maTaiKhoanDN);
            _frm.TopLevel = false;
            panel_master.Controls.Clear();
            panel_master.Controls.Add(_frm);
            _frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            _frm.Dock = DockStyle.Fill;
            _frm.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Button[] _btnList = new Button[]{
                btn_DangXuat, btn_QLDatSan, btn_QLSan, btn_ThongKe, btn_QLTaiKhoan
            };

            foreach(Button btn in _btnList)
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
            }
        }

        private void setOnClickButtonChange(Button btn)
        {
            Button[] _btnList = new Button[]{
                btn_QLDatSan, btn_QLSan, btn_ThongKe, btn_QLTaiKhoan
            };

            foreach (Button b in _btnList)
            {
                b.BackColor = Color.DarkGreen;
            }

            btn.BackColor = Color.Green;
        }

        private void btn_QLSan_Click(object sender, EventArgs e)
        {
            setOnClickButtonChange(btn_QLSan);
            frmQLSanBai _frm = new frmQLSanBai();
            _frm.TopLevel = false;
            panel_master.Controls.Clear();
            panel_master.Controls.Add(_frm);
            _frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            _frm.Dock = DockStyle.Fill;
            _frm.Show();
        }

        private void btn_QLTaiKhoan_Click(object sender, EventArgs e)
        {
            setOnClickButtonChange(btn_QLTaiKhoan);
            frmQLTaiKhoan _frm = new frmQLTaiKhoan(maTaiKhoanDN);
            _frm.TopLevel = false;
            panel_master.Controls.Clear();
            panel_master.Controls.Add(_frm);
            _frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            _frm.Dock = DockStyle.Fill;
            _frm.Show();
        }

        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            if (checkQuyenDN(maTaiKhoanDN))
            {
                setOnClickButtonChange(btn_ThongKe);
                frmThongKe _frm = new frmThongKe();
                _frm.TopLevel = false;
                panel_master.Controls.Clear();
                panel_master.Controls.Add(_frm);
                _frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                _frm.Dock = DockStyle.Fill;
                _frm.Show();
            }
            else
            {
                MessageBox.Show("Tài khoản không có quyền Admin, không thể truy cập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn Đăng Xuất?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if(rs == DialogResult.Yes)
            {
                this.Visible = false;
                frmDangNhap frmOBJ = new frmDangNhap();
                frmOBJ.Show();
            }
        }

        private bool checkQuyenDN(int maTKDN)
        {
            DataTable dsTaiKhoan = db.layDuLieu("select * from TaiKhoan where MaTaiKhoan = " + maTKDN);

            foreach (DataRow r in dsTaiKhoan.Rows)
            {
                if (r["MaQuyen"].ToString().Trim() == "staff")
                    return false;
            }
            return true;
        }
    }
}
