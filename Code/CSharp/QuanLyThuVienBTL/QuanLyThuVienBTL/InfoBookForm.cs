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
    public partial class InfoBookForm : Form
    {
        public InfoBookForm()
        {
            InitializeComponent();
        }

        ConnectDataBase c = new ConnectDataBase();

        private void InfoBookForm_Load(object sender, EventArgs e)
        {
            c.connectData();
            showData();

            DataTable data = new DataTable();
            String SqlQuery = "SELECT nameTypeOfBook " +
                            "FROM TypeOfBook";
            SqlDataAdapter adapter = new SqlDataAdapter(SqlQuery, c._conn);
            adapter.Fill(data);
            foreach (DataRow row in data.Rows)
            {
                cb_inputTOB_Book.Items.Add(row.ItemArray[0].ToString());
            }
        }

        private void showData()
        {
            DataSet data = new DataSet();
            String SqlQuery = "SELECT idBook 'Mã sách', " +
                                "nameBook 'Tên sách', " +
                                "b.nameTypeOfBook 'Tên kiểu sách', " +
                                "authorBook 'Tác giả', " +
                                "yearProductBook 'Năm xuất bản', " +
                                "numOfBook 'Số lượng sách', " +
                                "contentBook 'Nội dung' " +
                                "FROM Book as a, TypeOfBook as b " +
                                "WHERE a.idTypeOfBook = b.idTypeOfBook";
            SqlDataAdapter adapter = new SqlDataAdapter(SqlQuery, c._conn);
            adapter.Fill(data);
            dGVInfoBook.DataSource = data.Tables[0];
        }

        private void InfoBookForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (c._conn != null)
                c.disconnectData();
        }

        private void dGVInfoBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0) return;
            tb_inputID_Book.Text = dGVInfoBook.Rows[index].Cells[0].Value.ToString();
            tb_inputName_Book.Text = dGVInfoBook.Rows[index].Cells[1].Value.ToString();
            cb_inputTOB_Book.Text = dGVInfoBook.Rows[index].Cells[2].Value.ToString();
            tb_inputAuthor_Book.Text = dGVInfoBook.Rows[index].Cells[3].Value.ToString();
            tb_inputYearPd_Book.Text = dGVInfoBook.Rows[index].Cells[4].Value.ToString();
            nUP_inputNum_Book.Value = Convert.ToInt32(dGVInfoBook.Rows[index].Cells[5].Value);
            tb_inputContent_Book.Text = dGVInfoBook.Rows[index].Cells[6].Value.ToString();
        }

        private void bt_add_Book_Click(object sender, EventArgs e)
        {
            DataSet data = new DataSet();
            string query = "SELECT idTypeOfBook FROM TypeOfBook WHERE nameTypeOfBook = N'" + cb_inputTOB_Book.Text + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, c._conn);
            adapter.Fill(data);
            string getIdTOB = data.Tables[0].Rows[0][0].ToString();


            query = "INSERT INTO Book VALUES (" +
                            "'" + tb_inputID_Book.Text + "'," +
                            "N'" + tb_inputName_Book.Text + "'," +
                            "'" + getIdTOB + "'," +
                            "N'" + tb_inputAuthor_Book.Text + "'," +
                            "'" + Convert.ToInt32(tb_inputYearPd_Book.Text) + "'," +
                            "N'" + tb_inputContent_Book.Text + "'," +
                            "'" + nUP_inputNum_Book.Value + "')";
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

        private void bt_change_Book_Click(object sender, EventArgs e)
        {

        }

        private void bt_delete_Book_Click(object sender, EventArgs e)
        {

        }

        private void bt_reset_Book_Click(object sender, EventArgs e)
        {
            tb_inputID_Book.Text = "";
            tb_inputName_Book.Text = "";
            tb_inputAuthor_Book.Text = "";
            cb_inputTOB_Book.Text = "";
            tb_inputYearPd_Book.Text = "";
            nUP_inputNum_Book.Value = 0;
            tb_inputContent_Book.Text = "";
            showData();
        }
    }
}
