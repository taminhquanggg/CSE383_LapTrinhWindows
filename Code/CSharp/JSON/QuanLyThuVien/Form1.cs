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

namespace QuanLyThuVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataTable dataTable_Sach = new DataTable("Sách");
        DataTable dataTable_MuonSach = new DataTable("Mượn sách");
        DataTable dataTable_LuotMuon = new DataTable("Lượt mượn");
        DataTable dataTable_TraMuon = new DataTable("Trả muộn");
        private static int stt_muon = 0, stt_quaHan = 0, stt_TKMuon = 0;


        private void Form1_Load(object sender, EventArgs e)
        {
            dataTable_Sach.Columns.Add("Mã sách");
            dataTable_Sach.Columns.Add("Tên sách");

            dataTable_MuonSach.Columns.Add("STT");
            dataTable_MuonSach.Columns.Add("Họ tên sinh viên");
            dataTable_MuonSach.Columns.Add("Tên sách");
            dataTable_MuonSach.Columns.Add("Ngày mượn");
            dataTable_MuonSach.Columns.Add("Ngày trả");
            dataTable_MuonSach.Columns.Add("Thành tiền");

            dataTable_LuotMuon.Columns.Add("STT");
            dataTable_LuotMuon.Columns.Add("Tên sách");
            dataTable_LuotMuon.Columns.Add("Tổng lượt mượn");

            dataTable_TraMuon.Columns.Add("STT");
            dataTable_TraMuon.Columns.Add("Họ và tên");
            dataTable_TraMuon.Columns.Add("Số ngày quá hạn");

            if (System.IO.File.Exists(@"dataSach.json"))
            {
                
                System.IO.StreamReader reader = new System.IO.StreamReader(@"dataSach.json");
                string str = reader.ReadToEnd();
                reader.Close();
                dataTable_Sach = JsonConvert.DeserializeObject<DataTable>(str);
                
            }

            if (System.IO.File.Exists(@"dataMuon.json"))
            {
                System.IO.StreamReader reader = new System.IO.StreamReader(@"dataMuon.json");
                string str = reader.ReadToEnd();
                reader.Close();
                dataTable_MuonSach = JsonConvert.DeserializeObject<DataTable>(str);
            }

            if (System.IO.File.Exists(@"dataLuotMuon.json"))
            {
                System.IO.StreamReader reader = new System.IO.StreamReader(@"dataLuotMuon.json");
                string str = reader.ReadToEnd();
                reader.Close();
                dataTable_LuotMuon = JsonConvert.DeserializeObject<DataTable>(str);
            }

            if (System.IO.File.Exists(@"dataTraMuon.json"))
            {
                System.IO.StreamReader reader = new System.IO.StreamReader(@"dataTraMuon.json");
                string str = reader.ReadToEnd();
                reader.Close();
                dataTable_TraMuon = JsonConvert.DeserializeObject<DataTable>(str);
            }

            dataGridView_Sach.DataSource = dataTable_Sach;
            dataGridView_MuonSach.DataSource = dataTable_MuonSach;
            dataGridView_ThongKe.DataSource = dataTable_LuotMuon;
            dataGridViewQuaHan.DataSource = dataTable_TraMuon;

            for (int i=0; i< dataGridView_Sach.RowCount; i++)
            {
                cb_tenSach.Items.Add(dataGridView_Sach.Rows[i].Cells[1].Value.ToString());
            }
        }

        private void dt_ngayMuon_ValueChanged(object sender, EventArgs e)
        {
            dt_ngayTra.Value = dt_ngayMuon.Value.AddDays(40);
        }

        private void dataGridView_MuonSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView_MuonSach.CurrentCell.RowIndex;
            cb_tenSV.Text = dataGridView_MuonSach.Rows[index].Cells[1].Value.ToString();
            cb_tenSach.Text = dataGridView_MuonSach.Rows[index].Cells[2].Value.ToString();
            dt_ngayMuon.Value = Convert.ToDateTime(dataGridView_MuonSach.Rows[index].Cells[3].Value);
            dt_ngayTra.Value = Convert.ToDateTime(dataGridView_MuonSach.Rows[index].Cells[4].Value);
        }

        private void bt_tra_Click(object sender, EventArgs e)
        {
            int index = dataGridView_MuonSach.CurrentCell.RowIndex;
            string jsonstr;
            dataTable_MuonSach.Rows[index][4] = dt_ngayTra.Value.ToShortDateString();
            if ((dt_ngayTra.Value - dt_ngayMuon.Value).TotalDays > 40)
            {
                stt_quaHan++;
                dataTable_MuonSach.Rows[index][5] = (((dt_ngayTra.Value - dt_ngayMuon.Value).TotalDays - 40) * 2000).ToString();
                
                dataTable_TraMuon.Rows.Add(stt_quaHan.ToString(), cb_tenSV.Text, (((dt_ngayTra.Value - dt_ngayMuon.Value).TotalDays - 40) * 2000).ToString());
                jsonstr = JsonConvert.SerializeObject(dataTable_TraMuon);
                System.IO.File.WriteAllText(@"dataTraMuon.json", jsonstr);

                MessageBox.Show("Trả sách thành công, bạn đã trả sách không đúng hạn và sẽ bị cảnh báo !", "Thông báo !");
            }
            else
            {
                MessageBox.Show("Trả sách thành công, cảm ơn bạn đã trả sách đúng hạn !", "Thông báo !");
            }

            jsonstr = JsonConvert.SerializeObject(dataTable_MuonSach);
            System.IO.File.WriteAllText(@"dataMuon.json", jsonstr);



            cb_tenSV.Text = "";
            cb_tenSach.Text = "";
            dt_ngayMuon.Value = DateTime.Now;
            dt_ngayTra.Value = DateTime.Now;
        }

        private void bt_themSach_Click(object sender, EventArgs e)
        {
            dataTable_Sach.Rows.Add(tb_maSach.Text, tb_tenSach.Text);
            cb_tenSach.Items.Add(tb_tenSach.Text);

            string jsonstr = JsonConvert.SerializeObject(dataTable_Sach);
            System.IO.File.WriteAllText(@"dataSach.json", jsonstr);

            MessageBox.Show("Thêm thành công !", "Thông báo !");
            tb_maSach.Text = "";
            tb_tenSach.Text = "";
            
        }

        private void bt_muon_Click(object sender, EventArgs e)
        {
            stt_muon++;
            dataTable_MuonSach.Rows.Add(stt_muon.ToString(), cb_tenSV.Text, cb_tenSach.Text, dt_ngayMuon.Value.ToShortDateString(), dt_ngayTra.Value.ToShortDateString(), "0");
            string jsonstr = JsonConvert.SerializeObject(dataTable_MuonSach);
            System.IO.File.WriteAllText(@"dataMuon.json", jsonstr);

            DataGridViewRow rowAdd = null;
            int id_TKMuon = -1;

            foreach (DataGridViewRow row in dataGridView_ThongKe.Rows)
            {
                if (row.Cells[1].Value.ToString() == cb_tenSach.Text)
                {
                    id_TKMuon = Convert.ToInt32(row.Cells[0].Value);
                    break;
                }
            }

            if (id_TKMuon>-1)
            {
                dataTable_LuotMuon.Rows[id_TKMuon - 1][2] = Convert.ToInt32(dataTable_LuotMuon.Rows[id_TKMuon - 1][2]) + 1;
                jsonstr = JsonConvert.SerializeObject(dataTable_LuotMuon);
                System.IO.File.WriteAllText(@"dataLuotMuon.json", jsonstr);
            }
            else
            {
                stt_TKMuon++;
                dataTable_LuotMuon.Rows.Add(stt_TKMuon.ToString(), cb_tenSach.Text, "1");
                jsonstr = JsonConvert.SerializeObject(dataTable_LuotMuon);
                System.IO.File.WriteAllText(@"dataLuotMuon.json", jsonstr);
            }

            MessageBox.Show("Mượn thành công !", "Thông báo !");
            cb_tenSV.Text = "";
            cb_tenSach.Text = "";
            dt_ngayMuon.Value = DateTime.Now;
            dt_ngayTra.Value = DateTime.Now;
        }
    }
}
