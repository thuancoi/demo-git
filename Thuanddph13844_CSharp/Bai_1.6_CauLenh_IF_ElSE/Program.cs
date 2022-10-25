using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1._6_CauLenh_IF_ElSE
{
    class Program
    {
        static void Main(string[] args)
        {
            int nghi;
            Console.Write("Moi ban nhap so buoi nghi: ");
            nghi = Convert.ToInt32(Console.ReadLine());
            if (nghi<-0)
            {
                Console.WriteLine("kieu so khong duoc phep am");
            }
            else
            {
                if (nghi<=4)
                {
                    Console.WriteLine("Chuc mung ban van duoc di hoc");
                }
                else
                {
                    Console.WriteLine("chuc mung ban mat 700k");
                }
            }
            Console.ReadKey();
        }
    }
}
