using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinhDiem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double diem = 0;
        private int dem = 0;

        private void textBox1_Leave(object sender, EventArgs e)
        {
            diem += Convert.ToDouble(((TextBox)sender).Text);
            dem++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double dtb = (diem * 1.0 / dem);
            textBox9.Text = dtb.ToString();
            if (dtb < 1)
                textBox10.Text = "Kém";
            else if (dtb < 1.49)
                textBox10.Text = "Yếu";
            else if (dtb < 1.99)
                textBox10.Text = "Trung bình yếu";
            else if (dtb < 2.29)
                textBox10.Text = "Trung bình";
            else if (dtb < 2.49)
                textBox10.Text = "Trung bình khá";
            else if (dtb < 3.19)
                textBox10.Text = "Khá";
            else if (dtb < 3.59)
                textBox10.Text = "Giỏi";
            else textBox10.Text = "Xuất sắc";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
            textBox7.Text = "0";
            textBox8.Text = "0";
            textBox9.Text = "";
            textBox10.Text = "";
            diem = 0;
            dem = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
