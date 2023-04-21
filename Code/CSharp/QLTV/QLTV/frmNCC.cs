using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV
{
    public partial class frmNCC : Form
    {
        public frmNCC()
        {
            InitializeComponent();
        }

        cModify modify;
        string status;

        private void frmNCC_Load(object sender, EventArgs e)
        {
            tb_MaNCC.ReadOnly = true;
            tb_TenNCC.ReadOnly = true;
            tb_SDT.ReadOnly = true;
            tb_DiaChi.ReadOnly = true;

            tb_MaNCC.Text = "";
            tb_TenNCC.Text = "";
            tb_SDT.Text = "";
            tb_DiaChi.Text = "";
            tb_TimKiem.Text = "";

            bt_LamMoi.Enabled = true;
            bt_Them.Enabled = true;
            bt_Sua.Enabled = false;
            bt_Xoa.Enabled = false;
            bt_Luu.Enabled = false;
            bt_Huy.Enabled = false;
            gr_TimKiem.Enabled = true;

            dataGridView_NCC.Enabled = true;
            radioButton_maNCC.Checked = false;
            radioButton_tenNCC.Checked = false;

            modify = new cModify();
            try
            {
                dataGridView_NCC.DataSource = modify.getAllNCC();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            bt_LamMoi.Enabled = false;
            bt_Them.Enabled = false;
            bt_Sua.Enabled = false;
            bt_Xoa.Enabled = false;
            bt_Luu.Enabled = true;
            bt_Huy.Enabled = true;
            gr_TimKiem.Enabled = false;
            dataGridView_NCC.Enabled = false;

            tb_TenNCC.ReadOnly = false;
            tb_SDT.ReadOnly = false;
            tb_DiaChi.ReadOnly = false;
            
            int c = dataGridView_NCC.RowCount;
            if (c > 0)
            {
                string s = dataGridView_NCC.Rows[c - 1].Cells[0].Value.ToString();
                int stt = Int32.Parse((s[3]).ToString()) * 10 + Int32.Parse((s[4]).ToString()) + 1;
                if (stt < 10)
                {
                    tb_MaNCC.Text = "NCC0" + stt.ToString();
                }
                else
                {
                    tb_MaNCC.Text = "NCC" + stt.ToString();
                }
            }
            else
            {
                tb_MaNCC.Text = "NCC01";
            }

            tb_TenNCC.Text = "";
            tb_SDT.Text = "";
            tb_DiaChi.Text = "";

            
            status = "Them";
        }

        private void bt_Huy_Click(object sender, EventArgs e)
        {
            frmNCC_Load(sender, e);
        }

        private void dataGridView_NCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bt_Them.Enabled = true;
            bt_Sua.Enabled = true;
            bt_Xoa.Enabled = true;

            int index = e.RowIndex;
            if (index < 0) return;

            tb_MaNCC.Text = dataGridView_NCC.Rows[index].Cells[0].Value.ToString();
            tb_TenNCC.Text = dataGridView_NCC.Rows[index].Cells[1].Value.ToString();
            tb_SDT.Text = dataGridView_NCC.Rows[index].Cells[2].Value.ToString();
            tb_DiaChi.Text = dataGridView_NCC.Rows[index].Cells[3].Value.ToString();
        }

        private void bt_LamMoi_Click(object sender, EventArgs e)
        {
            frmNCC_Load(sender, e);
        }

        private void bt_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_Luu_Click(object sender, EventArgs e)
        {
            if (status == "Them")
            {
                modify = new cModify();
                bool kq = modify.insertNCC(tb_MaNCC.Text, tb_TenNCC.Text, tb_SDT.Text, tb_DiaChi.Text);
                if (kq == true)
                {
                    MessageBox.Show("Thêm dữ liệu thành công!", "Thành công!");
                    modify.updateslNCC("+");
                    frmNCC_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Thêm dữ liệu thất bại!", "Thất bại!");
                }
            }
            else if (status == "Sua")
            {
                modify = new cModify();
                bool kq = modify.updateNCC(tb_MaNCC.Text, tb_TenNCC.Text, tb_SDT.Text, tb_DiaChi.Text);
                if (kq == true)
                {
                    MessageBox.Show("Sửa dữ liệu thành công!", "Thành công!");
                    frmNCC_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Sửa dữ liệu thất bại!", "Thất bại!");
                }
            }

        }

        private void bt_Sua_Click(object sender, EventArgs e)
        {
            bt_LamMoi.Enabled = false;
            bt_Them.Enabled = false;
            bt_Sua.Enabled = false;
            bt_Xoa.Enabled = false;
            bt_Luu.Enabled = true;
            bt_Huy.Enabled = true;
            gr_TimKiem.Enabled = false;
            dataGridView_NCC.Enabled = false;

            tb_TenNCC.ReadOnly = false;
            tb_SDT.ReadOnly = false;
            tb_DiaChi.ReadOnly = false;
            
            status = "Sua";
        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                modify = new cModify();
                bool kq = modify.deleteNCC(tb_MaNCC.Text);
                if (kq == true)
                {
                    MessageBox.Show("Xóa dữ liệu thành công!", "Thành công!");
                    modify.updateslNCC("-");
                    frmNCC_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Xóa dữ liệu thất bại!", "Thất bại!");
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void tb_TimKiem_TextChanged(object sender, EventArgs e)
        {
            if (radioButton_maNCC.Checked == true)
            {
                modify = new cModify();
                dataGridView_NCC.DataSource =  modify.searchNCC("ma", tb_TimKiem.Text);
            }
            else if (radioButton_tenNCC.Checked == true)
            {
                dataGridView_NCC.DataSource =  modify.searchNCC("ten", tb_TimKiem.Text);
            }
        }
    }
}
