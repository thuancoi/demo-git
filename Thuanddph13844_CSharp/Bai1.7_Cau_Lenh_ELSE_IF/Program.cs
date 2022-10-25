using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1._7_Cau_Lenh_ELSE_IF
{
    class Program
    {
        static void Main(string[] args)
        {
            double canNang;
            Console.WriteLine("moi ban nhap so can nang: ");
            canNang = Convert.ToDouble(Console.ReadLine());
            if (canNang <= 50)
            {
                Console.WriteLine("ban qua gay");
            }
            else if (canNang <= 65)
            {
                Console.WriteLine("muc binh thuong");
            }
            else if (canNang <= 80)
            {
                Console.WriteLine("muc hoi map");
            }
            else if (canNang <= 100)
            {
                Console.WriteLine("muc beo phi");
            }
            else
            { Console.WriteLine("muc sieu beo phi"); 
            }
            Console.ReadKey();
        }
    }
}
