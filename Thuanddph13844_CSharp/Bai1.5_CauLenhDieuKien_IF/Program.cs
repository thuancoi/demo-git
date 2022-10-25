using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1._5_CauLenhDieuKien_IF
{
    class Program
    {
        static void Main(string[] args)
        {
            double diem;
            Console.Write("Mời bạn nhập điểm: ");
            diem = double.Parse(Console.ReadLine());
            if (diem >= 5)
            {
                Console.WriteLine("Chúc mừng bạn đã qua môn");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Bạn đã không qua môn");
            Console.ReadKey();

        }
    }
}
