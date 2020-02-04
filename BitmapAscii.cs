using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PROJECT_Asciify {
    //sick brain.... think i made issue with the moving of the kernel.. 

    class BitmapAscii {
        private readonly string[] asciiValues = { "@","#","$","%","+","*","/",":","."," " };
        private readonly int kerX;
        private readonly int kerY;
        private int imgX = 0;
        private int imgY = 0;

        public BitmapAscii(int x, int y) {
            kerX = x;
            kerY = y;
        }
        #region METHODS
        public string Asciify(Bitmap img) {
            //main function
            string stringImg = "";
            double num;

            //advance by kernel amount
            for (imgY = 0; imgY < img.Height; imgY+=kerY) {
                for (imgX = 0; imgX < img.Width; imgX+=kerX) {
                    //normalized avg of the kernel
                    num = Kernel(img);
                    //add char we get from num to string
                    stringImg += GrayToString(num);
                }
                stringImg += '\n';
            }        
            return stringImg;
        }
        #region PRIVATE
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
        //public string Test(Bitmap img) {
        //    string result = "";


        //    return result;
        //}
        private double Kernel(Bitmap img) {
            double num   = 0.0;
            double count = 0.0;

            //out of range checks
            if(imgY+kerY >= img.Height) {
                return 1;
            }
            if (imgX+kerX >= img.Width) {
                return 1;
            }
            //set x/y to last used x/y of the img
            for (int y = imgY; y < kerY+imgY; y++) {
                for (int x = imgX; x < kerX+imgX; x++) {
                    //avg the color and normalize that value (0-1)
                    num += AvgPixel(img.GetPixel(x,y));
                    count++;
                }
            }
            //return the overall avg
            return num/count;
        }
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
        private double Normalize(double num) {
            //z sub i = x sub i - min(x)/max(x)-min(x)
            //but then why not just divide by 255?
            return num/255;
        }
        #endregion
        #endregion
    }
}
