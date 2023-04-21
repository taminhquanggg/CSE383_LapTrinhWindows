using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyThuVienBTL
{
    internal class ConnectDataBase
    {
        public SqlConnection _conn;

        public void connectData()
        {
            String strConn = @"Data Source=.\DATA_BASE;Initial Catalog=SQL_LibraryManagement;Integrated Security=True";
            try
            {
                _conn = new SqlConnection(strConn);
                _conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối CSDL !", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void disconnectData()
        {
            _conn.Close();
            _conn.Dispose();
            _conn = null;
        }

        public Boolean exeSQL(string cmd)
        {
            try
            {
                SqlCommand sc = new SqlCommand(cmd, _conn);
                sc.ExecuteNonQuery();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }

}
