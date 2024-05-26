using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignT_ShirtModel
{
    public class Util
    {
        public string pathData = "C:\\DataPMThietKeMau";
        public string pathFDMockup = "";
        public string pathFD1 = "";
        public string pathFD2 = "";
        public string pathFD3 = "";
        public string pathFD4 = "";
        public string pathFDOut = "";

        public int canLe1 = 15;
        public int canLe2 = 15;
        public int canLe3 = 15;
        public int canLe4 = 15;

        private static Util instance = null;

        public List<MokupInfo> lMockupInfo;
        public Util()
        {
            loadData();
        }

        public static Util gI()
        {
            if (instance == null) instance = new Util();
            return instance;
        }

        public MokupInfo GetMokupInfoByName(string name)
        {
            if (lMockupInfo.Count==0) return null;
            foreach(MokupInfo m in lMockupInfo)
                if(m.Name==name) return m;
            return null;
        }

        public void newListMokupInfo(List<MokupInfo> l)
        {
            lMockupInfo.Clear();    
            foreach(MokupInfo m in l)
                lMockupInfo.Add(m);
            saveDataMockup();
        }

        public void updateMockupInfo(MokupInfo m)
        {
            for (int i = 0; i < lMockupInfo.Count; i++)
                if (lMockupInfo[i].Name == m.Name)
                {

                    lMockupInfo[i] = m;
                    saveDataMockup();
                    break;
                }
        }

        public void saveData()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(pathData + "\\DataPM.txt"))
                {
                    sw.WriteLine(pathFDMockup);
                    sw.WriteLine(pathFD1);
                    sw.WriteLine(pathFD2);
                    sw.WriteLine(pathFD3);
                    sw.WriteLine(pathFD4);
                    sw.WriteLine(pathFDOut);
                    sw.WriteLine(canLe1);
                    sw.WriteLine(canLe2);
                    sw.WriteLine(canLe3);
                    sw.WriteLine(canLe4);
                }
            }
            catch (Exception e)
            {

            }
        }

        public void saveDataMockup()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(pathData + "\\MokupInfo.txt"))
                {
                    sw.WriteLine(lMockupInfo.Count);
                    foreach(MokupInfo m in lMockupInfo)
                    {
                        sw.WriteLine(m.Name);
                        sw.WriteLine(m.Opacity);
                        sw.WriteLine(m.Turn);
                        sw.WriteLine(m.ThongSo1.MinX);
                        sw.WriteLine(m.ThongSo1.MinY);
                        sw.WriteLine(m.ThongSo1.MaxX);
                        sw.WriteLine(m.ThongSo1.MaxY);
                    }
                }
            }
            catch (Exception e)
            {

            }
        }

        public void loadData()
        {
            if (!Directory.Exists(pathData))
            {
                Directory.CreateDirectory(pathData);
                pathFDMockup = "Temp";
                pathFD1 = "Temp";
                pathFD2 = "Temp";
                pathFD3 = "Temp";
                pathFD4 = "Temp";
                pathFDOut = "Temp";
                saveData();
            }
            else if (!File.Exists(pathData + "\\DataPM.txt"))
            {
                Directory.CreateDirectory(pathData);
                pathFDMockup = "Temp";
                pathFD1 = "Temp";
                pathFD2 = "Temp";
                pathFD3 = "Temp";
                pathFD4 = "Temp";
                pathFDOut = "Temp";
                saveData();
            }
            else
            {
                try
                {
                    using (StreamReader sr = new StreamReader(pathData + "\\DataPM.txt"))
                    {
                        pathFDMockup = sr.ReadLine();
                        pathFD1 = sr.ReadLine();
                        pathFD2 = sr.ReadLine();
                        pathFD3 = sr.ReadLine();
                        pathFD4 = sr.ReadLine();
                        pathFDOut = sr.ReadLine();
                        canLe1 = int.Parse(sr.ReadLine());
                        canLe2 = int.Parse(sr.ReadLine());
                        canLe3 = int.Parse(sr.ReadLine());
                        canLe4 = int.Parse(sr.ReadLine());
                    }
                }
                catch (Exception ex) { }
            }

            lMockupInfo = new List<MokupInfo>();
            if (!File.Exists(pathData + "\\MokupInfo.txt"))
            {
                saveDataMockup();
            }
            else
            {
                try
                {
                    using (StreamReader sr = new StreamReader(pathData + "\\MokupInfo.txt"))
                    {
                        int n=int.Parse(sr.ReadLine()); 
                        
                        for(int  i=0; i<n; i++)
                        {
                            string path=sr.ReadLine();
                            int opacity=int.Parse(sr.ReadLine());
                            int turn = int.Parse(sr.ReadLine());
                            int minX = int.Parse(sr.ReadLine());
                            int minY = int.Parse(sr.ReadLine());
                            int maxX = int.Parse(sr.ReadLine());
                            int maxY = int.Parse(sr.ReadLine());
                            lMockupInfo.Add(new MokupInfo(path,new ThongSo(0,minX,minY,maxX,maxY), opacity, turn));
                        }
                    }
                }
                catch (Exception ex) { }
            }

            loadDataMock();
        }




        void loadDataMock()
        {
            List<MokupInfo> lNew = new List<MokupInfo>();
            List<string> list = readImageFromFolderMK();
            foreach (string s in list)
            {
                MokupInfo m = GetMokupInfoByName(s);
                if (m == null) m = new MokupInfo(s,new ThongSo(0, 180, 160, 490, 530), 100, 0);
                lNew.Add(m);
            }

            newListMokupInfo(lNew);
        }

        public List<string> readImageFromFolderMK()
        {
            List<string> imageList = new List<string>();
            if (!Directory.Exists(pathFDMockup)) return imageList;
            string[] imageFiles = Directory.GetFiles(pathFDMockup, "*.*", SearchOption.TopDirectoryOnly)
                                            .Where(s => s.EndsWith(".jpg") || s.EndsWith(".jpeg") || s.EndsWith(".png") || s.EndsWith(".gif"))
                                            .ToArray();
            foreach (string imagePath in imageFiles)
            {
                imageList.Add(imagePath);
            }

            return imageList;
        }

        List<Image> readImageFromFolder(string folder)
        {
            List<Image> imageList = new List<Image>();
            string[] imageFiles = Directory.GetFiles(folder, "*.*", SearchOption.TopDirectoryOnly)
                                            .Where(s => s.EndsWith(".jpg") || s.EndsWith(".jpeg") || s.EndsWith(".png") || s.EndsWith(".gif"))
                                            .ToArray();
            foreach (string imagePath in imageFiles)
            {
                Image image = Image.FromFile(imagePath);
                imageList.Add(image);
            }

            return imageList;
        }

        public List<ImageInfo> readImageInfoFromFolder1(string pathFD_)
        {
            List<ImageInfo> imageList = new List<ImageInfo>();
            try
            {
                string[] imageFiles = Directory.GetFiles(pathFD_, "*.*", SearchOption.TopDirectoryOnly)
                                                .Where(s => s.EndsWith(".jpg") || s.EndsWith(".jpeg") || s.EndsWith(".png") || s.EndsWith(".gif"))
                                                .ToArray();
                foreach (string imagePath in imageFiles)
                {
                    ImageInfo image = new ImageInfo(imagePath, Image.FromFile(imagePath));
                    imageList.Add(image);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi folder");
            }
            return imageList;
        }

        private static readonly Random rand = new Random();

        public int nextInt(int from, int to)
        {
            lock (rand)
            {
                return rand.Next(from, to + 1);
            }
        }


        //public Image taoAnhTrang(int width, int height)
        //{
        //    Bitmap bitmap = new Bitmap(width, height);
        //    using (Graphics graphics = Graphics.FromImage(bitmap))
        //    {
        //        graphics.Clear(Color.White);
        //    }
        //    return bitmap;
        //}





        public List<KetQua> tongHop()
        {
            List<KetQua> l = new List<KetQua>();
            try
            {
                List<ImageInfo> iFDMK = readImageInfoFromFolder1(pathFDMockup);
                List<ImageInfo> iFD1 = readImageInfoFromFolder1(pathFD1);
                List<Image> iFD2 = readImageFromFolder(pathFD2);
                List<Image> iFD3 = readImageFromFolder(pathFD3);
                List<Image> iFD4 = readImageFromFolder(pathFD4);
                if (iFDMK.Count < 1) return l;
                if (iFD1.Count < 1) return l;
                if (iFD2.Count < 2) return l;
                if (iFD3.Count < 2) return l;
                if (iFD4.Count < 2) return l;

                foreach (ImageInfo imMK in iFDMK)
                {
                    using (ImageService imS = new ImageService())
                    {
                        l.AddRange(imS.getDanhSachKetQua(imMK, iFD1, iFD2, iFD3, iFD4));
                    }
                }
                iFD1.Clear();
                iFD2.Clear();
                iFD3.Clear();
                iFD4.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return l;
        }
    }
}
