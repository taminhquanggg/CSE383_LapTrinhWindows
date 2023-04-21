namespace NhapChuoi
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_chuoiA = new System.Windows.Forms.TextBox();
            this.tb_chuoiB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_soLanXH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_nghichDaoA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_nghichDaoB = new System.Windows.Forms.TextBox();
            this.bt_ThucHien = new System.Windows.Forms.Button();
            this.bt_NhapLai = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.đổiMàuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ContextMenuStrip = this.contextMenuStrip1;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chuỗi A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ContextMenuStrip = this.contextMenuStrip1;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chuỗi B";
            // 
            // tb_chuoiA
            // 
            this.tb_chuoiA.ContextMenuStrip = this.contextMenuStrip1;
            this.tb_chuoiA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_chuoiA.Location = new System.Drawing.Point(163, 30);
            this.tb_chuoiA.Multiline = true;
            this.tb_chuoiA.Name = "tb_chuoiA";
            this.tb_chuoiA.Size = new System.Drawing.Size(200, 36);
            this.tb_chuoiA.TabIndex = 2;
            this.tb_chuoiA.Leave += new System.EventHandler(this.tb_chuoiA_Leave);
            // 
            // tb_chuoiB
            // 
            this.tb_chuoiB.ContextMenuStrip = this.contextMenuStrip1;
            this.tb_chuoiB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_chuoiB.Location = new System.Drawing.Point(163, 96);
            this.tb_chuoiB.Multiline = true;
            this.tb_chuoiB.Name = "tb_chuoiB";
            this.tb_chuoiB.Size = new System.Drawing.Size(200, 39);
            this.tb_chuoiB.TabIndex = 3;
            this.tb_chuoiB.Leave += new System.EventHandler(this.tb_chuoiB_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ContextMenuStrip = this.contextMenuStrip1;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(385, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số lần xuất hiện chuỗi ngắn trong chuỗi dài";
            // 
            // tb_soLanXH
            // 
            this.tb_soLanXH.ContextMenuStrip = this.contextMenuStrip1;
            this.tb_soLanXH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_soLanXH.Location = new System.Drawing.Point(474, 163);
            this.tb_soLanXH.Multiline = true;
            this.tb_soLanXH.Name = "tb_soLanXH";
            this.tb_soLanXH.ReadOnly = true;
            this.tb_soLanXH.Size = new System.Drawing.Size(66, 39);
            this.tb_soLanXH.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ContextMenuStrip = this.contextMenuStrip1;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Chuỗi nghịch đảo A";
            // 
            // tb_nghichDaoA
            // 
            this.tb_nghichDaoA.ContextMenuStrip = this.contextMenuStrip1;
            this.tb_nghichDaoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nghichDaoA.Location = new System.Drawing.Point(260, 227);
            this.tb_nghichDaoA.Multiline = true;
            this.tb_nghichDaoA.Name = "tb_nghichDaoA";
            this.tb_nghichDaoA.ReadOnly = true;
            this.tb_nghichDaoA.Size = new System.Drawing.Size(200, 39);
            this.tb_nghichDaoA.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ContextMenuStrip = this.contextMenuStrip1;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(58, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Chuỗi nghịch đảo B";
            // 
            // tb_nghichDaoB
            // 
            this.tb_nghichDaoB.ContextMenuStrip = this.contextMenuStrip1;
            this.tb_nghichDaoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nghichDaoB.Location = new System.Drawing.Point(260, 291);
            this.tb_nghichDaoB.Multiline = true;
            this.tb_nghichDaoB.Name = "tb_nghichDaoB";
            this.tb_nghichDaoB.ReadOnly = true;
            this.tb_nghichDaoB.Size = new System.Drawing.Size(200, 39);
            this.tb_nghichDaoB.TabIndex = 9;
            // 
            // bt_ThucHien
            // 
            this.bt_ThucHien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bt_ThucHien.ContextMenuStrip = this.contextMenuStrip1;
            this.bt_ThucHien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ThucHien.Location = new System.Drawing.Point(621, 45);
            this.bt_ThucHien.Name = "bt_ThucHien";
            this.bt_ThucHien.Size = new System.Drawing.Size(135, 68);
            this.bt_ThucHien.TabIndex = 10;
            this.bt_ThucHien.Text = "Thực hiện";
            this.bt_ThucHien.UseVisualStyleBackColor = false;
            this.bt_ThucHien.Click += new System.EventHandler(this.bt_ThucHien_Click);
            // 
            // bt_NhapLai
            // 
            this.bt_NhapLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bt_NhapLai.ContextMenuStrip = this.contextMenuStrip1;
            this.bt_NhapLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_NhapLai.Location = new System.Drawing.Point(441, 45);
            this.bt_NhapLai.Name = "bt_NhapLai";
            this.bt_NhapLai.Size = new System.Drawing.Size(135, 68);
            this.bt_NhapLai.TabIndex = 11;
            this.bt_NhapLai.Text = "Nhập lại";
            this.bt_NhapLai.UseVisualStyleBackColor = false;
            this.bt_NhapLai.Click += new System.EventHandler(this.bt_NhapLai_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đổiMàuToolStripMenuItem,
            this.đổiFontToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 96);
            // 
            // đổiMàuToolStripMenuItem
            // 
            this.đổiMàuToolStripMenuItem.Name = "đổiMàuToolStripMenuItem";
            this.đổiMàuToolStripMenuItem.Size = new System.Drawing.Size(158, 32);
            this.đổiMàuToolStripMenuItem.Text = "Đổi màu";
            this.đổiMàuToolStripMenuItem.Click += new System.EventHandler(this.đổiMàuToolStripMenuItem_Click);
            // 
            // đổiFontToolStripMenuItem
            // 
            this.đổiFontToolStripMenuItem.Name = "đổiFontToolStripMenuItem";
            this.đổiFontToolStripMenuItem.Size = new System.Drawing.Size(210, 32);
            this.đổiFontToolStripMenuItem.Text = "Đổi font";
            this.đổiFontToolStripMenuItem.Click += new System.EventHandler(this.đổiFontToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 388);
            this.Controls.Add(this.bt_NhapLai);
            this.Controls.Add(this.bt_ThucHien);
            this.Controls.Add(this.tb_nghichDaoB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_nghichDaoA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_soLanXH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_chuoiB);
            this.Controls.Add(this.tb_chuoiA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập chuỗi";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_chuoiA;
        private System.Windows.Forms.TextBox tb_chuoiB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_soLanXH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_nghichDaoA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_nghichDaoB;
        private System.Windows.Forms.Button bt_ThucHien;
        private System.Windows.Forms.Button bt_NhapLai;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem đổiMàuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiFontToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.FontDialog fontDialog;
    }
}

