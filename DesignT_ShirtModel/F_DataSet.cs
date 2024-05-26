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
    public partial class F_DataSet : Form
    {
        public F_DataSet()
        {
            InitializeComponent();
            showData();
        }

        void showData()
        {
            tbMK.Text = Util.gI().pathFDMockup;
            tbFD1.Text = Util.gI().pathFD1;
            tbFD2.Text = Util.gI().pathFD2;
            tbFD3.Text = Util.gI().pathFD3;
            tbFD4.Text = Util.gI().pathFD4;
            tbOut.Text = Util.gI().pathFDOut;
            numericUpDown2.Value = Util.gI().canLe2;
            numericUpDown3.Value = Util.gI().canLe3;
            numericUpDown4.Value = Util.gI().canLe4;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            showData();
        }

        private void btChon_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Chọn folder 1";
            folderBrowserDialog.ShowNewFolderButton = true;
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                tbFD1.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btVoHieu_MoKhoa_Click(object sender, EventArgs e)
        {
            Util.gI().pathFDMockup = tbMK.Text;
            Util.gI().pathFD1 = tbFD1.Text;
            Util.gI().pathFD2 = tbFD2.Text;
            Util.gI().pathFD3 = tbFD3.Text;
            Util.gI().pathFD4 = tbFD4.Text;
            Util.gI().pathFDOut = tbOut.Text;
            
            Util.gI().canLe2 = (int)numericUpDown2.Value;
            Util.gI().canLe3 = (int)numericUpDown3.Value;
            Util.gI().canLe4 = (int)numericUpDown4.Value; 
            Util.gI().saveData();
            MessageBox.Show("Lưu thành công","Thông báo");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Chọn folder Mockup";
            folderBrowserDialog.ShowNewFolderButton = true;
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                tbMK.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btChon2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Chọn folder 2";
            folderBrowserDialog.ShowNewFolderButton = true;
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                tbFD2.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btChon3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Chọn folder 3";
            folderBrowserDialog.ShowNewFolderButton = true;
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                tbFD3.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btChon4_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Chọn folder 4";
            folderBrowserDialog.ShowNewFolderButton = true;
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                tbFD4.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Chọn nơi lưu kết quả";
            folderBrowserDialog.ShowNewFolderButton = true;
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                tbOut.Text = folderBrowserDialog.SelectedPath;
            }
        }
    }
}
