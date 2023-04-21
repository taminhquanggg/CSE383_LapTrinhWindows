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

namespace TinhTienKhamRang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private DataTable dataTable = new DataTable();
        private static int stt = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            dataTable.Columns.Add("STT");
            dataTable.Columns.Add("Tên khách hàng");
            dataTable.Columns.Add("Dịch vụ");
            dataTable.Columns.Add("Thành tiền");

            if (System.IO.File.Exists(@"data.json"))
            {
                System.IO.StreamReader reader = new System.IO.StreamReader(@"data.json");
                string str = reader.ReadToEnd();
                reader.Close();
                dataTable = JsonConvert.DeserializeObject<DataTable>(str);
            }

            dataGridView.DataSource = dataTable;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_Name.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng!", "Thông báo!");
                tb_Name.Focus();
            }
            else if (!cb_Item1.Checked && !cb_Item2.Checked && !cb_Item3.Checked && !cb_Item4.Checked && Convert.ToInt32(nUD_Item5.Value) == 0)
            {
                MessageBox.Show("Vui lòng chọn dịch vụ để thanh toán!", "Thông báo!");
            }
            else
            {
                stt++;
                string dichVu = "";
                if (cb_Item1.Checked)
                {
                    tb_money.Text = (Convert.ToInt32(tb_money.Text) + 100000).ToString();
                    if (dichVu.Length > 0)
                        dichVu += ", ";
                    dichVu += "Cạo vôi";
                }
                if (cb_Item2.Checked)
                {
                    tb_money.Text = (Convert.ToInt32(tb_money.Text) + 1200000).ToString();
                    if (dichVu.Length > 0)
                        dichVu += ", ";
                    dichVu += "Tẩy trắng";
                }
                if (cb_Item3.Checked)
                {
                    tb_money.Text = (Convert.ToInt32(tb_money.Text) + 150000).ToString();
                    if (dichVu.Length > 0)
                        dichVu += ", ";
                    dichVu += "Chụp hình";
                }
                if (cb_Item4.Checked)
                {
                    tb_money.Text = (Convert.ToInt32(tb_money.Text) + 100000).ToString();
                    if (dichVu.Length > 0)
                        dichVu += ", ";
                    dichVu += "Lấy cao";
                }
                if (Convert.ToInt32(nUD_Item5.Value) > 0)
                {
                    tb_money.Text = (Convert.ToInt32(tb_money.Text) + Convert.ToInt32(nUD_Item5.Value * 90000)).ToString();
                    if (dichVu.Length > 0)
                        dichVu += ", ";
                    dichVu += $"Hàn {Convert.ToInt32(nUD_Item5.Value)} chiếc răng";
                }
                tb_money.Text += " VNĐ";
                dataTable.Rows.Add(stt.ToString(), tb_Name.Text, dichVu, tb_money.Text);

                string jsonstr = JsonConvert.SerializeObject(dataTable);
                System.IO.File.WriteAllText(@"data.json", jsonstr);
                MessageBox.Show($"Tổng tiền của khách hàng {tb_Name.Text} là {tb_money.Text} !", "Thông báo!");

                tb_Name.Text = "";
                cb_Item1.Checked = false;
                cb_Item2.Checked = false;
                cb_Item3.Checked = false;
                cb_Item4.Checked = false;
                nUD_Item5.Value = 0;
                tb_money.Text = "0";
            }
        }
    }
}
