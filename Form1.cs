using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_Asciify {
    // 1/2 kernel sizNOT 3x3 or whatever
    public partial class Form1 : Form {
        OpenFileDialog openFile = new OpenFileDialog {
                Filter = "JPEG files (*.jpeg)|*.jpeg|All files (*.*)|*.*",
                RestoreDirectory = false
            };
        public Form1() {
            InitializeComponent();
             
        }
        #region MENU CLICK EVENTS
        private void FileToolStripMenuItem_Click(object sender, EventArgs e) {
            //open file 
            if (openFile.ShowDialog() == DialogResult.OK) {
                picBox.ImageLocation = openFile.FileName;
                picBox.Load();
            }
            
        }

        private void SaveBitmapToolStripMenuItem_Click(object sender, EventArgs e) {
            //save newly generated text as img file
        }
        #endregion

        #region METHODS
        private void BtnGenerate_Click(object sender, EventArgs e) {
            Bitmap img = new Bitmap(picBox.Image);
            if (numUpDownX.Value > 0 && numUpDownY.Value > 0) {
                BitmapAscii bitmapAscii = new BitmapAscii((int)numUpDownX.Value, (int)numUpDownY.Value);
                textBox1.Text = bitmapAscii.Asciify(img);
            }
        }

        #endregion

        private void NumUpDownX_ValueChanged(object sender, EventArgs e) {

        }

        private void NumUpDownY_ValueChanged(object sender, EventArgs e) {

        }
    }
}
