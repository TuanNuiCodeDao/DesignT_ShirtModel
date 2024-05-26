using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignT_ShirtModel
{
    public class ThongSo
    {
        public int CanLe { get; set; }
        public int MinX { get; set; }
        public int MinY { get; set; }
        public int MaxX { get; set; }
        public int MaxY { get; set; }

        public ThongSo(int canLe, int minX, int minY, int maxX, int maxY)
        {
            CanLe = canLe;
            MinX = minX;
            MinY = minY;
            MaxX = maxX;
            MaxY = maxY;
        }
        public ThongSo() { }

        public string getStr()
        {
            return "(" + MinX + ";" + MinY + "),(" + MaxX + ";" + MaxY + ")";
        }
    }
}
