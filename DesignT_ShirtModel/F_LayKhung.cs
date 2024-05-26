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
    public partial class F_LayKhung : Form
    {
        public bool k = false;
        public ThongSo ThongSo1;
        private Point startPoint;
        private Rectangle selectionRectangle = new Rectangle();
        private bool isSelecting = false;

        ThongSo ThongSoTemp;
        Rectangle rectangleToDraw;

        public F_LayKhung(Image im,ThongSo thongSo)
        {
            InitializeComponent();
            using (ImageService imS = new ImageService())
            {
                this.ptAnh.Image = imS.reSize(im, 640, 640);
            }
            ThongSo1 = thongSo;
            labelNote.Text = thongSo.getStr();
            ThongSoTemp= thongSo;
            rectangleToDraw=new Rectangle((int)((float)thongSo.MinX*2/3), (int)((float)thongSo.MinY * 2 / 3), (int)((float)(thongSo.MaxX-thongSo.MinX) * 2 / 3), (int)((float)(thongSo.MaxY - thongSo.MinY) * 2 / 3));
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThongSo1 = ThongSoTemp;
            k = true;
            this.Close();
        }


        void veLai()
        {
            using (Graphics g = ptAnh.CreateGraphics())
            {
                using (Pen pen = new Pen(Color.Red, 2))
                {
                    g.DrawRectangle(pen, rectangleToDraw);
                }
            }

            labelNote.Text = ThongSo1.getStr();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            veLai();
        }

        private void F_LayKhung_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void F_LayKhung_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void F_LayKhung_Move(object sender, EventArgs e)
        {

        }

        private void F_LayKhung_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void F_LayKhung_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void ptAnh_MouseDown(object sender, MouseEventArgs e)
        {
            startPoint = e.Location;
            isSelecting = true;
        }

        private void ptAnh_MouseMove(object sender, MouseEventArgs e)
        {
            if (isSelecting)
            {
                Point currentPoint = ptAnh.PointToClient(MousePosition);
                int x = Math.Min(startPoint.X, currentPoint.X);
                int y = Math.Min(startPoint.Y, currentPoint.Y);
                int width = Math.Abs(startPoint.X - currentPoint.X);
                int height = Math.Abs(startPoint.Y - currentPoint.Y);
                selectionRectangle = new Rectangle(x, y, width, height);
                ThongSoTemp = new ThongSo(0, (int)(startPoint.X * 1.5f), (int)(startPoint.Y * 1.5f), Math.Min((int)(currentPoint.X * 1.5f),960), Math.Min((int)(currentPoint.Y*1.5f), 960));
                labelNote.Text = ThongSoTemp.getStr();
                ptAnh.Invalidate();
            }
        }

        private void ptAnh_MouseUp(object sender, MouseEventArgs e)
        {
            isSelecting = false;
            // Lưu vùng chọn
            //MessageBox.Show("Vùng chọn: " + selectionRectangle.ToString());
        }

        private void ptAnh_Paint(object sender, PaintEventArgs e)
        {
            if (isSelecting)
            {
                using (Pen pen = new Pen(Color.Red, 2))
                {
                    e.Graphics.DrawRectangle(pen, selectionRectangle);
                }
            }
        }

        private void ptAnh_MouseLeave(object sender, EventArgs e)
        {
        }

        private void F_LayKhung_Load(object sender, EventArgs e)
        {
            veLai();
        }
    }
}
