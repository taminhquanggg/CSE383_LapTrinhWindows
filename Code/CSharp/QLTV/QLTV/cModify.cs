using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QLTV
{
    class cModify
    {
        SqlDataAdapter dataAdapter;
        SqlCommand sqlCommand;
        public int update_SLSach = 0;
        public int update_SoDu = 0;

        public cModify()
        {

        }

        //
        //// START OBJECT DOC GIA
        public DataTable getAllDocGia()
        {
            DataTable dt = new DataTable();
            string query = "select maDG 'Mã ĐG', " +
                            "tenDG 'Tên ĐG', " +
                            "gioiTinhDG 'Giới tính', " +
                            "ngaySinhDG 'Ngày sinh', " +
                            "sdtDG 'SĐT', " +
                            "diaChiDG 'Địa chỉ', " +
                            "ngayLapThe 'Ngày lập thẻ', " +
                            "ngayHetHan 'Ngày hết hạn', " +
                            "soDu 'Số dư', " +
                            "anhDG 'Hình ảnh' " +
                            "from docGia";
            using (SqlConnection sqlConnection = cConnection.getConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dt);
                sqlConnection.Close();
            }
            return dt;
        }

        public Boolean insertDocGia(string maDG, string tenDG, string sdtDG, DateTime ngaySinhDG, string gioiTinhDG, DateTime ngayLapThe, DateTime ngayHetHan, int soDu, string diaChiDG)
        {
            string query = "insert into docGia values ('" + maDG + "', N'" + tenDG + "', '" + sdtDG + "', '" + ngaySinhDG + "', N'" + gioiTinhDG + "', '" + ngayLapThe + "', '" + ngayHetHan + "', '" + soDu + "', N'" + diaChiDG + "', null)";
            using (SqlConnection sqlConnection = cConnection.getConnection())
            {
                sqlConnection.Open();
                try
                {
                    SqlCommand sc = new SqlCommand(query, sqlConnection);
                    sc.ExecuteNonQuery();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
        }

        public void queryDocGia(string query, string maDG, string tenDG, string sdtDG, DateTime ngaySinhDG, string gioiTinhDG, DateTime ngayLapThe, DateTime ngayHetHan, int soDu, string diaChiDG, byte[] anhDG)
        {
            
            using (SqlConnection sqlConnection = cConnection.getConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@maDG", maDG);
                sqlCommand.Parameters.Add("@tenDG", tenDG);
                sqlCommand.Parameters.Add("@sdtDG", sdtDG);
                sqlCommand.Parameters.Add("@ngaySinhDG", ngaySinhDG);
                sqlCommand.Parameters.Add("@gioiTinhDG", gioiTinhDG);
                sqlCommand.Parameters.Add("@ngayLapThe", ngayLapThe);
                sqlCommand.Parameters.Add("@ngayHetHan", ngayHetHan);
                sqlCommand.Parameters.Add("@soDu", soDu);
                sqlCommand.Parameters.Add("@diaChiDG", diaChiDG);
                sqlCommand.Parameters.Add("@anhDG", anhDG);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }

            
        }

        public Boolean updateDocGia(string maDG, string tenDG, string sdtDG, DateTime ngaySinhDG, string gioiTinhDG, DateTime ngayLapThe, DateTime ngayHetHan, int soDu, string diaChiDG)
        {
            string query = "update docGia set tenDG = N'" + tenDG + "', sdtDG = '" + sdtDG + "', ngaySinhDG = '" + ngaySinhDG + "', gioiTinhDG = N'" + gioiTinhDG + "', ngayLapThe = '" + ngayLapThe + "', ngayHetHan = '" + ngayHetHan + "', soDu = '" + soDu + "', diaChiDG = N'" + soDu + "', anhDG = null where maDG = '" + maDG + "'";
            using (SqlConnection sqlConnection = cConnection.getConnection())
            {
                sqlConnection.Open();
                try
                {
                    SqlCommand sc = new SqlCommand(query, sqlConnection);
                    sc.ExecuteNonQuery();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
        }

        public Boolean deleteDocGia(string maDG)
        {
            string query = "delete docGia where maDG = '" + maDG + "'";
            using (SqlConnection sqlConnection = cConnection.getConnection())
            {
                sqlConnection.Open();
                try
                {
                    SqlCommand sc = new SqlCommand(query, sqlConnection);
                    sc.ExecuteNonQuery();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
        }

        public DataTable searchDocGia(string kieu, string data)
        {
            DataTable dt = new DataTable();
            string query = "select maDG 'Mã ĐG', " +
                            "tenDG 'Tên ĐG', " +
                            "gioiTinhDG 'Giới tính', " +
                            "ngaySinhDG 'Ngày sinh', " +
                            "sdtDG 'SĐT', " +
                            "diaChiDG 'Địa chỉ', " +
                            "ngayLapThe 'Ngày lập thẻ', " +
                            "ngayHetHan 'Ngày hết hạn', " +
                            "soDu 'Số dư', " +
                            "anhDG 'Hình ảnh' " +
                            "from docGia" + 
                            " where " + kieu + "DG like N'%" + data + "%'";
            using (SqlConnection sqlConnection = cConnection.getConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dt);
                sqlConnection.Close();
            }
            return dt;
        }
        //// END OBJECT DOC GIA
        //




        //
        //// START OBJECT LOAI SACH
        public DataTable getAllLoaiSach()
        {
            DataTable dt = new DataTable();
            string query = "select maLoaiSach 'Mã Loại sách', " +
                            "tenLoaiSach 'Tên Loại sách' " +
                            "from LoaiSach";
            using (SqlConnection sqlConnection = cConnection.getConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dt);
                sqlConnection.Close();
            }
            return dt;
        }

        public Boolean insertLoaiSach(string maLoai, string tenLoai)
        {
            string query = "insert into LoaiSach values ('" + maLoai + "', N'" + tenLoai + "')";
            using (SqlConnection sqlConnection = cConnection.getConnection())
            {
                sqlConnection.Open();
                try
                {
                    SqlCommand sc = new SqlCommand(query, sqlConnection);
                    sc.ExecuteNonQuery();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
        }

        public Boolean updateLoaiSach(string maLoai, string tenLoai)
        {
            string query = "update LoaiSach set tenLoaiSach = N'" + tenLoai + "' where maLoaiSach = '" + maLoai + "'";
            using (SqlConnection sqlConnection = cConnection.getConnection())
            {
                sqlConnection.Open();
                try
                {
                    SqlCommand sc = new SqlCommand(query, sqlConnection);
                    sc.ExecuteNonQuery();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
        }

        public Boolean deleteLoaiSach(string maLoai)
        {
            string query = "delete LoaiSach where maLoaiSach = '" + maLoai + "'";
            using (SqlConnection sqlConnection = cConnection.getConnection())
            {
                sqlConnection.Open();
                try
                {
                    SqlCommand sc = new SqlCommand(query, sqlConnection);
                    sc.ExecuteNonQuery();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
        }

        public DataTable searchLoaiSach(string kieu, string data)
        {
            DataTable dt = new DataTable();
            string query = "select maLoaiSach 'Mã Loại sách', " +
                            "tenLoaiSach 'Tên Loại sách' " +
                            "from LoaiSach where " + kieu + "LoaiSach like N'%" + data + "%'";
            using (SqlConnection sqlConnection = cConnection.getConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dt);
                sqlConnection.Close();
            }
            return dt;
        }
        //// END OBJECT LOAI SACH
        //




        //
        ////START OBJECT NCC
        public DataTable getAllNCC()
        {
            DataTable dt = new DataTable();
            string query = "select maNCC 'Mã NCC', " +
                            "tenNCC 'Tên NCC', " +
                            "sdtNCC 'SĐT', " +
                            "diaChiNCC 'Địa chỉ NCC' " +
                            "from NCC";
            using (SqlConnection sqlConnection = cConnection.getConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dt);
                sqlConnection.Close();
            }
            return dt;
        }

        public Boolean insertNCC(string maNCC, string tenNCC, string sdtNCC, string diaChiNCC)
        {
            string query = "insert into NCC values ('" + maNCC + "', N'" + tenNCC + "', '" + sdtNCC + "', N'" + diaChiNCC + "')";
            using (SqlConnection sqlConnection = cConnection.getConnection())
            {
                sqlConnection.Open();
                try
                {
                    SqlCommand sc = new SqlCommand(query, sqlConnection);
                    sc.ExecuteNonQuery();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
        }

        public Boolean updateNCC(string maNCC, string tenNCC, string sdtNCC, string diaChiNCC)
        {
            string query = "update NCC set tenNCC = N'" + tenNCC +  "', sdtNCC = '" + sdtNCC + "', diaChiNCC = N'" + diaChiNCC + "' where maNCC = '" + maNCC +"'";
            using (SqlConnection sqlConnection = cConnection.getConnection())
            {
                sqlConnection.Open();
                try
                {
                    SqlCommand sc = new SqlCommand(query, sqlConnection);
                    sc.ExecuteNonQuery();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
        }

        public Boolean deleteNCC(string maNCC)
        {
            string query = "delete NCC where maNCC = '" + maNCC + "'";
            using (SqlConnection sqlConnection = cConnection.getConnection())
            {
                sqlConnection.Open();
                try
                {
                    SqlCommand sc = new SqlCommand(query, sqlConnection);
                    sc.ExecuteNonQuery();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
        }

        public DataTable searchNCC(string kieu, string data)
        {
            DataTable dt = new DataTable();
            string query = "select maNCC 'Mã NCC', " +
                            "tenNCC 'Tên NCC', " +
                            "sdtNCC 'SĐT', " +
                            "diaChiNCC 'Địa chỉ NCC' " +
                            "from NCC where " + kieu + "NCC like N'%"+ data +"%'";
            using (SqlConnection sqlConnection = cConnection.getConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dt);
                sqlConnection.Close();
            }
            return dt;
        }
        ////END OBJECT NCC
        //



        //
        ////START OBJECT SACH
        public DataTable getAllSach()
        {
            DataTable dt = new DataTable();
            string query = "select maSach 'Mã sách', " +
                            "tenSach 'Tên sách', " +
                            "LoaiSach.tenLoaiSach 'Loại sách', " +
                            "tacGia 'Tác giả', " +
                            "NCC.tenNCC 'Nhà cung cấp', " +
                            "NamXB 'Năm xuất bản', " +
                            "soLuong 'Số lượng', " +
                            "donGia 'Đơn giá', " +
                            "tinhTrang 'Tình trạng', " +
                            "anhSach 'Hình ảnh' " +
                            "from LoaiSach, NCC, Sach " +
                            "where LoaiSach.maLoaiSach = Sach.idLoaiSach and Sach.idNCC = NCC.maNCC";
            using (SqlConnection sqlConnection = cConnection.getConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dt);
                sqlConnection.Close();
            }
            return dt;
        }

        public Boolean insertSach(string maSach, string tenSach, string idLoaiSach, string tacGia, string idNCC, int NamXB, int soLuong, int donGia, string tinhTrang)
        {
            string query = "insert into Sach values ('" + maSach + "', N'" + tenSach + "', '" + idLoaiSach + "', N'" + tacGia + "', '" + idNCC + "', '" + NamXB + "', '" + soLuong + "', '" + donGia + "', N'" + tinhTrang + "', null)";
            using (SqlConnection sqlConnection = cConnection.getConnection())
            {
                sqlConnection.Open();
                try
                {
                    SqlCommand sc = new SqlCommand(query, sqlConnection);
                    sc.ExecuteNonQuery();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
        }

        public Boolean updateSach(string maSach, string tenSach, string idLoaiSach, string tacGia, string idNCC, int NamXB, int soLuong, int donGia, string tinhTrang)
        {
            
            string query = "update Sach set tenSach = '" + tenSach + "', idLoaiSach = '" + idLoaiSach + "', tacGia = N'" + tacGia + "', idNCC = '" + idNCC + "', NamXB = '" + NamXB + "', soLuong = '" + soLuong + "', donGia = '" + donGia + "', tinhTrang = N'" + tinhTrang + "', anhSach = null where maSach = '" + maSach + "'";
            using (SqlConnection sqlConnection = cConnection.getConnection())
            {
                sqlConnection.Open();
                try
                {
                    SqlCommand sc = new SqlCommand(query, sqlConnection);
                    sc.ExecuteNonQuery();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
        }

        public Boolean deleteSach(string maSach)
        {
            string query = "delete Sach where maSach = '" + maSach + "'";
            using (SqlConnection sqlConnection = cConnection.getConnection())
            {
                sqlConnection.Open();
                try
                {
                    SqlCommand sc = new SqlCommand(query, sqlConnection);
                    sc.ExecuteNonQuery();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
        }

        public DataTable searchSach(string kieu, string data)
        {
            DataTable dt = new DataTable();
            string query = "select maSach 'Mã sách', " +
                            "tenSach 'Tên sách', " +
                            "LoaiSach.tenLoaiSach 'Loại sách', " +
                            "tacGia 'Tác giả', " +
                            "NCC.tenNCC 'Nhà cung cấp', " +
                            "NamXB 'Năm xuất bản', " +
                            "soLuong 'Số lượng', " +
                            "donGia 'Đơn giá', " +
                            "tinhTrang 'Tình trạng', " +
                            "anhSach 'Hình ảnh' " +
                            "from LoaiSach, NCC, Sach " +
                            "where LoaiSach.maLoaiSach = Sach.idLoaiSach and Sach.idNCC = NCC.maNCC and " + kieu + " like N'%" + data + "%'";
            
            using (SqlConnection sqlConnection = cConnection.getConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dt);
                sqlConnection.Close();
            }
            return dt;
        }

        public void querySach(string query, string maSach, string tenSach, string idLoaiSach, string tacGia, string idNCC, int NamXB, int soLuong, int donGia, string tinhTrang, byte[] anhSach)
        {

            using (SqlConnection sqlConnection = cConnection.getConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@maSach", maSach);
                sqlCommand.Parameters.Add("@tenSach", tenSach);
                sqlCommand.Parameters.Add("@idLoaiSach", idLoaiSach);
                sqlCommand.Parameters.Add("@tacGia", tacGia);
                sqlCommand.Parameters.Add("@idNCC", idNCC);
                sqlCommand.Parameters.Add("@NamXB", NamXB);
                sqlCommand.Parameters.Add("@soLuong", soLuong);
                sqlCommand.Parameters.Add("@donGia", donGia);
                sqlCommand.Parameters.Add("@tinhTrang", tinhTrang);
                sqlCommand.Parameters.Add("@anhSach", anhSach);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }

        ////END OBJECT SACH
        //


        //
        ////START OBJECT MUON _ TRA SACH
        public DataTable getAllPhieuMuon()
        {
            DataTable dt = new DataTable();
            string query = "select maPhieu 'Mã phiếu', " +
                            "maDG 'Mã ĐG', " +
                            "ngayLapPhieu 'Ngày lập phiếu', " +
                            "maSach 'Mã sách', " +
                            "ngayMuon 'Ngày mượn', " +
                            "ngayHenTra 'Ngày hẹn trả', " +
                            "slMuon 'SL mượn', " +

                            "tinhTrang 'Tình trạng' " +
                            "from PhieuMuon where daTra = 'False' and maSach is not null";
            using (SqlConnection sqlConnection = cConnection.getConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dt);
                sqlConnection.Close();
            }
            return dt;
        }

        public DataTable getInfoSachMuon(string maSach)
        {
            DataTable dt = new DataTable();
            string query = "select maSach 'Mã sách', " +
                            "tenSach 'Tên sách', " +
                            "tacGia 'Tác giả', " +
                            "NCC.tenNCC 'Nhà cung cấp', " +
                            "donGia 'Đơn giá', " +
                            "tinhTrang 'Tình trạng' " +
                            "from NCC, Sach " +
                            "where Sach.idNCC = NCC.maNCC and maSach = '" + maSach + "'";
            using (SqlConnection sqlConnection = cConnection.getConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dt);
                sqlConnection.Close();
            }
            return dt;
        }

        public Boolean insertPhieuMuon(string maPhieu, string maDG, DateTime ngayLapPhieu)
        {
            string query = "insert into phieuMuon values ('" + maPhieu + "', '" + maDG + "', '" + ngayLapPhieu + "', null, null, null, null, null, 'False', null, null, null, null)";
            using (SqlConnection sqlConnection = cConnection.getConnection())
            {
                sqlConnection.Open();
                try
                {
                    SqlCommand sc = new SqlCommand(query, sqlConnection);
                    sc.ExecuteNonQuery();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
        }

        public Boolean insertTTPhieu(string maPhieu, string maSach, string slMuon, DateTime ngayMuon, DateTime ngayHenTra, string tinhTrang)
        {
            string query = "update phieuMuon set maSach = '" + maSach + "', slMuon = '" + slMuon + "', ngayMuon = '" + ngayMuon + "', ngayHenTra = '" + ngayHenTra + "', tinhTrang = N'" + tinhTrang + "' where maPhieu = '" + maPhieu + "' ";
            using (SqlConnection sqlConnection = cConnection.getConnection())
            {
                sqlConnection.Open();
                try
                {
                    SqlCommand sc = new SqlCommand(query, sqlConnection);
                    sc.ExecuteNonQuery();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
        }

        public Boolean updatePhieuMuon(string maPhieu, DateTime ngayMuon, DateTime ngayHenTra)
        {
            string query = "update phieuMuon set ngayMuon = '" + ngayMuon + "', ngayHenTra = '" + ngayHenTra + "' where maPhieu = '" + maPhieu + "'";
            using (SqlConnection sqlConnection = cConnection.getConnection())
            {
                sqlConnection.Open();
                try
                {
                    SqlCommand sc = new SqlCommand(query, sqlConnection);
                    sc.ExecuteNonQuery();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
        }

        public DataTable searchPhieuMuon(string kieu, string data)
        {
            string query = "select maPhieu 'Mã phiếu', " +
                            "maDG 'Mã ĐG', " +
                            "ngayLapPhieu 'Ngày lập phiếu', " +
                            "maSach 'Mã sách', " +
                            "ngayMuon 'Ngày mượn', " +
                            "ngayHenTra 'Ngày hẹn trả', " +
                            "slMuon 'SL mượn', " +
                            "tinhTrang 'Tình trạng' " +
                            "from PhieuMuon where daTra = 'False' and maSach is not null and " + kieu + " like N'%" + data + "%'";
            
            DataTable dt = new DataTable();
            using (SqlConnection sqlConnection = cConnection.getConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dt);
                sqlConnection.Close();
            }
            return dt;
        }

        public Boolean updatePhieuTra(string maPhieu, string tinhTrang, string sl, string phiPhat)
        {
            string query = "update phieuMuon set daTra = 'True', ngayTra = '" + DateTime.Now + "' , tinhTrangTra = N'" + tinhTrang + "', slTra = '" + sl + "', phiPhat = '" + phiPhat + "' where maPhieu = '" + maPhieu + "'";
            using (SqlConnection sqlConnection = cConnection.getConnection())
            {
                sqlConnection.Open();
                try
                {
                    SqlCommand sc = new SqlCommand(query, sqlConnection);
                    sc.ExecuteNonQuery();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
        }
        ///END OBJECT MUON _ TRA SACH
        ///

        ////
        ///START OBJECT DANG NHAP
        ///
        public Boolean insertNV(string tenNV, DateTime ngaySinhNV, string gioiTinhNV, string sdtNV, string diaChiNV, string tkNV, string mkNV)
        {
            string query = "insert into NV values (N'" + tenNV + "', " +
                "'" + ngaySinhNV + "', " +
                "N'" + gioiTinhNV + "', " +
                "'" + sdtNV + "', " +
                "N'" + diaChiNV + "', " +
                "'" + tkNV + "', " +
                "'" + mkNV + "')";
            using (SqlConnection sqlConnection = cConnection.getConnection())
            {
                sqlConnection.Open();
                try
                {
                    SqlCommand sc = new SqlCommand(query, sqlConnection);
                    sc.ExecuteNonQuery();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
        }

        public Boolean updateMKNV(string tkNV, string mkNV)
        {
            string query = "update NV set mkNV = '" + mkNV + "' where tkNV = '" + tkNV + "'";
            using (SqlConnection sqlConnection = cConnection.getConnection())
            {
                sqlConnection.Open();
                try
                {
                    SqlCommand sc = new SqlCommand(query, sqlConnection);
                    sc.ExecuteNonQuery();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
        }

        public Boolean updateNV(string tkNV, string tenNV, DateTime ngaySinhNV, string gioiTinhNV, string sdtNV, string diaChiNV)
        {
            string query = "update NV set tenNV = N'" + tenNV + "', ngaySinhNV = '" + ngaySinhNV + "', gioiTinhNV = N'" + gioiTinhNV + "', sdtNV = '" + sdtNV + "', diaChiNV = N'" + diaChiNV + "' where tkNV = '" + tkNV + "'";
            using (SqlConnection sqlConnection = cConnection.getConnection())
            {
                sqlConnection.Open();
                try
                {
                    SqlCommand sc = new SqlCommand(query, sqlConnection);
                    sc.ExecuteNonQuery();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
        }

        public DataTable getAllNV(string tkNV)
        {
            DataTable dt = new DataTable();
            string query = "select * from NV where tkNV = '" + tkNV + "'";
            using (SqlConnection sqlConnection = cConnection.getConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dt);
                sqlConnection.Close();
            }
            return dt;
        }
        
        public DataTable getInfoNV()
        {
            DataTable dt = new DataTable();
            string query = "select tenNV 'Tên NV', ngaySinhNV 'Ngày sinh', gioiTinhNV 'Giới tính', sdtNV 'SĐT', diaChiNV 'Địa chỉ', tkNV 'Tài khoản' from NV";
            using (SqlConnection sqlConnection = cConnection.getConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dt);
                sqlConnection.Close();
            }
            return dt;
        }
        
        ////
        ///END OBJECT DANG NHAP
        ///

        public DataTable getThongKe()
        {
            DataTable dt = new DataTable();
            string query = "select * from thongKe where id = 1";
            using (SqlConnection sqlConnection = cConnection.getConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dt);
                sqlConnection.Close();
            }
            return dt;
        }



        public void updateSL_LoaiSach(string kieu)
        {
            string query = "update thongKe set slLoaiSach = slLoaiSach " + kieu + " 1 where id = '1'";
            using (SqlConnection sqlConnection = cConnection.getConnection())
            {
                sqlConnection.Open();
                try
                {
                    SqlCommand sc = new SqlCommand(query, sqlConnection);
                    sc.ExecuteNonQuery();
                }
                catch (Exception)
                {

                }
                finally
                {
                    sqlConnection.Close();
                }
            }
        }

        public void updateSL_Sach(string sl, string kieu)
        {
            string query = "update thongKe set slSach = slSach " + kieu + " " + sl + " where id = '1'";
            using (SqlConnection sqlConnection = cConnection.getConnection())
            {
                sqlConnection.Open();
                try
                {
                    SqlCommand sc = new SqlCommand(query, sqlConnection);
                    sc.ExecuteNonQuery();
                }
                catch (Exception)
                {
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
        }

        public void updateSL_DangMuon(string sl, string kieu)
        {
            string query = "update thongKe set slDangMuon = slDangMuon " + kieu + " " + sl + " where id = '1'";
            using (SqlConnection sqlConnection = cConnection.getConnection())
            {
                sqlConnection.Open();
                SqlCommand sc = new SqlCommand(query, sqlConnection);
                sc.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }

        public void updateDoanhThu(string TT)
        {
            string query = "update thongKe set doanhThu = doanhThu + " + TT + " where id = '1'";
            using (SqlConnection sqlConnection = cConnection.getConnection())
            {
                sqlConnection.Open();
                SqlCommand sc = new SqlCommand(query, sqlConnection);
                sc.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }

        public void updateslDG(string kieu)
        {
            string query = "update thongKe set slDG = slDG " + kieu + " 1 where id = '1'";
            using (SqlConnection sqlConnection = cConnection.getConnection())
            {
                sqlConnection.Open();
                SqlCommand sc = new SqlCommand(query, sqlConnection);
                sc.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }

        public void updatesl_SachMat(string sl)
        {
            string query = "update thongKe set slMat = slMat + " + sl + " where id = '1'";
            using (SqlConnection sqlConnection = cConnection.getConnection())
            {
                sqlConnection.Open();
                SqlCommand sc = new SqlCommand(query, sqlConnection);
                sc.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }

        public void updateslNCC(string kieu)
        {
            string query = "update thongKe set slNCC = slNCC " + kieu + " 1 where id = '1'";
            using (SqlConnection sqlConnection = cConnection.getConnection())
            {
                sqlConnection.Open();
                SqlCommand sc = new SqlCommand(query, sqlConnection);
                sc.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }

        public DataTable getDS_QuaHan()
        {
            DataTable dt = new DataTable();
            string query = "select maPhieu 'Mã phiếu', " +
                            "maDG 'Mã ĐG', " +
                            "maSach 'Mã sách', " +
                            "ngayMuon 'Ngày mượn', " +
                            "ngayHenTra 'Ngày hẹn trả', " +
                            "ngayTra 'Ngày trả' " +
                            "from PhieuMuon where daTra = 'True' and ngayTra > ngayHenTra";
            using (SqlConnection sqlConnection = cConnection.getConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dt);
                sqlConnection.Close();
            }
            return dt;
        }
    }

}
