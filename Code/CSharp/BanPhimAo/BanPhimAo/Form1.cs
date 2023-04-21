using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanPhimAo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Color backColor;

        private void button5_Click(object sender, EventArgs e)
        {
            tb_manHinh.Text += ((Button)sender).Text;
            ((Button)sender).BackColor = Color.Orange;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (tb_manHinh.Text.Length > 0)
                tb_manHinh.Text = tb_manHinh.Text.Remove(tb_manHinh.Text.Length - 1);
            ((Button)sender).BackColor = Color.Orange;
        }

        private void button42_Click(object sender, EventArgs e)
        {
            tb_manHinh.Text += " ";
            ((Button)sender).BackColor = Color.Orange;
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            backColor = ((Button)sender).BackColor;
            ((Button)sender).BackColor = Color.HotPink;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = backColor;
        }
    }
}
