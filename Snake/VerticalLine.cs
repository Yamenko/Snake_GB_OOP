using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class VerticalLine : Figura
    {
        public VerticalLine(byte yUp, byte yDown, byte x, char simb)
        {
            pLineList = new List<Point>();
            for(byte y = yUp; y <= yDown; y++) 
            {
                Point v = new Point(x, y, simb);
                pLineList.Add(v);
            }    
        }
    }
}
