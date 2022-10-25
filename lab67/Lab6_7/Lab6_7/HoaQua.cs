using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_7
{
    class HoaQua
    {
        private string ten;
        private double trongLuong;
        private string quocGia;
        public HoaQua()
        {

        }

        public HoaQua(string ten, double trongLuong, string quocGia)
        {
            this.Ten = ten;
            this.TrongLuong = trongLuong;
            this.QuocGia = quocGia;
        }

        public string Ten { get => ten; set => ten = value; }
        public double TrongLuong { get => trongLuong; set => trongLuong = value; }
        public string QuocGia { get => quocGia; set => quocGia = value; }
        public void inRaManHinh()
        {
            Console.WriteLine("Ten: {0} | Trong luong: {1} | Quoc gia: {2}",ten,trongLuong,quocGia);s
        }
    }
}
