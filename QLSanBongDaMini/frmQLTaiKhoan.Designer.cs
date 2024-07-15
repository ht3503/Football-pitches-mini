namespace QLSanBongDaMini
{
    partial class frmQLTaiKhoan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grp_dstk = new System.Windows.Forms.GroupBox();
            this.txt_MatKhau = new System.Windows.Forms.TextBox();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.txt_MaTK = new System.Windows.Forms.TextBox();
            this.cbb_BiKhoa = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbb_Quyen = new System.Windows.Forms.ComboBox();
            this.btn_LamMoi = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gv_DSTaiKhoan = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbl_MaTK = new System.Windows.Forms.Label();
            this.lbl_HoTen = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_Quyen = new System.Windows.Forms.Label();
            this.lbl_SDT = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_MKMoi = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_LamMoiDoiMK = new System.Windows.Forms.Button();
            this.btn_DoiMK = new System.Windows.Forms.Button();
            this.txt_MKXacNhan = new System.Windows.Forms.TextBox();
            this.txt_MKCu = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.grp_dstk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_DSTaiKhoan)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_dstk
            // 
            this.grp_dstk.Controls.Add(this.txt_MatKhau);
            this.grp_dstk.Controls.Add(this.txt_SDT);
            this.grp_dstk.Controls.Add(this.txt_Email);
            this.grp_dstk.Controls.Add(this.txt_HoTen);
            this.grp_dstk.Controls.Add(this.txt_MaTK);
            this.grp_dstk.Controls.Add(this.cbb_BiKhoa);
            this.grp_dstk.Controls.Add(this.label7);
            this.grp_dstk.Controls.Add(this.cbb_Quyen);
            this.grp_dstk.Controls.Add(this.btn_LamMoi);
            this.grp_dstk.Controls.Add(this.btn_Sua);
            this.grp_dstk.Controls.Add(this.btn_Xoa);
            this.grp_dstk.Controls.Add(this.btn_Them);
            this.grp_dstk.Controls.Add(this.label6);
            this.grp_dstk.Controls.Add(this.label5);
            this.grp_dstk.Controls.Add(this.label4);
            this.grp_dstk.Controls.Add(this.label3);
            this.grp_dstk.Controls.Add(this.label2);
            this.grp_dstk.Controls.Add(this.label1);
            this.grp_dstk.Controls.Add(this.gv_DSTaiKhoan);
            this.grp_dstk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_dstk.Location = new System.Drawing.Point(388, 21);
            this.grp_dstk.Name = "grp_dstk";
            this.grp_dstk.Size = new System.Drawing.Size(699, 650);
            this.grp_dstk.TabIndex = 1;
            this.grp_dstk.TabStop = false;
            this.grp_dstk.Text = "Danh Sách Tài Khoản:";
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.Location = new System.Drawing.Point(153, 266);
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.PasswordChar = '*';
            this.txt_MatKhau.Size = new System.Drawing.Size(528, 27);
            this.txt_MatKhau.TabIndex = 28;
            // 
            // txt_SDT
            // 
            this.txt_SDT.Location = new System.Drawing.Point(153, 211);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(528, 27);
            this.txt_SDT.TabIndex = 27;
            this.txt_SDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SDT_KeyPress);
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(153, 156);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(528, 27);
            this.txt_Email.TabIndex = 26;
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Location = new System.Drawing.Point(153, 101);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(528, 27);
            this.txt_HoTen.TabIndex = 25;
            // 
            // txt_MaTK
            // 
            this.txt_MaTK.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_MaTK.Enabled = false;
            this.txt_MaTK.Location = new System.Drawing.Point(153, 46);
            this.txt_MaTK.Name = "txt_MaTK";
            this.txt_MaTK.Size = new System.Drawing.Size(193, 27);
            this.txt_MaTK.TabIndex = 24;
            // 
            // cbb_BiKhoa
            // 
            this.cbb_BiKhoa.FormattingEnabled = true;
            this.cbb_BiKhoa.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cbb_BiKhoa.Location = new System.Drawing.Point(488, 321);
            this.cbb_BiKhoa.Name = "cbb_BiKhoa";
            this.cbb_BiKhoa.Size = new System.Drawing.Size(193, 28);
            this.cbb_BiKhoa.TabIndex = 23;
            this.cbb_BiKhoa.Text = "--- Chọn ---";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(403, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Bị khóa:";
            // 
            // cbb_Quyen
            // 
            this.cbb_Quyen.FormattingEnabled = true;
            this.cbb_Quyen.Items.AddRange(new object[] {
            "Nhân Viên",
            "Quản Lý"});
            this.cbb_Quyen.Location = new System.Drawing.Point(153, 321);
            this.cbb_Quyen.Name = "cbb_Quyen";
            this.cbb_Quyen.Size = new System.Drawing.Size(193, 28);
            this.cbb_Quyen.TabIndex = 21;
            this.cbb_Quyen.Text = "--- Chọn ---";
            // 
            // btn_LamMoi
            // 
            this.btn_LamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_LamMoi.Location = new System.Drawing.Point(19, 532);
            this.btn_LamMoi.Name = "btn_LamMoi";
            this.btn_LamMoi.Size = new System.Drawing.Size(116, 37);
            this.btn_LamMoi.TabIndex = 20;
            this.btn_LamMoi.Text = "Làm mới";
            this.btn_LamMoi.UseVisualStyleBackColor = false;
            this.btn_LamMoi.Click += new System.EventHandler(this.btn_LamMoi_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Sua.Location = new System.Drawing.Point(19, 489);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(116, 37);
            this.btn_Sua.TabIndex = 19;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Xoa.Location = new System.Drawing.Point(19, 446);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(116, 37);
            this.btn_Xoa.TabIndex = 18;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Them.Location = new System.Drawing.Point(19, 403);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(116, 37);
            this.btn_Them.TabIndex = 17;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Quyền:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mật khẩu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số điện thoại:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã tài khoản:";
            // 
            // gv_DSTaiKhoan
            // 
            this.gv_DSTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_DSTaiKhoan.Location = new System.Drawing.Point(153, 404);
            this.gv_DSTaiKhoan.Name = "gv_DSTaiKhoan";
            this.gv_DSTaiKhoan.RowTemplate.Height = 24;
            this.gv_DSTaiKhoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_DSTaiKhoan.Size = new System.Drawing.Size(528, 240);
            this.gv_DSTaiKhoan.TabIndex = 0;
            this.gv_DSTaiKhoan.SelectionChanged += new System.EventHandler(this.gv_DSTaiKhoan_SelectionChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 267);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 20);
            this.label10.TabIndex = 31;
            this.label10.Text = "SĐT:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 20);
            this.label11.TabIndex = 29;
            this.label11.Text = "Mã:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 20);
            this.label9.TabIndex = 30;
            this.label9.Text = "Họ tên:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 211);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 20);
            this.label13.TabIndex = 29;
            this.label13.Text = "Quyền:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 20);
            this.label8.TabIndex = 32;
            this.label8.Text = "Email:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 321);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 20);
            this.label14.TabIndex = 33;
            this.label14.Text = "Mật khẩu:";
            // 
            // lbl_MaTK
            // 
            this.lbl_MaTK.AutoSize = true;
            this.lbl_MaTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaTK.Location = new System.Drawing.Point(123, 49);
            this.lbl_MaTK.Name = "lbl_MaTK";
            this.lbl_MaTK.Size = new System.Drawing.Size(90, 20);
            this.lbl_MaTK.TabIndex = 34;
            this.lbl_MaTK.Text = "Loading...";
            // 
            // lbl_HoTen
            // 
            this.lbl_HoTen.AutoSize = true;
            this.lbl_HoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HoTen.Location = new System.Drawing.Point(123, 103);
            this.lbl_HoTen.Name = "lbl_HoTen";
            this.lbl_HoTen.Size = new System.Drawing.Size(90, 20);
            this.lbl_HoTen.TabIndex = 35;
            this.lbl_HoTen.Text = "Loading...";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(123, 156);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(90, 20);
            this.lbl_Email.TabIndex = 36;
            this.lbl_Email.Text = "Loading...";
            // 
            // lbl_Quyen
            // 
            this.lbl_Quyen.AutoSize = true;
            this.lbl_Quyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quyen.Location = new System.Drawing.Point(123, 211);
            this.lbl_Quyen.Name = "lbl_Quyen";
            this.lbl_Quyen.Size = new System.Drawing.Size(90, 20);
            this.lbl_Quyen.TabIndex = 37;
            this.lbl_Quyen.Text = "Loading...";
            // 
            // lbl_SDT
            // 
            this.lbl_SDT.AutoSize = true;
            this.lbl_SDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SDT.Location = new System.Drawing.Point(123, 267);
            this.lbl_SDT.Name = "lbl_SDT";
            this.lbl_SDT.Size = new System.Drawing.Size(90, 20);
            this.lbl_SDT.TabIndex = 38;
            this.lbl_SDT.Text = "Loading...";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(123, 321);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(79, 20);
            this.label21.TabIndex = 39;
            this.label21.Text = "**********";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.lbl_SDT);
            this.groupBox1.Controls.Add(this.lbl_Quyen);
            this.groupBox1.Controls.Add(this.lbl_Email);
            this.groupBox1.Controls.Add(this.lbl_HoTen);
            this.groupBox1.Controls.Add(this.lbl_MaTK);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 366);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Tài Khoản:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_MKMoi);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.btn_LamMoiDoiMK);
            this.groupBox3.Controls.Add(this.btn_DoiMK);
            this.groupBox3.Controls.Add(this.txt_MKXacNhan);
            this.groupBox3.Controls.Add(this.txt_MKCu);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.label29);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(22, 404);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(343, 261);
            this.groupBox3.TabIndex = 40;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Đổi Mật Khẩu:";
            // 
            // txt_MKMoi
            // 
            this.txt_MKMoi.Location = new System.Drawing.Point(148, 99);
            this.txt_MKMoi.Name = "txt_MKMoi";
            this.txt_MKMoi.PasswordChar = '*';
            this.txt_MKMoi.Size = new System.Drawing.Size(178, 27);
            this.txt_MKMoi.TabIndex = 39;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 102);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 20);
            this.label12.TabIndex = 38;
            this.label12.Text = "Mật khẩu mới:";
            // 
            // btn_LamMoiDoiMK
            // 
            this.btn_LamMoiDoiMK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_LamMoiDoiMK.Location = new System.Drawing.Point(22, 202);
            this.btn_LamMoiDoiMK.Name = "btn_LamMoiDoiMK";
            this.btn_LamMoiDoiMK.Size = new System.Drawing.Size(116, 37);
            this.btn_LamMoiDoiMK.TabIndex = 29;
            this.btn_LamMoiDoiMK.Text = "Làm Mới";
            this.btn_LamMoiDoiMK.UseVisualStyleBackColor = false;
            this.btn_LamMoiDoiMK.Click += new System.EventHandler(this.btn_LamMoiDoiMK_Click);
            // 
            // btn_DoiMK
            // 
            this.btn_DoiMK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_DoiMK.Location = new System.Drawing.Point(148, 202);
            this.btn_DoiMK.Name = "btn_DoiMK";
            this.btn_DoiMK.Size = new System.Drawing.Size(178, 37);
            this.btn_DoiMK.TabIndex = 37;
            this.btn_DoiMK.Text = "Đổi Mật Khẩu";
            this.btn_DoiMK.UseVisualStyleBackColor = false;
            this.btn_DoiMK.Click += new System.EventHandler(this.btn_DoiMK_Click);
            // 
            // txt_MKXacNhan
            // 
            this.txt_MKXacNhan.Location = new System.Drawing.Point(148, 148);
            this.txt_MKXacNhan.Name = "txt_MKXacNhan";
            this.txt_MKXacNhan.PasswordChar = '*';
            this.txt_MKXacNhan.Size = new System.Drawing.Size(178, 27);
            this.txt_MKXacNhan.TabIndex = 36;
            // 
            // txt_MKCu
            // 
            this.txt_MKCu.Location = new System.Drawing.Point(148, 50);
            this.txt_MKCu.Name = "txt_MKCu";
            this.txt_MKCu.PasswordChar = '*';
            this.txt_MKCu.Size = new System.Drawing.Size(178, 27);
            this.txt_MKCu.TabIndex = 35;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(20, 151);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(84, 20);
            this.label22.TabIndex = 34;
            this.label22.Text = "Xác nhận:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(20, 53);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(105, 20);
            this.label29.TabIndex = 33;
            this.label29.Text = "Mật khẩu cũ:";
            // 
            // frmQLTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 692);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grp_dstk);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmQLTaiKhoan";
            this.Text = "frmQLTaiKhoan";
            this.grp_dstk.ResumeLayout(false);
            this.grp_dstk.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_DSTaiKhoan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_dstk;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gv_DSTaiKhoan;
        private System.Windows.Forms.Button btn_LamMoi;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.TextBox txt_MatKhau;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.TextBox txt_MaTK;
        private System.Windows.Forms.ComboBox cbb_BiKhoa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbb_Quyen;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbl_MaTK;
        private System.Windows.Forms.Label lbl_HoTen;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_Quyen;
        private System.Windows.Forms.Label lbl_SDT;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_MKMoi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_LamMoiDoiMK;
        private System.Windows.Forms.Button btn_DoiMK;
        private System.Windows.Forms.TextBox txt_MKXacNhan;
        private System.Windows.Forms.TextBox txt_MKCu;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label29;
    }
}