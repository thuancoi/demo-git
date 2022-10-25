using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int chucNang, so,ten;
            int[] arrNhapso;
            string[] tenNguoidung;
            Console.WriteLine("menu");
            Console.WriteLine("1.Bai 1");
            Console.WriteLine("2.Bai 2");
            do
            {

            
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
                        Console.WriteLine("Moi ban nhap so thu{0}: ", (i + 1));
                        arrNhapso[i] = int.Parse(Console.ReadLine());
                    }
                    Console.Write("Day so ban vua nhap la: ");
                    foreach (var item in arrNhapso)
                    {
                        Console.Write(item+ " ");
                    }
                    break;
                case 2:
                    Console.WriteLine("ban muon nhap bao nhieu ten nguoi dung: ");
                    ten = int.Parse(Console.ReadLine());
                    tenNguoidung = new string[ten];
                    for (int j = 0; j < tenNguoidung.Length; j++)
                    {
                        Console.WriteLine("Moi ban nhap ten nguoi thu" +j+": ");
                        tenNguoidung[j] = Console.ReadLine();
                    }
                    foreach (var x in tenNguoidung)
                    {
                        Console.Write(x+ " ");
                    }
                    break;
            }
            } while (chucNang<=2);
            Console.ReadKey();
        }
    }
}

