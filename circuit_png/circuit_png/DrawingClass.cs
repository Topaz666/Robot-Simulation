using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using static System.Console;

namespace circuit_png
{
    class DrawingClass
    {
        static void DrawingElement() { 
            using (var src = new Bitmap("c:/Users/yuhon/source/repos/circuit_png/circuit_png/74906.png"))
            using (var bmp = new Bitmap(200, 200, PixelFormat.Format32bppPArgb))
            using (var gr = Graphics.FromImage(bmp))
            {
                gr.Clear(Color.Blue);
                //gr.DrawImage(src, new Rectangle(0, 0, bmp.Width, bmp.Height));
                bmp.Save("result2.png", ImageFormat.Png);
            }
        }
    }
}
