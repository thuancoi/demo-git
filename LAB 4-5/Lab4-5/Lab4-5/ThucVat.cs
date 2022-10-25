using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_5
{
    class ThucVat
    {
        private int maTV;
        private string tenLoai;
        private string khuVuc;
        public ThucVat()
        {

        }

        public ThucVat(int maTV, string tenLoai, string khuVuc)
        {
            this.MaTV = maTV;
            this.TenLoai = tenLoai;
            this.KhuVuc = khuVuc;
        }

        public int MaTV { get => maTV; set => maTV = value; }
        public string TenLoai { get => tenLoai; set => tenLoai = value; }
        public string KhuVuc { get => khuVuc; set => khuVuc = value; }
        public void inRaManHinh()
        {
            Console.WriteLine("Ma thuc vat {0} | ten loai {1} |Khu vuc {2}", maTV, tenLoai, KhuVuc);
        }
    }
}
