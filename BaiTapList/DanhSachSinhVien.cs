using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapList
{
    public class DanhSachSinhVien
    {
        private List<SinhVien> _danhSach;

        private static readonly string[] HoList = { "Nguyễn", "Trần", "Lê", "Phạm", "Hoàng", "Huỳnh", "Phan", "Vũ", "Đặng", "Bùi" };
        private static readonly string[] TenList = { "An", "Bình", "Chi", "Dũng", "Giang", "Hà", "Hùng", "Khoa", "Lan", "Minh", "Nam", "Phúc", "Quân", "Sơn", "Tâm", "Thảo", "Toàn", "Uyên", "Việt", "Xuân" };
        private static readonly string[] KhoaList = { "Công Nghệ Số", "Kinh Tế", "Kỹ Thuật", "Y Dược", "Luật", "Ngoại Ngữ" };

        public DanhSachSinhVien()
        {
            _danhSach = new List<SinhVien>();
        }
        public void InitRandom(int soLuong = 50)
        {
            var rng = new Random();
            _danhSach.Clear();

            for (int i = 1; i <= soLuong; i++)
            {
                string ho = HoList[rng.Next(HoList.Length)];
                string ten = TenList[rng.Next(TenList.Length)];
                string hoTen = $"{ho} {ten}";
                int tuoi = rng.Next(18, 26);
                string khoa = KhoaList[rng.Next(KhoaList.Length)];
                int namHoc = rng.Next(1, 5); // 1 đến 4
                double gpa = Math.Round(rng.NextDouble() * 6 + 4, 2); // 4.0 - 10.0

                _danhSach.Add(new SinhVien($"SV{i:D3}", hoTen, tuoi, khoa, namHoc, gpa));
            }

            Console.WriteLine($"✅ Đã khởi tạo {soLuong} sinh viên ngẫu nhiên.\n");
        }
