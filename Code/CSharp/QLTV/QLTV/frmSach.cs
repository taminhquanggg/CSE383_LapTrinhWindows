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
using System.IO;

namespace QLTV
{
    public partial class frmSach : Form
    {
        public frmSach()
        {
            InitializeComponent();
        }

        cModify modify;
        string status;
        DataGridViewCellEventArgs dgvEvent;
        SqlDataAdapter dataAdapter;

        private void frmSach_Load(object sender, EventArgs e)
        {
            radioButton_maSach.Checked = false;
            radioButton_tenLoai.Checked = false;
            radioButton_tenSach.Checked = false;
            radioButton_tacGia.Checked = false;

            bt_ChonAnh.Enabled = false;
            bt_XoaAnh.Enabled = false;

            tb_TimKiem.Text = "";
            tb_MaSach.Text = "";
            tb_TenSach.Text = "";
            tb_TacGia.Text = "";
            tb_namXB.Text = "";
            tb_SL.Text = "";
            tb_DonGia.Text = "";
            
            tb_MaSach.ReadOnly = true;
            tb_TenSach.ReadOnly = true;
            tb_TacGia.ReadOnly = true;
            tb_namXB.ReadOnly = true;
            tb_SL.ReadOnly = true;
            tb_DonGia.ReadOnly = true;

            cb_Loai.Enabled = false;
            cb_NCC.Enabled = false;
            cb_TinhTrang.Enabled = false;

            bt_LamMoi.Enabled = true;
            bt_Them.Enabled = true;
            bt_Sua.Enabled = false;
            bt_Xoa.Enabled = false;
            bt_Luu.Enabled = false;
            bt_Huy.Enabled = false;
            gr_TimKiem.Enabled = true;

            dataGridView_Sach.Enabled = true;

            pictureBox1.BackgroundImage = QLTV.Properties.Resources._1200px_Picture_icon_BLACK_svg;
            pictureBox1.ImageLocation = null;
            pictureBox1.Image = null;

            modify = new cModify();
            try
            {
                dataGridView_Sach.DataSource = modify.getAllSach();
                if (dataGridView_Sach.RowCount > 0)
                {
                    DataGridViewImageColumn pic = new DataGridViewImageColumn();
                    pic = (DataGridViewImageColumn)dataGridView_Sach.Columns[9];
                    pic.ImageLayout = DataGridViewImageCellLayout.Zoom;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }

            using (SqlConnection sqlConnection = cConnection.getConnection())
            {
                DataTable dtLoai = new DataTable();
                string queryLoai = "select * from LoaiSach";
                DataTable dtNCC = new DataTable();
                string queryNCC = "select maNCC, tenNCC from NCC";

                sqlConnection.Open();

                dataAdapter = new SqlDataAdapter(queryLoai, sqlConnection);
                dataAdapter.Fill(dtLoai);
                cb_Loai.DataSource = dtLoai;
                cb_Loai.DisplayMember = "tenLoaiSach";
                cb_Loai.ValueMember = "maLoaiSach";

                dataAdapter = new SqlDataAdapter(queryNCC, sqlConnection);
                dataAdapter.Fill(dtNCC);
                cb_NCC.DataSource = dtNCC;
                cb_NCC.DisplayMember = "tenNCC";
                cb_NCC.ValueMember = "maNCC";

                sqlConnection.Close();
            }
        }

        private void bt_LamMoi_Click(object sender, EventArgs e)
        {
            dgvEvent = null;
            frmSach_Load(sender, e);
        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = QLTV.Properties.Resources._1200px_Picture_icon_BLACK_svg;
            pictureBox1.ImageLocation = null;
            pictureBox1.Image = null;

            bt_LamMoi.Enabled = false;
            bt_Them.Enabled = false;
            bt_Sua.Enabled = false;
            bt_Xoa.Enabled = false;
            bt_Luu.Enabled = true;
            bt_Huy.Enabled = true;
            gr_TimKiem.Enabled = false;
            dataGridView_Sach.Enabled = false;

            bt_ChonAnh.Enabled = true;
            bt_XoaAnh.Enabled = true;

            tb_TenSach.ReadOnly = false;
            tb_TacGia.ReadOnly = false;
            tb_namXB.ReadOnly = false;
            tb_SL.ReadOnly = false;
            tb_DonGia.ReadOnly = false;

            cb_Loai.Enabled = true;
            cb_NCC.Enabled = true;
            cb_TinhTrang.Enabled = true;
            

            int c = dataGridView_Sach.RowCount;
            if (c > 0)
            {
                string s = dataGridView_Sach.Rows[c - 1].Cells[0].Value.ToString();
                int stt = Int32.Parse((s[3]).ToString()) * 100 + Int32.Parse((s[3]).ToString()) * 10 + Int32.Parse((s[4]).ToString()) + 1;
                if (stt < 10)
                {
                    tb_MaSach.Text = "S000" + stt.ToString();
                }
                else if (stt < 100)
                {
                    tb_MaSach.Text = "S00" + stt.ToString();
                }
                else if (stt < 1000)
                {
                    tb_MaSach.Text = "S0" + stt.ToString();
                }
                else
                {
                    tb_MaSach.Text = "S" + stt.ToString();
                }
            }
            else
            {
                tb_MaSach.Text = "S0001";
            }

            tb_TenSach.Text = "";
            tb_TacGia.Text = "";
            tb_namXB.Text = "";
            tb_SL.Text = "";
            tb_DonGia.Text = "";

            cb_Loai.Text = "";
            cb_NCC.Text = "";
            cb_TinhTrang.Text = "";

            status = "Them";
        }

        private byte[] ImageToByteArray(PictureBox pictureBox)
        {
            MemoryStream memoryStream = new MemoryStream();
            pictureBox.Image.Save(memoryStream, pictureBox.Image.RawFormat);
            return memoryStream.ToArray();
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
            dataGridView_Sach.Enabled = false;

            bt_ChonAnh.Enabled = true;
            bt_XoaAnh.Enabled = true;

            tb_TenSach.ReadOnly = false;
            tb_TacGia.ReadOnly = false;
            tb_namXB.ReadOnly = false;
            tb_SL.ReadOnly = false;
            tb_DonGia.ReadOnly = false;

            cb_Loai.Enabled = true;
            cb_NCC.Enabled = true;
            cb_TinhTrang.Enabled = true;

            status = "Sua";
        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                modify = new cModify();
                bool kq = modify.deleteSach(tb_MaSach.Text);
                if (kq == true)
                {
                    MessageBox.Show("Xóa dữ liệu thành công!", "Thành công!");
                    modify.updateSL_Sach(tb_SL.Text, "-");
                    frmSach_Load(sender, e);
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
                if (pictureBox1.ImageLocation != null)
                {
                    string query = "insert into Sach values (@maSach, @tenSach, @idLoaiSach, @tacGia, @idNCC, @NamXB, @soLuong, @donGia, @tinhTrang, @anhSach)";
                    try
                    {
                        byte[] picture = ImageToByteArray(pictureBox1);
                        modify.querySach(query, tb_MaSach.Text, tb_TenSach.Text, cb_Loai.SelectedValue.ToString(), tb_TacGia.Text, cb_NCC.SelectedValue.ToString(), Convert.ToInt32(tb_namXB.Text), Convert.ToInt32(tb_SL.Text), Convert.ToInt32(tb_DonGia.Text), cb_TinhTrang.Text, picture);
                        modify.updateSL_Sach(tb_SL.Text, "+");
                        MessageBox.Show("Thêm dữ liệu thành công!", "Thành công!");
                        frmSach_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Thêm dữ liệu thất bại!" + ex.Message, "Thất bại!");
                    }
                }
                else
                {
                    modify = new cModify();
                    bool kq = modify.insertSach(tb_MaSach.Text, tb_TenSach.Text, cb_Loai.SelectedValue.ToString(), tb_TacGia.Text, cb_NCC.SelectedValue.ToString(), Convert.ToInt32(tb_namXB.Text), Convert.ToInt32(tb_SL.Text), Convert.ToInt32(tb_DonGia.Text), cb_TinhTrang.Text);
                    if (kq == true)
                    {
                        MessageBox.Show("Thêm dữ liệu thành công!", "Thành công!");
                        modify.updateSL_Sach(tb_SL.Text, "+");
                        frmSach_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Thêm dữ liệu thất bại!", "Thất bại!");
                    }
                }
                
            }
            else if (status == "Sua")
            {
                if (pictureBox1.ImageLocation != null)
                {
                    string query = "update Sach set tenSach = @tenSach, idLoaiSach = @idLoaiSach, tacGia = @tacGia, idNCC = @idNCC, NamXB = @NamXB, soLuong = @soLuong, donGia = @donGia, tinhTrang = @tinhTrang, anhSach = @anhSach where maSach = @maSach";
                    try
                    {
                        byte[] picture = ImageToByteArray(pictureBox1);
                        modify.querySach(query, tb_MaSach.Text, tb_TenSach.Text, cb_Loai.SelectedValue.ToString(), tb_TacGia.Text, cb_NCC.SelectedValue.ToString(), Convert.ToInt32(tb_namXB.Text), Convert.ToInt32(tb_SL.Text), Convert.ToInt32(tb_DonGia.Text), cb_TinhTrang.Text, picture);
                        MessageBox.Show("Sửa dữ liệu thành công!", "Thành công!");
                        frmSach_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Sửa dữ liệu thất bại!" + ex.Message, "Thất bại!");
                    }
                }
                else
                {
                    modify = new cModify();
                    bool kq = modify.updateSach(tb_MaSach.Text, tb_TenSach.Text, cb_Loai.SelectedValue.ToString(), tb_TacGia.Text, cb_NCC.SelectedValue.ToString(), Convert.ToInt32(tb_namXB.Text), Convert.ToInt32(tb_SL.Text), Convert.ToInt32(tb_DonGia.Text), cb_TinhTrang.Text);
                    if (kq == true)
                    {
                        MessageBox.Show("Sửa dữ liệu thành công!", "Thành công!");
                        frmSach_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Sửa dữ liệu thất bại!", "Thất bại!");
                    }
                }
                
            }
        }

        private void bt_Huy_Click(object sender, EventArgs e)
        {
            frmSach_Load(sender, e);
        }

        private void bt_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_TimKiem_TextChanged(object sender, EventArgs e)
        {
            if (radioButton_maSach.Checked == true)
            {
                modify = new cModify();
                dataGridView_Sach.DataSource = modify.searchSach("maSach", tb_TimKiem.Text);
            }
            else if (radioButton_tenLoai.Checked == true)
            {
                dataGridView_Sach.DataSource = modify.searchSach("tenLoaiSach", tb_TimKiem.Text);
            }
            else if (radioButton_tenSach.Checked == true)
            {
                dataGridView_Sach.DataSource = modify.searchSach("tenSach", tb_TimKiem.Text);
            }   
            else if (radioButton_tacGia.Checked == true)
            {
                dataGridView_Sach.DataSource = modify.searchSach("tacGia", tb_TimKiem.Text);
            }
        }

        private void dataGridView_Sach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvEvent = e;
            bt_Them.Enabled = true;
            bt_Sua.Enabled = true;
            bt_Xoa.Enabled = true;

            int index = e.RowIndex;
            if (index < 0) return;

            tb_MaSach.Text = dataGridView_Sach.Rows[index].Cells[0].Value.ToString();
            tb_TenSach.Text = dataGridView_Sach.Rows[index].Cells[1].Value.ToString();
            cb_Loai.Text = dataGridView_Sach.Rows[index].Cells[2].Value.ToString();
            tb_TacGia.Text = dataGridView_Sach.Rows[index].Cells[3].Value.ToString();
            cb_NCC.Text = dataGridView_Sach.Rows[index].Cells[4].Value.ToString();
            tb_namXB.Text = dataGridView_Sach.Rows[index].Cells[5].Value.ToString();
            tb_SL.Text = dataGridView_Sach.Rows[index].Cells[6].Value.ToString();
            tb_DonGia.Text = dataGridView_Sach.Rows[index].Cells[7].Value.ToString();
            cb_TinhTrang.Text = dataGridView_Sach.Rows[index].Cells[8].Value.ToString();

            if (dataGridView_Sach.Rows[index].Cells[9].Value.ToString() != "")
            {
                MemoryStream memoryStream = new MemoryStream((byte[])dataGridView_Sach.Rows[index].Cells[9].Value);
                pictureBox1.Image = Image.FromStream(memoryStream);
                pictureBox1.BackgroundImage = null;
            }
            else
            {
                pictureBox1.Image = null;
            }
        }

        private void bt_ChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn ảnh";
            openFileDialog.Filter = "Image Files(*.gif; *.jpg; *.jpeg; *.bmp; *.wmf; *.png)| *.gif; *.jpg; *.jpeg; *.bmp; *.wmf; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog.FileName;
                pictureBox1.BackgroundImage = null;
            }
        }

        private void bt_XoaAnh_Click(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = QLTV.Properties.Resources._1200px_Picture_icon_BLACK_svg;
            pictureBox1.ImageLocation = null;
            pictureBox1.Image = null;
        }


    }
}
