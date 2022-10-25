using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Bai3._0_OOP_Lap_Trinh_Huong_Doi_Tuong
{
    class Program
    {
        static void Main(string[] args)
        {
            SinhVien sv1 = new SinhVien();
            SinhVien sv2 = new SinhVien();
            sv1.diaChi = "Ha Noi";
            sv1.ten = "Thuan";
            sv2.queQuan = "Tat Thang";
            sv2.tuoi = "2";

            sv1.getSinhVien();
            
            Console.ReadKey();
        }
    }
}
