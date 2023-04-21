namespace QuanLyThuVien
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_maSach = new System.Windows.Forms.TextBox();
            this.bt_themSach = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_tenSach = new System.Windows.Forms.TextBox();
            this.dataGridView_Sach = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_tenSV = new System.Windows.Forms.ComboBox();
            this.cb_tenSach = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dt_ngayMuon = new System.Windows.Forms.DateTimePicker();
            this.dt_ngayTra = new System.Windows.Forms.DateTimePicker();
            this.bt_muon = new System.Windows.Forms.Button();
            this.bt_tra = new System.Windows.Forms.Button();
            this.dataGridView_MuonSach = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView_ThongKe = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewQuaHan = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Sach)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MuonSach)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ThongKe)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuaHan)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 417);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quản lý sách";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView_Sach);
            this.splitContainer1.Size = new System.Drawing.Size(786, 411);
            this.splitContainer1.SplitterDistance = 150;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tb_maSach, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.bt_themSach, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tb_tenSach, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(786, 150);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sách";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_maSach
            // 
            this.tb_maSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_maSach.Location = new System.Drawing.Point(120, 29);
            this.tb_maSach.Multiline = true;
            this.tb_maSach.Name = "tb_maSach";
            this.tb_maSach.Size = new System.Drawing.Size(308, 29);
            this.tb_maSach.TabIndex = 1;
            // 
            // bt_themSach
            // 
            this.bt_themSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bt_themSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_themSach.Location = new System.Drawing.Point(551, 64);
            this.bt_themSach.Name = "bt_themSach";
            this.bt_themSach.Size = new System.Drawing.Size(151, 46);
            this.bt_themSach.TabIndex = 4;
            this.bt_themSach.Text = "Thêm sách";
            this.bt_themSach.UseVisualStyleBackColor = false;
            this.bt_themSach.Click += new System.EventHandler(this.bt_themSach_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 52);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên sách";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // tb_tenSach
            // 
            this.tb_tenSach.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tb_tenSach.Location = new System.Drawing.Point(120, 82);
            this.tb_tenSach.Multiline = true;
            this.tb_tenSach.Name = "tb_tenSach";
            this.tb_tenSach.Size = new System.Drawing.Size(308, 28);
            this.tb_tenSach.TabIndex = 3;
            // 
            // dataGridView_Sach
            // 
            this.dataGridView_Sach.AllowUserToAddRows = false;
            this.dataGridView_Sach.AllowUserToDeleteRows = false;
            this.dataGridView_Sach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Sach.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridView_Sach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Sach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Sach.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Sach.Name = "dataGridView_Sach";
            this.dataGridView_Sach.ReadOnly = true;
            this.dataGridView_Sach.RowHeadersWidth = 51;
            this.dataGridView_Sach.RowTemplate.Height = 24;
            this.dataGridView_Sach.Size = new System.Drawing.Size(786, 257);
            this.dataGridView_Sach.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 417);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mượn/Trả sách";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tableLayoutPanel2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dataGridView_MuonSach);
            this.splitContainer2.Size = new System.Drawing.Size(786, 411);
            this.splitContainer2.SplitterDistance = 148;
            this.splitContainer2.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 8;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.63844F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.96743F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.723127F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.19544F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.47557F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 143F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.cb_tenSV, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.cb_tenSach, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label5, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.label6, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.dt_ngayMuon, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.dt_ngayTra, 4, 2);
            this.tableLayoutPanel2.Controls.Add(this.bt_muon, 6, 1);
            this.tableLayoutPanel2.Controls.Add(this.bt_tra, 6, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(786, 148);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 51);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên sinh viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 51);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tên sách";
            // 
            // cb_tenSV
            // 
            this.cb_tenSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_tenSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_tenSV.FormattingEnabled = true;
            this.cb_tenSV.Items.AddRange(new object[] {
            "Tạ Minh Quang",
            "Tạ Minh Hải",
            "Tạ Hải Đăng",
            "Tạ Đức Thắng",
            "Tạ Tự Phú",
            "Tạ Gia Linh",
            "Tạ Tiến Sơn"});
            this.cb_tenSV.Location = new System.Drawing.Point(139, 25);
            this.cb_tenSV.Name = "cb_tenSV";
            this.cb_tenSV.Size = new System.Drawing.Size(175, 28);
            this.cb_tenSV.TabIndex = 8;
            // 
            // cb_tenSach
            // 
            this.cb_tenSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_tenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_tenSach.FormattingEnabled = true;
            this.cb_tenSach.Location = new System.Drawing.Point(139, 76);
            this.cb_tenSach.Name = "cb_tenSach";
            this.cb_tenSach.Size = new System.Drawing.Size(175, 28);
            this.cb_tenSach.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(348, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 51);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày mượn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(348, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 51);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ngày trả";
            // 
            // dt_ngayMuon
            // 
            this.dt_ngayMuon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dt_ngayMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_ngayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_ngayMuon.Location = new System.Drawing.Point(470, 25);
            this.dt_ngayMuon.Name = "dt_ngayMuon";
            this.dt_ngayMuon.Size = new System.Drawing.Size(129, 27);
            this.dt_ngayMuon.TabIndex = 6;
            this.dt_ngayMuon.ValueChanged += new System.EventHandler(this.dt_ngayMuon_ValueChanged);
            // 
            // dt_ngayTra
            // 
            this.dt_ngayTra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dt_ngayTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_ngayTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_ngayTra.Location = new System.Drawing.Point(470, 76);
            this.dt_ngayTra.Name = "dt_ngayTra";
            this.dt_ngayTra.Size = new System.Drawing.Size(129, 27);
            this.dt_ngayTra.TabIndex = 7;
            // 
            // bt_muon
            // 
            this.bt_muon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bt_muon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_muon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_muon.Location = new System.Drawing.Point(623, 25);
            this.bt_muon.Name = "bt_muon";
            this.bt_muon.Size = new System.Drawing.Size(137, 45);
            this.bt_muon.TabIndex = 10;
            this.bt_muon.Text = "Mượn sách";
            this.bt_muon.UseVisualStyleBackColor = false;
            this.bt_muon.Click += new System.EventHandler(this.bt_muon_Click);
            // 
            // bt_tra
            // 
            this.bt_tra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bt_tra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_tra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_tra.Location = new System.Drawing.Point(623, 76);
            this.bt_tra.Name = "bt_tra";
            this.bt_tra.Size = new System.Drawing.Size(137, 45);
            this.bt_tra.TabIndex = 11;
            this.bt_tra.Text = "Trả sách";
            this.bt_tra.UseVisualStyleBackColor = false;
            this.bt_tra.Click += new System.EventHandler(this.bt_tra_Click);
            // 
            // dataGridView_MuonSach
            // 
            this.dataGridView_MuonSach.AllowUserToAddRows = false;
            this.dataGridView_MuonSach.AllowUserToDeleteRows = false;
            this.dataGridView_MuonSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_MuonSach.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridView_MuonSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_MuonSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_MuonSach.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_MuonSach.Name = "dataGridView_MuonSach";
            this.dataGridView_MuonSach.ReadOnly = true;
            this.dataGridView_MuonSach.RowHeadersWidth = 51;
            this.dataGridView_MuonSach.RowTemplate.Height = 24;
            this.dataGridView_MuonSach.Size = new System.Drawing.Size(786, 259);
            this.dataGridView_MuonSach.TabIndex = 0;
            this.dataGridView_MuonSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_MuonSach_CellClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.splitContainer3);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 417);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Thống kê";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(3, 3);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer3.Size = new System.Drawing.Size(786, 411);
            this.splitContainer3.SplitterDistance = 277;
            this.splitContainer3.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView_ThongKe);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 411);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê lượt mượn";
            // 
            // dataGridView_ThongKe
            // 
            this.dataGridView_ThongKe.AllowUserToAddRows = false;
            this.dataGridView_ThongKe.AllowUserToDeleteRows = false;
            this.dataGridView_ThongKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_ThongKe.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridView_ThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_ThongKe.Location = new System.Drawing.Point(3, 26);
            this.dataGridView_ThongKe.Name = "dataGridView_ThongKe";
            this.dataGridView_ThongKe.ReadOnly = true;
            this.dataGridView_ThongKe.RowHeadersWidth = 51;
            this.dataGridView_ThongKe.RowTemplate.Height = 24;
            this.dataGridView_ThongKe.Size = new System.Drawing.Size(271, 382);
            this.dataGridView_ThongKe.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewQuaHan);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(505, 411);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sinh viên mượn sách quá hạn";
            // 
            // dataGridViewQuaHan
            // 
            this.dataGridViewQuaHan.AllowUserToAddRows = false;
            this.dataGridViewQuaHan.AllowUserToDeleteRows = false;
            this.dataGridViewQuaHan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewQuaHan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridViewQuaHan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuaHan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewQuaHan.Location = new System.Drawing.Point(3, 26);
            this.dataGridViewQuaHan.Name = "dataGridViewQuaHan";
            this.dataGridViewQuaHan.ReadOnly = true;
            this.dataGridViewQuaHan.RowHeadersWidth = 51;
            this.dataGridViewQuaHan.RowTemplate.Height = 24;
            this.dataGridViewQuaHan.Size = new System.Drawing.Size(499, 382);
            this.dataGridViewQuaHan.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý thư viện";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Sach)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MuonSach)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ThongKe)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuaHan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tb_maSach;
        private System.Windows.Forms.DataGridView dataGridView_Sach;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox tb_tenSach;
        private System.Windows.Forms.Button bt_themSach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dataGridView_MuonSach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dt_ngayMuon;
        private System.Windows.Forms.DateTimePicker dt_ngayTra;
        private System.Windows.Forms.ComboBox cb_tenSV;
        private System.Windows.Forms.ComboBox cb_tenSach;
        private System.Windows.Forms.Button bt_muon;
        private System.Windows.Forms.Button bt_tra;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView_ThongKe;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewQuaHan;
    }
}

