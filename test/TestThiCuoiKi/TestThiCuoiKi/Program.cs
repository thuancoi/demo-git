using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestThiCuoiKi
{
    class Program
    {
        private static List<Xe> _lstXe = new List<Xe>();
        private static Xe _Xe;
        private static string _input;
        static void Main(string[] args)
        {
            while (true)
            {
                menu();
            }
        }
        static void menu()
        {
            Console.WriteLine("1.them xe");
            Console.WriteLine("2.In danh sach xe");
            Console.WriteLine("3.sap xep");
            Console.WriteLine("Moi ban chon chuc nang: ");
            _input = Console.ReadLine();
            switch (_input)
            {
                case "1":
                    themXe();
                    break;
                case "2":
                    inDs();
                    break;
                case "3":
                    sapXep();
                    break;
                default:
                    Console.WriteLine("Chuc nang khong ton tai");
                    break;
            }
        } 
        static void themXe()
        {
            Console.WriteLine("Ban muon them bao nhieu xe: ");
            _input = Console.ReadLine();
            for (int i = 0; i < Convert.ToInt32(_input ); i++)
            {
                _Xe = new Xe();
                Console.WriteLine("Ban dang them xe so: "+(i+1));
                Console.WriteLine("Moi ban nhap ma xe: ");
                _Xe.Maxe = Console.ReadLine();
                Console.WriteLine("Moi ban nhap ten xe: ");
                _Xe.Ten = Console.ReadLine();
                Console.WriteLine("Moi ban nhap GIA xe: ");
                _Xe.Gia = Convert.ToInt32(Console.ReadLine());
                _lstXe.Add(_Xe);
            }
        }
        static void inDs()
        {
            foreach (var x in _lstXe)
            {
                x.inRaManHinh();
            }
        }
        static void sapXep()
        {
            var sapxepxe = _lstXe.OrderByDescending(c => c.Gia);
            foreach (var x in sapxepxe)
            {
                x.inRaManHinh();
            }
        }
    }
}
