using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2._7_MangHaiChieu
{
    class Program
    {
        static void Main(string[] args)
        {
            //1,Khai bao
            int[,] arrMang = new int[2, 3];
            //2 Gan gia tri
            arrMang[0, 0] = 5;
            arrMang[0, 1] = 6;
        //vi du
            int row, col;
            int[,] arrNumber;
            Console.WriteLine("Moi ban nhap so luong row: ");
            row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Moi ban nhap so luong col: ");
            col = Convert.ToInt32(Console.ReadLine());
            //khoi tao mang
            arrNumber = new int[row, col];
            // nhap du lieu mang 2 chieu
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.WriteLine("Gia tri tai row{0} col{1}: ",i,j);
                    arrMang[i, j] =Convert.ToInt32 (Console.ReadLine());
                }
            }
            //xuat gia tri mang
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.WriteLine("Gia tri tai row{ 0} - col{ 1} = {2} ",i,j, arrMang[i, j]);
                }
            }
            Console.ReadKey();
        }
    }
}
