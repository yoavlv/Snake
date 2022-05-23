using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Snake
{
    class Circle : Point
    {
        private float Radius;

        public Circle(int x = 2, int y = 2, int radius = 0)
        {
            X = x;
            Y = y;
            Radius1 = radius;
        }

        public float Radius1 { get => Radius; set => Radius = value; }

        public void DrawCircle(Graphics g)
        {
            //SolidBrush br = new SolidBrush(Color.BlueViolet);
            //Brush br = Brushes.BlueViolet;

            //g.FillEllipse(br, X * Settings.Width , Y * Settings.Height, Settings.Width * Radius, Settings.Height * Radius);
            Image Bon = Image.FromFile(@"C:\Users\yoavl\source\repos\Snake\Snake\bon.png");
            PointF pp = new PointF(X * Settings.Width,
            Y * Settings.Height);
            g.DrawImage(Bon, pp);
        }
    }
}
