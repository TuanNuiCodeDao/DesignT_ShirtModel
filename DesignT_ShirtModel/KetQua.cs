using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignT_ShirtModel
{
    public class KetQua
    {
        public string PathMK { get; set; }
        public ImageInfo Image1 { get; set; }

        public Image PhoiTong { get; set; }

        public Image Tong { get; set; }

        public int Opacity { get; set; }

        public int Turn { get; set; }

        public ThongSo KhungAnh1 { get;set; }

        public KetQua(string pathMK,ThongSo khungAnh1, ImageInfo image1, Image phoiTong)
        {
            this.KhungAnh1 = khungAnh1;
            this.PathMK = pathMK;
            Image1 = image1;
            PhoiTong = phoiTong;
            Opacity = 100;
            Turn = 0;
        }

        public KetQua() { }
    }
}
