using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Bai_2._9_List
{
    class Program
    {
        static void Main(string[] args)
        {
            /* //khai bao
             List<int> lstNumber = new List<int>();
             List<String> lstName = new List<string>();
             List<double> lstDiem = new List<double>(5);
             //Gan gia tri
             lstName.Add("Fpt");
             lstName.Add("BK");
             lstName.Add("poly");
             //lay gia tri
             Console.WriteLine(lstName[1]);
             for (int i = 0; i < lstName.Count; i++)
             {
                 Console.WriteLine(lstName[i]);
             }
             int input;
             List<string> lstMsv = new List<string>();
             Console.WriteLine("Muon nhap bao nhieu ma?: ");
             input = int.Parse(Console.ReadLine());
             for (int i = 0; i < input; i++)
             {
                 Console.WriteLine("Moi nhap ma sinh vien thu {0}: ",i);
                 lstMsv.Add(Console.ReadLine());
             }
             foreach (var x in lstMsv)
             {
                 Console.WriteLine(x);
             }
             Console.ReadKey();*/
            //bai 1
            int so;
            List<string> lstSo = new List<string>();
            Console.WriteLine("ban muon nhap bao nhieu so?: ");
            so = int.Parse(Console.ReadLine());
            for (int i = 0; i < so; i++)
            {
                Console.WriteLine("Moi ban nhap vao so thu {0}: ",i);
                lstSo.Add(Console.ReadLine());
            }
            foreach (var x in lstSo)
            {
                if (lstSo % 2 = 0)
                {

                }
            }
            Console.ReadKey();
        }
    }
}
