using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_Tap
{
    class Program
    {
        static void Main(string[] args)
        {
            /*bai 1*/
            string name;
            int Year, MS;
            Console.Write("Moi ban nhap ten: ");
            name = Console.ReadLine();
            Console.Write("Moi ban nhap nam sinh: ");
            Year = int.Parse(Console.ReadLine());
            Console.Write("moi ban nhap ma so sinh vien:  ");
                MS = int.Parse(Console.ReadLine());
            Console.Write("chao ban " + name);
            Console.Write(" sinh nam "+Year);
            Console.Write(" ma so sinh vien "+MS);
            Console.WriteLine(" den voi chuong trinh c# dau tien");
            Console.ReadKey();
            /*bai2*/
            double diemThi,dtB;
            Console.Write("Moi ban nhap diem thi: ");
            diemThi = double.Parse(Console.ReadLine());
            Console.Write("Moi ban nhap diem trung binh");
            dtB = double.Parse(Console.ReadLine());
            if (diemThi>=5&&dtB>=5)
            {
                Console.WriteLine("chuc mung ban da qua mon");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Ban da khong qua mon");
            Console.ReadKey();
        }
    }
}
