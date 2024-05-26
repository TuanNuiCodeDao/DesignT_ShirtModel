using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignT_ShirtModel
{
    public partial class Form1 : Form
    {
        List<KetQua> l =new List<KetQua> ();
        Image imTemp = null;
        int index = 0;
        int hOValue = 100;
        int hXValue = 0;
        public Form1()
        {
            InitializeComponent();
            labelNote.Text = "";
            imTemp = null;
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Xác nhận thoát chương trình ?", "Xác nhận", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void tùyChỉnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isRun)
            {
                MessageBox.Show("Tiến trình tổng hợp đang xử lý, vui lòng chờ !", "Thông báo");
                return;
            }
            F_DataSet f = new F_DataSet();
            f.ShowDialog();
        }

        bool isRun = false;
        void tongHop()
        {
            isRun = true;
            this.Invoke(new Action(() =>
            {
                labelNote.Text = "Đang tổng hợp......";
            }));
            l = Util.gI().tongHop();
            this.Invoke(new Action(() =>
            {
                labelNote.Text = "";
            }));
            isRun = false;
            Invoke(new Action(() =>
            {
                MessageBox.Show("Tiến trình tổng hợp đã hoàn tất.");
                if(l.Count>0)
                {
                    index = 0;
                    ShowKetQua();
                }
            }));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isRun)
            {
                MessageBox.Show("Tiến trình tổng hợp đang xử lý, vui lòng chờ !", "Thông báo");
                return;
            }
            Thread tongHopTH = new Thread(tongHop);
            tongHopTH.Start();
        }

        bool isShowKetQua = false;
        public void ShowKetQua()
        {
            try
            {
                isShowKetQua = true;
                hX.Value = hXValue;
                hO.Value = hOValue;
                label1.Text = (index + 1) + "/" + l.Count;
                if (index < 0 || index >= l.Count) return;
                labelO.Text = l[index].Opacity + " (Opacity)";
                lbX.Text = l[index].Turn + " (Turn)";
                ptAnh.Image = l[index].Tong;
                isShowKetQua = false;
            }
            catch (Exception ex) { }
        }

        private void hO_Scroll(object sender, ScrollEventArgs e)
        {
            int newHOValue = hO.Value;
            if (newHOValue < 0) newHOValue = 0;
            if (newHOValue > 100) newHOValue = 100;


            if (hOValue != newHOValue)
            {
                hOValue = newHOValue;
                labelO.Text = hOValue + " (Opacity)";
                if(!isShowKetQua) showNew();
            }
        }
        private void hX_Scroll(object sender, ScrollEventArgs e)
        {
            int newHXValue = hX.Value;
            if (newHXValue < -90) newHXValue = -90;
            if (newHXValue > 90) newHXValue = 90;

            if (hXValue != newHXValue)
            {
                hXValue = newHXValue;
                lbX.Text = hXValue + " (Turn)";
                if (!isShowKetQua)  showNew();
            }
        }
        private void F_KetQua_Load(object sender, EventArgs e)
        {
        }


        private void button7_Click(object sender, EventArgs e)
        {
            if (isRun)
            {
                MessageBox.Show("Tiến trình tổng hợp đang xử lý, vui lòng chờ !", "Thông báo");
                return;
            }

            if (l.Count == 0)
            {
                MessageBox.Show("Danh sách kết quả trống !", "Thông báo");
                return;
            }

            imTemp = null;
            ptAnh.Image = l[index].Tong;
        }

        void showNew()
        {
            if (isRun) return;
            if (l.Count == 0)
            {
                MessageBox.Show("Danh sách kết quả trống !", "Thông báo");
                return;
            }
            if (hOValue <= 0) imTemp = l[index].Tong;
            else
            {
                using (ImageService imS = new ImageService())
                {
                    imTemp = imS.FillSuper(l[index].PhoiTong, l[index].Image1.Image, l[index].KhungAnh1, hXValue, hOValue);
                }
            }
            ptAnh.Image = imTemp;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (isRun)
            {
                MessageBox.Show("Tiến trình tổng hợp đang xử lý, vui lòng chờ !", "Thông báo");
                return;
            }

            if (l.Count == 0)
            {
                MessageBox.Show("Danh sách kết quả trống !", "Thông báo");
                return;
            }
            imTemp = null;
            index--;
            if (index < 0) index = l.Count - 1;
            ShowKetQua();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (isRun)
            {
                MessageBox.Show("Tiến trình tổng hợp đang xử lý, vui lòng chờ !", "Thông báo");
                return;
            }

            if (l.Count == 0)
            {
                MessageBox.Show("Danh sách kết quả trống !", "Thông báo");
                return;
            }
            if (imTemp == null) return;

            l[index].Tong = (Image)imTemp.Clone();
            imTemp = null;
            l[index].Opacity = hOValue;
            l[index].Turn = hXValue;
            MokupInfo m = Util.gI().GetMokupInfoByName(l[index].PathMK);
            if (m != null)
            {
                m = new MokupInfo(m.Name,m.ThongSo1, hOValue, hXValue);
                Util.gI().updateMockupInfo(m);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (isRun)
            {
                MessageBox.Show("Tiến trình tổng hợp đang xử lý, vui lòng chờ !", "Thông báo");
                return;
            }

            if (l.Count == 0)
            {
                MessageBox.Show("Danh sách kết quả trống !", "Thông báo");
                return;
            }
            imTemp = null;
            index++;
            if (index >= l.Count) index = 0;
            ShowKetQua();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isRun)
            {
                MessageBox.Show("Tiến trình tổng hợp đang xử lý, vui lòng chờ !", "Thông báo");
                return;
            }

            if (l.Count == 0)
            {
                MessageBox.Show("Danh sách kết quả trống !", "Thông báo");
                return;
            }
            if (!Directory.Exists(Util.gI().pathFDOut))
            {
                MessageBox.Show("Thư mục lưu không tồn tại!", "Thông báo");
                return;
            }

            foreach (KetQua k in l)
            {
                string path = Util.gI().pathFDOut + "\\" + Path.GetFileNameWithoutExtension(k.Image1.Name) + " " + Util.gI().nextInt(100, 999) + ".PNG";
                int count = 0;
                while (File.Exists(path))
                {
                    count++;
                    if (count > 1000) path = Util.gI().pathFDOut + "\\" + Path.GetFileNameWithoutExtension(k.Image1.Name)+" "  + Util.gI().nextInt(1000, 9999) + ".PNG";
                    else if (count > 1000) path = Util.gI().pathFDOut + "\\" + Path.GetFileNameWithoutExtension(k.Image1.Name) + " " + Util.gI().nextInt(100, 999) + ".PNG";
                }

                k.Tong.Save(path);
            }

            MessageBox.Show("Lưu hoàn tất !");
        }

        private void ptAnh_Click(object sender, EventArgs e)
        {
            F_ViewImage f = new F_ViewImage(ptAnh.Image);
            f.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (isRun)
            {
                MessageBox.Show("Tiến trình tổng hợp đang xử lý, vui lòng chờ !", "Thông báo");
                return;
            }
            Thread tongHopTH = new Thread(tongHop);
            tongHopTH.Start();
        }


        private void chỉnhMockupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isRun)
            {
                MessageBox.Show("Tiến trình tổng hợp đang xử lý, vui lòng chờ !", "Thông báo");
                return;
            }

            if (!Directory.Exists(Util.gI().pathFDMockup))
            {
                MessageBox.Show("Thư mục mockup không tồn tại!", "Thông báo");
                return;
            }

            F_Mockup f = new F_Mockup();
            f.ShowDialog();
        }
    }
}
