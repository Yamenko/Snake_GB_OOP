using Snake;

//Границы
Lines board = new Lines(1, 99, 1, 25, '0');
board.Draw();


//Змейка
Point p = new Point(4, 5, '*');
SnakeBody snake = new SnakeBody(p, 5, Direction.RIGHT);
snake.Draw();

//Первая еда на карте
FoodCreator FoodCreator = new FoodCreator(99, 25, '$');
Point food = FoodCreator.CreateFood();
food.Draw();


while (true)
{
    if (snake.Eat(food))
    {
        food = FoodCreator.CreateFood();
        food.Draw();
    }
    else 
    {
        snake.Move();
    }

    if (Console.KeyAvailable) {snake.HandleKey(Console.ReadKey());}
    
    Thread.Sleep(100);
}