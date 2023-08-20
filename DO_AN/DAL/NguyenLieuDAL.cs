using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DO_AN.MODEL;

namespace DO_AN.DAL
{
    internal class NguyenLieuDAL : DBConnection
    {
        public List<NguyenLieu> ReadHang()
        {
            using (SqlConnection conn = CreateConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM tblHang", conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    List<NguyenLieu> lstHang = new List<NguyenLieu>();

                    while (reader.Read())
                    {
                        NguyenLieu hang = new NguyenLieu
                        {
                            MaHang = reader["MaHang"].ToString(),
                            TenHang = reader["TenHang"].ToString(),
                            MaChatLieu = reader["MaChatLieu"].ToString(),
                            SoLuong = Convert.ToInt32(reader["SoLuong"]),
                            DonGiaNhap = reader["DonGiaNhap"].ToString(),
                            DonGiaBan = reader["DonGiaBan"].ToString(),
                            Anh = reader["Anh"].ToString(),
                            GhiChu = reader["GhiChu"].ToString()
                        };

                        lstHang.Add(hang);
                    }

                    return lstHang;
                }
            }
        }

        public List<string> GetMaChatLieuList()
        {
            ChatLieuDAL chatLieuDAL = new ChatLieuDAL();
            List<string> maChatLieuList = chatLieuDAL.ReadAllMaChatLieu();
            return maChatLieuList;
        }
      
        //xóa
        public void DeleteHang(NguyenLieu hang)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM tblHang WHERE MaHang = @MaHang", conn);
            cmd.Parameters.Add(new SqlParameter("@MaHang", hang.MaHang));
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        //thêm
        public void NewHang(NguyenLieu hang)
        {
            try
            {
                using (SqlConnection conn = CreateConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO tblHang (MaHang, TenHang, MaChatLieu, SoLuong, DonGiaNhap, DonGiaBan, Anh, GhiChu) VALUES (@MaHang, @TenHang, @MaChatLieu, @SoLuong, @DonGiaNhap, @DonGiaBan, @Anh, @GhiChu)", conn);
                    cmd.Parameters.Add(new SqlParameter("@MaHang", hang.MaHang));
                    cmd.Parameters.Add(new SqlParameter("@TenHang", hang.TenHang));
                    cmd.Parameters.Add(new SqlParameter("@MaChatLieu", hang.MaChatLieu));
                    cmd.Parameters.Add(new SqlParameter("@SoLuong", hang.SoLuong));
                    cmd.Parameters.Add(new SqlParameter("@DonGiaNhap", hang.DonGiaNhap));
                    cmd.Parameters.Add(new SqlParameter("@DonGiaBan", hang.DonGiaBan));
                    cmd.Parameters.Add(new SqlParameter("@Anh", hang.Anh));
                    cmd.Parameters.Add(new SqlParameter("@GhiChu", hang.GhiChu));
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Lỗi SQL: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
        }


        //sữa
        public void EditHang(NguyenLieu hang)
        {
            using (SqlConnection conn = CreateConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE tblHang SET TenHang = @TenHang, MaChatLieu = @MaChatLieu, SoLuong = @SoLuong, DonGiaNhap = @DonGiaNhap, DonGiaBan = @DonGiaBan, Anh = @Anh, GhiChu = @GhiChu WHERE MaHang = @MaHang", conn);
                    cmd.Parameters.Add(new SqlParameter("@MaHang", hang.MaHang));
                    cmd.Parameters.Add(new SqlParameter("@TenHang", hang.TenHang));
                    cmd.Parameters.Add(new SqlParameter("@MaChatLieu", hang.MaChatLieu));
                    cmd.Parameters.Add(new SqlParameter("@SoLuong", hang.SoLuong));
                    cmd.Parameters.Add(new SqlParameter("@DonGiaNhap", hang.DonGiaNhap));
                    cmd.Parameters.Add(new SqlParameter("@DonGiaBan", hang.DonGiaBan));
                    cmd.Parameters.Add(new SqlParameter("@Anh", hang.Anh));
                    cmd.Parameters.Add(new SqlParameter("@GhiChu", hang.GhiChu));
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("SQL Error: " + ex.Message);
                }
            }
        }


        public List<NguyenLieu> SearchHangByMaAndTen(string maHang, string tenHang)
        {
            using (SqlConnection conn = CreateConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM tblHang WHERE MaHang = @MaHang OR TenHang = @TenHang", conn))
                {
                    cmd.Parameters.AddWithValue("@MaHang", maHang);
                    cmd.Parameters.AddWithValue("@TenHang", tenHang);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        List<NguyenLieu> searchResults = new List<NguyenLieu>();

                        while (reader.Read())
                        {
                            NguyenLieu hang = new NguyenLieu
                            {
                                MaHang = reader["MaHang"].ToString(),
                                TenHang = reader["TenHang"].ToString(),
                                MaChatLieu = reader["MaChatLieu"].ToString(),
                                SoLuong = Convert.ToInt32(reader["SoLuong"]),
                                DonGiaNhap = reader["DonGiaNhap"].ToString(),
                                DonGiaBan = reader["DonGiaBan"].ToString(),
                                Anh = reader["Anh"].ToString(),
                                GhiChu = reader["GhiChu"].ToString()
                            };

                            searchResults.Add(hang);
                        }

                        return searchResults;
                    }
                }
            }
        }

    }



}
