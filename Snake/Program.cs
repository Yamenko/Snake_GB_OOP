// See https://aka.ms/new-console-template for more information
using Snake;

//Границы
HorizontLine uLine = new HorizontLine(1, 99, 1, '+');
HorizontLine dLine = new HorizontLine(1, 99, 25, '+');
VerticalLine lLine = new VerticalLine(1, 25, 1, '+');
VerticalLine rLine = new VerticalLine(1, 25, 99, '+');
rLine.Draw(); uLine.Draw(); dLine.Draw(); lLine.Draw();

//Змейка
Point p = new Point(4, 5, '*');
SnakeBody snake = new SnakeBody(p, 5, Direction.RIGHT);
snake.Draw();

Console.ReadLine(); 