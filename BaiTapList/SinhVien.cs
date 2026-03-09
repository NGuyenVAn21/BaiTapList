using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapList
{
    public class SinhVien
    {
        public string MaSV { get; set; }
        public string HoTen { get; set; }
        public int Tuoi { get; set; }
        public string Khoa { get; set; }
        public int NamHoc { get; set; } 
        public double DiemTrungBinh { get; set; }

        public SinhVien(string maSV, string hoTen, int tuoi, string khoa, int namHoc, double diemTrungBinh)
        {
            MaSV = maSV;
            HoTen = hoTen;
            Tuoi = tuoi;
            Khoa = khoa;
            NamHoc = namHoc;
            DiemTrungBinh = diemTrungBinh;
        }

        public override string ToString()
        {
            return $"[{MaSV}] {HoTen,-20} | Tuổi: {Tuoi} | Khoa: {Khoa,-20} | Năm {NamHoc} | GPA: {DiemTrungBinh:F2}";
        }
    }
}
