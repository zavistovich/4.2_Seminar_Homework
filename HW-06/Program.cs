// Найти сумму чисел от 1 до А
int CountSum(int a)
{
    int number = 1;
    int sum = 0;
    for (int i = 0; i < a; i++)
    {
        sum = sum + number;
        number++;
    }
    return sum;
}

Console.Clear();

Console.Write("Enter number: ");
int a = int.Parse(Console.ReadLine() ?? "");

int sum = CountSum(a);
Console.WriteLine($"The sum of numbers from 1 to {a} is {sum}");
