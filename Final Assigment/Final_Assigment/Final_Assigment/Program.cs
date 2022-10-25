using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Assigment
{
    class Program
    {
        private static List<SinhVien> _lstSinhVien = new List<SinhVien>();
        private static string _input;
        private static SinhVien _sinhVien;

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            while (true)
            {
                menu();
            }
            Console.ReadKey();
        }
        static void menu()
        {
            Console.WriteLine();
            Console.WriteLine("1.THÊM & XÓA SINH VIÊN");
            Console.WriteLine("2.THÊM 15 NGƯỜI TẠO SẴN");
            Console.WriteLine("3.TÌM KIẾM SINH VIÊN");
            Console.WriteLine("4.LOAD TT SINH VIÊN");
            Console.WriteLine("5.TÌM KIẾM SINH VIÊN THEO KHOẢNG ĐIỂM JAVA DO NGƯỜI DÙNG NHẬP VÀO");
            Console.WriteLine("6.LOAD TẤT CẢ SINH VIÊN PHẢI HỌC LẠI 1 MÔN HOẶC CẢ 2");
            Console.WriteLine("7.LOAD TẤT CẢ SINH VIÊN VÀ PH N CHIA DANH SÁCH HỌC LỰC KHI HIỂN THỊ THEO ĐIỂM DƯỚI ĐÂY");
            Console.WriteLine("8.EXIT");
            Console.WriteLine(" MỜI BẠN CHỌN CHỨC NĂNG: ");
            _input = Console.ReadLine();
            switch (_input)
            {
                case "1":
                    Console.WriteLine("1.Thêm sinh viên");
                    Console.WriteLine("2.Xóa sinh viên");
                    Console.WriteLine(" MỜI BẠN CHỌN CHỨC NĂNG: ");
                    _input = Console.ReadLine();
                    switch (_input)
                    {
                        case "1":
                            themSv();
                            break;
                        case "2":
                            xoaSv();
                            break;
                    }
                    break;
                case "2":
                    them15Sv();
                    break;
                case "3":
                    timKiemsv();
                    break;
                case "4":
                    inDssv();
                    break;
                case "5":
                    timKiemSinhVienTheoKhoangDiem();
                    break;
                case "6":
                    loadSvHocLai();
                    break;
                case "7":
                    loadSVTheoHocLuc();
                    break;
                case "8":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("CHỨC NĂNG KHÔNG TỒN TẠI!!!");
                    break;
            }
        }
        static void themSv()
        {
            Console.WriteLine("Bạn  muốn thêm bao nhiêu sinh viên: ");
            _input = Console.ReadLine();
            for (int i = 0; i < Convert.ToInt32(_input); i++)
            {
                _sinhVien = new SinhVien();
                Console.WriteLine("Bạn đang nhập sinh viên thứ: "+(i+1));
                Console.WriteLine("Mời bạn nhập Họ: ");
                _sinhVien.Ho = Console.ReadLine();
                Console.WriteLine("Mời bạn nhập Tên Đệm: ");
                _sinhVien.TenDem = Console.ReadLine();
                Console.WriteLine("Mời Bạn nhập Tên: ");
                _sinhVien.Ten = Console.ReadLine();
                Console.WriteLine("Mời bạn nhập Mã sinh viên : ");
                _sinhVien.MaSv = Console.ReadLine();
                Console.WriteLine("Mời bạn nhập Sđt: ");
                _sinhVien.Sdt = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Mời bạn nhập Email: ");
                _sinhVien.Email1 = Console.ReadLine();
                Console.WriteLine("Mời bạn nhập Năm sinh: ");
                _sinhVien.NamSinh = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Mời bạn nhập Điểm CSharp: ");
                _sinhVien.DiemCsharp =Convert.ToDouble( Console.ReadLine());
                Console.WriteLine("Mời bạn nhập Điểm Java: ");
                _sinhVien.DiemJava = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Mời bạn nhập Giới tính: ");
                _sinhVien.GioiTinh = Console.ReadLine();
                Console.WriteLine("Mời bạn nhập Quê quán: ");
                _sinhVien.QueQuan = Console.ReadLine();
                _lstSinhVien.Add(_sinhVien);
            }
        }
        static void xoaSv()
        {   
            Console.WriteLine("Mời bạn nhập mã sinh viên muốn xóa: ");
            _input = Console.ReadLine();
            for (int i = 0; i < _lstSinhVien.Count; i++)
            {
                if (_input ==_lstSinhVien[i].MaSv)
                {
                    _lstSinhVien.RemoveAt(i);
                    Console.WriteLine("Xóa thành công sinh viên: "+i);
                }
            }
        }
        static void them15Sv()
        {
            SinhVien sv1 = new SinhVien("Đinh","Thuận","Đức","PH13844",0327292046,"Thuanddph13844",2002,5.1,6.5,"Nam","Phú Thọ");
            SinhVien sv2 = new SinhVien("Đinh", "Thuận", "Minh", "Ph1366", 033712465, "Thuanddph1366", 2002, 5.5, 6.5, "Nữ", "Phú Thọ");
            SinhVien sv3 = new SinhVien("Đỗ", "Tùng", "Minh", "Ph13666", 033712465, "minhdtph13666", 2001, 7, 8, "Nam", "Phú Thọ");
            SinhVien sv4 = new SinhVien("Trần", "Thuận", "Đức", "PH111", 56735472, "thuantdph111", 2002, 8, 4, "Nam", "Phú Thọ");
            SinhVien sv5 = new SinhVien("Đinh", "Ngọc", "Minh", "Ph1366", 033712465, "Ngocdm1366", 1999, 5.5, 6.5, "Nữ", "Hà Nội");
            SinhVien sv6 = new SinhVien("Đỗ", "Tùng", "Minh", "Ph13666", 033712465, "minhdtph13666", 2001, 7, 8, "Nam", "Phú Thọ");
            SinhVien sv7 = new SinhVien("Đinh", "Thuận", "Đức", "PH13844", 0327292046, "Thuanddph13844", 2002, 5.1, 6.5, "Nam", "Phú Thọ");
            SinhVien sv8 = new SinhVien("Đinh", "Thuận", "Minh", "Ph1366", 033712465, "Thuanddph1366", 2002, 5.5, 6.5, "Nữ", "Phú Thọ");
            SinhVien sv9 = new SinhVien("Đỗ", "Tùng", "Minh", "Ph13666", 033712465, "minhdtph13666", 2001, 7, 8, "Nam", "Phú Thọ");
            SinhVien sv10 = new SinhVien("Trần", "Thuận", "Đức", "PH111", 56735472, "thuantdph111", 2002, 8, 4, "Nam", "Phú Thọ");
            SinhVien sv11 = new SinhVien("Đinh", "Ngọc", "Minh", "Ph1366", 033712465, "Ngocdm1366", 1999, 5.5, 6.5, "Nữ", "Hà Nội");
            SinhVien sv12 = new SinhVien("Đỗ", "Tùng", "Minh", "Ph13666", 033712465, "minhdtph13666", 2001, 7, 8, "Nam", "Phú Thọ");
            SinhVien sv13 = new SinhVien("Trần", "Thuận", "Đức", "PH111", 56735472, "thuantdph111", 2002, 8, 4, "Nam", "Phú Thọ");
            SinhVien sv14 = new SinhVien("Đinh", "Ngọc", "Minh", "Ph1366", 033712465, "Ngocdm1366", 1999, 5.5, 6.5, "Nữ", "Hà Nội");
            SinhVien sv15 = new SinhVien();
            sv15.Ho = "Đinh";
            sv15.Ten = "Thuận";
            sv15.TenDem = "Đức";
            sv15.MaSv = "Ph13844";
            sv15.Sdt = 0923241424;
            sv15.Email1 = "Thuanncoi2002@gmail.com";
            sv15.DiemCsharp = 7.0;
            sv15.DiemJava = 8.0;
            sv15.NamSinh = 2002;
            sv15.QueQuan = "Phú Thọ";
            sv15.GioiTinh = "Nam";
            _lstSinhVien.Add(sv1);
            _lstSinhVien.Add(sv2);
            _lstSinhVien.Add(sv3);
            _lstSinhVien.Add(sv4);
            _lstSinhVien.Add(sv5);
            _lstSinhVien.Add(sv6);
            _lstSinhVien.Add(sv7);
            _lstSinhVien.Add(sv8);
            _lstSinhVien.Add(sv9);
            _lstSinhVien.Add(sv1);
            _lstSinhVien.Add(sv10);
            _lstSinhVien.Add(sv11);
            _lstSinhVien.Add(sv12);
            _lstSinhVien.Add(sv13);
            _lstSinhVien.Add(sv14);
            _lstSinhVien.Add(sv15);
        }
        static void timKiemsv()
        {
            Console.WriteLine("Mời bạn nhập mã sinh viên muốn tìm: ");
            _input = Console.ReadLine();
            for (int i = 0; i < _lstSinhVien.Count; i++)
            {
                if (_input==_lstSinhVien[i].MaSv)
                {
                    Console.WriteLine("Đã tìm thấy sinh viên: ");
                    _lstSinhVien[i].inRaManHinh();
                }
            }
        }
        static void inDssv()
        {
            foreach (var x in _lstSinhVien)
            {
                x.inRaManHinh();
            }
        }
        static void timKiemSinhVienTheoKhoangDiem()
        {
            double k1, k2;
            Console.WriteLine("Mời bạn nhập khoảng điểm thứ nhất: ");
            k1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mời bạn nhập khoảng điểm thứ hai: ");
            k2 = Convert.ToInt32(Console.ReadLine());
            foreach (var x in _lstSinhVien.Where(c => (c.DiemJava >= k1 && c.DiemJava <= k2)|| (c.DiemJava >= k2 && c.DiemJava <= k1)))
            {
                x.inRaManHinh();
            }
        }
        static void loadSvHocLai()
        {
            for (int i = 0; i < _lstSinhVien.Count; i++)
            {
                if (_lstSinhVien[i].DiemCsharp<5||_lstSinhVien[i].DiemJava<5)
                {
                    _lstSinhVien[i].inRaManHinh();
                }
            }
        }
        static void loadSVTheoHocLuc()
        {
           
            for (int i = 0; i < _lstSinhVien.Count; i++)
            {
                if (((_lstSinhVien[i].DiemCsharp+_lstSinhVien[i].DiemJava)/2 )== 10)
                {
                    Console.WriteLine("Danh sách học sinh xuất săc: ");
                    _lstSinhVien[i].inRaManHinh();
                }
                else if ( ((_lstSinhVien[i].DiemCsharp + _lstSinhVien[i].DiemJava) / 2)> 8.5 )
                {
                    Console.WriteLine("Danh Sách học sinh giỏi: ");
                    _lstSinhVien[i].inRaManHinh();
                }
                else if (((_lstSinhVien[i].DiemCsharp + _lstSinhVien[i].DiemJava) / 2)>6.5)
                {
                    Console.WriteLine("Danh Sách học sinh Khá: ");
                    _lstSinhVien[i].inRaManHinh();
                }
                else if (((_lstSinhVien[i].DiemCsharp + _lstSinhVien[i].DiemJava) / 2)>5.5)
                {
                    Console.WriteLine("Danh Sách học sinh TB: ");
                    _lstSinhVien[i].inRaManHinh();
                }
                else
                {
                    Console.WriteLine("Danh Sách học sinh học lại: ");
                    _lstSinhVien[i].inRaManHinh();
                }
            }
            
        }
    }
}
