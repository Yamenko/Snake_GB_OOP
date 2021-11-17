using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class VerticalLine
    {
        List<Point> vLineList;
        public VerticalLine(byte yUp, byte yDown, byte x, char simb)
        {
            vLineList = new List<Point>();
            for(byte y = yUp; y <= yDown; y++) 
            {
                Point v = new Point(x, y, simb);
                vLineList.Add(v);
            }    
        }
        public void Draw()
        {
            foreach (Point v in vLineList)
            {
                v.Draw();
            }
        }
    }
}
