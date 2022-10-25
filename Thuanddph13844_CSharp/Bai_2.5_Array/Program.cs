using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2._5_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrNumber;
            arrNumber = new int[5];//mảng số nguyên có 5 phần tử
            int[] arrNumber2 = new int[5];
            string[] arrName = new[] { "thuan", "duong", "cong" };//khoi tao kieu ngam dinh
            string[] arrName1 = new string[] { "thuan", "duong", "cong" };//khoi tao kieu ngam dinh
            var arrDiem = new[] { 8.6, 8.9, 20 };
            var arrDiem1 = new double[] { 8.6, 8.9, 20 };
            // 2.gán giá trị cho mảng
            arrNumber[0] = 5; // gan gia tri cho mang tai vi tri so 0
            arrNumber[3] = 5; // gan gia tri cho mang tai vi tri so 3
            arrNumber[0] = 5; // ghi đè vào vị trí số 0 nếu vị trí số 0 đã có giá trị
            //3. xuất 1 giá tr
            Console.WriteLine(arrNumber[3]);
            //4. xuat nhieu gia tri ra mh while- do...while-foreach
            // a) for
            for (int i = 0; i < arrName.Length; i++)
            {
                Console.WriteLine(arrName[i]);
            }
            //b) for each
            foreach (var x  in arrName)   
            {
                Console.WriteLine(x);
            }
            //c) dp..while
            int d = 0;
            do
            {
                Console.WriteLine(arrName[d]);
                d++;
            } while (d<arrName.Length); 
            Console.ReadKey();
        }
    }
}
