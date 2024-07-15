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
    public partial class frmDangNhap : Form
    {
        DBConnection db = new DBConnection();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            if(txt_MatKhau.Text.Trim() == string.Empty || txt_SDT.Text.Trim() == string.Empty)
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                string sdtDN = txt_SDT.Text.Trim();
                string mkDN = txt_MatKhau.Text.Trim();

                DataTable dsTaiKhoan = db.layDuLieu("select * from TaiKhoan where SoDienThoai = '"+ sdtDN +"' and MatKhau= '"+ mkDN +"'");

                if (dsTaiKhoan.Rows.Count < 1)
                    MessageBox.Show("Thông tin đăng nhập không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    int maTaiKhoanDN = 0;
                    string biKhoa = "";
                    foreach (DataRow d in dsTaiKhoan.Rows)
                    {
                        maTaiKhoanDN = Int32.Parse(d["MaTaiKhoan"].ToString().Trim());
                        biKhoa = d["BiKhoa"].ToString().Trim();
                    }

                    if(biKhoa == "True")
                        MessageBox.Show("Tài khoản đã bị khóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        frmMain frmOBJ = new frmMain(maTaiKhoanDN);
                        frmOBJ.Show();
                        txt_MatKhau.Text = txt_SDT.Text = string.Empty;
                        this.Visible = false;
                    }
                }                
            }
        }

        private void txt_SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
