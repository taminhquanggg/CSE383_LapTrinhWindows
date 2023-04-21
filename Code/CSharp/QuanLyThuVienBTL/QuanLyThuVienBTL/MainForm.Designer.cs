namespace QuanLyThuVienBTL
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ts_Info = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_InfoTypeOfBook = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_InfoBook = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_InfoReader = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_BorrowGiveBack = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_Borrow = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_GiveBack = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_Search = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_History = new System.Windows.Forms.ToolStripMenuItem();
            this.hỗTrợToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_LogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_Info,
            this.ts_BorrowGiveBack,
            this.ts_Search,
            this.hỗTrợToolStripMenuItem,
            this.ts_LogOut});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1382, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ts_Info
            // 
            this.ts_Info.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_InfoTypeOfBook,
            this.ts_InfoBook,
            this.ts_InfoReader});
            this.ts_Info.Image = global::QuanLyThuVienBTL.Properties.Resources.info_96px;
            this.ts_Info.Name = "ts_Info";
            this.ts_Info.Size = new System.Drawing.Size(122, 29);
            this.ts_Info.Text = "Thông tin";
            // 
            // ts_InfoTypeOfBook
            // 
            this.ts_InfoTypeOfBook.Name = "ts_InfoTypeOfBook";
            this.ts_InfoTypeOfBook.Size = new System.Drawing.Size(247, 30);
            this.ts_InfoTypeOfBook.Text = "Thông tin loại sách";
            this.ts_InfoTypeOfBook.Click += new System.EventHandler(this.ts_InfoTypeOfBook_Click);
            // 
            // ts_InfoBook
            // 
            this.ts_InfoBook.Name = "ts_InfoBook";
            this.ts_InfoBook.Size = new System.Drawing.Size(247, 30);
            this.ts_InfoBook.Text = "Thông tin sách";
            this.ts_InfoBook.Click += new System.EventHandler(this.ts_InfoBook_Click);
            // 
            // ts_InfoReader
            // 
            this.ts_InfoReader.Name = "ts_InfoReader";
            this.ts_InfoReader.Size = new System.Drawing.Size(247, 30);
            this.ts_InfoReader.Text = "Thông tin đọc giả";
            // 
            // ts_BorrowGiveBack
            // 
            this.ts_BorrowGiveBack.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_Borrow,
            this.ts_GiveBack});
            this.ts_BorrowGiveBack.Image = global::QuanLyThuVienBTL.Properties.Resources.borrow_book_96px;
            this.ts_BorrowGiveBack.Name = "ts_BorrowGiveBack";
            this.ts_BorrowGiveBack.Size = new System.Drawing.Size(173, 29);
            this.ts_BorrowGiveBack.Text = "Mượn - Trả sách";
            // 
            // ts_Borrow
            // 
            this.ts_Borrow.Name = "ts_Borrow";
            this.ts_Borrow.Size = new System.Drawing.Size(186, 30);
            this.ts_Borrow.Text = "Mượn sách";
            // 
            // ts_GiveBack
            // 
            this.ts_GiveBack.Name = "ts_GiveBack";
            this.ts_GiveBack.Size = new System.Drawing.Size(186, 30);
            this.ts_GiveBack.Text = "Trả sách";
            // 
            // ts_Search
            // 
            this.ts_Search.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_History});
            this.ts_Search.Image = global::QuanLyThuVienBTL.Properties.Resources.search_96px;
            this.ts_Search.Name = "ts_Search";
            this.ts_Search.Size = new System.Drawing.Size(209, 29);
            this.ts_Search.Text = "Tìm kiếm - Thống kê";
            // 
            // ts_History
            // 
            this.ts_History.Name = "ts_History";
            this.ts_History.Size = new System.Drawing.Size(244, 30);
            this.ts_History.Text = "Lịch sử Mượn - Trả";
            // 
            // hỗTrợToolStripMenuItem
            // 
            this.hỗTrợToolStripMenuItem.Image = global::QuanLyThuVienBTL.Properties.Resources.help_96px;
            this.hỗTrợToolStripMenuItem.Name = "hỗTrợToolStripMenuItem";
            this.hỗTrợToolStripMenuItem.Size = new System.Drawing.Size(98, 29);
            this.hỗTrợToolStripMenuItem.Text = "Hỗ trợ";
            // 
            // ts_LogOut
            // 
            this.ts_LogOut.Image = global::QuanLyThuVienBTL.Properties.Resources.Logout_96px;
            this.ts_LogOut.Name = "ts_LogOut";
            this.ts_LogOut.Size = new System.Drawing.Size(127, 29);
            this.ts_LogOut.Text = "Đăng xuất";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1382, 653);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ THƯ VIỆN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ts_Info;
        private System.Windows.Forms.ToolStripMenuItem ts_InfoTypeOfBook;
        private System.Windows.Forms.ToolStripMenuItem ts_InfoBook;
        private System.Windows.Forms.ToolStripMenuItem ts_InfoReader;
        private System.Windows.Forms.ToolStripMenuItem ts_BorrowGiveBack;
        private System.Windows.Forms.ToolStripMenuItem ts_Borrow;
        private System.Windows.Forms.ToolStripMenuItem ts_GiveBack;
        private System.Windows.Forms.ToolStripMenuItem ts_Search;
        private System.Windows.Forms.ToolStripMenuItem ts_History;
        private System.Windows.Forms.ToolStripMenuItem ts_LogOut;
        private System.Windows.Forms.ToolStripMenuItem hỗTrợToolStripMenuItem;
    }
}