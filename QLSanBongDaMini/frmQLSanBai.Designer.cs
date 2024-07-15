namespace QLSanBongDaMini
{
    partial class frmQLSanBai
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_LamMoi = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.cbb_LoaiSan = new System.Windows.Forms.ComboBox();
            this.cbb_TrangThai = new System.Windows.Forms.ComboBox();
            this.txt_TenSan = new System.Windows.Forms.TextBox();
            this.txt_MaSan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gv_DSSan = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_LLamMoi = new System.Windows.Forms.Button();
            this.btn_LSua = new System.Windows.Forms.Button();
            this.num_SoNguoiToiDa = new System.Windows.Forms.NumericUpDown();
            this.btn_LXoa = new System.Windows.Forms.Button();
            this.txt_GiaGio = new System.Windows.Forms.TextBox();
            this.btn_LThem = new System.Windows.Forms.Button();
            this.txt_TenLoaiSan = new System.Windows.Forms.TextBox();
            this.txt_MaLoaiSan = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gv_DSLoaiSan = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_DSSan)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_SoNguoiToiDa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_DSLoaiSan)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_LamMoi);
            this.groupBox1.Controls.Add(this.btn_Sua);
            this.groupBox1.Controls.Add(this.btn_Xoa);
            this.groupBox1.Controls.Add(this.btn_Them);
            this.groupBox1.Controls.Add(this.cbb_LoaiSan);
            this.groupBox1.Controls.Add(this.cbb_TrangThai);
            this.groupBox1.Controls.Add(this.txt_TenSan);
            this.groupBox1.Controls.Add(this.txt_MaSan);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.gv_DSSan);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(32, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 628);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản Lý Sân Bãi";
            // 
            // btn_LamMoi
            // 
            this.btn_LamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_LamMoi.Location = new System.Drawing.Point(374, 289);
            this.btn_LamMoi.Name = "btn_LamMoi";
            this.btn_LamMoi.Size = new System.Drawing.Size(116, 37);
            this.btn_LamMoi.TabIndex = 16;
            this.btn_LamMoi.Text = "Làm mới";
            this.btn_LamMoi.UseVisualStyleBackColor = false;
            this.btn_LamMoi.Click += new System.EventHandler(this.btn_LamMoi_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Sua.Location = new System.Drawing.Point(256, 289);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(116, 37);
            this.btn_Sua.TabIndex = 15;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Xoa.Location = new System.Drawing.Point(138, 289);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(116, 37);
            this.btn_Xoa.TabIndex = 14;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Them.Location = new System.Drawing.Point(20, 289);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(116, 37);
            this.btn_Them.TabIndex = 13;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // cbb_LoaiSan
            // 
            this.cbb_LoaiSan.FormattingEnabled = true;
            this.cbb_LoaiSan.Location = new System.Drawing.Point(131, 215);
            this.cbb_LoaiSan.Name = "cbb_LoaiSan";
            this.cbb_LoaiSan.Size = new System.Drawing.Size(359, 28);
            this.cbb_LoaiSan.TabIndex = 8;
            this.cbb_LoaiSan.Text = "--- Chọn ---";
            // 
            // cbb_TrangThai
            // 
            this.cbb_TrangThai.FormattingEnabled = true;
            this.cbb_TrangThai.Items.AddRange(new object[] {
            "Đang Sửa Chữa",
            "Đang Hoạt Động"});
            this.cbb_TrangThai.Location = new System.Drawing.Point(131, 158);
            this.cbb_TrangThai.Name = "cbb_TrangThai";
            this.cbb_TrangThai.Size = new System.Drawing.Size(359, 28);
            this.cbb_TrangThai.TabIndex = 7;
            this.cbb_TrangThai.Text = "--- Chọn ---";
            // 
            // txt_TenSan
            // 
            this.txt_TenSan.Location = new System.Drawing.Point(131, 101);
            this.txt_TenSan.Name = "txt_TenSan";
            this.txt_TenSan.Size = new System.Drawing.Size(359, 27);
            this.txt_TenSan.TabIndex = 6;
            // 
            // txt_MaSan
            // 
            this.txt_MaSan.Location = new System.Drawing.Point(131, 44);
            this.txt_MaSan.Name = "txt_MaSan";
            this.txt_MaSan.Size = new System.Drawing.Size(359, 27);
            this.txt_MaSan.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Loại sân:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Trạng thái:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên sân:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã sân:";
            // 
            // gv_DSSan
            // 
            this.gv_DSSan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_DSSan.Location = new System.Drawing.Point(20, 356);
            this.gv_DSSan.Name = "gv_DSSan";
            this.gv_DSSan.RowTemplate.Height = 24;
            this.gv_DSSan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_DSSan.Size = new System.Drawing.Size(470, 266);
            this.gv_DSSan.TabIndex = 0;
            this.gv_DSSan.SelectionChanged += new System.EventHandler(this.gv_DSSan_SelectionChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_LLamMoi);
            this.groupBox2.Controls.Add(this.btn_LSua);
            this.groupBox2.Controls.Add(this.num_SoNguoiToiDa);
            this.groupBox2.Controls.Add(this.btn_LXoa);
            this.groupBox2.Controls.Add(this.txt_GiaGio);
            this.groupBox2.Controls.Add(this.btn_LThem);
            this.groupBox2.Controls.Add(this.txt_TenLoaiSan);
            this.groupBox2.Controls.Add(this.txt_MaLoaiSan);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.gv_DSLoaiSan);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(572, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(509, 628);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Loại Sân Bãi";
            // 
            // btn_LLamMoi
            // 
            this.btn_LLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_LLamMoi.Location = new System.Drawing.Point(374, 333);
            this.btn_LLamMoi.Name = "btn_LLamMoi";
            this.btn_LLamMoi.Size = new System.Drawing.Size(116, 37);
            this.btn_LLamMoi.TabIndex = 20;
            this.btn_LLamMoi.Text = "Làm mới";
            this.btn_LLamMoi.UseVisualStyleBackColor = false;
            this.btn_LLamMoi.Click += new System.EventHandler(this.btn_LLamMoi_Click);
            // 
            // btn_LSua
            // 
            this.btn_LSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_LSua.Location = new System.Drawing.Point(256, 333);
            this.btn_LSua.Name = "btn_LSua";
            this.btn_LSua.Size = new System.Drawing.Size(116, 37);
            this.btn_LSua.TabIndex = 19;
            this.btn_LSua.Text = "Sửa";
            this.btn_LSua.UseVisualStyleBackColor = false;
            this.btn_LSua.Click += new System.EventHandler(this.btn_LSua_Click);
            // 
            // num_SoNguoiToiDa
            // 
            this.num_SoNguoiToiDa.Location = new System.Drawing.Point(166, 519);
            this.num_SoNguoiToiDa.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_SoNguoiToiDa.Name = "num_SoNguoiToiDa";
            this.num_SoNguoiToiDa.Size = new System.Drawing.Size(120, 27);
            this.num_SoNguoiToiDa.TabIndex = 12;
            this.num_SoNguoiToiDa.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_LXoa
            // 
            this.btn_LXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_LXoa.Location = new System.Drawing.Point(138, 333);
            this.btn_LXoa.Name = "btn_LXoa";
            this.btn_LXoa.Size = new System.Drawing.Size(116, 37);
            this.btn_LXoa.TabIndex = 18;
            this.btn_LXoa.Text = "Xóa";
            this.btn_LXoa.UseVisualStyleBackColor = false;
            this.btn_LXoa.Click += new System.EventHandler(this.btn_LXoa_Click);
            // 
            // txt_GiaGio
            // 
            this.txt_GiaGio.Location = new System.Drawing.Point(166, 572);
            this.txt_GiaGio.Name = "txt_GiaGio";
            this.txt_GiaGio.Size = new System.Drawing.Size(324, 27);
            this.txt_GiaGio.TabIndex = 11;
            this.txt_GiaGio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_GiaGio_KeyPress);
            // 
            // btn_LThem
            // 
            this.btn_LThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_LThem.Location = new System.Drawing.Point(20, 333);
            this.btn_LThem.Name = "btn_LThem";
            this.btn_LThem.Size = new System.Drawing.Size(116, 37);
            this.btn_LThem.TabIndex = 17;
            this.btn_LThem.Text = "Thêm";
            this.btn_LThem.UseVisualStyleBackColor = false;
            this.btn_LThem.Click += new System.EventHandler(this.btn_LThem_Click);
            // 
            // txt_TenLoaiSan
            // 
            this.txt_TenLoaiSan.Location = new System.Drawing.Point(166, 464);
            this.txt_TenLoaiSan.Name = "txt_TenLoaiSan";
            this.txt_TenLoaiSan.Size = new System.Drawing.Size(324, 27);
            this.txt_TenLoaiSan.TabIndex = 10;
            // 
            // txt_MaLoaiSan
            // 
            this.txt_MaLoaiSan.Location = new System.Drawing.Point(166, 406);
            this.txt_MaLoaiSan.Name = "txt_MaLoaiSan";
            this.txt_MaLoaiSan.Size = new System.Drawing.Size(324, 27);
            this.txt_MaLoaiSan.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 575);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Giá (giờ):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 521);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Số người tối đa:";
            // 
            // gv_DSLoaiSan
            // 
            this.gv_DSLoaiSan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_DSLoaiSan.Location = new System.Drawing.Point(21, 47);
            this.gv_DSLoaiSan.Name = "gv_DSLoaiSan";
            this.gv_DSLoaiSan.RowTemplate.Height = 24;
            this.gv_DSLoaiSan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_DSLoaiSan.Size = new System.Drawing.Size(469, 252);
            this.gv_DSLoaiSan.TabIndex = 1;
            this.gv_DSLoaiSan.SelectionChanged += new System.EventHandler(this.gv_DSLoaiSan_SelectionChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 467);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tên loại sân:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 413);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Mã loại sân:";
            // 
            // frmQLSanBai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 692);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmQLSanBai";
            this.Text = "frmQLSanBai";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_DSSan)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_SoNguoiToiDa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_DSLoaiSan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView gv_DSSan;
        private System.Windows.Forms.DataGridView gv_DSLoaiSan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_TenSan;
        private System.Windows.Forms.TextBox txt_MaSan;
        private System.Windows.Forms.TextBox txt_TenLoaiSan;
        private System.Windows.Forms.TextBox txt_MaLoaiSan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_GiaGio;
        private System.Windows.Forms.ComboBox cbb_LoaiSan;
        private System.Windows.Forms.ComboBox cbb_TrangThai;
        private System.Windows.Forms.NumericUpDown num_SoNguoiToiDa;
        private System.Windows.Forms.Button btn_LamMoi;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_LLamMoi;
        private System.Windows.Forms.Button btn_LSua;
        private System.Windows.Forms.Button btn_LXoa;
        private System.Windows.Forms.Button btn_LThem;

    }
}