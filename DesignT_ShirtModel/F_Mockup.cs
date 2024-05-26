using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignT_ShirtModel
{
    public partial class F_Mockup : Form
    {

        public F_Mockup()
        {
            InitializeComponent();
            ShowData();
        }

        void ShowData()
        {
            int stt = 0;
            dgv.Rows.Clear();
            foreach (MokupInfo m in Util.gI().lMockupInfo)
            {
                stt++;
                dgv.Rows.Add(stt, m.Name, m.Opacity, m.Turn,m.ThongSo1.getStr());
            }
        }
        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    textBox1.Text = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                    if (!File.Exists(textBox1.Text)) return;
                    MokupInfo m = Util.gI().GetMokupInfoByName(textBox1.Text);
                    if(m==null) return;
                    nudOP.Value = m.Opacity;
                    nudT.Value = m.Turn;
                    ptAnh.Image=Image.FromFile(textBox1.Text);
                }
                catch(Exception ex) { }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!File.Exists(textBox1.Text))
            {
                MessageBox.Show("Hãy chọn mockup trước !","Thông báo");
                return;
            }

            MokupInfo m = Util.gI().GetMokupInfoByName(textBox1.Text);

            if (m==null)
            {
                MessageBox.Show("Hãy chọn mockup trước !", "Thông báo");
                return;
            }

            m = new MokupInfo(textBox1.Text,m.ThongSo1, (int)nudOP.Value, (int)nudT.Value);

            Util.gI().updateMockupInfo(m);
            ShowData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!File.Exists(textBox1.Text))
            {
                MessageBox.Show("Hãy chọn mockup trước !", "Thông báo");
                return;
            }

            MokupInfo m = Util.gI().GetMokupInfoByName(textBox1.Text);

            if (m == null)
            {
                MessageBox.Show("Hãy chọn mockup trước !", "Thông báo");
                return;
            }

            F_LayKhung f = new F_LayKhung(Image.FromFile(m.Name),m.ThongSo1);
            f.ShowDialog();
            if (f.k)
            {
                m.ThongSo1=f.ThongSo1;
                Util.gI().updateMockupInfo(m);
                ShowData();
            }

        }
    }
}
