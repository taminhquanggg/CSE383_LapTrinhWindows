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
    public partial class frmDoiMK : Form
    {
        public frmDoiMK()
        {
            InitializeComponent();
        }

        cModify modify;
        SqlDataAdapter dataAdapter;

        private void frmDoiMK_Load(object sender, EventArgs e)
        {
            
            tb_TK.Text = "";
            tb_MK.Text = "";
            tb_MKmoi.Text = "";
            tb_reMKmoi.Text = "";
        }

        private void bt_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_doiMK_Click(object sender, EventArgs e)
        {
            modify = new cModify();

            DataTable dt = new DataTable();

            string query = "select mkNV from NV where tkNV = '" + tb_TK.Text + "'";

            using (SqlConnection sqlConnection = cConnection.getConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dt);
                sqlConnection.Close();
            }

            if (tb_MK.Text != dt.Rows[0][0].ToString())
            {
                MessageBox.Show("Mật khẩu cũ không chính xác!", "Lỗi!");
                tb_MK.Text = "";
                tb_MK.Focus();
                return;
            }

            if (tb_MKmoi.Text != tb_reMKmoi.Text)
            {
                MessageBox.Show("Mật khẩu mới không khớp nhau!", "Lỗi!");
                tb_MKmoi.Text = "";
                tb_reMKmoi.Text = "";
                tb_MKmoi.Focus();
                return;
            }

            modify = new cModify();
            bool kq = modify.updateMKNV(tb_TK.Text, tb_MKmoi.Text);
            if (kq == true)
            {
                MessageBox.Show("Thay đổi mật khẩu thành công!", "Thành công!");
                frmDoiMK_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Thay đổi mật khẩu thất bại!", "Thất bại!");
            }

        }
    }
}
