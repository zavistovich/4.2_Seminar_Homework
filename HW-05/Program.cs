// Найти кубы чисел от 1 до N
Console.Clear();

Console.Write("Enter number N: ");
int n = int.Parse(Console.ReadLine() ?? "");


int[] CountCubes(int n)
{
    int[] cubes = new int[n];
    int number = 1;
    for (int i = 0; i < n; i++)
    {
        cubes[i] = number * number * number;
        number++;
    }
    return cubes;
}

void PrintCubes(int[] array)
{
    int number = 1;
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{number} ^ 3 = ");
        Console.WriteLine(array[i]);
        number++;
    }
}

int[] cubesAll = CountCubes(n);
PrintCubes(cubesAll);