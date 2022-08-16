// Показать кубы чисел, заканчивающихся на чётную цифру
Console.Clear();

int a = new Random().Next(1, 10);
int number = 1;


while (number <= a)
{
    int cube = number * number * number;
    
    if (cube % 2 == 0) Console.Write(cube + " ");
    number++;
}
