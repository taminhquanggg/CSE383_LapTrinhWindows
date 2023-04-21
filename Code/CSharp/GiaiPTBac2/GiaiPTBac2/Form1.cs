using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaiPTBac2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int a, b, c;

        private void bt_Giai_Click(object sender, EventArgs e)
        {
            double delta = b * b - 4 * a * c;
            if (delta < 0)
            {
                lb_SoNghiem.Text = "Phương trình vô nghiệm";
                lb_SoNghiem.Visible = true;
            }
            else if (delta > 0)
            {
                lb_SoNghiem.Text = "Phương trình có 2 nghiệm phân biệt";
                lb_SoNghiem.Visible = true;
                panel_Nghiem.Visible = true;
                tb_x1.Text = (1.0 * (-b + Math.Sqrt(delta)) / (2 * a)).ToString();
                tb_x2.Text = (1.0 * (-b - Math.Sqrt(delta)) / (2 * a)).ToString();
            }
            else
            {
                lb_SoNghiem.Text = "Phương trình có nghiệm kép";
                lb_SoNghiem.Visible = true;
                panel_NghiemKep.Visible = true;
                tb_NghiemKep.Text = (-b * 1.0 / (2 * a)).ToString();
            }
        }

        private void tb_a_Leave(object sender, EventArgs e)
        {
            if (!int.TryParse(tb_a.Text, out a))
            {
                MessageBox.Show("Số nhập vào phải là số nguyên !", "Lỗi !");
                tb_a.Focus();
            }
        }

        private void tb_b_Leave(object sender, EventArgs e)
        {
            if (!int.TryParse(tb_b.Text, out b))
            {
                MessageBox.Show("Số nhập vào phải là số nguyên !", "Lỗi !");
                tb_b.Focus();
            }
        }

        private void tb_c_Leave(object sender, EventArgs e)
        {
            if (!int.TryParse(tb_c.Text, out c))
            {
                MessageBox.Show("Số nhập vào phải là số nguyên !", "Lỗi !");
                tb_c.Focus();
            }
        }

        private void đổiMàuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                contextMenuStrip1.SourceControl.BackColor = colorDialog1.Color;
            }
        }

        private void đỔiFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                contextMenuStrip1.SourceControl.Font = fontDialog1.Font;
            }
        }

        private void bt_LamMoi_Click(object sender, EventArgs e)
        {
            tb_a.Text = "";
            tb_b.Text = "";
            tb_c.Text = "";
            lb_SoNghiem.Visible = false;
            panel_Nghiem.Visible = false;
            panel_NghiemKep.Visible = false;
        }

        private void bt_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
