using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2._4_BaiTap_OnTap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            /* cach 1
             * int so;
             Console.WriteLine("Moi ban nhap vao bang cuu chuong: ");
                 so = int.Parse(Console.ReadLine());
             for (int i = 1; i <= 10; i++)
             {
                 Console.WriteLine(" {0} x {1} = {2} " ,so, i, so*i);
             }
             Console.ReadKey(); */

            /* 
             * cach 2 int so = 0, i = 1;
             Console.WriteLine("Moi ban nhap vao bang cuu chuong: ");
             so = int.Parse(Console.ReadLine());
             do
             {
                 Console.WriteLine(" {0} x {1} = {2} ", so, i, so * i);
                 i++;
             } while (i <= 10);
             Console.ReadKey();*/
            //int i=1;
            //Console.WriteLine("Moi ban nhap bang cuu chuong: ");
            //i = int.Parse(Console.ReadLine());
            int chucNang, chucNang1, khoang1, khoang2, tuoi, chieuCao, chieuCao1 = 165, tuoi1 = 18;
            int namSinh ;
            float diemTongKet;
            string hoTen, gioiTinh, gioiTinh1 = "nam";
            Console.WriteLine("---Chương trình 1---");
            Console.WriteLine("1.In bảng cửu chương đơn");
            Console.WriteLine("2.In bảng cửu chương theo khoảng");
            Console.WriteLine("3.Kiểm tra học lực Sinh Viên Poly");
            Console.WriteLine("4.Nhập thông tin người yêu");
            Console.WriteLine("5.Thoát");
            Console.WriteLine("Mời bạn chọn chức năng: ");
            chucNang = int.Parse(Console.ReadLine());
            switch (chucNang)
            {
                case 1:
                    Console.WriteLine("Mời bạn nhập bảng cửu chương muốn in: ");
                    chucNang1 = int.Parse(Console.ReadLine());
                    for (int i = 1; i < 10; i++)
                    {
                        Console.WriteLine("{0} x {1} = {2}", chucNang1, i, chucNang1 * i);
                    }
                    break;
                case 2:
                    Console.WriteLine("Mời bạn nhập vào khoảng bắt đầu: ");
                    khoang1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Mời bạn nhập vào khoảng kết thúc: ");
                    khoang2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Bảng cửu chương của bạn thuộc khoảng {0} đến khoảng {1} ", khoang1, khoang2);
                    while (khoang1 <= khoang2)
                    {
                        Console.WriteLine("");
                        for (int j = 1; j < 10; j++)    
                        {
                            Console.WriteLine("{0} x {1} = {2}", khoang1, j, khoang1 * j);
                        }
                        khoang1++;
                    }
                    break;
                case 3:
                    Console.WriteLine("Mời bạn nhập vào điểm tổng kết môn C#: ");
                    diemTongKet = float.Parse(Console.ReadLine());
                    if (diemTongKet <= 5)
                    {
                        Console.WriteLine("Bạn xếp loại yếu");
                    }
                    else if (diemTongKet <= 7)
                    {
                        Console.WriteLine("Bạn xếp loại khá");
                    }
                    else if (diemTongKet <= 8)
                    {
                        Console.WriteLine("Bạn xếp loại tiên tiến");
                    }
                    else if (diemTongKet <= 9)
                    {
                        Console.WriteLine("Bạn xếp loại giỏi");
                    }
                    else
                    {
                        Console.WriteLine("Bạn xếp loại xuất sắc");
                    }
                    break;
                case 4:
                    Console.WriteLine("Mời bạn nhập thông tin người yêu");
                    Console.Write("Họ và tên: ");
                    hoTen = Console.ReadLine();
                    Console.Write("Mời bạn nhập năm sinh: ");
                    namSinh = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Mời bạn nhập tuổi: ");
                    tuoi = int.Parse(Console.ReadLine());
                    if (tuoi < tuoi1)
                    {
                        Console.WriteLine("Kém tuổi");
                    }
                    else if (tuoi > tuoi1)
                    {
                        Console.WriteLine("Hơn tuổi");
                    }
                    else
                    {
                        Console.WriteLine("Bằng tuổi");
                    }
                    Console.Write("Mời bạn nhập giới tính: ");
                    gioiTinh = Console.ReadLine();
                    if (gioiTinh == gioiTinh1)
                    {
                        Console.WriteLine("Cùng giới");
                    }
                    else
                    {
                        Console.WriteLine("Khác giới");
                    }
                    Console.Write("Mời bạn nhập chiều cao: ");
                    chieuCao = Convert.ToInt32(Console.ReadLine());
                    if (chieuCao < chieuCao1)
                    {
                        Console.WriteLine("Thấp hơn");
                    }
                    else
                    {
                        Console.WriteLine("Cao hơn");
                    }
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
            }
            Console.ReadKey();
        }
    }
}
