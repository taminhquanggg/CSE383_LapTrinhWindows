using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ThongTinSinhVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loadDataGridView();
        }
        private string gioiTinh;
        private static bool continueDate = false;
        private DataTable dataTable = new DataTable("data");
        
        

        private void loadDataGridView()
        {
            dataTable.Columns.Add("Mã SV");
            dataTable.Columns.Add("Họ tên");
            dataTable.Columns.Add("Ngày sinh");
            dataTable.Columns.Add("Giới tính");
            dataTable.Columns.Add("Quê quán");
            dataTable.Columns.Add("Lớp");
            dataTable.Columns.Add("Khoa");
            dGV_TableData.Font = new Font("Microsoft Sans Serif", 10);
            System.IO.StreamReader reader;
            reader = new System.IO.StreamReader(@"data.json");
            string str = reader.ReadToEnd();
            reader.Close();
            dataTable = JsonConvert.DeserializeObject<DataTable>(str);

            dGV_TableData.DataSource = dataTable;
        }

        private void resetTextBox()
        {
            tb_MaSV.Text = null;
            tb_Hoten.Text = null;
            dTP_NgaySinh.Value = Convert.ToDateTime("01/01/2002");
            cb_Nu.Checked = false;
            cb_Nam.Checked = false;
            cbBox_QueQuan.Text = null;
            cbB_lop.Text = null;
            cbB_Khoa.Text = null;
        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            if (tb_MaSV.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập Mã Sinh viên !", "Thông báo !");
                tb_MaSV.Focus();
                return;
            }
            if (tb_Hoten.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập Tên Sinh viên !", "Thông báo !");
                tb_Hoten.Focus();
                return;
            }

            if (dTP_NgaySinh.Value == Convert.ToDateTime("01/01/2002") && continueDate==false)
            {
                var result = MessageBox.Show("Ngày sinh chưa được thay đổi, bạn có muốn tiếp tục?", "Thông báo !", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    dTP_NgaySinh.Focus();
                    return;
                }
                else
                {
                    continueDate = true;
                }
                
            }
            if (cb_Nam.Checked == false && cb_Nu.Checked==false)
            {
                MessageBox.Show("Bạn chưa chọn giới tính !", "Thông báo !");
                return;
            }
            if (cbBox_QueQuan.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn Quê quán !", "Thông báo !");
                cbBox_QueQuan.Focus();
                return;
            }
            if (cbB_lop.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn Lớp !", "Thông báo !");
                cbB_lop.Focus();
                return;
            }
            if (cbB_Khoa.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn Khoa !", "Thông báo !");
                cbB_Khoa.Focus();
                return;
            }

            MessageBox.Show("Thêm thành công !", "Thông báo !");
            dataTable.Rows.Add(tb_MaSV.Text, tb_Hoten.Text, dTP_NgaySinh.Value.ToString("dd/MM/yyyy"), gioiTinh, cbBox_QueQuan.Text, cbB_lop.Text, cbB_Khoa.Text);
            dGV_TableData.DataSource = dataTable;
            resetTextBox();
            continueDate = false;
            
            string jsonstr = JsonConvert.SerializeObject(dataTable);
            System.IO.File.WriteAllText(@"data.json", jsonstr);
        }

        private void cb_Nam_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Nu.Checked == true)
            {
                cb_Nu.Checked = false;
            }
            gioiTinh = "Nam";
        }

        private void cb_Nu_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Nam.Checked == true)
            {
                cb_Nam.Checked = false;
            }
            gioiTinh = "Nữ";
        }

        private void dGV_TableData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dGV_TableData.CurrentCell.RowIndex;
            bt_Sua.Visible = true;
            bt_Xoa.Visible = true;
            loadDataTextBox(index);
        }

        private void loadDataTextBox(int index)
        {
            tb_MaSV.Text = dGV_TableData.Rows[index].Cells[0].Value.ToString();
            tb_Hoten.Text = dGV_TableData.Rows[index].Cells[1].Value.ToString();
            dTP_NgaySinh.Value = Convert.ToDateTime(dGV_TableData.Rows[index].Cells[2].Value.ToString());
            string gioiTinhData = dGV_TableData.Rows[index].Cells[3].Value.ToString();
            
            if (gioiTinhData == "Nam")
            {
                cb_Nam.Checked = true;
                cb_Nu.Checked = false;
            }
            else
            {
                cb_Nu.Checked = true;
                cb_Nam.Checked = false;
            }

            cbBox_QueQuan.Text = dGV_TableData.Rows[index].Cells[4].Value.ToString();
            cbB_lop.Text = dGV_TableData.Rows[index].Cells[5].Value.ToString();
            cbB_Khoa.Text = dGV_TableData.Rows[index].Cells[6].Value.ToString();
        }

        private void bt_Sua_Click(object sender, EventArgs e)
        {
            int index = dGV_TableData.CurrentCell.RowIndex;
            updateDataTable(index);
            resetTextBox();
            
        }

        private void updateDataTable(int index)
        {
            
            dGV_TableData.Rows[index].Cells[0].Value = tb_MaSV.Text ;
            dGV_TableData.Rows[index].Cells[1].Value = tb_Hoten.Text;
            dGV_TableData.Rows[index].Cells[2].Value = dTP_NgaySinh.Value.ToShortDateString();
            dGV_TableData.Rows[index].Cells[3].Value = gioiTinh;
            dGV_TableData.Rows[index].Cells[4].Value = cbBox_QueQuan.Text;
            dGV_TableData.Rows[index].Cells[5].Value = cbB_lop.Text;
            dGV_TableData.Rows[index].Cells[6].Value = cbB_Khoa.Text;

            
            dataTable.Rows[index].SetField("Mã SV", tb_MaSV.Text);
            dataTable.Rows[index].SetField("Họ tên", tb_Hoten.Text);
            dataTable.Rows[index].SetField("Ngày sinh", dTP_NgaySinh.Value.ToShortDateString());
            dataTable.Rows[index].SetField("Giới tính", gioiTinh);
            dataTable.Rows[index].SetField("Quê quán", cbBox_QueQuan.Text);
            dataTable.Rows[index].SetField("Lớp", cbB_lop.Text);
            dataTable.Rows[index].SetField("Khoa", cbB_Khoa.Text);
            dataTable.AcceptChanges();
            MessageBox.Show("Cập nhật thành công !", "Thông báo!");


        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có muốn xóa dữ liệu của sinh viên này? !", "Thông báo!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                
                dGV_TableData.Rows.RemoveAt(dGV_TableData.CurrentCell.RowIndex);
                
                
                MessageBox.Show("Xóa thành công !", "Thông báo!");
                resetTextBox();
            }
            else
            {
                return;
            }
            
        }
    }
}
