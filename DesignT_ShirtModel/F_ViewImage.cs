using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignT_ShirtModel
{
    public partial class F_ViewImage : Form
    {
        private PictureBox pictureBox;
        public F_ViewImage(Image im)
        {
            InitializeComponent();
            InitializeComponents(im);
        }
        private void InitializeComponents(Image im)
        {
            pictureBox = new PictureBox();
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.Image = im;

            

            Controls.Add(pictureBox);
        }


    }
}
