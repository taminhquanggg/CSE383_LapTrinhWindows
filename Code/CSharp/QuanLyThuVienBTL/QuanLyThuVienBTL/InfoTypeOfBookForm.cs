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

namespace QuanLyThuVienBTL
{
    public partial class InfoTypeOfBookForm : Form
    {
        public InfoTypeOfBookForm()
        {
            InitializeComponent();
        }

        ConnectDataBase c = new ConnectDataBase();

        private void InfoTypeOfBookForm_Load(object sender, EventArgs e)
        {
            c.connectData();
            showData();
        }

        private void InfoTypeOfBookForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (c._conn!=null)
                c.disconnectData();
        }

        private void dGVInfoTypeOfBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0) return;
            tb_inputID_TOBook.Text = dGVInfoTypeOfBook.Rows[index].Cells[0].Value.ToString();
            tb_inputName_TOBook.Text = dGVInfoTypeOfBook.Rows[index].Cells[1].Value.ToString();
            tb_inputAdd_TOBook.Text = dGVInfoTypeOfBook.Rows[index].Cells[2].Value.ToString();
        }

        private void bt_reset_TOBook_Click(object sender, EventArgs e)
        {
            tb_inputID_TOBook.Text = "";
            tb_inputName_TOBook.Text = "";
            tb_inputAdd_TOBook.Text = "";
            showData();
        }

        private void bt_searchReset_TOBook_Click(object sender, EventArgs e)
        {
            radioButton_searchById_TOBook.Checked = false;
            radioButton_searchByName_TOBook.Checked = false;
            tb_search_TOBook.Text = "";
            showData();
        }

        private void showData()
        {
            DataSet data = new DataSet();
            String SqlQuery = "SELECT idTypeOfBook 'Mã loại sách', " +
                            "nameTypeOfBook 'Tên loại sách', " +
                            "positionTypeOfBook 'Vị trí tủ sách' " +
                            "FROM TypeOfBook";
            SqlDataAdapter adapter = new SqlDataAdapter(SqlQuery, c._conn);
            adapter.Fill(data);
            dGVInfoTypeOfBook.DataSource = data.Tables[0];
        }

        private void bt_add_TOBook_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO TypeOfBook VALUES (" +
                            "'" + tb_inputID_TOBook.Text + "'," +
                            "N'" + tb_inputName_TOBook.Text + "'," +
                            "'" + tb_inputAdd_TOBook.Text + "')";
            bool kq = c.exeSQL(query);
            if (kq == true)
            {
                MessageBox.Show("Thêm dữ liệu thành công!", "Thành công!");
                showData();
            }
            else
            {
                MessageBox.Show("Thêm dữ liệu thất bại!", "Thất bại!");
            }
        }

        private void bt_change_TOBook_Click(object sender, EventArgs e)
        {
            string query = "UPDATE TypeOfBook SET " +
                            " nameTypeOfBook = N'" + tb_inputName_TOBook.Text + "', " +
                            " positionTypeOfBook = '" + tb_inputAdd_TOBook.Text + "'" +
                            " WHERE " +
                            "idTypeOfBook = '" + tb_inputID_TOBook.Text + "'";
            bool kq = c.exeSQL(query);
            if (kq == true)
            {
                MessageBox.Show("Cập nhật dữ liệu thành công!", "Thành công!");
                showData();
                
            }
            else
            {
                MessageBox.Show("Cập nhật dữ liệu thất bại!", "Thất bại!");
            }
            
        }

        private void bt_del_TOBook_Click(object sender, EventArgs e)
        {
            string query = "DELETE TypeOfBook " +
                            " WHERE " +
                            "idTypeOfBook = '" + tb_inputID_TOBook.Text + "'";
            bool kq = c.exeSQL(query);
            if (kq == true)
            {
                MessageBox.Show("Xóa dữ liệu thành công!", "Thành công!");
                tb_inputID_TOBook.Text = "";
                tb_inputName_TOBook.Text = "";
                tb_inputAdd_TOBook.Text = "";
                showData();
            }
            else
            {
                MessageBox.Show("Xóa dữ liệu thất bại!", "Thất bại!");
            }
        }

        private void bt_search_TOBook_Click(object sender, EventArgs e)
        {
            if (radioButton_searchById_TOBook.Checked == false && radioButton_searchById_TOBook.Checked == false)
            {
                MessageBox.Show("Bạn chưa chọn loại tìm kiếm !", "Lỗi !");
                return;
            }
            if (tb_search_TOBook.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập nội dung tìm kiếm !", "Lỗi !");
                tb_search_TOBook.Focus();
                return;
            }
            DataSet data = new DataSet();
            string SqlQuery = "";
            if (radioButton_searchById_TOBook.Checked == true)
            {
                SqlQuery = "SELECT idTypeOfBook 'Mã loại sách', " +
                            "nameTypeOfBook 'Tên loại sách', " +
                            "positionTypeOfBook 'Vị trí tủ sách' " +
                            "FROM TypeOfBook " +
                            "WHERE idTypeOfBook like '%" + tb_search_TOBook.Text + "%'";
            }
            else if (radioButton_searchByName_TOBook.Checked == true)
            {
                SqlQuery = "SELECT idTypeOfBook 'Mã loại sách', " +
                            "nameTypeOfBook 'Tên loại sách', " +
                            "positionTypeOfBook 'Vị trí tủ sách' " +
                            "FROM TypeOfBook " +
                            "WHERE nameTypeOfBook LIKE N'%" + tb_search_TOBook.Text + "%'";
            }
            if (SqlQuery != "")
            {
                SqlDataAdapter adapter = new SqlDataAdapter(SqlQuery, c._conn);
                adapter.Fill(data);
                dGVInfoTypeOfBook.DataSource = data.Tables[0];
            }
        }
    }
}
