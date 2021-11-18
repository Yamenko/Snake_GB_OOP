using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Figura
    {
        protected List<Point> pLineList;
        public void Draw()
        {
            foreach (Point p in pLineList)
            {
                p.Draw();
            }
        }
    }  
}