using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_5
{
    class Oto
    {
        private int maOto;
        private string hangOto;
        private string dongCo;
        private string nhienLieu;
        private int giaTien;
        public Oto()
        {

        }

        public Oto(int maOto, string hangOto, string dongCo, string nhienLieu, int giaTien)
        {
            this.MaOto = maOto;
            this.HangOto = hangOto;
            this.DongCo = dongCo;
            this.NhienLieu = nhienLieu;
            this.GiaTien = giaTien;
        }

        public int MaOto { get => maOto; set => maOto = value; }
        public string HangOto { get => hangOto; set => hangOto = value; }
        public string DongCo { get => dongCo; set => dongCo = value; }
        public string NhienLieu { get => nhienLieu; set => nhienLieu = value; }
        public int GiaTien { get => giaTien; set => giaTien = value; }
        public void inrRaManhinh()
        {
            Console.WriteLine("Ma oto {0} | Hang oto {1} | Dong co {2} | Nhien lieu {3} |Gia tien {4} ", maOto, hangOto, dongCo, nhienLieu, giaTien);
        }
    }
}
