namespace Snake
{
    internal class Lines : Figura
    {
        public Lines(byte xStart, byte xStop, byte yStart, byte yStop, Char simb)
        {
            pLineList = new List<Point>();
            Point p = new Point(xStart, yStart, simb);
            for (byte i = xStart; i <= xStop; i++)
            {
                p = new Point(i, yStart, simb);
                pLineList.Add(p);
                p = new Point(i, yStop, simb);
                pLineList.Add(p);
            }
            for (byte i = yStart; i <= yStop; i++)
            {
                p = new Point(xStart, i, simb);
                pLineList.Add(p);
                p = new Point(xStop, i, simb);
                pLineList.Add(p);
            }
        }

    }
}
