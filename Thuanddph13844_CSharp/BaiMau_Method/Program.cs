using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiMau_Method
{
    class Program
    {
        int  so1, so2;
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            meNu();
            switch (input)
            {
                case 1:
                    nhapHaiso();
                    Console.WriteLine(so1+so2);
                    break;
                case 2:
                    nhapHaiso();
                    Console.WriteLine(so1-so2);
                    break;
                case 3:
                    nhapHaiso();
                    Console.WriteLine(so1*so2);
                    break;
                case 4:
                    nhapHaiso();
                    Console.WriteLine(so1/so2);
                    break;
            }
            Console.ReadKey();
        }
        static void nhapHaiso()
        {
            Console.WriteLine("Mời bạn nhập số thứ nhất: ");
            so1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Mời bạn nhập số thứ hai: ");
            so2 = int.Parse(Console.ReadLine());
        }
        static void meNu()
        {
            Console.WriteLine("Chương trình máy tính");
            Console.WriteLine("Cộng hai số");
            Console.WriteLine("Trừ hai số");
            Console.WriteLine("Nhân hai số");
            Console.WriteLine("Chia hai số");
            Console.WriteLine("mời bạn chọn chức năng");
            input = int.Parse(Console.ReadLine());
        }
    }
}
