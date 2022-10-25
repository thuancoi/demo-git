using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiMau_CoBan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            string user = "admin", pass = "123", inPutuser, inPutpass;
            int inputNumber;
            bool result, resultNumber;
            Console.WriteLine("Login Poly");
            do
            {
                Console.WriteLine("Mời bạn nhập user: ");
                inPutuser = Console.ReadLine();
                Console.WriteLine("Mời bạn nhập password: ");
                inPutpass = Console.ReadLine();
                result = (inPutuser == user && inPutpass == pass) ? true : false;
                if (!result)
                {
                    Console.WriteLine("Mời bạn đăng nhập lại");
                }
            } while (!result);
            do
            {
                Console.WriteLine("Mời bạn nhập số trong khoảng 10 - 20|| 90 - 100");
                inputNumber = Convert.ToInt32(Console.ReadLine());
                resultNumber = (inputNumber >= 10 && inputNumber <= 20) || (inputNumber >= 90 && inputNumber <= 100) ? true : false;
                if (!resultNumber)
                {
                    Console.WriteLine("Bạn nhập sai rồi vui lòng nhập đúng số yêu cầu: ");
                } 
            } while (!resultNumber);
            Console.WriteLine("Chương trình kết thúc");
            Console.ReadKey();
        }
    }
}
