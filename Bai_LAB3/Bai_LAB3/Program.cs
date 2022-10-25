using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_LAB3
{
    class Program
    {
        static int Main(string[] args)
        {
            int chucNang,so;
            int[] arrNhapso;
            Console.WriteLine("menu");
            Console.WriteLine("1.Bai 1");
            Console.WriteLine("2.Bai 2");
            
                Console.WriteLine("Moi ban chon chuc nang: ");
                chucNang = int.Parse(Console.ReadLine());
                switch (chucNang)
                {
                    case 1:
                        Console.WriteLine("Ban muon nhap bao nhieu so: ");
                        so = int.Parse(Console.ReadLine());
                        arrNhapso = new int[so];
                        for (int i = 0; i < arrNhapso.Length; i++)
                        {
                            Console.WriteLine("Moi ban nhap so thu{0}: ",(i+1));
                            arrNhapso[i] = int.Parse(Console.ReadLine());
                        }
                        Console.WriteLine("Day so ban vua nhap la: ");
                        foreach (var item in arrNhapso)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                }
           
        }
    }
}
