using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanHang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int _stt = 0;
        int _rowIndex = -1;

        private void bt_tao_Click(object sender, EventArgs e)
        {
            dGV_donHang.Rows.Clear();
            tb_tongTien.Text = "";
        }

        private void cb_tenHang_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cb_tenHang.SelectedItem == "Bánh mì")
            {
                tb_donGia.Text = (5000).ToString();
            }
            else if (cb_tenHang.SelectedItem == "Kẹo mút")
            {
                tb_donGia.Text = (2000).ToString();
            }
            else if (cb_tenHang.SelectedItem == "Bánh bao")
            {
                tb_donGia.Text = (10000).ToString();
            }
            else if (cb_tenHang.SelectedItem == "Kem đánh răng")
            {
                tb_donGia.Text = (15000).ToString();
            }
        }

        private void nUD_SL_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            _stt++;
            dGV_donHang.Rows.Add(_stt, cb_tenHang.SelectedItem, nUD_SL.Value.ToString(), tb_donGia.Text, Convert.ToInt32(nUD_SL.Value) * Convert.ToInt32(tb_donGia.Text));
            tb_tenKhach.Text = "";
            cb_tenHang.SelectedIndex = -1;
            nUD_SL.Value = 0;
            tb_donGia.Text = "";

        }

        private void dGV_donHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _rowIndex = dGV_donHang.CurrentCell.RowIndex;
        }

        private void bt_dele_Click(object sender, EventArgs e)
        {
            dGV_donHang.Rows.RemoveAt(_rowIndex);
        }

        private void bt_thanhToan_Click(object sender, EventArgs e)
        {
            double s = 0;
            for (int i=0; i<dGV_donHang.RowCount; i++)
            {
                s = s + Convert.ToInt32(dGV_donHang.Rows[i].Cells[4].Value);
            }
            tb_tongTien.Text = s.ToString();
        }

        private void đổiMàuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog _colorDialog = new ColorDialog();
            if (_colorDialog.ShowDialog() == DialogResult.OK)
            {
                contextMenuStrip1.SourceControl.BackColor = _colorDialog.Color;
            }
        }

        private void dGV_donHang_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip2.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }

        private void đổiMàuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ColorDialog _colorDialog = new ColorDialog();
            if (_colorDialog.ShowDialog() == DialogResult.OK)
            {
                dGV_donHang.BackgroundColor = _colorDialog.Color;
            }
        }
    }
}
