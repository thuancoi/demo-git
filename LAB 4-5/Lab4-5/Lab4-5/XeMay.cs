using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_5
{
    class XeMay
    {
        private string maXeMay;
        private string tenXeMay;
        private string hangXeMay;
        private string loaiXeMay;
        private string nhienLieu;
        private string dongCo;
        private int giaTien;
        public XeMay()
        {

        }

        public XeMay(string maXeMay, string tenXeMay, string hangXeMay, string loaiXeMay, string nhienLieu, string dongCo, int giaTien)
        {
            this.MaXeMay = maXeMay;
            this.TenXeMay = tenXeMay;
            this.HangXeMay = hangXeMay;
            this.LoaiXeMay = loaiXeMay;
            this.NhienLieu = nhienLieu;
            this.DongCo = dongCo;
            this.GiaTien = giaTien;
        }

        public string MaXeMay { get => maXeMay; set => maXeMay = value; }
        public string TenXeMay { get => tenXeMay; set => tenXeMay = value; }
        public string HangXeMay { get => hangXeMay; set => hangXeMay = value; }
        public string LoaiXeMay { get => loaiXeMay; set => loaiXeMay = value; }
        public string NhienLieu { get => nhienLieu; set => nhienLieu = value; }
        public string DongCo { get => dongCo; set => dongCo = value; }
        public int GiaTien { get => giaTien; set => giaTien = value; }
        public void inRaManHinh()
        {
            Console.WriteLine("Ma xe may: {0}| Ten xe may: {1}| Hang xe may {2}| Loai xe may: {3} |nhien lieu: {4}| Dong co: {5}| Gia tien :{6}");
        }
    }
}
