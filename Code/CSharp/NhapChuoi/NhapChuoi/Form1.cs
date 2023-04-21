using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NhapChuoi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string a, b;

        private void tb_chuoiB_Leave(object sender, EventArgs e)
        {
            b = tb_chuoiB.Text;
        }

        private void bt_NhapLai_Click(object sender, EventArgs e)
        {
            a = "";
            b = "";
            tb_chuoiA.Text = "";
            tb_chuoiB.Text = "";
            tb_nghichDaoA.Text = "";
            tb_nghichDaoB.Text = "";
            tb_soLanXH.Text = "";
        }

        private string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        private int countArr(string a, string b)
        {
            int strt = 0;
            int cnt = -1;
            int idx = -1;
            while (strt != -1)
            {
                strt = a.IndexOf(b, idx + 1);
                cnt += 1;
                idx = strt;
            }

            return cnt;
        }

        private void bt_ThucHien_Click(object sender, EventArgs e)
        {
            tb_nghichDaoA.Text = ReverseString(a);
            tb_nghichDaoB.Text = ReverseString(b);
            if (String.Compare(a, b, false) == -1)
            {
                tb_soLanXH.Text = countArr(b, a).ToString();
            }
            else if (String.Compare(a, b, false) == 1)
            {
                tb_soLanXH.Text = countArr(a, b).ToString();
            }
            else
            {
                tb_soLanXH.Text = "1";
            }
        }

        private void đổiMàuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                contextMenuStrip1.SourceControl.BackColor = colorDialog.Color;
            }
        }

        private void đổiFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                contextMenuStrip1.SourceControl.Font = fontDialog.Font;
            }
        }

        private void tb_chuoiA_Leave(object sender, EventArgs e)
        {
            a = tb_chuoiA.Text;
        }


    }
}
