// Определить количество цифр в числе
Console.Clear();

Console.Write("Enter the number: ");
int n = int.Parse(Console.ReadLine() ?? "");


int result = n;
int count = 0;

while (result > 0)
{
    result = result / 10;
    count++;
}

Console.WriteLine($"Number of digits in number {n} is {count}");
