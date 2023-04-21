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
using DevExpress.LookAndFeel;
using DevExpress.XtraReports.UI;

namespace QLTV
{
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
        }

        cModify modify;
        string status;

        private void frmThongKe_Load(object sender, EventArgs e)
        {

            modify = new cModify();
            DataTable dt = new DataTable();

            try
            {
                dt = modify.getThongKe();
                dataGridView_Thongke.DataSource = modify.getDS_QuaHan();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }

            tb_SLLoai.Text = dt.Rows[0][1].ToString();
            tb_SLSach.Text = dt.Rows[0][2].ToString();
            tb_SLMuon.Text = dt.Rows[0][3].ToString();
            tb_SLMat.Text = dt.Rows[0][4].ToString();
            tb_DoanhThu.Text = dt.Rows[0][5].ToString();
            tb_slNCC.Text = dt.Rows[0][7].ToString();
            tb_slDG.Text = dt.Rows[0][6].ToString();


        }

        private void bt_NCC_Click(object sender, EventArgs e)
        {
            modify = new cModify();
            try
            {
                dataGridView_Thongke.DataSource = modify.getAllNCC();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
            status = "NCC";
        }

        private void bt_LoaiSach_Click(object sender, EventArgs e)
        {
            modify = new cModify();
            try
            {
                dataGridView_Thongke.DataSource = modify.getAllLoaiSach();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
            status = "LoaiSach";
        }

        private void bt_DG_Click(object sender, EventArgs e)
        {
            modify = new cModify();
            try
            {
                dataGridView_Thongke.DataSource = modify.getAllDocGia();
                if (dataGridView_Thongke.RowCount > 0)
                {
                    DataGridViewImageColumn pic = new DataGridViewImageColumn();
                    pic = (DataGridViewImageColumn)dataGridView_Thongke.Columns[9];
                    pic.ImageLayout = DataGridViewImageCellLayout.Zoom;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
            status = "DG";
        }

        private void bt_Sach_Click(object sender, EventArgs e)
        {
            modify = new cModify();
            try
            {
                dataGridView_Thongke.DataSource = modify.getAllSach();
                if (dataGridView_Thongke.RowCount > 0)
                {
                    DataGridViewImageColumn pic = new DataGridViewImageColumn();
                    pic = (DataGridViewImageColumn)dataGridView_Thongke.Columns[9];
                    pic.ImageLayout = DataGridViewImageCellLayout.Zoom;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
            status = "Sach";
        }

        private void bt_NV_Click(object sender, EventArgs e)
        {
            modify = new cModify();
            try
            {
                dataGridView_Thongke.DataSource = modify.getInfoNV();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
            status = "NV";
        }

        private void bt_In_Click(object sender, EventArgs e)
        {
            if (status == "NCC")
            {
                reportNCC report = new reportNCC();
                report.ShowPreview();
            }
            else if (status == "DG")
            {
                reportDG report = new reportDG();
                report.ShowPreview();
            }
            else if (status == "LoaiSach")
            {
                reportLoaiSach report = new reportLoaiSach();
                report.ShowPreview();
            }
            else if (status == "Sach")
            {
                reportSach report = new reportSach();
                report.ShowPreview();
            }
            else if (status == "NV")
            {
                reportNV report = new reportNV();
                report.ShowPreview();
            }
            
        }
    }
}
