using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Point
    {
        
        public byte x;
        public byte y;
        public char simb;
        public Point (byte _x, byte _y, char _simb)
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
