using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignT_ShirtModel
{
    public class ImageInfo 
    {
        private bool disposed = false;

        public string Name { get; set; }
        public Image Image { get; set; }
        public ImageInfo(string name, Image image)
        {
            Name = name;
            Image = image;
        }

        public ImageInfo Clone()
        {
            return new ImageInfo(Name, Image.Clone() as Image);
        }
    }
}
