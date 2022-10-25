using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_5
{
    class Cho
    {
        private string maCho;
        private string tenCho;
        private string gioiTinh;
        private string thucAnYeuThich;
        private int ngaySinh;
        public Cho()
        {

        }

        public Cho(string maCho, string tenCho, string gioiTinh, string thucAnYeuThich, int ngaySinh)
        {
            this.MaCho = maCho;
            this.TenCho = tenCho;
            this.GioiTinh = gioiTinh;
            this.ThucAnYeuThich = thucAnYeuThich;
            this.NgaySinh = ngaySinh;
        }
        public string MaCho { get => maCho; set => maCho = value; }
        public string TenCho { get => tenCho; set => tenCho = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string ThucAnYeuThich { get => thucAnYeuThich; set => thucAnYeuThich = value; }
        public int NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public void inRaManHinh()
        {
            Console.WriteLine("Ma cho {0} |Ten cho {1} |Gioi tinh {2} |Thuc an yeu thich {3} |Ngay sinh {4}", maCho, tenCho, gioiTinh, thucAnYeuThich, ngaySinh);
        }
    }
}
