using DO_AN.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DO_AN.DAL
{
    internal class ChatLieuDAL : DBConnection
    {
        public List<ChatLieu> ReadChatLieu()
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from tbLNguyenLieu", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<ChatLieu> lstCus = new List<ChatLieu>();
            while (reader.Read())
            {
                ChatLieu cus = new ChatLieu();
                cus.MaChatLieu = reader["MaChatLieu"].ToString();
                cus.TenChatLieu = reader["TenChatLieu"].ToString();
                lstCus.Add(cus);
            }
            conn.Close();
            return lstCus;
        }
        public List<string> ReadAllMaChatLieu()
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT MaChatLieu FROM tbLNguyenLieu", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<string> maChatLieuList = new List<string>();

            while (reader.Read())
            {
                string maChatLieu = reader["MaChatLieu"].ToString();
                maChatLieuList.Add(maChatLieu);
            }

            conn.Close();
            return maChatLieuList;
        }
        //xóa 
        public void DeleteChatLieu(ChatLieu cus)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from tbLNguyenLieu where MaChatLieu  = @MaChatLieu", conn);
            cmd.Parameters.Add(new SqlParameter("@MaChatLieu", cus.MaChatLieu));
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        //thêm
        public void NewChatLieu(ChatLieu cus)
        {
            try
            {
                using (SqlConnection conn = CreateConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO tbLNguyenLieu (MaChatLieu, TenChatLieu) VALUES (@MaChatLieu, @TenChatLieu)", conn);
                    cmd.Parameters.Add(new SqlParameter("@MaChatLieu", cus.MaChatLieu));
                    cmd.Parameters.Add(new SqlParameter("@TenChatLieu", cus.TenChatLieu));
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
        public void EditChatLieu(ChatLieu cus)
        {
            try
            {
                if (string.IsNullOrEmpty(cus.MaChatLieu) || string.IsNullOrEmpty(cus.TenChatLieu))
                {
                    throw new ArgumentException("MaChatLieu and TenChatLieu must not be null or empty.");
                }

                using (SqlConnection conn = CreateConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE tbLNguyenLieu SET TenChatLieu = @TenChatLieu WHERE MaChatLieu = @MaChatLieu", conn);
                    cmd.Parameters.Add(new SqlParameter("@MaChatLieu", cus.MaChatLieu));
                    cmd.Parameters.Add(new SqlParameter("@TenChatLieu", cus.TenChatLieu));
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
        public void SaveChatLieu(ChatLieu cus)
        {
            try
            {
                using (SqlConnection conn = CreateConnection())
                {
                    conn.Open();
                    if (!string.IsNullOrEmpty(cus.MaChatLieu) && !string.IsNullOrEmpty(cus.TenChatLieu))
                    {
                        SqlCommand cmd = new SqlCommand("UPDATE tbLNguyenLieu SET TenChatLieu = @TenChatLieu WHERE MaChatLieu = @MaChatLieu", conn);
                        cmd.Parameters.Add(new SqlParameter("@MaChatLieu", cus.MaChatLieu));
                        cmd.Parameters.Add(new SqlParameter("@TenChatLieu", cus.TenChatLieu));
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


        public void CloseChatLieu(SqlConnection cus)
        {
            if (cus.State == ConnectionState.Open)
            {
                cus.Close();
            }
        }


    }
}