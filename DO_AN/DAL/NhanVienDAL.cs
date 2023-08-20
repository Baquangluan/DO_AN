using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DO_AN.GUI;
using DO_AN.Model;
using DO_AN.MODEL;

namespace DO_AN.DAL
{
    internal class NhanVienDAL : DBConnection
    {
        public List<NhanVien> ReadNhanVien()
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from tbLNhanVien", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<NhanVien> lstCus = new List<NhanVien>();
            while (reader.Read())
            {
                NhanVien cus = new NhanVien();
                cus.MaNhanVien = reader["MaNhanVien"].ToString();
                cus.TenNhanVien = reader["TenNhanVien"].ToString();   
                cus.DiaChi = reader["DiaChi"].ToString();
                cus.SoLienLac = reader["SoLienLac"].ToString();
                if (reader["NgaySinh"] != DBNull.Value)
                {
                    cus.NgaySinh = Convert.ToDateTime(reader["NgaySinh"]);
                }
                else
                {
                    cus.NgaySinh = DateTime.MinValue;
                }
                lstCus.Add(cus);
            }
            conn.Close();
            return lstCus;
        }



        public List<string> ReadAllMaNhanVien()
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT MaNhanVien FROM tbLNhanVien", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<string> maNhanVienList = new List<string>();

            while (reader.Read())
            {
                string maNhanVien = reader["MaNhanVien"].ToString();
                maNhanVienList.Add(maNhanVien);
            }

            conn.Close();
            return maNhanVienList;
        }



        //xóa 
        public void DeleteNhanVien(NhanVien cus)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from tbLNhanVien where MaNhanVien  = @MaNhanVien", conn);
            cmd.Parameters.Add(new SqlParameter("@MaNhanVien", cus.MaNhanVien));
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        //thêm
        public void NewNhanVien(NhanVien cus)
        {
            try
            {
                using (SqlConnection conn = CreateConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO tbLNhanVien VALUES (@MaNhanVien, @TenNhanVien, @DiaChi, @SoLienLac, @NgaySinh)", conn);
                    cmd.Parameters.Add(new SqlParameter("@MaChatLieu", cus.MaNhanVien));
                    cmd.Parameters.Add(new SqlParameter("@TenChatLieu", cus.TenNhanVien));
                    cmd.Parameters.Add(new SqlParameter("@DiaChi", cus.DiaChi));
                    cmd.Parameters.Add(new SqlParameter("@SoLienLac", cus.SoLienLac));
                    cmd.Parameters.Add(new SqlParameter("@NgaySinh", cus.NgaySinh));                
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
        public void EditNhanVien(NhanVien cus)
        {
            try
            {
                if (string.IsNullOrEmpty(cus.MaNhanVien) || string.IsNullOrEmpty(cus.TenNhanVien))
                {
                    throw new ArgumentException("MaNhanVien and TenNhanVien must not be null or empty.");
                }

                using (SqlConnection conn = CreateConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE tbLNhanVien SET TenNhanVien = @TenNhanVien, DiaChi = @DiaChi, SoLienLac = @SoLienLac, NgaySinh = @NgaySinh WHERE MaNhanVien = @MaNhanVien", conn);
                    cmd.Parameters.Add(new SqlParameter("@MaNhanVien", cus.MaNhanVien));
                    cmd.Parameters.Add(new SqlParameter("@TenNhanVien", cus.TenNhanVien));
                    cmd.Parameters.Add(new SqlParameter("@DiaChi", cus.DiaChi));
                    cmd.Parameters.Add(new SqlParameter("@SoLienLac", cus.SoLienLac));
                    cmd.Parameters.Add(new SqlParameter("@NgaySinh", cus.NgaySinh));
                   
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

        public void SaveNhanVien(NhanVien cus)
        {
            try
            {
                using (SqlConnection conn = CreateConnection())
                {
                    conn.Open();
                    if (!string.IsNullOrEmpty(cus.MaNhanVien) && !string.IsNullOrEmpty(cus.TenNhanVien))
                    {
                        SqlCommand cmd = new SqlCommand("UPDATE tbLNhanVien SET TenNhanVien = @TenNhanVien, DiaChi = @DiaChi, SoLienLac = @SoLienLac, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh WHERE MaNhanVien = @MaNhanVien", conn);
                        cmd.Parameters.Add(new SqlParameter("@MaNhanVien", cus.MaNhanVien));
                        cmd.Parameters.Add(new SqlParameter("@TenNhanVien", cus.TenNhanVien));
                        cmd.Parameters.Add(new SqlParameter("@DiaChi", cus.DiaChi));
                        cmd.Parameters.Add(new SqlParameter("@SoLienLac", cus.SoLienLac));
                        cmd.Parameters.Add(new SqlParameter("@NgaySinh", cus.NgaySinh));
                        
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

