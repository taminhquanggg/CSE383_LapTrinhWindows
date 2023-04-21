using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyXeKhach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loadDataGridView();
        }

        private bool btnGhe_choose = false;
        private string soGhe;
        private Button btnGhe_ThanhToan = null;
        private DataTable dataTable = new DataTable();


        private void loadDataGridView()
        {
            dataTable.Columns.Add("Vị trí ngồi", typeof(string));
            dataTable.Columns.Add("Tên khách", typeof(string));
            dataTable.Columns.Add("Tuổi", typeof(string));
            dataTable.Columns.Add("Thành tiền", typeof(string));

            dataGridView.DataSource = dataTable;
        }

        private void btn_ghe_Click(object sender, EventArgs e)
        {
            if (((Button)sender).BackColor == Color.Red)
            {
                return;
            }

            if (btnGhe_choose == true)
            {
                btnGhe_choose = false;
                foreach (Button button in tableLayoutPanel1.Controls)
                {
                    if (button.BackColor != Color.Red)
                    {
                        button.BackColor = Color.White;
                    }
                }
                foreach (Button button in tableLayoutPanel2.Controls)
                {
                    if (button.BackColor != Color.Red)
                    {
                        button.BackColor = Color.White;
                    }
                }
            }

            if (btnGhe_choose == false)
            {
                ((Button)sender).BackColor = Color.Orange;
                btnGhe_choose = true;
                soGhe = ((Button)sender).Text;
            }
            btnGhe_ThanhToan = ((Button)sender);
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            if (btnGhe_ThanhToan.BackColor == Color.Red)
            {
                MessageBox.Show("Ghế đã được người khác chọn !", "Lỗi !");
                return;
            }

            if (tb_Hoten.Text == null)
            {
                MessageBox.Show("Bạn chưa nhập tên !", "Lỗi !");
                tb_Hoten.Focus();
                return;
            }

            if (nUD_Tuoi.Value == 0)
            {
                MessageBox.Show("Bạn chưa nhập tuổi !", "Lỗi !");
                nUD_Tuoi.Focus();
                return;
            }

            if (btnGhe_ThanhToan == null)
            {
                MessageBox.Show("Bạn chưa chọn ghế !", "Lỗi !");
                return;
            }

            if (Convert.ToInt32(soGhe)%2==0)
            {
                foreach (Button button in tableLayoutPanel2.Controls)
                {
                    if (button.Text == soGhe)
                    {
                        button.BackColor = Color.Red;
                    }
                }
            }
            else
            {
                foreach (Button button in tableLayoutPanel1.Controls)
                {
                    if (button.Text == soGhe)
                    {
                        button.BackColor = Color.Red;
                    }
                }
            }

            MessageBox.Show($"Khách hàng: {tb_Hoten.Text} \nTuổi: {nUD_Tuoi.Value} \nGhế thanh toán: {soGhe} \nGiá vé: {tb_GiaVe.Text} " , "Thanh toán thành công !");

            dataTable.Rows.Add(soGhe, tb_Hoten.Text, nUD_Tuoi.Value, tb_GiaVe.Text);
            dataGridView.DataSource = dataTable;

            tb_Hoten.Text = null;
            nUD_Tuoi.Value = 0;
            tb_GiaVe.Text = null;
        }

        private void nUD_Tuoi_ValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(nUD_Tuoi.Value) < 18)
            {
                tb_GiaVe.Text = Convert.ToString(50000 - (50000 * 20 / 100));
            }
            else if (Convert.ToInt32(nUD_Tuoi.Value) >= 50)
            {
                tb_GiaVe.Text = Convert.ToString(50000 - (50000 * 50 / 100));
            }
            else
            {
                tb_GiaVe.Text = Convert.ToString(50000);
            }
        }
    }
}
