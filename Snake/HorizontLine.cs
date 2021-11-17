using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class HorizontLine
    {
        List<Point> pLineList;
        public HorizontLine(byte xLeft, byte xRight, byte y, Char simb)
        {
            pLineList = new List<Point>();
            for(byte x = xLeft; x <= xRight; x++) 
            {
                Point p = new Point(x, y, simb);
                pLineList.Add(p);
            }    
        }
        public void Draw()
        {
            foreach (Point p in pLineList)
            {
                p.Draw();
            }
        }
    }
}
