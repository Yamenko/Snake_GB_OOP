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

        public Point (Point p)
        {
            x = p.x;
            y = p.y;
            simb = p.simb;
        }

        public void Move (byte offset, Direction direction)
        {
            switch (direction)
            {
                case Direction.LEFT: x = (byte)(x - offset); break;
                case Direction.RIGHT: x = (byte)(x + offset); break;
                case Direction.DOWN: y = (byte)(y + offset); ; break;
                case Direction.UP: y = (byte)(y - offset); break;
            }

        }

            public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(simb);
        }
    }
}
