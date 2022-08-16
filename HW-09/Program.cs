// Написать программу вычисления произведения чисел от 1 до N
int Comp(int a)
{
    int comp = 1;
    for (int num = 1; num <= a; num++)
    {
        comp = comp * num;
    }
    return comp;
}

Console.Clear();

Console.Write("Enter the number: ");
int n = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine($"The product of numbers from 1 to {n} is {Comp(n)}");
