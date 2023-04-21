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
    public partial class frmLoaiSach : Form
    {
        public frmLoaiSach()
        {
            InitializeComponent();
        }

        cModify modify;
        string status;
        

        private void frmLoaiSach_Load(object sender, EventArgs e)
        {
            tb_MaLoai.ReadOnly = true;
            tb_TenLoai.ReadOnly = true;

            radioButton_maLoai.Checked = false;
            radioButton_tenLoai.Checked = false;

            tb_MaLoai.Text = "";
            tb_TenLoai.Text = "";

            bt_LamMoi.Enabled = true;
            bt_Them.Enabled = true;
            bt_Sua.Enabled = false;
            bt_Xoa.Enabled = false;
            bt_Luu.Enabled = false;
            bt_Huy.Enabled = false;
            gr_TimKiem.Enabled = true;

            dataGridView_LoaiSach.Enabled = true;
            
            modify = new cModify();
            try
            {
                dataGridView_LoaiSach.DataSource = modify.getAllLoaiSach();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        private void bt_lamMoi_Click(object sender, EventArgs e)
        {
            frmLoaiSach_Load(sender, e);
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
            dataGridView_LoaiSach.Enabled = false;

            tb_TenLoai.ReadOnly = false;

            status = "Sua";
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
            dataGridView_LoaiSach.Enabled = false;

            tb_TenLoai.ReadOnly = false;

            int c = dataGridView_LoaiSach.RowCount;
            if (c > 0)
            {
                string s = dataGridView_LoaiSach.Rows[c - 1].Cells[0].Value.ToString();
                int stt = Int32.Parse((s[2]).ToString()) * 100 + Int32.Parse((s[3]).ToString()) * 10 + Int32.Parse((s[4]).ToString()) + 1;
                if (stt < 10)
                {
                    tb_MaLoai.Text = "LS00" + stt.ToString();
                }
                else if (stt < 100)
                {
                    tb_MaLoai.Text = "LS0" + stt.ToString();
                }
                else
                {
                    tb_MaLoai.Text = "LS" + stt.ToString();
                }
            }
            else
            {
                tb_MaLoai.Text = "LS001";
            }

            tb_TenLoai.Text = "";

            status = "Them";
        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                modify = new cModify();
                bool kq = modify.deleteLoaiSach(tb_MaLoai.Text);
                if (kq == true)
                {
                    MessageBox.Show("Xóa dữ liệu thành công!", "Thành công!");
                    modify.updateSL_LoaiSach("-");
                    frmLoaiSach_Load(sender, e);
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

        private void bt_Luu_Click(object sender, EventArgs e)
        {
            if (status == "Them")
            {
                modify = new cModify();
                bool kq = modify.insertLoaiSach(tb_MaLoai.Text, tb_TenLoai.Text);
                if (kq == true)
                {
                    MessageBox.Show("Thêm dữ liệu thành công!", "Thành công!");
                    modify.updateSL_LoaiSach("+");
                    frmLoaiSach_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Thêm dữ liệu thất bại!", "Thất bại!");
                }
            }
            else if (status == "Sua")
            {
                modify = new cModify();
                bool kq = modify.updateLoaiSach(tb_MaLoai.Text, tb_TenLoai.Text);
                if (kq == true)
                {
                    MessageBox.Show("Sửa dữ liệu thành công!", "Thành công!");
                    frmLoaiSach_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Sửa dữ liệu thất bại!", "Thất bại!");
                }
            }
        }

        private void bt_Huy_Click(object sender, EventArgs e)
        {
            frmLoaiSach_Load(sender, e);
        }

        private void bt_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView_LoaiSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bt_Them.Enabled = true;
            bt_Sua.Enabled = true;
            bt_Xoa.Enabled = true;

            int index = e.RowIndex;
            if (index < 0) return;

            tb_MaLoai.Text = dataGridView_LoaiSach.Rows[index].Cells[0].Value.ToString();
            tb_TenLoai.Text = dataGridView_LoaiSach.Rows[index].Cells[1].Value.ToString();
            
        }

        private void tb_TimKiem_TextChanged(object sender, EventArgs e)
        {
            
            if (radioButton_maLoai.Checked == true)
            {
                modify = new cModify();
                dataGridView_LoaiSach.DataSource = modify.searchLoaiSach("ma", tb_TimKiem.Text);
            }
            else if (radioButton_tenLoai.Checked == true)
            {
                dataGridView_LoaiSach.DataSource = modify.searchLoaiSach("ten", tb_TimKiem.Text);
            }
        }
    }
}
