using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using static System.Console;

namespace circuit_png
{
  class Program
  {
    static void Main(string[] args)
    {
      Bitmap bm = (Bitmap) System.Drawing.Image.FromFile("74906.png",true);
      Bitmap tmp=new Bitmap (bm.Width ,bm.Height );
      Graphics grPhoto = Graphics.FromImage(tmp);
      grPhoto.DrawImage(bm, new Rectangle(0, 0, tmp.Width , tmp.Height ), 0, 0, tmp.Width , tmp.Height , GraphicsUnit.Pixel);
    }
  }
}
