using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_5
{
    class GiaoVien
    {
        private string ten;
        private string tenDem;
        private string hoten;
        private string maGV;
        private string email1;
        private string email2;
        private int sdt;
        private int  soGioDay;
        private string chucVu;
        public GiaoVien()
        {

        }

        public GiaoVien(string ten, string tenDem, string hoten, string maGV, string email1, string email2, int sdt, int soGioDay, string chucVu)
        {
            this.Ten = ten;
            this.TenDem = tenDem;
            this.Hoten = hoten;
            this.MaGV = maGV;
            this.Email1 = email1;
            this.Email2 = email2;
            this.Sdt = sdt;
            this.SoGioDay = soGioDay;
            this.ChucVu = chucVu;
        }

        public string Ten { get => ten; set => ten = value; }
        public string TenDem { get => tenDem; set => tenDem = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public string MaGV { get => maGV; set => maGV = value; }
        public string Email1 { get => email1; set => email1 = value; }
        public string Email2 { get => email2; set => email2 = value; }
        public int Sdt { get => sdt; set => sdt = value; }
        public int SoGioDay { get => soGioDay; set => soGioDay = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }
        public void inRaManHinh()
        {
            Console.WriteLine("Ten {0}|Ten dem {1}| Ho ten {2} |Ma giao vien {3} | email1 {4} |email2{5} |SDT {6} |So gio day {7} |Chuc vu {8}", ten, tenDem, hoten, maGV, email1, email2, sdt, soGioDay, chucVu);
        }
    }
}
