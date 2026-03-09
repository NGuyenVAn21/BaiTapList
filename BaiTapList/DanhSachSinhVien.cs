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
        public void HienThi()
        {
            Console.WriteLine($"📋 DANH SÁCH SINH VIÊN ({_danhSach.Count} người):");
            Console.WriteLine(new string('-', 80));
            foreach (var sv in _danhSach)
                Console.WriteLine(sv);
            Console.WriteLine(new string('-', 80));
        }

        // ===== 1. MAX TUỔI, MIN TUỔI =====
        public void TimMaxMinTuoi()
        {
            if (_danhSach.Count == 0)
            {
                Console.WriteLine("⚠️ Danh sách trống!");
                return;
            }

            SinhVien svMaxTuoi = _danhSach[0];
            SinhVien svMinTuoi = _danhSach[0];

            foreach (var sv in _danhSach)
            {
                if (sv.Tuoi > svMaxTuoi.Tuoi) svMaxTuoi = sv;
                if (sv.Tuoi < svMinTuoi.Tuoi) svMinTuoi = sv;
            }

            Console.WriteLine("🎂 [1] MAX & MIN TUỔI:");
            Console.WriteLine($"   ➤ Lớn tuổi nhất: {svMaxTuoi.HoTen} - {svMaxTuoi.Tuoi} tuổi");
            Console.WriteLine($"   ➤ Nhỏ tuổi nhất: {svMinTuoi.HoTen} - {svMinTuoi.Tuoi} tuổi\n");
        }
        public void KiemTraKhoCongNgheSo()
        {
            const string tenKhoa = "Công Nghệ Số";
            var dsCNS = _danhSach.Where(sv => sv.Khoa == tenKhoa).ToList();

            Console.WriteLine($"🔍 [2] SINH VIÊN KHOA {tenKhoa.ToUpper()}:");
            if (dsCNS.Count == 0)
            {
                Console.WriteLine($"   ❌ Không có sinh viên nào thuộc khoa {tenKhoa}.");
            }
            else
            {
                Console.WriteLine($"   ✅ Có {dsCNS.Count} sinh viên thuộc khoa {tenKhoa}:");
                foreach (var sv in dsCNS)
                    Console.WriteLine($"   {sv}");
            }
            Console.WriteLine();
        }
        public void Top10DiemCaoNhatTheoKhoa(string tenKhoa = "Công Nghệ Số")
        {
            var top10 = _danhSach
                .Where(sv => sv.Khoa == tenKhoa)
                .OrderByDescending(sv => sv.DiemTrungBinh)
                .Take(10)
                .ToList();

            Console.WriteLine($"🏆 [3] TOP 10 SINH VIÊN ĐIỂM CAO NHẤT - KHOA {tenKhoa.ToUpper()}:");
            if (top10.Count == 0)
            {
                Console.WriteLine($"   ❌ Không có sinh viên nào thuộc khoa {tenKhoa}.");
            }
            else
            {
                int rank = 1;
                foreach (var sv in top10)
                    Console.WriteLine($"   #{rank++,2}. {sv}");
            }
            Console.WriteLine();
        }