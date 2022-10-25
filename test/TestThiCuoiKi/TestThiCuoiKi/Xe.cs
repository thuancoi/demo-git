using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestThiCuoiKi
{
    class Xe
    {
        private string maxe;
        private string ten;
        private int gia;
        public Xe()
        {

        }

        public Xe(string maxe, string ten, int gia)
        {
            this.Maxe = maxe;
            this.Ten = ten;
            this.Gia = gia;
        }

        public string Maxe { get => maxe; set => maxe = value; }
        public string Ten { get => ten; set => ten = value; }
        public int Gia { get => gia; set => gia = value; }
        public void inRaManHinh()
        {
            Console.WriteLine("Ma xe: {0} |Ten xe: {1} |Gia tien: {2}",maxe,ten,gia);
        }
    }
}
