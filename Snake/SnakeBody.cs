namespace Snake
{
    internal class SnakeBody : Figura
    {
        static Direction direction;
        public SnakeBody(Point tail, byte length, Direction _direction)
        {
            direction = _direction;
            pLineList = new List<Point>();
            for (byte i = 0; i <= length; i++ )
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pLineList.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = pLineList.First();
            Point head = GetNextPoint();
            pLineList.Remove(tail);
            pLineList.Add(head);

            tail.Clear();
            head.Draw();
        }

        public Point GetNextPoint()
        {
            Point head = pLineList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }

        public void HandleKey(ConsoleKeyInfo key)
        {
            switch (key.Key)
            {
                case ConsoleKey.UpArrow: direction = Direction.UP; break;
                case ConsoleKey.DownArrow: direction = Direction.DOWN ; break;
                case ConsoleKey.LeftArrow: direction = Direction.LEFT ; break;
                case ConsoleKey.RightArrow: direction = Direction.RIGHT ; break;
            }
        }
    }
}
