using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinhTienKhamRang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string name;
        double money;
        private void tb_Name_Leave(object sender, EventArgs e)
        {
            name = tb_Name.Text;
            if (name == "")
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng!", "Thông báo!");
                tb_Name.Focus();
            }
        }

        private void bt_calc_Click(object sender, EventArgs e)
        {
            if (!cb_item1.Checked && !cb_item2.Checked && !cb_item3.Checked && !cb_item4.Checked && Convert.ToInt32(nUD_item5.Value)==0)
            {
                MessageBox.Show("Vui lòng chọn dịch vụ để thanh toán!", "Thông báo!");
            }
            else
            {
                money = 0;
                if (cb_item1.Checked)
                {
                    money += 100000;
                }
                if (cb_item2.Checked)
                {
                    money += 1200000;
                }
                if (cb_item3.Checked)
                {
                    money += 150000;
                }
                if (cb_item4.Checked)
                {
                    money += 100000;
                }
                if (Convert.ToInt32(nUD_item5.Value) > 0)
                {
                    money += Convert.ToInt32(nUD_item5.Value * 90000);
                }
                tb_totalMoney.Text = Convert.ToString(money) + "VNĐ";
                MessageBox.Show($"Tổng tiền của khách hàng {name} là {money} VNĐ !", "Thông báo!");
            }
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
