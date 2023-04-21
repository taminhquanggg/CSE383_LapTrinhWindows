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
    public partial class frmThongTin : Form
    {
        frmMainForm frmForm;
        cModify modify;
        string _sex;

        public frmThongTin(frmMainForm frmMain)
        {
            InitializeComponent();
            frmForm = frmMain;
        }

        private void frmThongTin_Load(object sender, EventArgs e)
        {
            tb_TenNV.ReadOnly = true;
            dt_NgaySinh.Enabled = false;
            radioButton_nam.Enabled = false;
            radioButton_nu.Enabled = false;
            tb_SDT.ReadOnly = true;
            tb_DiaChi.ReadOnly = true;

            bt_Sua.Enabled = true;
            bt_Luu.Enabled = false;
            bt_Huy.Enabled = false;

            DataTable dt = new DataTable();
            modify = new cModify();
            try
            {
                dt = modify.getAllNV(frmForm.tk);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }

            tb_TenNV.Text = dt.Rows[0][0].ToString();
            dt_NgaySinh.Value = Convert.ToDateTime(dt.Rows[0][1]);

            if (dt.Rows[0][2].ToString() == "Nam")
            {
                radioButton_nam.Checked = true;
            }
            else if (dt.Rows[0][2].ToString() == "Nữ")
            {
                radioButton_nu.Checked = true;
            }

            tb_SDT.Text = dt.Rows[0][3].ToString();
            tb_DiaChi.Text = dt.Rows[0][4].ToString();
        }

        private void bt_Huy_Click(object sender, EventArgs e)
        {
            frmThongTin_Load(sender, e);
        }

        private void bt_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_Sua_Click(object sender, EventArgs e)
        {
            bt_Sua.Enabled = false;
            bt_Luu.Enabled = true;
            bt_Huy.Enabled = true;

            tb_TenNV.ReadOnly = false;
            dt_NgaySinh.Enabled = true;
            radioButton_nam.Enabled = true;
            radioButton_nu.Enabled = true;
            tb_SDT.ReadOnly = false;
            tb_DiaChi.ReadOnly = false;


        }

        private void bt_Luu_Click(object sender, EventArgs e)
        {
            modify = new cModify();
            if (radioButton_nam.Checked == true)
            {
                _sex = "Nam";
            }
            else if (radioButton_nu.Checked == true)
            {
                _sex = "Nữ";
            }

            bool kq = modify.updateNV(frmForm.tk, tb_TenNV.Text, dt_NgaySinh.Value, _sex, tb_SDT.Text, tb_DiaChi.Text);
            if (kq == true)
            {
                MessageBox.Show("Thay đổi thông tin thành công!", "Thành công!");
                frmThongTin_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Thay đổi thông tin  thất bại!", "Thất bại!");
            }
        }
    }
}
