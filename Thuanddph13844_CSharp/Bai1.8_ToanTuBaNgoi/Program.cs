using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1._8_ToanTuBaNgoi
{
    class Program
    {
        static void Main(string[] args)
        {
            string user = "admin", pass = "123", userInput1, passInput;
            Console.WriteLine("Moi ban nhap ten dang nhap: ");
            userInput1 = Console.ReadLine();
            Console.WriteLine("moi ban nhap pass: ");
            passInput = Console.ReadLine();
            string result = (userInput1 == user) && (passInput == pass) ? "dang nhap thanh cong" : "dang nhap that bai";
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
