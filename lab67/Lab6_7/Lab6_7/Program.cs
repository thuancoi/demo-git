using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_7
{
    class Program
    {
        private static List<HoaQua> _lsthoaqua = new List<HoaQua>();
        private static string _input;
        private static HoaQua _hoaqua;
        static void Main(string[] args)
        {

            while (true)
            {
                menu();
            }
            Console.ReadKey();
        }
        static void menu()
        {
            Console.WriteLine( "1.Them doi tuong");
            Console.WriteLine("2.in tat ca doi tuong");
            Console.WriteLine("3.Sap xep doi tuong");
            Console.WriteLine("Mơi ban chon chuc nang: ");
            _input =Console.ReadLine();
            switch (_input)
            {
                case "1":
                    themDoiTuong();                       
                    break;
                case "2":
                    inDoiTuong();
                    break;
                case "3":
                    sapXep();
                    break;
                default:
                    Console.WriteLine("chuc nang khong ton tai");
                    break;
            }
        }
        static void themDoiTuong()
        {
            Console.WriteLine("Ban muon them bao nhieu doi tuong: ");
            _input =Console.ReadLine();
            for (int i = 0; i <Convert.ToInt32(_input); i++)
            {
                _hoaqua = new HoaQua();
                Console.WriteLine("ban dang nhap hoa qua thu: "+(i+1));
                Console.WriteLine("Moi ban nhap ten: ");
                _hoaqua.Ten = Console.ReadLine();
                Console.WriteLine("Moi ban nhap trong luong: ");
                _hoaqua.TrongLuong = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Moi ban nhap quoc gia: ");
                _hoaqua.QuocGia = Console.ReadLine();
                _lsthoaqua.Add(_hoaqua);
            }
        }
        static void inDoiTuong()
        {
            foreach (var x in _lsthoaqua)
            {
                x.inRaManHinh();
            }
        }
        static void sapXep()
        {
            var lstSapXep = _lsthoaqua.OrderBy(c => c.TrongLuong).ToList();
            foreach (var x in lstSapXep )
            {
                x.inRaManHinh();
            }
        }
    }
}
