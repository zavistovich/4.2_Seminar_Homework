// Задать номер четверти, показать диапазоны для возможных координат
Console.Clear();

int quarter = new Random().Next(1,5);
Console.Write($"For the quarter #{quarter} the coordinates must be: ");

if (quarter == 1)
{
    Console.Write("x > 0, y > 0");
}
else if (quarter == 2)
{
    Console.Write("x < 0, y > 0");
}
else if (quarter == 3)
{
    Console.Write("x < 0, y < 0");
}
else if (quarter == 4)
{
    Console.Write("x > 0, y < 0");
}
