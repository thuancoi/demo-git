using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_5
{
    class BanGhe
    {
        private int maBG;
        private string tenBG;
        private string loaiBG;
        private string chatLieu;
        private int chieuCao;
        private int chieuRong;
        public BanGhe()
        {

        }

        public BanGhe(int maBG, string tenBG, string loaiBG, string chatLieu, int chieuCao, int chieuRong)
        {
            this.MaBG = maBG;
            this.TenBG = tenBG;
            this.LoaiBG = loaiBG;
            this.ChatLieu = chatLieu;
            this.ChieuCao = chieuCao;
            this.ChieuRong = chieuRong;

        }

        public int MaBG { get => maBG; set => maBG = value; }
        public string TenBG { get => tenBG; set => tenBG = value; }
        public string LoaiBG { get => loaiBG; set => loaiBG = value; }
        public string ChatLieu { get => chatLieu; set => chatLieu = value; }
        public int ChieuCao { get => chieuCao; set => chieuCao = value; }
        public int ChieuRong { get => chieuRong; set => chieuRong = value; }
        public void inRaManHinh()
        {
            Console.WriteLine("Ma ban ghe {0} | Ten ban ghe {1} | Loai ban ghe {2} |Chat lieu {3} | Chieu cao {4} | Chieu rong {5}", MaBG, tenBG, loaiBG, chatLieu, chieuCao, chieuRong);
        }
    }
}
