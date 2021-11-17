// See https://aka.ms/new-console-template for more information

Snake.Point p1 = new Snake.Point(1, 3, '*');
p1.Draw();

Snake.Point p2 = new Snake.Point(4, 5, '#');
p2.Draw();

Snake.HorizontLine hline = new Snake.HorizontLine(5, 10, 8, '+');
hline.Draw();

Snake.VerticalLine vline = new Snake.VerticalLine(5, 10, 8, '0');
vline.Draw();

Console.ReadLine(); 