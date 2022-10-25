using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_5
{
    class SinhVien
    {
        private string ten;
        private string tenDem;
        private string hoten;
        private string maSV;
        private string email;
        private int sdt;
        private int sdtNguoiThan;
        private string nganhHoc;

        public SinhVien()
        {

        }

        public SinhVien(string ten, string tenDem, string hoten, string maSV, string email, int sdt, int sdtNguoiThan, string nganhHoc)
        {
            this.Ten = ten;
            this.TenDem = tenDem;
            this.Hoten = hoten;
            this.MaSV = maSV;
            this.Email = email;
            this.Sdt = sdt;
            this.SdtNguoiThan = sdtNguoiThan;
            this.NganhHoc = nganhHoc;
        }

        public string Ten { get => ten; set => ten = value; }
        public string TenDem { get => tenDem; set => tenDem = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public string MaSV { get => maSV; set => maSV = value; }
        public string Email { get => email; set => email = value; }
        public int Sdt { get => sdt; set => sdt = value; }
        public int SdtNguoiThan { get => sdtNguoiThan; set => sdtNguoiThan = value; }
        public string NganhHoc { get => nganhHoc; set => nganhHoc = value; }

        public void inRaManHinh()
        {
            Console.WriteLine("Ten {0}|Ten dem {1}| Ho ten {2} |Ma Sinh vien {3} | email {4} | sdt {5} | sdt nguoi thanh {6} |nganh hoc {7}", Ten, TenDem, Hoten, MaSV, Email, Sdt, SdtNguoiThan, NganhHoc);
        }
    }
}
