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
            Rows1 = row;
            Cols1 = col;
        }

        public int Rows1 { get => Rows; set => Rows = value; }
        public int Cols1 { get => Cols; set => Cols = value; }

        public void  Draw(Graphics g)
        {
            Brush RecColor = Brushes.AliceBlue;

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    g.FillEllipse(RecColor, new Rectangle(
                    X + i * Settings.Width,
                    Y + j * Settings.Height,
                    Settings.Width, Settings.Height));
                }
            }

        }

    }





}
