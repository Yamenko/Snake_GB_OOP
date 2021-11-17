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
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(simb);
        }
    }
}
