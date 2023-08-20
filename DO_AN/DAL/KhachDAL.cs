using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DO_AN.Model;
using DO_AN.MODEL;

namespace DO_AN.DAL
{
    internal class KhachDAL :DBConnection
    {
        public List<Khach> ReadKhachHang()
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from tblKhach", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<Khach> lstCus = new List<Khach>();
            while (reader.Read())
            {
                Khach cus = new Khach();
                cus.MaKhach = reader["MaKhach"].ToString();
                cus.TenKhach = reader["TenKhach"].ToString();
                cus.DienThoai = reader["DienThoai"].ToString();
                cus.DiaChi = reader["DiaChi"].ToString();
                lstCus.Add(cus);
            }
            conn.Close();
            return lstCus;
        }



        //xóa 
        public void DeletekhachHang(Khach cus)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from tblKhach where MaKhach  = @MaKhach", conn);
            cmd.Parameters.Add(new SqlParameter("@MaKhach", cus.MaKhach));
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        //thêm
        public void NewkhachHang(Khach cus)
        {
            try
            {
                using (SqlConnection conn = CreateConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO tblKhach (MaKhach, TenKhach, DiaChi, SoLienLac) VALUES (@MaKhach, @TenKhach, @DiaChi, @SoLienLac)", conn);
                    cmd.Parameters.Add(new SqlParameter("@MaKhac", cus.MaKhach));
                    cmd.Parameters.Add(new SqlParameter("@TenKhach", cus.TenKhach));
                    cmd.Parameters.Add(new SqlParameter("@DiaChi", cus.DiaChi));
                    cmd.Parameters.Add(new SqlParameter("@SoLienLac", cus.DienThoai));
                  
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                // Xử lý lỗi kết nối hoặc truy vấn
                Console.WriteLine("Đã xảy ra lỗi khi thực hiện thêm dữ liệu: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Xử lý lỗi chung (nếu có)
                Console.WriteLine("Đã xảy ra lỗi không xác định: " + ex.Message);
            }
        }




        //sữa
        public void EditkhachHang(Khach cus)
        {
            try
            {
                if (string.IsNullOrEmpty(cus.MaKhach) || string.IsNullOrEmpty(cus.TenKhach))
                {
                    throw new ArgumentException("MaKhach and TenKhach must not be null or empty.");
                }

                using (SqlConnection conn = CreateConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE tblKhach SET TenKhach = @TenKhach, DiaChi = @DiaChi, SoLienLac = @SoLienLac, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh WHERE MaKhach = @MaKhach", conn);
                    cmd.Parameters.Add(new SqlParameter("@MaKhach", cus.MaKhach));
                    cmd.Parameters.Add(new SqlParameter("@TenKhach", cus.TenKhach));
                    cmd.Parameters.Add(new SqlParameter("@DiaChi", cus.DiaChi));
                    cmd.Parameters.Add(new SqlParameter("@SoLienLac", cus.DienThoai));
                  
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                // Xử lý lỗi kết nối hoặc truy vấn
                Console.WriteLine("Đã xảy ra lỗi khi thực hiện sửa dữ liệu: " + ex.Message);
            }
            catch (ArgumentException ex)
            {
                // Xử lý lỗi tham số không hợp lệ
                Console.WriteLine("Lỗi tham số không hợp lệ: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Xử lý lỗi chung (nếu có)
                Console.WriteLine("Đã xảy ra lỗi không xác định: " + ex.Message);
            }
        }

        public void SavekhachHang(Khach cus)
        {
            try
            {
                using (SqlConnection conn = CreateConnection())
                {
                    conn.Open();
                    if (!string.IsNullOrEmpty(cus.MaKhach) && !string.IsNullOrEmpty(cus.TenKhach))
                    {
                        SqlCommand cmd = new SqlCommand("UPDATE tblKhach SET TenKhach = @TenKhach, DiaChi = @DiaChi, SoLienLac = @SoLienLac WHERE MaKhach = @MaKhach", conn);
                        cmd.Parameters.Add(new SqlParameter("@MaKhach", cus.MaKhach));
                        cmd.Parameters.Add(new SqlParameter("@TenKhach", cus.TenKhach));
                        cmd.Parameters.Add(new SqlParameter("@DiaChi", cus.DiaChi));
                        cmd.Parameters.Add(new SqlParameter("@SoLienLac", cus.DienThoai));
                    
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                // Xử lý lỗi kết nối hoặc truy vấn
                Console.WriteLine("Đã xảy ra lỗi khi lưu dữ liệu: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Xử lý lỗi chung (nếu có)
                Console.WriteLine("Đã xảy ra lỗi không xác định: " + ex.Message);
            }
        }

    }
}

