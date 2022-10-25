using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3._1_Method_PhuongThucKhongTraVe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            inRaMH();
            inRaMHCoThamSo(2021, "thuan");
            Console.ReadKey();
          
        }
        //1 k trả về k tham số
        static void inRaMH()
        {
            //body code thực hiện nhiều câu lệnh giải quyết nghiệp vụ nào đó
            Console.WriteLine("Chúc mừng năm mới");
        }
        //2 kiểu k trả về và có tham số
        static void inRaMHCoThamSo(int year,string name)
        {
            //coi tham số như biến
            Console.WriteLine("Chúc mừng năm mới "+" "+year +" " +"chào bạn: "+name );
        }
    }
}
