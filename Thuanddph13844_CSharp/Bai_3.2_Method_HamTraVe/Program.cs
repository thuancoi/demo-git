using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3._2_Method_HamTraVe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            Console.WriteLine(getYear());
            foreach (var x in getListBytThuandd())
            {
                Console.WriteLine(x);
            }
            Console.ReadKey();
        }
        static int getYear()
        {
            int a = 2020;
            return 0;
        }
        static int[] getListBytThuandd()
        {
            int[] arrYear = new int[2021 - 1980];
            int temp = 0;
            for (int i = 1980; i < 2021; i++)
            {
                arrYear[temp] = 1;
                temp++;
            }
            return arrYear;
        }
    }
}
