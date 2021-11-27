using Snake;

//Границы
Lines board = new Lines(1, 99, 1, 25, '0');
board.Draw();


//Змейка
Point p = new Point(4, 5, '*');
SnakeBody snake = new SnakeBody(p, 5, Direction.RIGHT);
snake.Draw();


while (true)
{
    if (Console.KeyAvailable)
    {
        snake.HandleKey(Console.ReadKey());
    }
    Thread.Sleep(100);
    snake.Move();
}