using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignT_ShirtModel
{
    public class MokupInfo
    {
        public string Name { get; set; }
        public int Opacity { get; set; }
        public int Turn { get; set; }
        public ThongSo ThongSo1 { get; set; }

        public MokupInfo(string name, ThongSo thongSo1, int opacity, int turn)
        {
            Name = name;
            this.ThongSo1 = thongSo1;
            Opacity = opacity;
            Turn = turn;
        }

        public MokupInfo() { }
    }
}
