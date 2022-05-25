using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Snake
{
    class SRectangle : Point
    {
        private int Rows ;
        private int Cols ;



        public SRectangle(int x=0, int y=0, int row=0, int col=0)
        {
            X = x;
            Y = y;
            Rows = row;
            Cols = col;
        }

        public int Rows1 { get => Rows; set => Rows = value; }
        public int Cols1 { get => Cols; set => Cols = value; }

        public override void Draw(Graphics g)
        {
            Image BlackHole = Image.FromFile(@"C:\Users\yoavl\source\repos\Snake\Snake\BlackHole2.png");
            if (Rows > 0 && Cols > 0)
            {
                Bitmap BlachHoleB = new Bitmap(BlackHole, new Size(16 * Rows, 16 * Cols));
                g.DrawImage(BlachHoleB, new PointF(X * Settings.Width, Y * Settings.Height));

            }

        }

    }





}
