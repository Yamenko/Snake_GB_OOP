// See https://aka.ms/new-console-template for more information
static void Draw(byte x, byte y, char simb) 
{
    Console.SetCursorPosition(x, y);
    Console.Write(simb);
}

byte x1 = 1;
byte y1 = 3;
char simb1 = '*';
Draw(x1, y1, simb1);

byte x2 = 4;
byte y2 = 5;
char simb2 = '#';
Draw(x2, y2, simb2);



Console.ReadLine();