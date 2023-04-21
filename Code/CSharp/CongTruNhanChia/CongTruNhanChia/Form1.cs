using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CongTruNhanChia
{
    public partial class Form1 : Form
    {

        private int a, b;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxA_Leave(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxA.Text, out a))
            {
                MessageBox.Show("Lỗi nhập sai dữ liệu");
                textBoxA.Focus();
            }
        }

        private void buttonTinh_Click(object sender, EventArgs e)
        {
            labelKQTong.Text = Convert.ToString(a + b);
            labelKQHieu.Text = Convert.ToString(a - b);
            labelKQTich.Text = Convert.ToString(a * b);
            if (b == 0)
            {
                MessageBox.Show("Lỗi chia cho 0");
            }
            else
            {
                labelKQThuong.Text = Convert.ToString((double)a / b);
            }
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxB_Leave(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxB.Text, out b))
            {
                MessageBox.Show("Lỗi nhập sai dữ liệu");
                textBoxB.Focus();
            }
        }
    }

    class MyException: ApplicationException
    {
        public MyException(string msg) : base(msg)
        {

        }
    }
}
