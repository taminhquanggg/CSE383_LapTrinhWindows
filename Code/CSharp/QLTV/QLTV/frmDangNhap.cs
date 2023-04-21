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
    public partial class frmDangNhap : Form
    {
        frmMainForm frmForm;
        public frmDangNhap(frmMainForm frmMain)
        {
            InitializeComponent();
            frmForm = frmMain;
        }

        private void bt_DangNhap_Click(object sender, EventArgs e)
        {
            string query = "select * from NV where tkNV = '" + tb_TK.Text + "' and mkNV = '" + tb_MK.Text + "'";
            frmForm.tk = tb_TK.Text;
            using (SqlConnection sqlConnection = cConnection.getConnection())
            {
                sqlConnection.Open();

                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read() == false)
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác !", "Thông báo !");
                    tb_TK.Text = "";
                    tb_MK.Text = "";
                    tb_TK.Focus();
                }
                else
                {
                    this.Close();
                    frmForm.isLogin = true;
                    frmForm.frmMainForm_Load(null, null);
                }

                sqlConnection.Close();
            }
        }
    }
}
