// See https://aka.ms/new-console-template for more information
using Snake;
Console.SetBufferSize(150, 100);

Point p1 = new Point(5, 3, '*');
p1.Draw();

Point p2 = new Point(4, 5, '#');
p2.Draw();

HorizontLine uLine = new HorizontLine(1, 99, 1, '+');
uLine.Draw();
HorizontLine dLine = new HorizontLine(1, 99, 25, '+');
dLine.Draw();

VerticalLine lLine = new VerticalLine(1, 25, 1, '+');
lLine.Draw();
VerticalLine rLine = new VerticalLine(1, 25, 99, '+');
rLine.Draw();

Console.ReadLine(); 