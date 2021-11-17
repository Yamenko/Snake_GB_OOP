using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Point
    {
        public Byte x;
        public Byte y;
        public Char simb;
        public Point (Byte _x, Byte _y, Char _simb)
        {
            x = _x;
            y = _y;
            simb = _simb;
        }
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(simb);
        }
    }
}
