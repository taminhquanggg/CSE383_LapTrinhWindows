namespace ThongTinSinhVien
{
    partial class Form1
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
            this.dGV_TableData = new System.Windows.Forms.DataGridView();
            this.lb_MaSV = new System.Windows.Forms.Label();
            this.lb_Hoten = new System.Windows.Forms.Label();
            this.lb_NgaySinh = new System.Windows.Forms.Label();
            this.lb_GioiTinh = new System.Windows.Forms.Label();
            this.lb_QueQuan = new System.Windows.Forms.Label();
            this.lb_Lop = new System.Windows.Forms.Label();
            this.lb_Khoa = new System.Windows.Forms.Label();
            this.tb_MaSV = new System.Windows.Forms.TextBox();
            this.tb_Hoten = new System.Windows.Forms.TextBox();
            this.dTP_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cb_Nam = new System.Windows.Forms.CheckBox();
            this.cb_Nu = new System.Windows.Forms.CheckBox();
            this.cbBox_QueQuan = new System.Windows.Forms.ComboBox();
            this.cbB_lop = new System.Windows.Forms.ComboBox();
            this.cbB_Khoa = new System.Windows.Forms.ComboBox();
            this.bt_Them = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_Xoa = new System.Windows.Forms.Button();
            this.bt_Sua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_TableData)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGV_TableData
            // 
            this.dGV_TableData.AllowUserToAddRows = false;
            this.dGV_TableData.AllowUserToDeleteRows = false;
            this.dGV_TableData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGV_TableData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV_TableData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_TableData.Location = new System.Drawing.Point(12, 199);
            this.dGV_TableData.Name = "dGV_TableData";
            this.dGV_TableData.ReadOnly = true;
            this.dGV_TableData.RowHeadersWidth = 51;
            this.dGV_TableData.RowTemplate.Height = 24;
            this.dGV_TableData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_TableData.Size = new System.Drawing.Size(738, 202);
            this.dGV_TableData.TabIndex = 2;
            this.dGV_TableData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_TableData_CellClick);
            // 
            // lb_MaSV
            // 
            this.lb_MaSV.AutoSize = true;
            this.lb_MaSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaSV.Location = new System.Drawing.Point(20, 11);
            this.lb_MaSV.Name = "lb_MaSV";
            this.lb_MaSV.Size = new System.Drawing.Size(73, 25);
            this.lb_MaSV.TabIndex = 0;
            this.lb_MaSV.Text = "Mã SV";
            // 
            // lb_Hoten
            // 
            this.lb_Hoten.AutoSize = true;
            this.lb_Hoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Hoten.Location = new System.Drawing.Point(20, 51);
            this.lb_Hoten.Name = "lb_Hoten";
            this.lb_Hoten.Size = new System.Drawing.Size(69, 25);
            this.lb_Hoten.TabIndex = 1;
            this.lb_Hoten.Text = "Họ tên";
            // 
            // lb_NgaySinh
            // 
            this.lb_NgaySinh.AutoSize = true;
            this.lb_NgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NgaySinh.Location = new System.Drawing.Point(20, 91);
            this.lb_NgaySinh.Name = "lb_NgaySinh";
            this.lb_NgaySinh.Size = new System.Drawing.Size(99, 25);
            this.lb_NgaySinh.TabIndex = 2;
            this.lb_NgaySinh.Text = "Ngày sinh";
            // 
            // lb_GioiTinh
            // 
            this.lb_GioiTinh.AutoSize = true;
            this.lb_GioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_GioiTinh.Location = new System.Drawing.Point(20, 135);
            this.lb_GioiTinh.Name = "lb_GioiTinh";
            this.lb_GioiTinh.Size = new System.Drawing.Size(82, 25);
            this.lb_GioiTinh.TabIndex = 3;
            this.lb_GioiTinh.Text = "Giới tính";
            // 
            // lb_QueQuan
            // 
            this.lb_QueQuan.AutoSize = true;
            this.lb_QueQuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_QueQuan.Location = new System.Drawing.Point(389, 11);
            this.lb_QueQuan.Name = "lb_QueQuan";
            this.lb_QueQuan.Size = new System.Drawing.Size(99, 25);
            this.lb_QueQuan.TabIndex = 4;
            this.lb_QueQuan.Text = "Quê quán";
            // 
            // lb_Lop
            // 
            this.lb_Lop.AutoSize = true;
            this.lb_Lop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Lop.Location = new System.Drawing.Point(389, 51);
            this.lb_Lop.Name = "lb_Lop";
            this.lb_Lop.Size = new System.Drawing.Size(45, 25);
            this.lb_Lop.TabIndex = 5;
            this.lb_Lop.Text = "Lớp";
            // 
            // lb_Khoa
            // 
            this.lb_Khoa.AutoSize = true;
            this.lb_Khoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Khoa.Location = new System.Drawing.Point(389, 91);
            this.lb_Khoa.Name = "lb_Khoa";
            this.lb_Khoa.Size = new System.Drawing.Size(59, 25);
            this.lb_Khoa.TabIndex = 6;
            this.lb_Khoa.Text = "Khoa";
            // 
            // tb_MaSV
            // 
            this.tb_MaSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MaSV.Location = new System.Drawing.Point(141, 7);
            this.tb_MaSV.Multiline = true;
            this.tb_MaSV.Name = "tb_MaSV";
            this.tb_MaSV.Size = new System.Drawing.Size(203, 33);
            this.tb_MaSV.TabIndex = 8;
            // 
            // tb_Hoten
            // 
            this.tb_Hoten.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Hoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Hoten.Location = new System.Drawing.Point(141, 47);
            this.tb_Hoten.Multiline = true;
            this.tb_Hoten.Name = "tb_Hoten";
            this.tb_Hoten.Size = new System.Drawing.Size(203, 33);
            this.tb_Hoten.TabIndex = 9;
            // 
            // dTP_NgaySinh
            // 
            this.dTP_NgaySinh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dTP_NgaySinh.CustomFormat = "";
            this.dTP_NgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTP_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTP_NgaySinh.Location = new System.Drawing.Point(141, 88);
            this.dTP_NgaySinh.MaxDate = new System.DateTime(2022, 2, 16, 0, 0, 0, 0);
            this.dTP_NgaySinh.Name = "dTP_NgaySinh";
            this.dTP_NgaySinh.Size = new System.Drawing.Size(203, 30);
            this.dTP_NgaySinh.TabIndex = 11;
            this.dTP_NgaySinh.Value = new System.DateTime(2002, 1, 1, 0, 0, 0, 0);
            // 
            // cb_Nam
            // 
            this.cb_Nam.AutoSize = true;
            this.cb_Nam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Nam.Location = new System.Drawing.Point(141, 133);
            this.cb_Nam.Name = "cb_Nam";
            this.cb_Nam.Size = new System.Drawing.Size(75, 29);
            this.cb_Nam.TabIndex = 12;
            this.cb_Nam.Text = "Nam";
            this.cb_Nam.UseVisualStyleBackColor = true;
            this.cb_Nam.Click += new System.EventHandler(this.cb_Nam_CheckedChanged);
            // 
            // cb_Nu
            // 
            this.cb_Nu.AutoSize = true;
            this.cb_Nu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Nu.Location = new System.Drawing.Point(223, 133);
            this.cb_Nu.Name = "cb_Nu";
            this.cb_Nu.Size = new System.Drawing.Size(59, 29);
            this.cb_Nu.TabIndex = 13;
            this.cb_Nu.Text = "Nữ";
            this.cb_Nu.UseVisualStyleBackColor = true;
            this.cb_Nu.Click += new System.EventHandler(this.cb_Nu_CheckedChanged);
            // 
            // cbBox_QueQuan
            // 
            this.cbBox_QueQuan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBox_QueQuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBox_QueQuan.FormattingEnabled = true;
            this.cbBox_QueQuan.Items.AddRange(new object[] {
            "An Giang",
            "Bà rịa – Vũng tàu",
            "Bắc Giang",
            "Bắc Kạn",
            "Bạc Liêu",
            "Bắc Ninh",
            "Bến Tre",
            "Bình Định",
            "Bình Dương",
            "Bình Phước",
            "Bình Thuận",
            "Cà Mau",
            "Cần Thơ",
            "Cao Bằng ",
            "Đà Nẵng",
            "Đắk Lắk",
            "Đắk Nông",
            "Điện Biên",
            "Đồng Nai",
            "Đồng Tháp",
            "Gia Lai",
            "Hà Giang",
            "Hà Nam",
            "Hà Nội ",
            "Hà Tĩnh",
            "Hải Dương",
            "Hải Phòng",
            "Hậu Giang",
            "Hòa Bình",
            "Hưng Yên",
            "Khánh Hòa",
            "Kiên Giang",
            "Kon Tum",
            "Lai Châu",
            "Lâm Đồng",
            "Lạng Sơn",
            "Lào Cai",
            "Long An",
            "Nam Định",
            "Nghệ An",
            "Ninh Bình",
            "Ninh Thuận",
            "Phú Thọ",
            "Phú Yên",
            "Quảng Bình",
            "Quảng Nam",
            "Quảng Ngãi",
            "Quảng Ninh",
            "Quảng Trị",
            "Sóc Trăng",
            "Sơn La",
            "Tây Ninh",
            "Thái Bình",
            "Thái Nguyên",
            "Thanh Hóa",
            "Thừa Thiên Huế",
            "Tiền Giang",
            "Thành phố Hồ Chí Minh",
            "Trà Vinh",
            "Tuyên Quang",
            "Vĩnh Long",
            "Vĩnh Phúc",
            "Yên Bái"});
            this.cbBox_QueQuan.Location = new System.Drawing.Point(508, 7);
            this.cbBox_QueQuan.Name = "cbBox_QueQuan";
            this.cbBox_QueQuan.Size = new System.Drawing.Size(203, 33);
            this.cbBox_QueQuan.TabIndex = 15;
            // 
            // cbB_lop
            // 
            this.cbB_lop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbB_lop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbB_lop.FormattingEnabled = true;
            this.cbB_lop.Items.AddRange(new object[] {
            "60PM1",
            "60PM2",
            "61PM1",
            "61PM2",
            "62PM1",
            "62PM2"});
            this.cbB_lop.Location = new System.Drawing.Point(508, 47);
            this.cbB_lop.Name = "cbB_lop";
            this.cbB_lop.Size = new System.Drawing.Size(203, 33);
            this.cbB_lop.TabIndex = 16;
            // 
            // cbB_Khoa
            // 
            this.cbB_Khoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbB_Khoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbB_Khoa.FormattingEnabled = true;
            this.cbB_Khoa.Items.AddRange(new object[] {
            "CNTT",
            "KT",
            "CK"});
            this.cbB_Khoa.Location = new System.Drawing.Point(508, 87);
            this.cbB_Khoa.Name = "cbB_Khoa";
            this.cbB_Khoa.Size = new System.Drawing.Size(203, 33);
            this.cbB_Khoa.TabIndex = 17;
            // 
            // bt_Them
            // 
            this.bt_Them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bt_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Them.Location = new System.Drawing.Point(389, 131);
            this.bt_Them.Name = "bt_Them";
            this.bt_Them.Size = new System.Drawing.Size(99, 47);
            this.bt_Them.TabIndex = 18;
            this.bt_Them.Text = "Thêm";
            this.bt_Them.UseVisualStyleBackColor = false;
            this.bt_Them.Click += new System.EventHandler(this.bt_Them_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_Xoa);
            this.panel1.Controls.Add(this.bt_Sua);
            this.panel1.Controls.Add(this.bt_Them);
            this.panel1.Controls.Add(this.cbB_Khoa);
            this.panel1.Controls.Add(this.cbB_lop);
            this.panel1.Controls.Add(this.cbBox_QueQuan);
            this.panel1.Controls.Add(this.cb_Nu);
            this.panel1.Controls.Add(this.cb_Nam);
            this.panel1.Controls.Add(this.dTP_NgaySinh);
            this.panel1.Controls.Add(this.tb_Hoten);
            this.panel1.Controls.Add(this.tb_MaSV);
            this.panel1.Controls.Add(this.lb_Khoa);
            this.panel1.Controls.Add(this.lb_Lop);
            this.panel1.Controls.Add(this.lb_QueQuan);
            this.panel1.Controls.Add(this.lb_GioiTinh);
            this.panel1.Controls.Add(this.lb_NgaySinh);
            this.panel1.Controls.Add(this.lb_Hoten);
            this.panel1.Controls.Add(this.lb_MaSV);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(738, 181);
            this.panel1.TabIndex = 1;
            // 
            // bt_Xoa
            // 
            this.bt_Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bt_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Xoa.Location = new System.Drawing.Point(612, 131);
            this.bt_Xoa.Name = "bt_Xoa";
            this.bt_Xoa.Size = new System.Drawing.Size(99, 47);
            this.bt_Xoa.TabIndex = 20;
            this.bt_Xoa.Text = "Xóa";
            this.bt_Xoa.UseVisualStyleBackColor = false;
            this.bt_Xoa.Visible = false;
            this.bt_Xoa.Click += new System.EventHandler(this.bt_Xoa_Click);
            // 
            // bt_Sua
            // 
            this.bt_Sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bt_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Sua.Location = new System.Drawing.Point(500, 131);
            this.bt_Sua.Name = "bt_Sua";
            this.bt_Sua.Size = new System.Drawing.Size(99, 47);
            this.bt_Sua.TabIndex = 19;
            this.bt_Sua.Text = "Sửa";
            this.bt_Sua.UseVisualStyleBackColor = false;
            this.bt_Sua.Visible = false;
            this.bt_Sua.Click += new System.EventHandler(this.bt_Sua_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(762, 413);
            this.Controls.Add(this.dGV_TableData);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập thông tin sinh viên";
            ((System.ComponentModel.ISupportInitialize)(this.dGV_TableData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dGV_TableData;
        private System.Windows.Forms.Label lb_MaSV;
        private System.Windows.Forms.Label lb_Hoten;
        private System.Windows.Forms.Label lb_NgaySinh;
        private System.Windows.Forms.Label lb_GioiTinh;
        private System.Windows.Forms.Label lb_QueQuan;
        private System.Windows.Forms.Label lb_Lop;
        private System.Windows.Forms.Label lb_Khoa;
        private System.Windows.Forms.TextBox tb_MaSV;
        private System.Windows.Forms.TextBox tb_Hoten;
        private System.Windows.Forms.DateTimePicker dTP_NgaySinh;
        private System.Windows.Forms.CheckBox cb_Nam;
        private System.Windows.Forms.CheckBox cb_Nu;
        private System.Windows.Forms.ComboBox cbBox_QueQuan;
        private System.Windows.Forms.ComboBox cbB_lop;
        private System.Windows.Forms.ComboBox cbB_Khoa;
        private System.Windows.Forms.Button bt_Them;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_Xoa;
        private System.Windows.Forms.Button bt_Sua;
    }
}

