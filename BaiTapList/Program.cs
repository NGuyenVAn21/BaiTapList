using BaiTapList;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("     BÀI TẬP LIST - SINH VIÊN (OOP)  \n ");
       

        // Khởi tạo danh sách sinh viên
        DanhSachSinhVien ds = new DanhSachSinhVien();
        ds.InitRandom(50);

        // Hiển thị toàn bộ danh sách
        ds.HienThi();
        Console.WriteLine();
        // Hiển thị toàn bộ danh sách
        ds.HienThi();
        Console.WriteLine();

        // 1. Max tuổi, min tuổi
        ds.TimMaxMinTuoi();

        // 2. Kiểm tra có sinh viên thuộc khoa Công Nghệ Số
        ds.KiemTraKhoCongNgheSo();


    }
}