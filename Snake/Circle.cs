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

        public Circle(int x = 2, int y = 2, int radius = 1)
        {
            X = x;
            Y = y;
            Radius1 = radius;
        }

        public float Radius1 { get => Radius; set => Radius = value; }

        public override void Draw(Graphics g)
        {
            Image Burger = Image.FromFile(@"C:\Users\yoavl\source\repos\Snake\Snake\img\Burger.png");
            PointF BugerP = new PointF(X * Settings.Width,
            Y * Settings.Height);
            g.DrawImage(Burger, BugerP);
        }
    }
}
