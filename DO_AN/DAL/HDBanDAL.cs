using DO_AN.Model;
using DO_AN.MODEL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO_AN.DAL
{
    internal class HDBanDAL : DBConnection
    {
        public List<Tuple<string, string>> GetNhanVienList()
        {
            NhanVienDAL nhanvienDAL = new NhanVienDAL();
            List<DO_AN.Model.NhanVien> nhanVienList = nhanvienDAL.ReadNhanVien();

            // Chuyển đổi danh sách đối tượng NhanVien sang danh sách tuple (MãNhânViên, TênNhânViên)
            List<Tuple<string, string>> nhanVienInfoList = nhanVienList.Select(nv => Tuple.Create(nv.MaNhanVien, nv.TenNhanVien)).ToList();

            return nhanVienInfoList;
        }
        public List<Tuple<string, string, string, string>> GetKhachHangList()
        {
            KhachDAL khachDAL = new KhachDAL();
            List<Khach> khachHangList = khachDAL.ReadKhachHang();
            

            // Chuyển đổi danh sách đối tượng KhachHang sang danh sách tuple (MaKhachHang, TenKhachHang, DiaChi, DienThoai)
            List<Tuple<string, string, string, string>> khachHangInfoList = khachHangList
                .Select(kh => Tuple.Create(kh.MaKhach, kh.TenKhach, kh.DiaChi, kh.DienThoai))
                .ToList();

            return khachHangInfoList;
        }


        public List<Tuple<string, string, string>> GetHangHoaList()
        {
            NguyenLieuDAL hangDAL = new NguyenLieuDAL();
            List<NguyenLieu> hangList = hangDAL.ReadHang();

            List<Tuple<string, string, string>> hanghoaInfoList = hangList
                .Select(hh => Tuple.Create(hh.MaHang, hh.TenHang, hh.DonGiaBan.ToString())).ToList();

            return hanghoaInfoList;
        }


        public List<HDBan> ReadHDBan()
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from tblHDBan", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<HDBan> lstHD = new List<HDBan>();
            while (reader.Read())
            {
                HDBan hdb = new HDBan();
                hdb.MaHoaDon = reader["MaHDBan"].ToString();
                hdb.MaNhanVien = reader["MaNhanVien"].ToString();
                if (reader["NgayBan"] != DBNull.Value)
                {
                    hdb.NgayBan = Convert.ToDateTime(reader["NgayBan"]);
                }
                else
                {
                    hdb.NgayBan = DateTime.MinValue;
                }
                hdb.MaKhachHang = reader["MaKhach"].ToString();
                hdb.TenKhachHang = reader["TenKhach"].ToString();
                hdb.MaHang = reader["MaHang"].ToString();
                hdb.TenHang = reader["TenHang"].ToString();
                hdb.SoLuong = Convert.ToInt32(reader["SoLuong"]);
                hdb.ThanhTien = reader["ThanhTien"].ToString();


                lstHD.Add(hdb);
            }
            conn.Close();
            return lstHD;
        }
        //xóa
        public void DeleteHDBan(HDBan hdBan)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM tblHDBan WHERE MaHDBan      = @MaHoaDon", conn);
            cmd.Parameters.Add(new SqlParameter("@MaHoaDon", hdBan.MaHoaDon));
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        //thêm
        public void NewHDBan(HDBan hdBan)
        {
            using (SqlConnection conn = CreateConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO tblHDBan (MaHDBan, MaNhanVien, NgayBan, MaKhach, TenKhach, MaHang, TenHang, SoLuong, ThanhTien) VALUES (@MaHoaDon, @MaNhanVien, @NgayBan, @MaKhachHang, @TenKhachHang, @MaHang, @TenHang, @SoLuong, @ThanhTien)", conn);
                cmd.Parameters.Add(new SqlParameter("@MaHoaDon", hdBan.MaHoaDon));
                cmd.Parameters.Add(new SqlParameter("@MaNhanVien", hdBan.MaNhanVien));
                cmd.Parameters.Add(new SqlParameter("@NgayBan", hdBan.NgayBan));
                cmd.Parameters.Add(new SqlParameter("@MaKhachHang", hdBan.MaKhachHang));
                cmd.Parameters.Add(new SqlParameter("@TenKhachHang", hdBan.TenKhachHang));
                cmd.Parameters.Add(new SqlParameter("@MaHang", hdBan.MaHang));
                cmd.Parameters.Add(new SqlParameter("@TenHang", hdBan.TenHang));
                cmd.Parameters.Add(new SqlParameter("@SoLuong", hdBan.SoLuong));
                cmd.Parameters.Add(new SqlParameter("@ThanhTien", hdBan.ThanhTien));
                cmd.ExecuteNonQuery();
            }
        }

        //xóa
        public void EditHDBan(HDBan hdBan)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE tblHDBan SET MaNhanVien = @MaNhanVien, NgayBan = @NgayBan, MaKhach = @MaKhachHang, TenKhach = @TenKhachHang, MaHang = @MaHang, TenHang = @TenHang, SoLuong = @SoLuong, ThanhTien = @ThanhTien WHERE MaHDBan = @MaHoaDon", conn);
            cmd.Parameters.Add(new SqlParameter("@MaHoaDon", hdBan.MaHoaDon));
            cmd.Parameters.Add(new SqlParameter("@MaNhanVien", hdBan.MaNhanVien));
            cmd.Parameters.Add(new SqlParameter("@NgayBan", hdBan.NgayBan));
            cmd.Parameters.Add(new SqlParameter("@MaKhachHang", hdBan.MaKhachHang));
            cmd.Parameters.Add(new SqlParameter("@TenKhachHang", hdBan.TenKhachHang));
            cmd.Parameters.Add(new SqlParameter("@MaHang", hdBan.MaHang));
            cmd.Parameters.Add(new SqlParameter("@TenHang", hdBan.TenHang));
            cmd.Parameters.Add(new SqlParameter("@SoLuong", hdBan.SoLuong));
            cmd.Parameters.Add(new SqlParameter("@ThanhTien", hdBan.ThanhTien));
            cmd.ExecuteNonQuery();
            conn.Close();
        }

    }

}