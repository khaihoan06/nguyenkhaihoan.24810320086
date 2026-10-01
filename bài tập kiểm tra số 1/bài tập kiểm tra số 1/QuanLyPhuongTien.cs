using System;
using System.Collections.Generic;
using System.Text;

namespace bài_tập_kiểm_tra_số_1
{
    internal class QuanLyPhuongTien
    {
    }
}


namespace AutoSpeed
{
    public class QuanLyPhuongTien
    {
        private readonly List<PhuongTien> danhSach =
            new List<PhuongTien>();

        // 1. Thêm phương tiện
        public void AddPhuongTien(PhuongTien pt)
        {
            if (pt == null)
                throw new ArgumentNullException(nameof(pt));

            danhSach.Add(pt);
        }

        // 2. Hiển thị toàn bộ phương tiện
        public void DisplayAll()
        {
            if (danhSach.Count == 0)
            {
                Console.WriteLine("Danh sách phương tiện đang trống!");
                return;
            }

            Console.WriteLine(
                " DANH SACH PHUONG TIEN ");

            foreach (PhuongTien pt in danhSach)
            {
                Console.WriteLine(pt.GetInfo());
                Console.WriteLine(
                    $"Gia lan banh: {pt.TinhGiaLanBanh():N0} VNĐ");
                Console.WriteLine("-");
            }
        }

        public PhuongTien? FindMaxGiaLanBanh()
        {
            return danhSach
                .OrderByDescending(pt => pt.TinhGiaLanBanh())
                .FirstOrDefault();
        }

        public List<PhuongTien> SearchByName(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
                return new List<PhuongTien>();

            return danhSach
                .Where(pt =>
                    pt.TenHang.Contains(
                        keyword,
                        StringComparison.OrdinalIgnoreCase))
                .ToList();
        }
    }
}