using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Assigment
{
    class SinhVien
    {
        private string ho;
        private string ten;
        private string tenDem;
        private string maSv;
        private int sdt;
        private string email1;
        private int namSinh;
        private double diemCsharp;
        private double diemJava;
        private string gioiTinh;
        private string queQuan;
        public SinhVien()
        {

        }

        public SinhVien(string ho, string ten, string tenDem, string maSv, int sdt, string email1, int namSinh, double diemCsharp, double diemJava, string gioiTinh, string queQuan)
        {
            this.Ho = ho;
            this.Ten = ten;
            this.TenDem = tenDem;
            this.MaSv = maSv;
            this.Sdt = sdt;
            this.Email1 = email1;
            this.NamSinh = namSinh;
            this.DiemCsharp = diemCsharp;
            this.DiemJava = diemJava;
            this.GioiTinh = gioiTinh;
            this.QueQuan = queQuan;
        }

        public string Ho { get => ho; set => ho = value; }
        public string Ten { get => ten; set => ten = value; }
        public string TenDem { get => tenDem; set => tenDem = value; }
        public string MaSv { get => maSv; set => maSv = value; }
        public int Sdt { get => sdt; set => sdt = value; }
        public string Email1 { get => email1; set => email1 = value; }
        public int NamSinh { get => namSinh; set => namSinh = value; }
        public double DiemCsharp { get => diemCsharp; set => diemCsharp = value; }
        public double DiemJava { get => diemJava; set => diemJava = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string QueQuan { get => queQuan; set => queQuan = value; }

        public void inRaManHinh()
        {
            Console.WriteLine("Ho va ten: {0} {1} {2} |Ma sinh vien: {3} |Std: {4} |Nam sinh: {5} |Email: {6} |Diem CSharp: {7} |Diem Java: {8} |Goi tinh: {9} |Que quan: {10}",Ho,TenDem,Ten,MaSv,Sdt,NamSinh,Email1,DiemCsharp <5 ?"NA": diemCsharp.ToString(),DiemJava<5?"N/A":diemJava.ToString(),GioiTinh,QueQuan);
        }
    }
}
