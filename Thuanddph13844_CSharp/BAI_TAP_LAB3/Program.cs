using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_TAP_LAB3
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            int chucNang;
            Console.WriteLine("Menu");
            Console.WriteLine("1.Bài 1");
            Console.WriteLine("2.Bài 2");
            Console.WriteLine("3.Exit");
            do
            {
                Console.WriteLine();
                Console.Write("Mời bạn chọn chức năng: ");
                chucNang = int.Parse(Console.ReadLine());
                switch (chucNang)
                {
                    case 1:
                        bai1();
                        break;
                    case 2:
                        bai2();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                }
            } while (chucNang <= 3);
            Console.ReadKey();
        }
        static void bai1()
        {
            int[] arrNhapSo;
            int input;
            Console.WriteLine("Bạn muốn nhập bao nhiêu số: ");
            input = int.Parse(Console.ReadLine());
            arrNhapSo = new int[input];
            for (int i = 0; i < arrNhapSo.Length; i++)
            {
                Console.WriteLine("Mời bạn nhập số thứ {0}: ", i + 1);
                arrNhapSo[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Dãy số bạn vừa nhập là: ");
            foreach (var x in arrNhapSo)
            {
                Console.Write(x + " ");
            }
        }
        static void bai2()
        {
            int[] arrDiem;
            int diem, max;
            Console.WriteLine("Bạn muốn nhập bao nhiêu điểm: ");
            diem = int.Parse(Console.ReadLine());
            arrDiem = new int[diem];
            for (int j = 0; j < arrDiem.Length; j++)
            {
                Console.Write("Mời bạn nhập điểm thứ " + (j + 1) + ": ");
                arrDiem[j] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Điểm bạn vừa nhập là: ");
            foreach (var item in arrDiem)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.Write("Các điểm dưới 5 là: ");
            for (int j = 0; j < arrDiem.Length; j++)
            {
                if (arrDiem[j] < 5)
                {
                    Console.Write(arrDiem[j] + " ");
                }
            }
            Console.WriteLine();
            Console.Write("Điểm lớn nhất trong dãy là: ");
            max = arrDiem[0];
            for (int j = 1; j < arrDiem.Length; j++)
            {
                ;
                if (arrDiem[0] < arrDiem[j])
                {
                    max = arrDiem[j];
                }
            }
            Console.WriteLine(max);
            Console.WriteLine("diem lon nhat la: "+arrDiem.Max());
            Console.WriteLine("diem nho nhat la: "+arrDiem.Min());
        }
    }
}
