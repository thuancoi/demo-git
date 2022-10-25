using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_5
{
    class Program
    {
        static void Main(string[] args)
        {

            Program p1 = new Program();
            p1.nguoi();
            Program p2 = new Program();
            p2.sinhVien();
            Program p3 = new Program();
            p3.tv();
            Program p4 = new Program();
            p4.xm();
            Program p5 = new Program();
            p5.bg();
            Program p6 = new Program();
            p6.cho();
            Program p7 = new Program();
            p7.dv();
            Program p8 = new Program();
            p8.gv();
            Program p9 = new Program();
            p9.m();
            Program p10 = new Program();
            p10.oto();
            Console.ReadKey();
        }
        void nguoi()
        {
            //khong tham so
            Nguoi n1 = new Nguoi();
            n1.DiaChi = "ngo 1 pham van dong";
            n1.QueQuan = "Phu tho";
            n1.NgaySinh = "20/1/2010";
            n1.Sdt = 912304124;
            n1.Ten = "Thuan";
            n1.TrinhDo = "Kha";
            n1.Tuoi = 11;
            n1.inRaManHinh();
            // co tham so
            Nguoi n2 = new Nguoi("thuan", 11, 0143545712, "ngo 2 pham van dong", "20/1/2010", "Phu tho", "kha");
            n2.inRaManHinh();
        }
        void sinhVien()
        {
            //khong tham so
            SinhVien sv1 = new SinhVien();
            sv1.Ten = "thuan";
            sv1.Hoten = "Dinh duc thuan";
            sv1.Email = "thuanddph";
            sv1.MaSV = "ph13844";
            sv1.NganhHoc = "web";
            sv1.Sdt = 013244;
            sv1.SdtNguoiThan = 2342566;
            sv1.TenDem = "duc";
            sv1.inRaManHinh();
            //co tham so
            SinhVien sv = new SinhVien("thuan", "duc", "dinh duc thuan", "ph13844", "thuanddph13844", 0243853, 234523, "web");
            sv.inRaManHinh();
        }
        void tv()
        {
            //khong tham so
            ThucVat tv1 = new ThucVat();
            tv1.KhuVuc = "chau a";
            tv1.MaTV = 132;
            tv1.TenLoai = "hoa quynh";
            tv1.inRaManHinh();
            //co tham so
            ThucVat tv2 = new ThucVat(123, "hoa quynh", "chau a");
            tv2.inRaManHinh();

        }
        void xm()
        {
            //khong tham so
            XeMay xm1 = new XeMay();
            xm1.HangXeMay = "yamaha";
            xm1.LoaiXeMay = "exciter ";
            xm1.MaXeMay = "m150";
            xm1.NhienLieu = "xang";
            xm1.TenXeMay = "yamaha exciter 150";
            xm1.GiaTien = 40000000;
            xm1.DongCo = "150cc";
            xm1.inRaManHinh();
            //khong tham so
            XeMay xm2 = new XeMay("m150", "yamaha exciter 150", "yahmaha", "exciter", "xang", "150cc", 35000000);
            xm2.inRaManHinh();
        }
        void bg()
        {
            //khong tham so
            BanGhe bg1 = new BanGhe();
            bg1.LoaiBG = "go";
            bg1.MaBG = 145;
            bg1.TenBG = "ban ghe go";
            bg1.ChatLieu = "go dep";
            bg1.ChieuCao = 100;
            bg1.ChieuRong = 500;
            bg1.inRaManHinh();
            //co tham so
            BanGhe bg2 = new BanGhe(154, "ban ghe go", "go", "go dep", 60, 40);
            bg2.inRaManHinh();
        }
        void cho()
        {
            //khong tham so
            Cho c = new Cho();
            c.MaCho = "ph343";
            c.NgaySinh = 25;
            c.TenCho = "Do tung duong";
            c.ThucAnYeuThich = "com";
            c.GioiTinh = "duc";
            c.inRaManHinh();
            //co tham so
            Cho c1 = new Cho("ph2324", "do tung duong", "cho duc", "com", 24);
            c1.inRaManHinh();

        }
        void dv()
        {
            //khong tham so
            DongVat dv1 = new DongVat();
            dv1.GiongLoai = "gia suc";
            dv1.KhuVucSong = "chau au";
            dv1.MaDongVat = "th24124";
            dv1.TenLoai = "cho";
            dv1.ThucAn = "com";
            dv1.inRaManHinh();
            //co tham so
            DongVat dv2 = new DongVat("th43242", "cho", "gia suc", "chau au", "com cho");
            dv2.inRaManHinh();
        }
        void gv()
        {
            //khong tham so
            GiaoVien gv1 = new GiaoVien();
            gv1.Hoten = "Ha Bich Lieu";
            gv1.MaGV = "L250102";
            gv1.Sdt = 0966653014;
            gv1.SoGioDay = 72;
            gv1.Ten = "Lieu";
            gv1.TenDem = "Bich";
            gv1.Email1 = "Lieuuuu224@mai.com";
            gv1.Email2 = "lieu2434@mai.com";
            gv1.ChucVu = "Gv";
            gv1.inRaManHinh();
            //co tham so;
            GiaoVien gv2 = new GiaoVien("Lieu", "Bich", "Ha", "L250102", "lieuuu@gmail.com", "Lieu2@gmail.com", 03242345, 54, "gv");
            gv2.inRaManHinh();
        }
        void m()
        {
            //khong tham so
            Meo m1 = new Meo();
            m1.DiaChi = "Phu tho";
            m1.GioiTinh = "cai";
            m1.NgaySinh = 30;
            m1.Ten = "thuy";
            m1.inRaManHinh();
            //co tham so
            Meo m2 = new Meo("thuy", 23, "Phu tho", "cai", 10);
            m2.inRaManHinh();
        }
        void oto()
        {
            //khong tham so
            Oto o1 = new Oto();
            o1.DongCo = "diezen";
            o1.GiaTien = 1000000000;
            o1.HangOto = "mecedez";
            o1.MaOto = 533;
            o1.NhienLieu = "xang";
            o1.inrRaManhinh();
            //co tham so
            Oto o2 = new Oto(533, "mecedez", "diezen", "xang", 100000000);
            o2.inrRaManhinh();
        }
    }
}
