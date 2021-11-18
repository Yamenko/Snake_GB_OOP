namespace Snake
{
    internal class HorizontLine : Figura
    {
        public HorizontLine(byte xLeft, byte xRight, byte y, Char simb)
        {
            pLineList = new List<Point>();
            for(byte x = xLeft; x <= xRight; x++) 
            {
                Point p = new Point(x, y, simb);
                pLineList.Add(p);
            }    
        }
    }
}
