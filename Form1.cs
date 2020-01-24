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
            //save newly generated image as a jpeg
        }
        #endregion
        #region METHODS
        private void Asciify() {
            //main function
        }
        #endregion
    }
}
