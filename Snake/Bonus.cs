using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Snake
{
    class Bonus : Circle
    {
        public Bonus (int x = 500, int y = 500, int radius = 1)
        {
            X = x;
            Y = y;
            Radius1 = radius;
        }
        public override void Draw(Graphics g)
        {
     
            Image Bon = Image.FromFile(@"C:\Users\yoavl\source\repos\Snake\Snake\bon.png");
            PointF pp = new PointF(X * Settings.Width,
            Y * Settings.Height);
            g.DrawImage(Bon, pp);
        }
    }
}
