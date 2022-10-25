using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_5
{
    class Meo
    {
        private string ten;
        private int tuoi;
        private string diaChi;
        private string gioiTinh;
        private int ngaySinh;
        public Meo()
        {

        }

        public Meo(string ten, int tuoi, string diaChi, string gioiTinh, int ngaySinh)
        {
            this.Ten = ten;
            this.Tuoi = tuoi;
            this.DiaChi = diaChi;
            this.GioiTinh = gioiTinh;
            this.NgaySinh = ngaySinh;
        }

        public string Ten { get => ten; set => ten = value; }
        public int Tuoi { get => tuoi; set => tuoi = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public int NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public void inRaManHinh()
        {
            Console.WriteLine("Ten: {1} |Tuoi: {2} |Dia chi: {3}  |Gioi tinh: {4} | Ngay sinh: {5}");
        }
    }
}
