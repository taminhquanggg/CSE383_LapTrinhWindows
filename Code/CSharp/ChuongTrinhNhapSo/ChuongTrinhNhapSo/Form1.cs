using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuongTrinhNhapSo
{
    public partial class Form1 : Form
    {
        private int n;
        public Form1()
        {
            InitializeComponent();
        }

        private bool KT_SNT(int n)
        {
            if (n<2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n%i==0) return false;
            }
            return true;
        }

        private bool KT_SCP(int n)
        {
            int sqr = Convert.ToInt32(Math.Sqrt(n));
            if (sqr*sqr == n) return true;
            return false;
        }

        private bool KT_SHH(int n)
        {
            if (n<6) return false;
            int s = 0;
            for (int i = 1; i<=n/2; i++)
            {
                if (n%i==0)
                {
                    s += i;
                }
            }
            if (s==n) return true;
            return false;
        }

        private void textBoxInputN_Leave(object sender, EventArgs e)
        {

            if (!int.TryParse(textBoxInputN.Text, out n))
            {
                MessageBox.Show("Dữ liệu nhập và phải là số nguyên !", "Lỗi !");
                textBoxInputN.Text = "";
                textBoxInputN.Focus();
            }

            else if (n <= 0 || n >= 1000)
            {
                MessageBox.Show("Số n không thỏa mãn điều kiện 0<n<1000 !", "Lỗi !");
                textBoxInputN.Text = "";
                textBoxInputN.Focus();
            }
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            textBoxOutputSNT.Text = "";
            textBoxOutputSCP.Text = "";
            textBoxOutputSHH.Text = "";
            for (int i = 0; i<n; i++)
            {
                if (this.KT_SNT(i))
                {
                    textBoxOutputSNT.Text += i + " ";
                }
    
                if (this.KT_SCP(i))
                {
                    textBoxOutputSCP.Text += i + " ";
                }

                if (this.KT_SHH(i))
                {
                    textBoxOutputSHH.Text += i + " ";
                }
            }
        }
    }
}
