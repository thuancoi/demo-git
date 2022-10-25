using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_5
{
    class DongVat
    {
        private string maDongVat;
        private string tenLoai;
        private string giongLoai;
        private string khuVucSong;
        private string thucAn;
        public DongVat()
        {

        }

        public DongVat(string maDongVat, string tenLoai, string giongLoai, string khuVucSong, string thucAn)
        {
            this.MaDongVat = maDongVat;
            this.TenLoai = tenLoai;
            this.GiongLoai = giongLoai;
            this.KhuVucSong = khuVucSong;
            this.ThucAn = thucAn;
        }

        public string MaDongVat { get => maDongVat; set => maDongVat = value; }
        public string TenLoai { get => tenLoai; set => tenLoai = value; }
        public string GiongLoai { get => giongLoai; set => giongLoai = value; }
        public string KhuVucSong { get => khuVucSong; set => khuVucSong = value; }
        public string ThucAn { get => thucAn; set => thucAn = value; }
        public void inRaManHinh()
        {
            Console.WriteLine("Ma dong vat {0} |Ten loai {1} | Giong loai {2} | Khu vuc song {3} |Thuc an {4}", maDongVat, tenLoai, giongLoai, khuVucSong, thucAn);
        }
    }
}
