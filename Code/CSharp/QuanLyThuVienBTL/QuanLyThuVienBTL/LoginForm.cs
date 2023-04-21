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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void bt_Login_Click(object sender, EventArgs e)
        {
            ConnectDataBase c = new ConnectDataBase();
            c.connectData();
            string sql = "SELECT * FROM EmployeeAccount " +
                         "WHERE userEmployeeAccount = '" + tb_Username.Text +
                         "' and passEmployeeAccount = '" + tb_Password.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, c._conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read() == false)
            {
                MessageBox.Show("Đăng nhập không thành công !", "Lỗi !");
                tb_Username.Text = "";
                tb_Password.Text = "";
                tb_Username.Focus();
            }
            else
            {
                this.Hide();
                MainForm main = new MainForm();
                main.Show();
            }
            c.disconnectData();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
