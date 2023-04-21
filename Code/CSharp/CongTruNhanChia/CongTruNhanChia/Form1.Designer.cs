namespace CongTruNhanChia
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
            this.labelA = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.labelB = new System.Windows.Forms.Label();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.buttonTinh = new System.Windows.Forms.Button();
            this.labelTong = new System.Windows.Forms.Label();
            this.labelHieu = new System.Windows.Forms.Label();
            this.labelTich = new System.Windows.Forms.Label();
            this.labelThuong = new System.Windows.Forms.Label();
            this.labelKQTong = new System.Windows.Forms.Label();
            this.labelKQHieu = new System.Windows.Forms.Label();
            this.labelKQTich = new System.Windows.Forms.Label();
            this.labelKQThuong = new System.Windows.Forms.Label();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelA.Location = new System.Drawing.Point(33, 37);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(59, 25);
            this.labelA.TabIndex = 0;
            this.labelA.Text = "Số a:";
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(127, 37);
            this.textBoxA.Multiline = true;
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(283, 25);
            this.textBoxA.TabIndex = 1;
            this.textBoxA.Leave += new System.EventHandler(this.textBoxA_Leave);
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelB.Location = new System.Drawing.Point(33, 68);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(59, 25);
            this.labelB.TabIndex = 2;
            this.labelB.Text = "Số b:";
            // 
            // textBoxB
            // 
            this.textBoxB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxB.Location = new System.Drawing.Point(127, 68);
            this.textBoxB.Multiline = true;
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(283, 25);
            this.textBoxB.TabIndex = 3;
            this.textBoxB.Leave += new System.EventHandler(this.textBoxB_Leave);
            // 
            // buttonTinh
            // 
            this.buttonTinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTinh.BackColor = System.Drawing.Color.LightGray;
            this.buttonTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTinh.Location = new System.Drawing.Point(455, 37);
            this.buttonTinh.Name = "buttonTinh";
            this.buttonTinh.Size = new System.Drawing.Size(132, 56);
            this.buttonTinh.TabIndex = 4;
            this.buttonTinh.Text = "Tính";
            this.buttonTinh.UseVisualStyleBackColor = false;
            this.buttonTinh.Click += new System.EventHandler(this.buttonTinh_Click);
            // 
            // labelTong
            // 
            this.labelTong.AutoSize = true;
            this.labelTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTong.Location = new System.Drawing.Point(33, 129);
            this.labelTong.Name = "labelTong";
            this.labelTong.Size = new System.Drawing.Size(129, 25);
            this.labelTong.TabIndex = 5;
            this.labelTong.Text = "Tổng a + b = ";
            // 
            // labelHieu
            // 
            this.labelHieu.AutoSize = true;
            this.labelHieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHieu.Location = new System.Drawing.Point(33, 167);
            this.labelHieu.Name = "labelHieu";
            this.labelHieu.Size = new System.Drawing.Size(118, 25);
            this.labelHieu.TabIndex = 6;
            this.labelHieu.Text = "Hiệu a - b = ";
            // 
            // labelTich
            // 
            this.labelTich.AutoSize = true;
            this.labelTich.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTich.Location = new System.Drawing.Point(33, 206);
            this.labelTich.Name = "labelTich";
            this.labelTich.Size = new System.Drawing.Size(117, 25);
            this.labelTich.TabIndex = 7;
            this.labelTich.Text = "Tích a * b = ";
            // 
            // labelThuong
            // 
            this.labelThuong.AutoSize = true;
            this.labelThuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThuong.Location = new System.Drawing.Point(33, 245);
            this.labelThuong.Name = "labelThuong";
            this.labelThuong.Size = new System.Drawing.Size(145, 25);
            this.labelThuong.TabIndex = 8;
            this.labelThuong.Text = "Thương a / b = ";
            // 
            // labelKQTong
            // 
            this.labelKQTong.AutoSize = true;
            this.labelKQTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKQTong.Location = new System.Drawing.Point(168, 129);
            this.labelKQTong.Name = "labelKQTong";
            this.labelKQTong.Size = new System.Drawing.Size(0, 25);
            this.labelKQTong.TabIndex = 9;
            // 
            // labelKQHieu
            // 
            this.labelKQHieu.AutoSize = true;
            this.labelKQHieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKQHieu.Location = new System.Drawing.Point(157, 167);
            this.labelKQHieu.Name = "labelKQHieu";
            this.labelKQHieu.Size = new System.Drawing.Size(0, 25);
            this.labelKQHieu.TabIndex = 10;
            // 
            // labelKQTich
            // 
            this.labelKQTich.AutoSize = true;
            this.labelKQTich.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKQTich.Location = new System.Drawing.Point(156, 206);
            this.labelKQTich.Name = "labelKQTich";
            this.labelKQTich.Size = new System.Drawing.Size(0, 25);
            this.labelKQTich.TabIndex = 11;
            // 
            // labelKQThuong
            // 
            this.labelKQThuong.AutoSize = true;
            this.labelKQThuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKQThuong.Location = new System.Drawing.Point(184, 245);
            this.labelKQThuong.Name = "labelKQThuong";
            this.labelKQThuong.Size = new System.Drawing.Size(0, 25);
            this.labelKQThuong.TabIndex = 12;
            // 
            // buttonThoat
            // 
            this.buttonThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonThoat.BackColor = System.Drawing.Color.LightGray;
            this.buttonThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThoat.Location = new System.Drawing.Point(455, 214);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(132, 56);
            this.buttonThoat.TabIndex = 13;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = false;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonTinh;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CancelButton = this.buttonThoat;
            this.ClientSize = new System.Drawing.Size(613, 315);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.labelKQThuong);
            this.Controls.Add(this.labelKQTich);
            this.Controls.Add(this.labelKQHieu);
            this.Controls.Add(this.labelKQTong);
            this.Controls.Add(this.labelThuong);
            this.Controls.Add(this.labelTich);
            this.Controls.Add(this.labelHieu);
            this.Controls.Add(this.labelTong);
            this.Controls.Add(this.buttonTinh);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.labelA);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Button buttonTinh;
        private System.Windows.Forms.Label labelTong;
        private System.Windows.Forms.Label labelHieu;
        private System.Windows.Forms.Label labelTich;
        private System.Windows.Forms.Label labelThuong;
        private System.Windows.Forms.Label labelKQTong;
        private System.Windows.Forms.Label labelKQHieu;
        private System.Windows.Forms.Label labelKQTich;
        private System.Windows.Forms.Label labelKQThuong;
        private System.Windows.Forms.Button buttonThoat;
    }
}

