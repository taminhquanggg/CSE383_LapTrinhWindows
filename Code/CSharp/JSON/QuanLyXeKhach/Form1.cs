using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace QuanLyXeKhach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataTable dataTable = new DataTable();
        private Button btn_GheChoose = null;

        private void changeRedButton(string v)
        {
            foreach (Button btn in tableLayoutPanel1.Controls)
            {
                if (btn.Name == "btn_ghe" + v)
                {
                    btn.BackColor = Color.Red;
                }
            }
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataTable.Columns.Add("Vị trí ngồi");
            dataTable.Columns.Add("Tên khách");
            dataTable.Columns.Add("Tuổi");
            dataTable.Columns.Add("Thành tiền");

            if (System.IO.File.Exists(@"data.json"))
            {
                System.IO.StreamReader reader = new System.IO.StreamReader(@"data.json");
                string str = reader.ReadToEnd();
                reader.Close();
                dataTable = JsonConvert.DeserializeObject<DataTable>(str);
            }

            dataGridView.DataSource = dataTable;
            if (dataGridView.Rows.Count>0)
            {
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    changeRedButton(dataGridView.Rows[i].Cells[0].Value.ToString());
                }
            }
            
        }

        private void btn_ghe1_Click(object sender, EventArgs e)
        {
            if (((Button)sender).BackColor == Color.Red)
            {
                MessageBox.Show("Ghế đã được người khác chọn !", "Lỗi !");
                return;
            }
            
            if (btn_GheChoose == null ) {
                ((Button)sender).BackColor = Color.Orange;
                btn_GheChoose = ((Button)sender);
            }
            else
            {
                btn_GheChoose.BackColor = Color.White;
                ((Button)sender).BackColor= Color.Orange;
                btn_GheChoose = ((Button)sender);
            }
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {

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

            if (btn_GheChoose == null)
            {
                MessageBox.Show("Bạn chưa chọn ghế !", "Lỗi !");
                return;
            }

            btn_GheChoose.BackColor = Color.Red;
            dataTable.Rows.Add(btn_GheChoose.Text, tb_Hoten.Text, nUD_Tuoi.Value, tb_GiaVe.Text);
            string jsonstr = JsonConvert.SerializeObject(dataTable);
            System.IO.File.WriteAllText(@"data.json", jsonstr);

            tb_Hoten.Text = null;
            nUD_Tuoi.Value = 0;
            tb_GiaVe.Text = null;
            btn_GheChoose = null;
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
