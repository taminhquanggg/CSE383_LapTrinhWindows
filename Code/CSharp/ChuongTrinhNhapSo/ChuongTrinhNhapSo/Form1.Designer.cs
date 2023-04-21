namespace ChuongTrinhNhapSo
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
            this.labelInputN = new System.Windows.Forms.Label();
            this.textBoxInputN = new System.Windows.Forms.TextBox();
            this.buttonShow = new System.Windows.Forms.Button();
            this.labelShowSNT = new System.Windows.Forms.Label();
            this.labelShowSCP = new System.Windows.Forms.Label();
            this.labelShowSHH = new System.Windows.Forms.Label();
            this.textBoxOutputSNT = new System.Windows.Forms.TextBox();
            this.textBoxOutputSCP = new System.Windows.Forms.TextBox();
            this.textBoxOutputSHH = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelInputN
            // 
            this.labelInputN.AutoSize = true;
            this.labelInputN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInputN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelInputN.Location = new System.Drawing.Point(40, 40);
            this.labelInputN.Name = "labelInputN";
            this.labelInputN.Size = new System.Drawing.Size(101, 25);
            this.labelInputN.TabIndex = 0;
            this.labelInputN.Text = "Nhập số n";
            // 
            // textBoxInputN
            // 
            this.textBoxInputN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxInputN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInputN.Location = new System.Drawing.Point(164, 31);
            this.textBoxInputN.Multiline = true;
            this.textBoxInputN.Name = "textBoxInputN";
            this.textBoxInputN.Size = new System.Drawing.Size(248, 34);
            this.textBoxInputN.TabIndex = 1;
            this.textBoxInputN.Leave += new System.EventHandler(this.textBoxInputN_Leave);
            // 
            // buttonShow
            // 
            this.buttonShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShow.Location = new System.Drawing.Point(485, 17);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(100, 58);
            this.buttonShow.TabIndex = 2;
            this.buttonShow.Text = "Hiển thị";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // labelShowSNT
            // 
            this.labelShowSNT.AutoSize = true;
            this.labelShowSNT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShowSNT.Location = new System.Drawing.Point(40, 123);
            this.labelShowSNT.Name = "labelShowSNT";
            this.labelShowSNT.Size = new System.Drawing.Size(263, 25);
            this.labelShowSNT.TabIndex = 3;
            this.labelShowSNT.Text = "Các số nguyên tố nhỏ hơn n:";
            // 
            // labelShowSCP
            // 
            this.labelShowSCP.AutoSize = true;
            this.labelShowSCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShowSCP.Location = new System.Drawing.Point(40, 198);
            this.labelShowSCP.Name = "labelShowSCP";
            this.labelShowSCP.Size = new System.Drawing.Size(295, 25);
            this.labelShowSCP.TabIndex = 4;
            this.labelShowSCP.Text = "Các số chính phương nhỏ hơn n:";
            // 
            // labelShowSHH
            // 
            this.labelShowSHH.AutoSize = true;
            this.labelShowSHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShowSHH.Location = new System.Drawing.Point(40, 273);
            this.labelShowSHH.Name = "labelShowSHH";
            this.labelShowSHH.Size = new System.Drawing.Size(259, 25);
            this.labelShowSHH.TabIndex = 5;
            this.labelShowSHH.Text = "Các số hoàn hảo nhỏ hơn n:";
            // 
            // textBoxOutputSNT
            // 
            this.textBoxOutputSNT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOutputSNT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOutputSNT.Location = new System.Drawing.Point(322, 120);
            this.textBoxOutputSNT.Multiline = true;
            this.textBoxOutputSNT.Name = "textBoxOutputSNT";
            this.textBoxOutputSNT.ReadOnly = true;
            this.textBoxOutputSNT.Size = new System.Drawing.Size(263, 36);
            this.textBoxOutputSNT.TabIndex = 6;
            // 
            // textBoxOutputSCP
            // 
            this.textBoxOutputSCP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOutputSCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOutputSCP.Location = new System.Drawing.Point(365, 187);
            this.textBoxOutputSCP.Multiline = true;
            this.textBoxOutputSCP.Name = "textBoxOutputSCP";
            this.textBoxOutputSCP.ReadOnly = true;
            this.textBoxOutputSCP.Size = new System.Drawing.Size(220, 36);
            this.textBoxOutputSCP.TabIndex = 7;
            // 
            // textBoxOutputSHH
            // 
            this.textBoxOutputSHH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOutputSHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOutputSHH.Location = new System.Drawing.Point(322, 262);
            this.textBoxOutputSHH.Multiline = true;
            this.textBoxOutputSHH.Name = "textBoxOutputSHH";
            this.textBoxOutputSHH.ReadOnly = true;
            this.textBoxOutputSHH.Size = new System.Drawing.Size(263, 36);
            this.textBoxOutputSHH.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(612, 395);
            this.Controls.Add(this.textBoxOutputSHH);
            this.Controls.Add(this.textBoxOutputSCP);
            this.Controls.Add(this.textBoxOutputSNT);
            this.Controls.Add(this.labelShowSHH);
            this.Controls.Add(this.labelShowSCP);
            this.Controls.Add(this.labelShowSNT);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.textBoxInputN);
            this.Controls.Add(this.labelInputN);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chương trình nhập số";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInputN;
        private System.Windows.Forms.TextBox textBoxInputN;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.Label labelShowSNT;
        private System.Windows.Forms.Label labelShowSCP;
        private System.Windows.Forms.Label labelShowSHH;
        private System.Windows.Forms.TextBox textBoxOutputSNT;
        private System.Windows.Forms.TextBox textBoxOutputSCP;
        private System.Windows.Forms.TextBox textBoxOutputSHH;
    }
}

