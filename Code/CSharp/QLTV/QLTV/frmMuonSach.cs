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
    public partial class frmMuonSach : Form
    {
        public frmMuonSach()
        {
            InitializeComponent();
        }

        cModify modify;
        DataGridViewCellEventArgs dgvEvent;
        SqlDataAdapter dataAdapter;

        private void frmMuonSach_Load(object sender, EventArgs e)
        {
            radioButton_maSach.Checked = false;
            radioButton_maDG.Checked = false;

            dt_ngayTao.Value = DateTime.Now;
            dt_ngayMuon.Value = DateTime.Now;
            dt_ngayTra.Value = DateTime.Now.AddDays(30);


            //cb_maSach.DropDownStyle = ComboBoxStyle.DropDown;

            tb_mpMuon.Text = "";
            cb_maDG.Text = "";
            cb_mpMuon.Text = "";
            cb_maSach.Text = "";
            tb_SL.Text = "";
            cb_tinhTrang.Text = "";
            tb_infoMaSach.Text = "";
            tb_infoTenSach.Text = "";
            tb_infoTacGia.Text = "";
            tb_infoNCC.Text = "";
            tb_infoDonGia.Text = "";
            tb_infoTinhTrang.Text = "";

            gr_infoPhieu.Enabled = true;
            gr_infoSach.Enabled = true;
            gr_themPhieu.Enabled = true;
            tb_navBar.Enabled = true;

            tb_mpMuon.ReadOnly = true;
            tb_SL.ReadOnly = true;
            tb_infoMaSach.ReadOnly = true;
            tb_infoTenSach.ReadOnly = true;
            tb_infoTacGia.ReadOnly = true;
            tb_infoNCC.ReadOnly = true;
            tb_infoDonGia.ReadOnly = true;
            tb_infoTinhTrang.ReadOnly = true;

            dt_ngayTao.Enabled = false;
            cb_maDG.Enabled = false;
           
            cb_mpMuon.Enabled = false;
            cb_maSach.Enabled = false;
            dt_ngayMuon.Enabled = false;
            dt_ngayTra.Enabled = false;
            cb_tinhTrang.Enabled = false;

            bt_Luu.Enabled = false;
            bt_HuyPhieu.Enabled = false;
            bt_LamMoi.Enabled = true;
            bt_Them.Enabled = true;
            bt_GiaHan.Enabled = false;
            bt_ChoMuon.Enabled = false;
            bt_Huy.Enabled = false;
            bt_MuonMoi.Enabled = true;
            gr_TimKiem.Enabled = true;




            dataGridView_MuonSach.Enabled = true;

            modify = new cModify();
            try
            {
                dataGridView_MuonSach.DataSource = modify.getAllPhieuMuon();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }

            using (SqlConnection sqlConnection = cConnection.getConnection())
            {
                DataTable dtDG = new DataTable();
                string queryDG = "select maDG from docGia where ngayHetHan>GETDATE()";
                DataTable dtmaPhieu = new DataTable();
                string queryMP = "select maPhieu from phieuMuon where maSach is null";
                DataTable dtMS = new DataTable();
                string queryMS = "select maSach from Sach";

                sqlConnection.Open();

                dataAdapter = new SqlDataAdapter(queryDG, sqlConnection);
                dataAdapter.Fill(dtDG);
                cb_maDG.DataSource = dtDG;
                cb_maDG.DisplayMember = "maDG";
                cb_maDG.ValueMember = "maDG";

                dataAdapter = new SqlDataAdapter(queryMP, sqlConnection);
                dataAdapter.Fill(dtmaPhieu);
                cb_mpMuon.DataSource = dtmaPhieu;
                cb_mpMuon.DisplayMember = "maPhieu";
                cb_mpMuon.ValueMember = "maPhieu";

                dataAdapter = new SqlDataAdapter(queryMS, sqlConnection);
                dataAdapter.Fill(dtMS);
                cb_maSach.DataSource = dtMS;
                cb_maSach.DisplayMember = "maSach";
                cb_maSach.ValueMember = "maSach";

                sqlConnection.Close();
            }
        }

        private void bt_LamMoi_Click(object sender, EventArgs e)
        {
            frmMuonSach_Load(sender, e);
        }

        private void bt_MuonMoi_Click(object sender, EventArgs e)
        {
            gr_TimKiem.Enabled = false;
            gr_themPhieu.Enabled = false;
            bt_LamMoi.Enabled = false;
            bt_MuonMoi.Enabled = false;
            bt_ChoMuon.Enabled = true;
            bt_Huy.Enabled = true;
            bt_GiaHan.Enabled = false;

            dataGridView_MuonSach.Enabled = false;

            cb_mpMuon.Enabled = true;

            cb_maSach.Enabled = true;
            tb_SL.ReadOnly = false;
            dt_ngayMuon.Enabled = true;
            cb_tinhTrang.Enabled = true;

            cb_mpMuon.DropDownStyle = ComboBoxStyle.DropDownList;

            tb_mpMuon.Text = "";
            dt_ngayTao.Value = DateTime.Now;
            tb_SL.Text = "";
            tb_infoMaSach.Text = "";
            tb_infoTenSach.Text = "";
            tb_infoTacGia.Text = "";
            tb_infoNCC.Text = "";
            tb_infoDonGia.Text = "";
            tb_infoTinhTrang.Text = "";

            dt_ngayMuon.Value = DateTime.Now;
            dt_ngayTra.Value = DateTime.Now.AddDays(30);



            //using (SqlConnection sqlConnection = cConnection.getConnection())
            //{
            //    DataTable dtDG = new DataTable();
            //    string queryDG = "select maDG from docGia";
            //    DataTable dtmaPhieu = new DataTable();
            //    string queryMP = "select maPhieu from phieuMuon where maSach is null";
            //    DataTable dtMS = new DataTable();
            //    string queryMS = "select maSach from Sach";

            //    sqlConnection.Open();

            //    dataAdapter = new SqlDataAdapter(queryDG, sqlConnection);
            //    dataAdapter.Fill(dtDG);
            //    cb_maDG.DataSource = dtDG;
            //    cb_maDG.DisplayMember = "maDG";
            //    cb_maDG.ValueMember = "maDG";

            //    dataAdapter = new SqlDataAdapter(queryMP, sqlConnection);
            //    dataAdapter.Fill(dtmaPhieu);
            //    cb_mpMuon.DataSource = dtmaPhieu;
            //    cb_mpMuon.DisplayMember = "maPhieu";
            //    cb_mpMuon.ValueMember = "maPhieu";

            //    dataAdapter = new SqlDataAdapter(queryMS, sqlConnection);
            //    dataAdapter.Fill(dtMS);
            //    cb_maSach.DataSource = dtMS;
            //    cb_maSach.DisplayMember = "maSach";
            //    cb_maSach.ValueMember = "maSach";

            //    sqlConnection.Close();
            //}
        }

        private void bt_ChoMuon_Click(object sender, EventArgs e)
        {
            modify = new cModify();

            DataTable dtdonGia = new DataTable();
            DataTable dtSoDu = new DataTable();

            string querydonGia = "select donGia " +
                            "from Sach " +
                            "where maSach = '" + cb_maSach.SelectedValue.ToString() + "'";

            string querySoDu = "select soDu " +
                            "from docGia " +
                            "where maDG = '" + cb_maDG.SelectedValue.ToString() + "'";

            using (SqlConnection sqlConnection = cConnection.getConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(querydonGia, sqlConnection);
                dataAdapter.Fill(dtdonGia);

                dataAdapter = new SqlDataAdapter(querySoDu, sqlConnection);
                dataAdapter.Fill(dtSoDu);

                sqlConnection.Close();
            }

            int thanhToan = Convert.ToInt32(dtdonGia.Rows[0][0]) * Convert.ToInt32(tb_SL.Text);

            if (thanhToan > Convert.ToInt32(dtSoDu.Rows[0][0]))
            {
                MessageBox.Show("Số dư trong tài khoản của độc giả không đủ để thanh toán!", "Thông báo!");
                return;
            }

            bool kq = modify.insertTTPhieu(cb_mpMuon.SelectedValue.ToString(), cb_maSach.SelectedValue.ToString(), tb_SL.Text, dt_ngayMuon.Value, dt_ngayTra.Value, cb_tinhTrang.Text);
            if (kq == true)
            {
                string updateSoDu = "update docGia set soDu = " + (Convert.ToInt32(dtSoDu.Rows[0][0]) - thanhToan).ToString() + "where maDG = '" + cb_maDG.SelectedValue.ToString() + "'";
                string updateSL = "update Sach set soLuong = soLuong - " + tb_SL.Text + " where maSach = '" + cb_maSach.SelectedValue.ToString() + "'";

                using (SqlConnection sqlConnection = cConnection.getConnection())
                {
                    sqlConnection.Open();
                    try
                    {
                        SqlCommand scSoDu = new SqlCommand(updateSoDu, sqlConnection);
                        SqlCommand scSL = new SqlCommand(updateSL, sqlConnection);
                        scSoDu.ExecuteNonQuery();
                        scSL.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi : " + ex.ToString(), "Lỗi!");
                        return;
                    }
                    finally
                    {
                        sqlConnection.Close();
                    }
                }
                modify.updateSL_DangMuon(tb_SL.Text, "+");
                modify.updateDoanhThu(thanhToan.ToString());
                MessageBox.Show("Đăng ký mượn thành công!", "Thành công!");
                
                frmMuonSach_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Đăng ký mượn thất bại!", "Thất bại!");
            }
        }

        private void bt_GiaHan_Click(object sender, EventArgs e)
        {
            int compare = DateTime.Compare(DateTime.Now, dt_ngayTra.Value);
            if (compare <= 0)
            {
                modify = new cModify();

                DataTable dtdonGia = new DataTable();
                DataTable dtSoDu = new DataTable();

                string querydonGia = "select donGia " +
                                "from Sach " +
                                "where maSach = '" + cb_maSach.SelectedValue.ToString() + "'";

                string querySoDu = "select soDu " +
                                "from docGia " +
                                "where maDG = '" + cb_maDG.SelectedValue.ToString() + "'";

                using (SqlConnection sqlConnection = cConnection.getConnection())
                {
                    sqlConnection.Open();
                    dataAdapter = new SqlDataAdapter(querydonGia, sqlConnection);
                    dataAdapter.Fill(dtdonGia);

                    dataAdapter = new SqlDataAdapter(querySoDu, sqlConnection);
                    dataAdapter.Fill(dtSoDu);

                    sqlConnection.Close();
                }

                int thanhToan = Convert.ToInt32(dtdonGia.Rows[0][0]) * Convert.ToInt32(tb_SL.Text);

                if (thanhToan > Convert.ToInt32(dtSoDu.Rows[0][0]))
                {
                    MessageBox.Show("Số dư trong tài khoản của độc giả không đủ để gia hạn!", "Thông báo!");
                    return;
                }

                bool kq = modify.updatePhieuMuon(tb_mpMuon.Text, DateTime.Now, DateTime.Now.AddDays(30));
                if (kq == true)
                {
                    string updateSoDu = "update docGia set soDu = " + (Convert.ToInt32(dtSoDu.Rows[0][0]) - thanhToan).ToString() + "where maDG = '" + cb_maDG.SelectedValue.ToString() + "'";
                    
                    using (SqlConnection sqlConnection = cConnection.getConnection())
                    {
                        sqlConnection.Open();
                        try
                        {
                            SqlCommand scSoDu = new SqlCommand(updateSoDu, sqlConnection);
                            scSoDu.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi : " + ex.ToString(), "Lỗi!");
                            return;
                        }
                        finally
                        {
                            sqlConnection.Close();
                        }
                    }
                    MessageBox.Show("Gia hạn thành công!", "Thành công!");
                    modify.updateDoanhThu(thanhToan.ToString());
                    frmMuonSach_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Gia hạn thất bại!", "Thất bại!");
                }
            }

            else
            {
                TimeSpan interval = DateTime.Now.Subtract(dt_ngayTra.Value);

                modify = new cModify();

                DataTable dtdonGia = new DataTable();
                DataTable dtSoDu = new DataTable();

                string querydonGia = "select donGia " +
                                "from Sach " +
                                "where maSach = '" + cb_maSach.SelectedValue.ToString() + "'";

                string querySoDu = "select soDu " +
                                "from docGia " +
                                "where maDG = '" + cb_maDG.SelectedValue.ToString() + "'";

                using (SqlConnection sqlConnection = cConnection.getConnection())
                {
                    sqlConnection.Open();
                    dataAdapter = new SqlDataAdapter(querydonGia, sqlConnection);
                    dataAdapter.Fill(dtdonGia);

                    dataAdapter = new SqlDataAdapter(querySoDu, sqlConnection);
                    dataAdapter.Fill(dtSoDu);

                    sqlConnection.Close();
                }

                int thanhToan = Convert.ToInt32(dtdonGia.Rows[0][0]) * Convert.ToInt32(tb_SL.Text) + interval.Days * 1000;

                if (thanhToan > Convert.ToInt32(dtSoDu.Rows[0][0]))
                {
                    MessageBox.Show("Số dư trong tài khoản của độc giả không đủ để gia hạn!", "Thông báo!");
                    return;
                }

                bool kq = modify.updatePhieuMuon(tb_mpMuon.Text, DateTime.Now, DateTime.Now.AddDays(30));
                if (kq == true)
                {
                    string updateSoDu = "update docGia set soDu = " + (Convert.ToInt32(dtSoDu.Rows[0][0]) - thanhToan).ToString() + "where maDG = '" + cb_maDG.SelectedValue.ToString() + "'";

                    using (SqlConnection sqlConnection = cConnection.getConnection())
                    {
                        sqlConnection.Open();
                        try
                        {
                            SqlCommand scSoDu = new SqlCommand(updateSoDu, sqlConnection);
                            scSoDu.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi : " + ex.ToString(), "Lỗi!");
                            return;
                        }
                        finally
                        {
                            sqlConnection.Close();
                        }
                    }
                    MessageBox.Show("Gia hạn thành công, bạn đã gia hạn ngoài thời gian quy định và bị phạt " + interval.Days*1000 + " VNĐ !", "Thành công!");
                    modify.updateDoanhThu(thanhToan.ToString());
                    frmMuonSach_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Gia hạn thất bại!", "Thất bại!");
                }
            }



            
        }

        private void bt_Huy_Click(object sender, EventArgs e)
        {
            frmMuonSach_Load(sender, e);

            if (dataGridView_MuonSach.RowCount > 0 && dgvEvent != null)
            {
                dataGridView_MuonSach_CellClick(sender, dgvEvent);
            }
        }

        private void bt_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_Them_Click(object sender, EventArgs e)
        {


            DataTable dt = new DataTable();
            string query = "select maPhieu 'Mã phiếu' " +
                            "from PhieuMuon";
            using (SqlConnection sqlConnection = cConnection.getConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dt);
                sqlConnection.Close();
            }


            int c = dt.Rows.Count;
            if (c > 0)
            {
                string s = dt.Rows[c - 1][0].ToString();
                int stt = Int32.Parse((s[2]).ToString()) * 100 + Int32.Parse((s[3]).ToString()) * 10 + Int32.Parse((s[4]).ToString()) + 1;
                if (stt < 10)
                {
                    tb_mpMuon.Text = "PM00" + stt.ToString();
                }
                else if (stt < 100)
                {
                    tb_mpMuon.Text = "PM0" + stt.ToString();
                }
                else
                {
                    tb_mpMuon.Text = "PM" + stt.ToString();
                }
            }
            else
            {
                tb_mpMuon.Text = "PM001";
            }

            bt_Them.Enabled = false;
            tb_navBar.Enabled = false;
            gr_infoPhieu.Enabled = false;
            gr_TimKiem.Enabled = false;
            gr_infoSach.Enabled = false;
            dataGridView_MuonSach.Enabled = false;
            
            bt_Luu.Enabled = true;
            bt_HuyPhieu.Enabled = true;

            cb_maDG.Enabled = true;
            dt_ngayTao.Enabled = true;


        }

        private void bt_Luu_Click(object sender, EventArgs e)
        {
            modify = new cModify();
            bool kq = modify.insertPhieuMuon(tb_mpMuon.Text, cb_maDG.SelectedValue.ToString(), dt_ngayTao.Value);
            if (kq == true)
            {
                MessageBox.Show("Thêm dữ liệu thành công!", "Thành công!");
                frmMuonSach_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Thêm dữ liệu thất bại!", "Thất bại!");
            }
        }

        private void bt_HuyPhieu_Click(object sender, EventArgs e)
        {
            frmMuonSach_Load(sender, e);

            if (dataGridView_MuonSach.RowCount > 0 && dgvEvent != null)
            {
                dataGridView_MuonSach_CellClick(sender, dgvEvent);
            }
        }

        private void dataGridView_MuonSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvEvent = e;
            bt_Them.Enabled = true;
            bt_MuonMoi.Enabled = true;
            bt_GiaHan.Enabled = true;
            //bt_InThe.Enabled = true;

            int index = e.RowIndex;
            if (index < 0) return;

            tb_mpMuon.Text = dataGridView_MuonSach.Rows[index].Cells[0].Value.ToString();

            cb_maDG.Text = dataGridView_MuonSach.Rows[index].Cells[1].Value.ToString();
            dt_ngayTao.Value = Convert.ToDateTime(dataGridView_MuonSach.Rows[index].Cells[2].Value);


            cb_mpMuon.DropDownStyle = ComboBoxStyle.DropDown;
            cb_mpMuon.Text = dataGridView_MuonSach.Rows[index].Cells[0].Value.ToString();

            cb_maSach.Text = dataGridView_MuonSach.Rows[index].Cells[3].Value.ToString();
            tb_SL.Text = dataGridView_MuonSach.Rows[index].Cells[6].Value.ToString();
            //tb_SoDu.Text = String.Format(culture, "{0:N0}", dataGridView_DocGia.Rows[index].Cells[8].Value) + " VNĐ";

            dt_ngayMuon.Value = Convert.ToDateTime(dataGridView_MuonSach.Rows[index].Cells[4].Value);
            dt_ngayTra.Value = Convert.ToDateTime(dataGridView_MuonSach.Rows[index].Cells[5].Value);
            cb_tinhTrang.Text = dataGridView_MuonSach.Rows[index].Cells[7].Value.ToString();
            DataTable dataTable = modify.getInfoSachMuon(dataGridView_MuonSach.Rows[index].Cells[3].Value.ToString());
            tb_infoMaSach.Text = dataTable.Rows[0][0].ToString();
            tb_infoTenSach.Text = dataTable.Rows[0][1].ToString();
            tb_infoTacGia.Text = dataTable.Rows[0][2].ToString();
            tb_infoNCC.Text = dataTable.Rows[0][3].ToString();
            tb_infoDonGia.Text = dataTable.Rows[0][4].ToString();
            tb_infoTinhTrang.Text = dataTable.Rows[0][5].ToString();
        }

        private void dt_ngayMuon_ValueChanged(object sender, EventArgs e)
        {
            dt_ngayTra.Value = dt_ngayMuon.Value.AddDays(30);
        }

        private void cb_maSach_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cb_maSach.Enabled == false) return;
            DataTable dataTable = new DataTable();
            string query = "select maSach 'Mã sách', " +
                            "tenSach 'Tên sách', " +
                            "tacGia 'Tác giả', " +
                            "NCC.tenNCC 'Nhà cung cấp', " +
                            "donGia 'Đơn giá', " +
                            "tinhTrang 'Tình trạng' " +
                            "from NCC, Sach " +
                            "where Sach.idNCC = NCC.maNCC and maSach = '" + cb_maSach.SelectedValue.ToString() + "'";
            using (SqlConnection sqlConnection = cConnection.getConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }

            tb_infoMaSach.Text = dataTable.Rows[0][0].ToString();
            tb_infoTenSach.Text = dataTable.Rows[0][1].ToString();
            tb_infoTacGia.Text = dataTable.Rows[0][2].ToString();
            tb_infoNCC.Text = dataTable.Rows[0][3].ToString();
            tb_infoDonGia.Text = dataTable.Rows[0][4].ToString();
            tb_infoTinhTrang.Text = dataTable.Rows[0][5].ToString();


        }

        private void tb_SL_TextChanged(object sender, EventArgs e)
        {
            if (tb_SL.ReadOnly == true) return;
            DataTable dataTable = new DataTable();
            string query = "select soLuong " +
                            "from Sach " +
                            "where maSach = '" + cb_maSach.SelectedValue.ToString() + "'";
            using (SqlConnection sqlConnection = cConnection.getConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }

            int result = 0;

            if (int.TryParse(tb_SL.Text, out result) && result>Convert.ToInt32(dataTable.Rows[0][0]))
            {
                MessageBox.Show("Số sách đăng ký mượn không đủ trong kho!", "Thông báo!");
                tb_SL.Text = "";
                tb_SL.Focus();
            }
        }

        private void cb_mpMuon_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cb_maSach.Enabled == false) return;
            DataTable dataTable = new DataTable();
            string query = "select maDG, ngayLapPhieu from phieuMuon where maPhieu = '" + cb_mpMuon.SelectedValue.ToString() + "'";
                            
            using (SqlConnection sqlConnection = cConnection.getConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }

            tb_mpMuon.Text = cb_mpMuon.SelectedValue.ToString();
            cb_maDG.Text = dataTable.Rows[0][0].ToString();
            dt_ngayTao.Value = Convert.ToDateTime(dataTable.Rows[0][1]);
        }

        private void tb_TimKiem_TextChanged(object sender, EventArgs e)
        {
            if (radioButton_maSach.Checked == true)
            {
                modify = new cModify();
                dataGridView_MuonSach.DataSource = modify.searchPhieuMuon("maSach", tb_TimKiem.Text);
            }
            else if (radioButton_maDG.Checked == true)
            {
                dataGridView_MuonSach.DataSource = modify.searchPhieuMuon("maDG", tb_TimKiem.Text);
            }
        }

    }
}
