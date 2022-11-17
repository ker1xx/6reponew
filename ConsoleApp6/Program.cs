Console.SetCursorPosition(0, 1);
ConsoleKeyInfo klavisha = Console.ReadKey();
int position = 1;
while (klavisha.Key != ConsoleKey.Enter)
{

    if (klavisha.Key == ConsoleKey.UpArrow)
    {
        position--;
        if (position <= 0)
            position = 0;
    }
    else if (klavisha.Key == ConsoleKey.DownArrow)
        position++;
    Console.Clear();
    Console.WriteLine("  Какой цвет вы любите?");
    Console.WriteLine("  1. Желтый ");
    Console.WriteLine("  2. Красный ");
    Console.WriteLine("  3. Синий");
    Console.WriteLine("  4. Зеленый ");
    Console.SetCursorPosition(0, position);
    Console.WriteLine("->");
    klavisha = Console.ReadKey();
}
switch (position)
{
    case 1:
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Clear();
        Console.WriteLine("Jeltu)");
        break;
    case 2:
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Clear();
        Console.WriteLine("Krasni)");
        break;
    case 3:
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Clear();
        Console.WriteLine("Sini)");
        break;
    case 4:
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Clear();
        Console.WriteLine("Zeleni)");
        break;
}