namespace MayTinh
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thayĐổiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeColorMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.changeFontMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tb_Input = new System.Windows.Forms.TextBox();
            this.tb_Output = new System.Windows.Forms.TextBox();
            this.bt_num1 = new System.Windows.Forms.Button();
            this.bt_num2 = new System.Windows.Forms.Button();
            this.bt_num3 = new System.Windows.Forms.Button();
            this.bt_plus = new System.Windows.Forms.Button();
            this.bt_minus = new System.Windows.Forms.Button();
            this.bt_num6 = new System.Windows.Forms.Button();
            this.bt_num5 = new System.Windows.Forms.Button();
            this.bt_num4 = new System.Windows.Forms.Button();
            this.bt_multiply = new System.Windows.Forms.Button();
            this.bt_num9 = new System.Windows.Forms.Button();
            this.bt_num8 = new System.Windows.Forms.Button();
            this.bt_num7 = new System.Windows.Forms.Button();
            this.bt_division = new System.Windows.Forms.Button();
            this.bt_return = new System.Windows.Forms.Button();
            this.bt_clear = new System.Windows.Forms.Button();
            this.bt_num0 = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thayĐổiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(563, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thayĐổiToolStripMenuItem
            // 
            this.thayĐổiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeColorMenu,
            this.changeFontMenu});
            this.thayĐổiToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.thayĐổiToolStripMenuItem.Name = "thayĐổiToolStripMenuItem";
            this.thayĐổiToolStripMenuItem.Size = new System.Drawing.Size(120, 36);
            this.thayĐổiToolStripMenuItem.Text = "Thay đổi";
            // 
            // changeColorMenu
            // 
            this.changeColorMenu.Name = "changeColorMenu";
            this.changeColorMenu.Size = new System.Drawing.Size(291, 36);
            this.changeColorMenu.Text = "Thay đổi màu sắc";
            this.changeColorMenu.Click += new System.EventHandler(this.changeColorMenu_Click);
            // 
            // changeFontMenu
            // 
            this.changeFontMenu.Name = "changeFontMenu";
            this.changeFontMenu.Size = new System.Drawing.Size(291, 36);
            this.changeFontMenu.Text = "Thay đổi font chữ";
            this.changeFontMenu.Click += new System.EventHandler(this.changeFontMenu_Click);
            // 
            // tb_Input
            // 
            this.tb_Input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tb_Input.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Input.Location = new System.Drawing.Point(0, 0);
            this.tb_Input.Multiline = true;
            this.tb_Input.Name = "tb_Input";
            this.tb_Input.ReadOnly = true;
            this.tb_Input.Size = new System.Drawing.Size(563, 71);
            this.tb_Input.TabIndex = 1;
            this.tb_Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_Output
            // 
            this.tb_Output.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tb_Output.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Output.Location = new System.Drawing.Point(0, 0);
            this.tb_Output.Multiline = true;
            this.tb_Output.Name = "tb_Output";
            this.tb_Output.ReadOnly = true;
            this.tb_Output.Size = new System.Drawing.Size(563, 105);
            this.tb_Output.TabIndex = 2;
            this.tb_Output.Text = "0";
            this.tb_Output.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bt_num1
            // 
            this.bt_num1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_num1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_num1.Location = new System.Drawing.Point(3, 3);
            this.bt_num1.Name = "bt_num1";
            this.bt_num1.Size = new System.Drawing.Size(134, 65);
            this.bt_num1.TabIndex = 3;
            this.bt_num1.Text = "1";
            this.bt_num1.UseVisualStyleBackColor = false;
            this.bt_num1.Click += new System.EventHandler(this.bt_num1_Click);
            // 
            // bt_num2
            // 
            this.bt_num2.BackColor = System.Drawing.Color.Cyan;
            this.bt_num2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_num2.Location = new System.Drawing.Point(143, 3);
            this.bt_num2.Name = "bt_num2";
            this.bt_num2.Size = new System.Drawing.Size(134, 65);
            this.bt_num2.TabIndex = 4;
            this.bt_num2.Text = "2";
            this.bt_num2.UseVisualStyleBackColor = false;
            this.bt_num2.Click += new System.EventHandler(this.bt_num2_Click);
            // 
            // bt_num3
            // 
            this.bt_num3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_num3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_num3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_num3.Location = new System.Drawing.Point(283, 3);
            this.bt_num3.Name = "bt_num3";
            this.bt_num3.Size = new System.Drawing.Size(134, 65);
            this.bt_num3.TabIndex = 5;
            this.bt_num3.Text = "3";
            this.bt_num3.UseVisualStyleBackColor = false;
            this.bt_num3.Click += new System.EventHandler(this.bt_num3_Click);
            // 
            // bt_plus
            // 
            this.bt_plus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bt_plus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_plus.Location = new System.Drawing.Point(423, 3);
            this.bt_plus.Name = "bt_plus";
            this.bt_plus.Size = new System.Drawing.Size(137, 65);
            this.bt_plus.TabIndex = 6;
            this.bt_plus.Text = "+";
            this.bt_plus.UseVisualStyleBackColor = false;
            this.bt_plus.Click += new System.EventHandler(this.bt_plus_Click);
            // 
            // bt_minus
            // 
            this.bt_minus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.bt_minus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_minus.Location = new System.Drawing.Point(423, 74);
            this.bt_minus.Name = "bt_minus";
            this.bt_minus.Size = new System.Drawing.Size(137, 65);
            this.bt_minus.TabIndex = 10;
            this.bt_minus.Text = "-";
            this.bt_minus.UseVisualStyleBackColor = false;
            this.bt_minus.Click += new System.EventHandler(this.bt_minus_Click);
            // 
            // bt_num6
            // 
            this.bt_num6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bt_num6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_num6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_num6.Location = new System.Drawing.Point(283, 74);
            this.bt_num6.Name = "bt_num6";
            this.bt_num6.Size = new System.Drawing.Size(134, 65);
            this.bt_num6.TabIndex = 9;
            this.bt_num6.Text = "6";
            this.bt_num6.UseVisualStyleBackColor = false;
            this.bt_num6.Click += new System.EventHandler(this.bt_num6_Click);
            // 
            // bt_num5
            // 
            this.bt_num5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_num5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_num5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_num5.Location = new System.Drawing.Point(143, 74);
            this.bt_num5.Name = "bt_num5";
            this.bt_num5.Size = new System.Drawing.Size(134, 65);
            this.bt_num5.TabIndex = 8;
            this.bt_num5.Text = "5";
            this.bt_num5.UseVisualStyleBackColor = false;
            this.bt_num5.Click += new System.EventHandler(this.bt_num5_Click);
            // 
            // bt_num4
            // 
            this.bt_num4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_num4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_num4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_num4.Location = new System.Drawing.Point(3, 74);
            this.bt_num4.Name = "bt_num4";
            this.bt_num4.Size = new System.Drawing.Size(134, 65);
            this.bt_num4.TabIndex = 7;
            this.bt_num4.Text = "4";
            this.bt_num4.UseVisualStyleBackColor = false;
            this.bt_num4.Click += new System.EventHandler(this.bt_num4_Click);
            // 
            // bt_multiply
            // 
            this.bt_multiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bt_multiply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_multiply.Location = new System.Drawing.Point(423, 145);
            this.bt_multiply.Name = "bt_multiply";
            this.bt_multiply.Size = new System.Drawing.Size(137, 65);
            this.bt_multiply.TabIndex = 14;
            this.bt_multiply.Text = "x";
            this.bt_multiply.UseVisualStyleBackColor = false;
            this.bt_multiply.Click += new System.EventHandler(this.bt_multiply_Click);
            // 
            // bt_num9
            // 
            this.bt_num9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bt_num9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_num9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_num9.Location = new System.Drawing.Point(283, 145);
            this.bt_num9.Name = "bt_num9";
            this.bt_num9.Size = new System.Drawing.Size(134, 65);
            this.bt_num9.TabIndex = 13;
            this.bt_num9.Text = "9";
            this.bt_num9.UseVisualStyleBackColor = false;
            this.bt_num9.Click += new System.EventHandler(this.bt_num9_Click);
            // 
            // bt_num8
            // 
            this.bt_num8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bt_num8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_num8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_num8.Location = new System.Drawing.Point(143, 145);
            this.bt_num8.Name = "bt_num8";
            this.bt_num8.Size = new System.Drawing.Size(134, 65);
            this.bt_num8.TabIndex = 12;
            this.bt_num8.Text = "8";
            this.bt_num8.UseVisualStyleBackColor = false;
            this.bt_num8.Click += new System.EventHandler(this.bt_num8_Click);
            // 
            // bt_num7
            // 
            this.bt_num7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bt_num7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_num7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_num7.Location = new System.Drawing.Point(3, 145);
            this.bt_num7.Name = "bt_num7";
            this.bt_num7.Size = new System.Drawing.Size(134, 65);
            this.bt_num7.TabIndex = 11;
            this.bt_num7.Text = "7";
            this.bt_num7.UseVisualStyleBackColor = false;
            this.bt_num7.Click += new System.EventHandler(this.bt_num7_Click);
            // 
            // bt_division
            // 
            this.bt_division.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bt_division.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_division.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_division.Location = new System.Drawing.Point(423, 216);
            this.bt_division.Name = "bt_division";
            this.bt_division.Size = new System.Drawing.Size(137, 65);
            this.bt_division.TabIndex = 18;
            this.bt_division.Text = "/";
            this.bt_division.UseCompatibleTextRendering = true;
            this.bt_division.UseVisualStyleBackColor = false;
            this.bt_division.Click += new System.EventHandler(this.bt_division_Click);
            // 
            // bt_return
            // 
            this.bt_return.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_return.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_return.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_return.Location = new System.Drawing.Point(283, 216);
            this.bt_return.Name = "bt_return";
            this.bt_return.Size = new System.Drawing.Size(134, 65);
            this.bt_return.TabIndex = 17;
            this.bt_return.Text = "=";
            this.bt_return.UseVisualStyleBackColor = false;
            this.bt_return.Click += new System.EventHandler(this.bt_return_Click);
            // 
            // bt_clear
            // 
            this.bt_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bt_clear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_clear.Location = new System.Drawing.Point(143, 216);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(134, 65);
            this.bt_clear.TabIndex = 16;
            this.bt_clear.Text = "C";
            this.bt_clear.UseVisualStyleBackColor = false;
            this.bt_clear.Click += new System.EventHandler(this.bt_clear_Click);
            // 
            // bt_num0
            // 
            this.bt_num0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bt_num0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_num0.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_num0.Location = new System.Drawing.Point(3, 216);
            this.bt_num0.Name = "bt_num0";
            this.bt_num0.Size = new System.Drawing.Size(134, 65);
            this.bt_num0.TabIndex = 15;
            this.bt_num0.Text = "0";
            this.bt_num0.UseVisualStyleBackColor = false;
            this.bt_num0.Click += new System.EventHandler(this.bt_num0_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 40);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(563, 468);
            this.splitContainer1.SplitterDistance = 180;
            this.splitContainer1.TabIndex = 19;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tb_Input);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tb_Output);
            this.splitContainer2.Size = new System.Drawing.Size(563, 180);
            this.splitContainer2.SplitterDistance = 71;
            this.splitContainer2.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.bt_num1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.bt_num6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.bt_num9, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.bt_num5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.bt_num0, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.bt_num4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.bt_num8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.bt_clear, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.bt_num7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.bt_return, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.bt_division, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.bt_num2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.bt_num3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.bt_plus, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.bt_minus, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.bt_multiply, 3, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(563, 284);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(563, 508);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Máy Tính của Quangka";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thayĐổiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeColorMenu;
        private System.Windows.Forms.ToolStripMenuItem changeFontMenu;
        private System.Windows.Forms.TextBox tb_Input;
        private System.Windows.Forms.TextBox tb_Output;
        private System.Windows.Forms.Button bt_num1;
        private System.Windows.Forms.Button bt_num2;
        private System.Windows.Forms.Button bt_num3;
        private System.Windows.Forms.Button bt_plus;
        private System.Windows.Forms.Button bt_minus;
        private System.Windows.Forms.Button bt_num6;
        private System.Windows.Forms.Button bt_num5;
        private System.Windows.Forms.Button bt_num4;
        private System.Windows.Forms.Button bt_multiply;
        private System.Windows.Forms.Button bt_num9;
        private System.Windows.Forms.Button bt_num8;
        private System.Windows.Forms.Button bt_num7;
        private System.Windows.Forms.Button bt_division;
        private System.Windows.Forms.Button bt_return;
        private System.Windows.Forms.Button bt_clear;
        private System.Windows.Forms.Button bt_num0;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.FontDialog fontDialog;
    }
}

