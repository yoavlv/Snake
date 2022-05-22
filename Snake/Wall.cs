using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Wall : Point
    {
        private int Lenght;

        public Wall(int x = 0, int y = 0, int lenght = 0)
        {
            X = x;
            Y = y;
            Lenght1 = lenght;
        }

        public int Lenght1 { get => Lenght; set => Lenght = value; }
    }
}
