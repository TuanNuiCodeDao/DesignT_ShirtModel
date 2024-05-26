using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignT_ShirtModel
{
    public class ImageService : IDisposable
    {
        private bool disposed = false;

        // Hàm hủy
        ~ImageService()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                   
                }

                disposed = true;
            }
        }
        public ImageService() { }

        public Bitmap reSize(Image i, float tiLe)
        {
            if (tiLe == 1) return new Bitmap(i);

            Size newSize = new Size((int)(i.Width * tiLe), (int)(i.Height * tiLe));

            Bitmap bmp = new Bitmap(newSize.Width, newSize.Height);
            using (Graphics graphics = Graphics.FromImage(bmp))
            {
                graphics.DrawImage(i, new Rectangle(0, 0, newSize.Width, newSize.Height));
            }

            return bmp;
        }

        static int min_x2_1 = 676;
        static int min_y2_1 = 0;
        static int max_x2_1 = 960;
        static int max_y2_1 = 325;

        static int min_x2_2 = 676;
        static int min_y2_2 = 333;
        static int max_x2_2 = 960;
        static int max_y2_2 = 660;

        static int min_x3_1 = 0;
        static int min_y3_1 = 667;
        static int max_x3_1 = 233;
        static int max_y3_1 = 960;

        static int min_x3_2 = 240;
        static int min_y3_2 = 667;
        static int max_x3_2 = 476;
        static int max_y3_2 = 960;

        static int min_x4_1 = 483;
        static int min_y4_1 = 667;
        static int max_x4_1 = 719;
        static int max_y4_1 = 960;

        static int min_x4_2 = 725;
        static int min_y4_2 = 667;
        static int max_x4_2 = 960;
        static int max_y4_2 = 960;

        Bitmap fill(Bitmap bmp, Image i2, int canLe, int minX, int minY, int maxX, int maxY)
        {
            try
            {
                int width = maxX - minX;
                int height = maxY - minY;
                int tamX = minX + width / 2;
                int tamY = minY + height / 2;

                canLe = Math.Min(canLe, width / 2);
                canLe = Math.Min(canLe, height / 2);

                width -= canLe;
                height -= canLe;

                float tile1 = (float)width / i2.Width;
                float tile2 = (float)height / i2.Height;
                float tiLe = Math.Min(tile1, tile2);
                using (ImageService imS = new ImageService())
                {
                    using (Image i = imS.reSize(i2, tiLe))
                    {
                        using (Graphics graphics = Graphics.FromImage(bmp))
                        {
                            graphics.DrawImage(i, new Point(tamX - i.Width / 2, tamY - i.Height / 2));
                        }
                    }
                }

                return bmp;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi out index ( hãy điều chỉnh tỉ lệ) " + ex.Message);
            }

            return bmp;
        }

        public Image getPhoiTong(Image mk, Image im2_1, Image im2_2, Image im3_1, Image im3_2, Image im4_1, Image im4_2)
        {
            Image img = null;
            using (ImageService imS = new ImageService())
            {
                try
                {
                    img = imS.reSize(mk, 960, 960);
                    Bitmap bm = new Bitmap(img);
                    bm = fill(bm, im2_1, Util.gI().canLe2, min_x2_1, min_y2_1, max_x2_1, max_y2_1);
                    bm = fill(bm, im2_2, Util.gI().canLe2, min_x2_2, min_y2_2, max_x2_2, max_y2_2);
                    bm = fill(bm, im3_1, Util.gI().canLe3, min_x3_1, min_y3_1, max_x3_1, max_y3_1);
                    bm = fill(bm, im3_2, Util.gI().canLe3, min_x3_2, min_y3_2, max_x3_2, max_y3_2);
                    bm = fill(bm, im4_1, Util.gI().canLe4, min_x4_1, min_y4_1, max_x4_1, max_y4_1);
                    bm = fill(bm, im4_2, Util.gI().canLe4, min_x4_2, min_y4_2, max_x4_2, max_y4_2);
                    return bm;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return img;
        }

        public Image getTong(KetQua k)
        {
            try
            {
                MokupInfo m = Util.gI().GetMokupInfoByName(k.PathMK);
                Image image = null;
                using (ImageService imS = new ImageService())
                {
                    image = imS.FillSuper(k.PhoiTong, k.Image1.Image, k.KhungAnh1, m == null ? 0 : m.Turn, m == null ? 0 : m.Opacity);
                }

                return image;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return k.PhoiTong;
        }

        public Bitmap reSize(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }

            }

            return destImage;
        }

        public Bitmap Fill(Bitmap bmp, Image image, int margin, int minX, int minY, int maxX, int maxY)
        {
            try
            {
                int width = maxX - minX;
                int height = maxY - minY;
                int centerX = minX + width / 2;
                int centerY = minY + height / 2;

                margin = Math.Min(margin, width / 2);
                margin = Math.Min(margin, height / 2);

                width -= margin;
                height -= margin;

                float scale = Math.Min((float)width / image.Width, (float)height / image.Height);

                using (Bitmap resizedImage = reSize(image, scale))
                using (Graphics graphics = Graphics.FromImage(bmp))
                {
                    graphics.DrawImage(resizedImage, centerX - resizedImage.Width / 2, centerY - resizedImage.Height / 2);
                }

                return bmp;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }

            return bmp;
        }

        public Image FillSuper(Image bmp, Image image, ThongSo ts, int turn, int opacity)
        {
            try
            {
                int width = ts.MaxX - ts.MinX;
                int height = ts.MaxY - ts.MinY;
                int centerX = ts.MinX + width / 2;
                int centerY = ts.MinY + height / 2;

                int margin = Math.Min(ts.CanLe, width / 2);
                margin = Math.Min(margin, height / 2);

                width -= margin;
                height -= margin;

                float scale = Math.Min((float)width / image.Width, (float)height / image.Height);
                Bitmap b = new Bitmap(bmp);
                using (Bitmap resizedImage = reSize(image, scale))
                {
                    int chenhLech = height - resizedImage.Height;

                    //MessageBox.Show(chenhLech + "");
                    if (chenhLech > 0) centerY -= chenhLech / 2;
                    b = MergeImages(b, resizedImage, centerX, centerY, turn, opacity);
                }

                return b;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }

            return bmp;
        }

        public Bitmap MergeImages(Bitmap image1, Bitmap image2, int x, int y, float turn, float opacity)
        {
            try
            {
                PointF pivotImage2 = new PointF(image2.Width / 2f, image2.Height / 2f);

                Matrix transformMatrix = new Matrix();
                transformMatrix.Translate(x - pivotImage2.X, y - pivotImage2.Y);
                transformMatrix.RotateAt(turn, pivotImage2);

                using (Graphics graphics = Graphics.FromImage(image1))
                {
                    graphics.DrawImage(image1, new Point(0, 0));
                    graphics.Transform = transformMatrix;
                    using (Bitmap bm2 = SetImageOpacity(image2, opacity))
                    {
                        graphics.DrawImage(bm2, new Rectangle(0, 0, image2.Width, image2.Height));
                    }
                }


                return image1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return image1;
            }
        }

        public Bitmap SetImageOpacity(Bitmap bmp1, float opacity)
        {
            if (opacity == 100) return bmp1;
            try
            {
                Bitmap bmp = new Bitmap(bmp1.Width, bmp1.Height);
                for (int i = 0; i < bmp1.Width; i++)
                    for (int j = 0; j < bmp1.Height; j++)
                    {
                        Color c = bmp1.GetPixel(i, j);
                        if (c.A == 0) bmp.SetPixel(i, j, c);
                        else
                        {
                            byte newR = (byte)(c.R * opacity / 100);
                            byte newG = (byte)(c.G * opacity / 100);
                            byte newB = (byte)(c.B * opacity / 100);
                            bmp.SetPixel(i, j, Color.FromArgb(c.A, newR, newG, newB));
                        }
                    }
                return bmp;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return bmp1;
            }
        }

        int getNgauNhienViTri(List<int> l)
        {
            if (l.Count == 0) return -1;

            return l[Util.gI().nextInt(0, l.Count - 1)];
        }

        public List<KetQua> getDanhSachKetQua(ImageInfo mk, List<ImageInfo> iFD1, List<Image> iFD2, List<Image> iFD3, List<Image> iFD4)
        {
            List<KetQua> l = new List<KetQua>();
            try
            {
                if (iFD1.Count < 1) return l;
                if (iFD2.Count < 2) return l;
                if (iFD3.Count < 2) return l;
                if (iFD4.Count < 2) return l;

                List<int> iFD1_ = new List<int>();
                for (int i = 0; i < iFD1.Count; i++) iFD1_.Add(i);
                List<int> iFD2_ = new List<int>();
                for (int i = 0; i < iFD2.Count; i++) iFD2_.Add(i);
                List<int> iFD3_ = new List<int>();
                for (int i = 0; i < iFD3.Count; i++) iFD3_.Add(i);
                List<int> iFD4_ = new List<int>();
                for (int i = 0; i < iFD4.Count; i++) iFD4_.Add(i);

                while (true)
                {

                    int id1 = getNgauNhienViTri(iFD1_);
                    if (id1 == -1) break;
                    iFD1_.Remove(id1);

                    int id2_1 = getNgauNhienViTri(iFD2_);
                    if (id2_1 == -1) break;
                    iFD2_.Remove(id2_1);


                    int id2_2 = getNgauNhienViTri(iFD2_);
                    if (id2_2 == -1) break;
                    iFD2_.Remove(id2_2);

                    int id3_1 = getNgauNhienViTri(iFD3_);
                    if (id3_1 == -1) break;
                    iFD3_.Remove(id3_1);

                    int id3_2 = getNgauNhienViTri(iFD3_);
                    if (id3_2 == -1) break;
                    iFD3_.Remove(id3_2);

                    int id4_1 = getNgauNhienViTri(iFD4_);
                    if (id4_1 == -1) break;
                    iFD4_.Remove(id4_1);

                    int id4_2 = getNgauNhienViTri(iFD4_);
                    if (id4_2 == -1) break;
                    iFD4_.Remove(id4_2);

                    ImageInfo im1 = iFD1[id1].Clone();
                    using (Image im2_1 = iFD2[id2_1].Clone() as Image)
                    using (Image im2_2 = iFD2[id2_2].Clone() as Image)
                    using (Image im3_1 = iFD3[id3_1].Clone() as Image)
                    using (Image im3_2 = iFD3[id3_2].Clone() as Image)
                    using (Image im4_1 = iFD4[id4_1].Clone() as Image)
                    using (Image im4_2 = iFD4[id4_2].Clone() as Image)
                    {
                        using (ImageService imS = new ImageService())
                        {
                            Image phoi = imS.getPhoiTong(mk.Image, im2_1, im2_2, im3_1, im3_2, im4_1, im4_2);
                            KetQua k = new KetQua(mk.Name, Util.gI().GetMokupInfoByName(mk.Name).ThongSo1, im1, phoi);
                            k.Tong = imS.getTong(k);
                            l.Add(k);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return l;
        }
    }
}
