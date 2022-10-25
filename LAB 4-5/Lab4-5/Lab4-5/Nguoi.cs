using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_5
{
    class Nguoi
    {
        private string ten;
        private int tuoi;
        private int sdt;
        private string diaChi;
        private string ngaySinh;
        private string queQuan;
        private string trinhDo;
        public Nguoi()
        {

        }

        public Nguoi(string ten, int tuoi, int sdt, string diaChi, string ngaySinh, string queQuan, string trinhDo)
        {
            this.Ten = ten;
            this.Tuoi = tuoi;
            this.Sdt = sdt;
            this.DiaChi = diaChi;
            this.NgaySinh = ngaySinh;
            this.QueQuan = queQuan;
            this.TrinhDo = trinhDo;
        }

        public string Ten { get => ten; set => ten = value; }
        public int Tuoi { get => tuoi; set => tuoi = value; }
        public int Sdt { get => sdt; set => sdt = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string QueQuan { get => queQuan; set => queQuan = value; }
        public string TrinhDo { get => trinhDo; set => trinhDo = value; }
        public void inRaManHinh()
        {
            Console.WriteLine("Ten: {0} |Tuoi: {1} |SDT: {2} |Dia chi: {3} |Ngay Sinh: {4} |Que Quan: {5} |Trinh Do: {6} ",ten,tuoi,sdt,diaChi,ngaySinh,queQuan,trinhDo);
        }
    }
}
