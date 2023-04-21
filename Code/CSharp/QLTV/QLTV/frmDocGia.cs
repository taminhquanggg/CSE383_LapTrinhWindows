using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using DevExpress.XtraPrinting.Preview;
using System.Data.SqlClient;

namespace QLTV
{
    public partial class frmDocGia : Form
    {
        public frmDocGia()
        {
            InitializeComponent();
        }

        cModify modify;
        string _sex;
        string status;
        DataGridViewCellEventArgs dgvEvent;
        private void frmDocGia_Load(object sender, EventArgs e)
        {
            radioButton_maDG.Checked = false;
            radioButton_tenDG.Checked = false;
            radioButton_nam.Checked = false;
            radioButton_nu.Checked = false;

            radioButton_nam.Enabled = false;
            radioButton_nu.Enabled = false;

            bt_ChonAnh.Enabled = false;
            bt_XoaAnh.Enabled = false;

            tb_MaDG.Text = "";
            tb_TenDG.Text = "";
            tb_SDT.Text = "";
            tb_SoDu.Text = "";
            tb_DiaChi.Text = "";

            dt_NgaySinh.Value = DateTime.Now;
            dt_NgayLap.Value = DateTime.Now;
            dt_HetHan.Value = DateTime.Now;

            tb_MaDG.ReadOnly = true;
            tb_TenDG.ReadOnly = true;
            tb_SDT.ReadOnly = true;
            tb_SoDu.ReadOnly = true;
            tb_DiaChi.ReadOnly = true;

            dt_NgaySinh.Enabled = false;
            dt_NgayLap.Enabled = false;
            dt_HetHan.Enabled = false;

            bt_LamMoi.Enabled = true;
            bt_Them.Enabled = true;
            bt_Sua.Enabled = false;
            bt_Xoa.Enabled = false;
            bt_Luu.Enabled = false;
            bt_Huy.Enabled = false;
            gr_TimKiem.Enabled = true;

            dataGridView_DocGia.Enabled = true;

            pictureBox1.BackgroundImage = QLTV.Properties.Resources.JaZBMzV14fzRI4vBWG8jymplSUGSGgimkqtJakOV;
            pictureBox1.ImageLocation = null;
            pictureBox1.Image = null;
 
            modify = new cModify();
            try
            {
                dataGridView_DocGia.DataSource = modify.getAllDocGia();
                if (dataGridView_DocGia.RowCount>0)
                {
                    DataGridViewImageColumn pic = new DataGridViewImageColumn();
                    pic = (DataGridViewImageColumn)dataGridView_DocGia.Columns[9];
                    pic.ImageLayout = DataGridViewImageCellLayout.Zoom;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        private void bt_LamMoi_Click(object sender, EventArgs e)
        {
            dgvEvent = null;
            frmDocGia_Load(sender, e);
        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = QLTV.Properties.Resources.JaZBMzV14fzRI4vBWG8jymplSUGSGgimkqtJakOV;
            pictureBox1.ImageLocation = null;
            pictureBox1.Image = null;

            bt_LamMoi.Enabled = false;
            bt_Them.Enabled = false;
            bt_Sua.Enabled = false;
            bt_Xoa.Enabled = false;
            bt_Luu.Enabled = true;
            bt_Huy.Enabled = true;
            gr_TimKiem.Enabled = false;
            dataGridView_DocGia.Enabled = false;

            bt_ChonAnh.Enabled = true;
            bt_XoaAnh.Enabled = true;

            tb_TenDG.ReadOnly = false;
            tb_SDT.ReadOnly = false;
            tb_SoDu.ReadOnly = false;
            tb_DiaChi.ReadOnly = false;
            dt_NgaySinh.Enabled = true;
            dt_NgayLap.Enabled = true;
            radioButton_nam.Enabled = true;
            radioButton_nu.Enabled = true;

            int c = dataGridView_DocGia.RowCount;
            if (c > 0)
            {
                string s = dataGridView_DocGia.Rows[c - 1].Cells[0].Value.ToString();
                int stt = Int32.Parse((s[2]).ToString()) * 100 + Int32.Parse((s[3]).ToString()) * 10 + Int32.Parse((s[4]).ToString()) + 1;
                if (stt<10)
                {
                    tb_MaDG.Text = "DG00" + stt.ToString();
                }
                else if (stt<100)
                {
                    tb_MaDG.Text = "DG0" + stt.ToString();
                }
                else
                {
                    tb_MaDG.Text = "DG" + stt.ToString();
                }
            }
            else
            {
                tb_MaDG.Text = "DG001";
            }

            tb_TenDG.Text = "";
            tb_SDT.Text = "";
            tb_SoDu.Text = "";
            tb_DiaChi.Text = "";

            dt_NgaySinh.Value = DateTime.Now;
            dt_NgayLap.Value = DateTime.Now;
            dt_HetHan.Value = DateTime.Now;

            status = "Them";
        }

        private void bt_Sua_Click(object sender, EventArgs e)
        {
            bt_ChonAnh.Enabled = true;
            bt_XoaAnh.Enabled = true;

            bt_LamMoi.Enabled = false;
            bt_Them.Enabled = false;
            bt_Sua.Enabled = false;
            bt_Xoa.Enabled = false;
            bt_Luu.Enabled = true;
            bt_Huy.Enabled = true;
            gr_TimKiem.Enabled = false;
            dataGridView_DocGia.Enabled = false;

            tb_TenDG.ReadOnly = false;
            tb_SDT.ReadOnly = false;
            tb_SoDu.ReadOnly = false;
            tb_DiaChi.ReadOnly = false;
            dt_NgaySinh.Enabled = true;
            dt_NgayLap.Enabled = true;
            dt_HetHan.Enabled = true;
            radioButton_nam.Enabled = true;
            radioButton_nu.Enabled = true;

            status = "Sua";
        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                modify = new cModify();
                bool kq = modify.deleteDocGia(tb_MaDG.Text);
                if (kq == true)
                {
                    MessageBox.Show("Xóa dữ liệu thành công!", "Thành công!");
                    modify.updateslDG("-");
                    frmDocGia_Load(sender, e);
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

        private byte[] ImageToByteArray(PictureBox pictureBox)
        {
            MemoryStream memoryStream = new MemoryStream();
            pictureBox.Image.Save(memoryStream, pictureBox.Image.RawFormat);
            return memoryStream.ToArray();
        }

        private void bt_Luu_Click(object sender, EventArgs e)
        {
            
            if (status == "Them")
            {
                if (pictureBox1.ImageLocation != null)
                {
                    if (radioButton_nam.Checked == true)
                    {
                        _sex = "Nam";
                    }
                    else if (radioButton_nu.Checked == true)
                    {
                        _sex = "Nữ";
                    }
                    string query = "insert into docGia values (@maDG, @tenDG, @sdtDG, @ngaySinhDG, @gioiTinhDG, @ngayLapThe, @ngayHetHan, @soDu, @diaChiDG, @anhDG)";
                    try
                    {

                    byte[] picture = ImageToByteArray(pictureBox1);
                        modify.queryDocGia(query, tb_MaDG.Text, tb_TenDG.Text, tb_SDT.Text, dt_NgaySinh.Value, _sex, dt_NgayLap.Value, dt_HetHan.Value, Convert.ToInt32(tb_SoDu.Text), tb_DiaChi.Text, picture);
                        MessageBox.Show("Thêm dữ liệu thành công!", "Thành công!");
                        modify.updateslDG("+");
                        modify.updateDoanhThu(tb_SoDu.Text);
                        frmDocGia_Load(sender, e);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Thêm dữ liệu thất bại!" + ex.Message, "Thất bại!");
                    }
                }
                else
                {
                    if (radioButton_nam.Checked == true)
                    {
                        _sex = "Nam";
                    }
                    else if (radioButton_nu.Checked == true)
                    {
                        _sex = "Nữ";
                    }
                    modify = new cModify();
                    bool kq = modify.insertDocGia(tb_MaDG.Text, tb_TenDG.Text, tb_SDT.Text, dt_NgaySinh.Value, _sex, dt_NgayLap.Value, dt_HetHan.Value, Convert.ToInt32(tb_SoDu.Text), tb_DiaChi.Text);
                    if (kq == true)
                    {
                        MessageBox.Show("Thêm dữ liệu thành công!", "Thành công!");
                        modify.updateslDG("+");
                        modify.updateDoanhThu(tb_SoDu.Text);
                        frmDocGia_Load(sender, e);
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
                    if (radioButton_nam.Checked == true)
                    {
                        _sex = "Nam";
                    }
                    else if (radioButton_nu.Checked == true)
                    {
                        _sex = "Nữ";
                    }
                    string query = "update docGia set tenDG = @tenDG, sdtDG = @sdtDG, ngaySinhDG = @ngaySinhDG, gioiTinhDG = @gioiTinhDG, ngayLapThe = @ngayLapThe, ngayHetHan = @ngayHetHan, soDu = @soDu, diaChiDG = @diaChiDG, anhDG = @anhDG where maDG = @maDG";
                    try
                    {
                        byte[] picture = ImageToByteArray(pictureBox1);
                        modify.queryDocGia(query, tb_MaDG.Text, tb_TenDG.Text, tb_SDT.Text, dt_NgaySinh.Value, _sex, dt_NgayLap.Value, dt_HetHan.Value, Convert.ToInt32(tb_SoDu.Text), tb_DiaChi.Text, picture);
                        MessageBox.Show("Sửa dữ liệu thành công!", "Thành công!");
                        frmDocGia_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Sửa dữ liệu thất bại!" + ex.Message, "Thất bại!");
                    }
                }
                else
                {
                    if (radioButton_nam.Checked == true)
                    {
                        _sex = "Nam";
                    }
                    else if (radioButton_nu.Checked == true)
                    {
                        _sex = "Nữ";
                    }
                    modify = new cModify();
                    bool kq = modify.updateDocGia(tb_MaDG.Text, tb_TenDG.Text, tb_SDT.Text, dt_NgaySinh.Value, _sex, dt_NgayLap.Value, dt_HetHan.Value, Convert.ToInt32(tb_SoDu.Text), tb_DiaChi.Text);
                    if (kq == true)
                    {
                        MessageBox.Show("Sửa dữ liệu thành công!", "Thành công!");
                        frmDocGia_Load(sender, e);
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
            frmDocGia_Load(sender, e);

            if (dataGridView_DocGia.RowCount > 0 && dgvEvent!=null) 
            {
                dataGridView_DocGia_CellClick(sender, dgvEvent);
            }
        }

        private void bt_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView_DocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvEvent = e;
            bt_Them.Enabled = true;
            bt_Sua.Enabled = true;
            bt_Xoa.Enabled = true;

            int index = e.RowIndex;
            if (index < 0) return;

            tb_MaDG.Text = dataGridView_DocGia.Rows[index].Cells[0].Value.ToString();
            tb_TenDG.Text = dataGridView_DocGia.Rows[index].Cells[1].Value.ToString();
            tb_SDT.Text = dataGridView_DocGia.Rows[index].Cells[4].Value.ToString();
            dt_NgaySinh.Value = Convert.ToDateTime(dataGridView_DocGia.Rows[index].Cells[3].Value);
            if (dataGridView_DocGia.Rows[index].Cells[2].Value.ToString() == "Nam")
            {
                radioButton_nam.Checked = true;
            }
            else if (dataGridView_DocGia.Rows[index].Cells[2].Value.ToString() == "Nữ")
            {
                radioButton_nu.Checked = true;
            }

            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");

            dt_NgayLap.Value = Convert.ToDateTime(dataGridView_DocGia.Rows[index].Cells[6].Value);
            dt_HetHan.Value = Convert.ToDateTime(dataGridView_DocGia.Rows[index].Cells[7].Value);
            //tb_SoDu.Text = String.Format(culture, "{0:N0}", dataGridView_DocGia.Rows[index].Cells[8].Value) + " VNĐ";
            tb_SoDu.Text = dataGridView_DocGia.Rows[index].Cells[8].Value.ToString();
            tb_DiaChi.Text = dataGridView_DocGia.Rows[index].Cells[5].Value.ToString();
            if (dataGridView_DocGia.Rows[index].Cells[9].Value.ToString()!="")
            {
                MemoryStream memoryStream = new MemoryStream((byte[])dataGridView_DocGia.Rows[index].Cells[9].Value);
                pictureBox1.Image = Image.FromStream(memoryStream);
                pictureBox1.BackgroundImage = null;
            }
            else
            {
                pictureBox1.Image = null;
            }



        }

        private void tb_TimKiem_TextChanged(object sender, EventArgs e)
        {
            if (radioButton_maDG.Checked == true)
            {
                modify = new cModify();
                dataGridView_DocGia.DataSource = modify.searchDocGia("ma", tb_TimKiem.Text);
            }
            else if (radioButton_tenDG.Checked == true)
            {
                dataGridView_DocGia.DataSource = modify.searchDocGia("ten", tb_TimKiem.Text);
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
            pictureBox1.BackgroundImage = QLTV.Properties.Resources.JaZBMzV14fzRI4vBWG8jymplSUGSGgimkqtJakOV;
            pictureBox1.ImageLocation = null;
            pictureBox1.Image = null;
        }

        private void dt_NgayLap_ValueChanged(object sender, EventArgs e)
        {
            dt_HetHan.Value = dt_NgayLap.Value.AddYears(3);
        }
    }
}
