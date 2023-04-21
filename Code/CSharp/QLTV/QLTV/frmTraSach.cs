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
    public partial class frmTraSach : Form
    {
        public frmTraSach()
        {
            InitializeComponent();
        }

        cModify modify;
        DataGridViewCellEventArgs dgvEvent;
        SqlDataAdapter dataAdapter;
        int indexRow;
        bool phatTT = false;
        int phatSL = 0;

        private void frmTraSach_Load(object sender, EventArgs e)
        {
            phatSL = 0;
            phatTT = false;

            gr_XuLy.Enabled = false;
            gr_TimKiem.Enabled = true;

            bt_LamMoi.Enabled = true;
            bt_TraSach.Enabled = false;
            bt_XacNhan.Enabled = false;
            bt_Huy.Enabled = false;

            tb_mpMuon.Text = "";
            tb_maDG.Text = "";
            tb_maSach.Text = "";
            tb_SLMuon.Text = "";
            cb_TinhTrang.SelectedIndex = -1;
            tb_SLTra.Text = "";
            tb_Phat.Text = "0";

            dt_ngayMuon.Value = DateTime.Now;
            dt_ngayTra.Value = DateTime.Now;

            dataGridView_TraSach.Enabled = true;

            modify = new cModify();
            try
            {
                dataGridView_TraSach.DataSource = modify.getAllPhieuMuon();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        private void bt_LamMoi_Click(object sender, EventArgs e)
        {
            frmTraSach_Load(sender, e);
        }

        private void bt_TraSach_Click(object sender, EventArgs e)
        {
            gr_XuLy.Enabled = true;
            gr_TimKiem.Enabled = false;
            bt_TraSach.Enabled = false;
            bt_LamMoi.Enabled = false;
            bt_Huy.Enabled = true;
            bt_XacNhan.Enabled = true;
            dataGridView_TraSach.Enabled = false;

            tb_mpMuon.ReadOnly = true;
            tb_maDG.ReadOnly = true ;
            tb_maSach.ReadOnly = true;
            tb_SLMuon.ReadOnly=true;

            dt_ngayMuon.Enabled = false;
            dt_ngayTra.Enabled = false;

            int compare = DateTime.Compare(DateTime.Now, dt_ngayTra.Value);
            if (compare == 1)
            {
                TimeSpan interval = DateTime.Now.Subtract(dt_ngayTra.Value);

                tb_Phat.Text = (interval.Days * 2000).ToString();
            }
        }

        private void bt_XacNhan_Click(object sender, EventArgs e)
        {
            modify = new cModify();
            
            DataTable dtSoDu = new DataTable();

            string querySoDu = "select soDu " +
                            "from docGia " +
                            "where maDG = '" + tb_maDG.Text + "'";

            using (SqlConnection sqlConnection = cConnection.getConnection())
            {
                sqlConnection.Open();

                dataAdapter = new SqlDataAdapter(querySoDu, sqlConnection);
                dataAdapter.Fill(dtSoDu);

                sqlConnection.Close();
            }

            if (Convert.ToInt32(tb_Phat.Text) > Convert.ToInt32(dtSoDu.Rows[0][0]))
            {
                MessageBox.Show("Số dư trong tài khoản của độc giả không đủ để thanh toán. Hãy nạp thêm!", "Thông báo!");
                return;
            }


            modify = new cModify();
            bool kq = modify.updatePhieuTra(tb_mpMuon.Text, cb_TinhTrang.Text, tb_SLTra.Text, tb_Phat.Text);
            if (kq == true)
            {
                MessageBox.Show("Trả sách thành công!", "Thành công!");
                modify.updateSL_DangMuon(tb_SLTra.Text, "-");
                modify.updateDoanhThu(tb_Phat.Text);
                int result1, result2;
                if (int.TryParse(tb_SLTra.Text, out result1) && int.TryParse(tb_SLMuon.Text, out result2))
                    modify.updatesl_SachMat((result2 - result1).ToString());
                frmTraSach_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Trả sách thất bại!", "Thất bại!");
            }
        }

        private void bt_Huy_Click(object sender, EventArgs e)
        {
            frmTraSach_Load(sender, e);
            
            if (dataGridView_TraSach.RowCount > 0 && dgvEvent != null)
            {
                dataGridView_TraSach.CurrentCell = dataGridView_TraSach.Rows[indexRow].Cells[0];
                dataGridView_TraSach_CellClick(sender, dgvEvent);
            }
        }

        private void bt_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView_TraSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bt_TraSach.Enabled = true;

            dgvEvent = e;

            indexRow = e.RowIndex;
            if (indexRow < 0) return;

            tb_mpMuon.Text = dataGridView_TraSach.Rows[indexRow].Cells[0].Value.ToString();

            tb_maDG.Text = dataGridView_TraSach.Rows[indexRow].Cells[1].Value.ToString();

            tb_maSach.Text = dataGridView_TraSach.Rows[indexRow].Cells[3].Value.ToString();
            tb_SLMuon.Text = dataGridView_TraSach.Rows[indexRow].Cells[6].Value.ToString();
            //tb_SoDu.Text = String.Format(culture, "{0:N0}", dataGridView_DocGia.Rows[index].Cells[8].Value) + " VNĐ";

            dt_ngayMuon.Value = Convert.ToDateTime(dataGridView_TraSach.Rows[indexRow].Cells[4].Value);
            dt_ngayTra.Value = Convert.ToDateTime(dataGridView_TraSach.Rows[indexRow].Cells[5].Value);
        }

        private void cb_TinhTrang_SelectedValueChanged(object sender, EventArgs e)
        {
            
            if (cb_TinhTrang.Text == "Cũ" && dataGridView_TraSach.Rows[indexRow].Cells[7].Value.ToString() == "Mới")
            {
                if (phatTT == false)
                {
                    tb_Phat.Text = (Convert.ToInt32(tb_Phat.Text) + 10000).ToString();
                }
                phatTT = true;
            }
            else if (cb_TinhTrang.Text == dataGridView_TraSach.Rows[indexRow].Cells[7].Value.ToString() && (cb_TinhTrang.Text == "Mới" || cb_TinhTrang.Text == "Cũ"))
            {
                if (phatTT == true)
                {
                    tb_Phat.Text = (Convert.ToInt32(tb_Phat.Text) - 10000).ToString();
                }
                phatTT = false;
            }
        }

        private void tb_SLTra_TextChanged(object sender, EventArgs e)
        {
            int result1, result2;
            if ((int.TryParse(tb_SLTra.Text, out result1) && int.TryParse(tb_SLMuon.Text, out result2) && result1 > result2) || result1<0)
            {
                MessageBox.Show("Số lượng sách trả không hợp lệ!", "Lỗi!");
                tb_SLTra.Text = null;
                tb_SLTra.Focus();
                return;
            }
            else if (int.TryParse(tb_SLTra.Text, out result1) && int.TryParse(tb_SLMuon.Text, out result2))
            {
                modify = new cModify();
                DataTable dtdonGia = new DataTable();
                string querydonGia = "select donGia " +
                            "from Sach " +
                            "where maSach = '" + tb_maSach.Text + "'";
                using (SqlConnection sqlConnection = cConnection.getConnection())
                {
                    sqlConnection.Open();
                    dataAdapter = new SqlDataAdapter(querydonGia, sqlConnection);
                    dataAdapter.Fill(dtdonGia);
                    sqlConnection.Close();
                }
                

                tb_Phat.Text = (Convert.ToInt32(tb_Phat.Text) + (result2 - result1) * Convert.ToInt32(dtdonGia.Rows[0][0]) * 5 - phatSL).ToString();

                phatSL = (result2 - result1) * Convert.ToInt32(dtdonGia.Rows[0][0]) * 5;

            }
            else if (!int.TryParse(tb_SLTra.Text, out result1))
            {
                tb_Phat.Text = (Convert.ToInt32(tb_Phat.Text) - phatSL).ToString();
                phatSL = 0;
            }
        }

        private void tb_TimKiem_TextChanged(object sender, EventArgs e)
        {
            
            if (radioButton_maSach.Checked == true)
            {
                modify = new cModify();
                dataGridView_TraSach.DataSource = modify.searchPhieuMuon("maSach", tb_TimKiem.Text);
            }
            else if (radioButton_docGia.Checked == true)
            {
                dataGridView_TraSach.DataSource = modify.searchPhieuMuon("maDG", tb_TimKiem.Text);
            }
            
        }
    }
}
