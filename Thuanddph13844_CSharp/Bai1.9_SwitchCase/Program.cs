using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1._9_SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            double so1, so2;
            int input;
            Console.Write("Mời bạn nhập số thứ 1 :");
            so1 = double.Parse(Console.ReadLine());
            Console.Write("Mời bạn nhập số thứ 2 :");
            so2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Chương trình máy tính POLY");
            Console.WriteLine("1. Phép cộng");
            Console.WriteLine("2. Phép trừ");
            Console.WriteLine("Mời bạn chọn chức năng: ");
            input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Console.WriteLine("Phép cộng: {0} + {1} = {2}", so1, so2, so1 + so2);

                    break;
                case 2:
                    Console.WriteLine("Phép trừ: {0} - {1} = {2}", so1, so2, so1 - so2);
                    break;
                default:
                    Console.WriteLine("Chức năng bạn chọn không tồn tại");
                    break;
            }
            Console.ReadKey();
        }
    }
}
