using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PROJECT_Asciify {
    class BitmapAscii {
        private readonly string[] asciiValues = { "@","#","$","%","+","*",":","."," " };

        #region METHODS
        private string Asciify(Bitmap img) {
            //main function
            for (int y = 0; y < img.Height; y++) {
                for (int x = 0; x < img.Width; x++) {
                    img.GetPixel(x,y);
                }
            }            
        }
        #region PRIVATE
        private double AvgPixel(int r, int g, int b) {
            // R * 0.21     G * 0.72       B * 0.07
            double avg = (r*0.21)+(g*0.72)+(b*0.07);
            return Normalize(avg);
        }
        private double AvgPixel(Color col) {
            // R * 0.21     G * 0.72       B * 0.07
            double avg = (col.R*0.21)+(col.G*0.72)+(col.B*0.07);
            return Normalize(avg);
        }
        private double AvgColor(List<Color> colList) {
            double[] arr = new double[colList.Count];
            double   avg = 0.0;
            for (int i = 0; i < arr.Length; i++) {
                avg += Normalize(AvgPixel(colList[i]));                
            }
            return avg/colList.Count;
        }
        private string GrayToString(double num) {
            //
            int val = (int)Math.Round(num*10);

            if (val >= asciiValues.Length) {
                val = asciiValues.Length-1;
            }else if (val <= 0) {
                val = 0;
            }
            return asciiValues[val];
        }
        private double Normalize(double num) {
            //z sub i = x sub i - min(x)/max(x)-min(x)
            //but then why not just divide by 255?
            return num/255;
        }
        #endregion
        #endregion
    }
}
