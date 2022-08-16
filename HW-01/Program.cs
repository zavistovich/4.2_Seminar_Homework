// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.Clear();

int number = new Random().Next(1, 8);
string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
string result = "";

if (number > 5) 
{
    result = $". It's a day off";
}
else 
{
    result = $", it's a working day";
}

Console.WriteLine($"{number} day of the week is {days[number - 1]}{result}");
