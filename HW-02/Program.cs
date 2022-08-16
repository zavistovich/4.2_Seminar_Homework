// По двум заданным числам проверять является ли одно квадратом другого

Console.Clear();

int[] num = new int[2];
string Result = "is not";

for (int i = 0; i < 2; i++)
{
    num[i] = new Random().Next(1, 5);
}

if (num[0] / num[1] == num[1]) Result = Result.Replace("not", "");

System.Console.WriteLine($"The number {num[0]} {Result} square of {num[1]}");
