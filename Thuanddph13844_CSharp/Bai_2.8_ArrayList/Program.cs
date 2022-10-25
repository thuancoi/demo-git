using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2._8_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Khai bao
             ArrayList arrLstTemp = new ArrayList();
             ArrayList arrLstTemp2 = new ArrayList();
            ArrayList arrLstTemp1 = new ArrayList();
            arrLstTemp1.Add("FPT");
            arrLstTemp1.Add("2");
            arrLstTemp1.Add("True");
            Console.WriteLine(arrLstTemp1[0]);
            for (int i = 0; i < arrLstTemp1.Count; i++)
            {
                Console.WriteLine(arrLstTemp1[i]);
            }
            Console.ReadKey();
        }
       
    }
}
