// Подсчитать сумму цифр в числе
Console.Clear();

int number = new Random().Next(1, 100);
int sum = 0;
Console.Write($"The sum of the digits of the number {number} is ");

while (number > 0)
{
    int digit = number % 10;
    sum = sum + digit;
    number = number / 10;
}

Console.WriteLine(sum);