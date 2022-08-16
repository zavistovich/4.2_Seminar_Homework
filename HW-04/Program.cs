// Найти расстояние между точками в пространстве 2D/3D
void Coordinates(int[] array)
{
    Console.Write($"({array[0]}, ");
    for (int i = 1; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine($"{array[array.Length - 1]})");
}

double Distance(int[] dis1, int[] dis2)
{
    int sum = 0;
    for (int i = 0; i < dis1.Length; i++)
    {
        sum = sum + (dis1[i] - dis2[i]) * (dis1[i] - dis2[i]);
    }
    double result = Math.Sqrt(sum);
    return result;
}


Console.Clear();

int planes = 3;
int min = -5, max = 5;

int[] points(int numPlan)                  
{
    int[] coords = new int[numPlan];
    for (int i = 0; i < numPlan; i++)
    {
        coords[i] = new Random().Next(min, max);
    }
    return coords;
}


int[] a = points(planes);
int[] b = points(planes);

Console.Write($"Coordinates for a: ");
Coordinates(a);
Console.Write($"Coordinates for b: ");
Coordinates(b);

Console.WriteLine($"The distance between points a and b: {Distance(a, b)}");
Console.WriteLine();