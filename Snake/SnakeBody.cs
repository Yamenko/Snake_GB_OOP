namespace Snake
{
    internal class SnakeBody : Figura
    {
        public SnakeBody(Point tail, byte length, Direction direction)
        {
            pLineList = new List<Point>();
            for (byte i = 0; i <= length; i++ )
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pLineList.Add(p);
            }
        }

    }
}
