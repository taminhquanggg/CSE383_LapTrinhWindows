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
    public partial class frmTimKiem : Form
    {
        public frmTimKiem()
        {
            InitializeComponent();
        }

        cModify modify;

        private void frmTimKiem_Load(object sender, EventArgs e)
        {
            radioButton_MaSach.Checked = false;
            radioButton_TenSach.Checked=false;
            radioButton_TacGia.Checked=false;
            radioButton_LoaiSach.Checked=false;
            radioButton_MaDG.Checked=false;
        }

        private void tb_TimKiem_TextChanged(object sender, EventArgs e)
        {
            if (radioButton_MaSach.Checked == true)
            {
                modify = new cModify();
                dataGridView_TimKiem.DataSource = modify.searchSach("maSach", tb_TimKiem.Text);

                DataGridViewImageColumn pic = new DataGridViewImageColumn();
                pic = (DataGridViewImageColumn)dataGridView_TimKiem.Columns[9];
                pic.ImageLayout = DataGridViewImageCellLayout.Zoom;
            }
            else if (radioButton_TenSach.Checked == true)
            {
                modify = new cModify();
                dataGridView_TimKiem.DataSource = modify.searchSach("tenSach", tb_TimKiem.Text);

                DataGridViewImageColumn pic = new DataGridViewImageColumn();
                pic = (DataGridViewImageColumn)dataGridView_TimKiem.Columns[9];
                pic.ImageLayout = DataGridViewImageCellLayout.Zoom;
            }
            else if (radioButton_TacGia.Checked == true )
            {
                modify = new cModify();
                dataGridView_TimKiem.DataSource = modify.searchSach("tacGia", tb_TimKiem.Text);

                DataGridViewImageColumn pic = new DataGridViewImageColumn();
                pic = (DataGridViewImageColumn)dataGridView_TimKiem.Columns[9];
                pic.ImageLayout = DataGridViewImageCellLayout.Zoom;
            }
            else if (radioButton_LoaiSach.Checked == true)
            {
                modify = new cModify();
                dataGridView_TimKiem.DataSource = modify.searchSach("LoaiSach.tenLoaiSach", tb_TimKiem.Text);

                DataGridViewImageColumn pic = new DataGridViewImageColumn();
                pic = (DataGridViewImageColumn)dataGridView_TimKiem.Columns[9];
                pic.ImageLayout = DataGridViewImageCellLayout.Zoom;
            }
            else if (radioButton_MaDG.Checked == true)
            {
                modify = new cModify();
                dataGridView_TimKiem.DataSource = modify.searchPhieuMuon("maSach", tb_TimKiem.Text);
            }
        }

        private void radioButton_MaSach_CheckedChanged(object sender, EventArgs e)
        {
            radioButton_MaDG.Checked = false;
        }

        private void radioButton_MaDG_CheckedChanged(object sender, EventArgs e)
        {
            radioButton_MaSach.Checked = false;
            radioButton_TenSach.Checked = false;
            radioButton_TacGia.Checked = false;
            radioButton_LoaiSach.Checked = false;
        }
    }
}
