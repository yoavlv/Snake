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

        public void  Draw(Graphics g)
        {
            Brush RecColor = Brushes.Chocolate;

            Image BlackHole = Image.FromFile(@"C:\Users\yoavl\source\repos\Snake\Snake\BlackHole.png");
            PointF BlackHolep = new PointF(Rows1 * Settings.Width, Cols * Settings.Height);
            //canvas.DrawImage(Burger, BlackHolep);
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    g.DrawImage(BlackHole, new PointF((X + i) * Settings.Width, (Y + j) * Settings.Height));
                }
            }

        }

    }





}
