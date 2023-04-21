using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLTV
{
    public partial class frmDangKy : Form
    {
        public frmDangKy()
        {
            InitializeComponent();
        }

        cModify modify;
        string _sex;

        private void frmDangKy_Load(object sender, EventArgs e)
        {
            tb_tenNV.Text = "";
            dt_ngaySinh.Value = DateTime.Now;
            radioButton_nam.Checked = false;
            radioButton_nu.Checked = false;
            tb_SDT.Text = "";
            tb_diaChi.Text = "";
            tb_TK.Text = "";
            tb_MK.Text = "";
            tb_reMK.Text = "";
        }

        private void bt_dangKy_Click(object sender, EventArgs e)
        {
            if (tb_MK.Text != tb_reMK.Text)
            {
                MessageBox.Show("Mật khẩu không khớp!", "Lỗi!");
                tb_MK.Text = "";
                tb_reMK.Text = "";
                tb_MK.Focus();
                return;
            }

            if (radioButton_nam.Checked == true)
            {
                _sex = "Nam";
            }
            else if (radioButton_nu.Checked == true)
            {
                _sex = "Nữ";
            }
            modify = new cModify();
            bool kq = modify.insertNV(tb_tenNV.Text, dt_ngaySinh.Value, _sex, tb_SDT.Text, tb_diaChi.Text, tb_TK.Text, tb_MK.Text);
            if (kq == true)
            {
                MessageBox.Show("Đăng ký thành công!", "Thành công!");
                frmDangKy_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Đăng ký thất bại!", "Thất bại!");
            }



        }

        private void bt_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
