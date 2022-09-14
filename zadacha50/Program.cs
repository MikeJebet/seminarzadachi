Console.Clear();
Console.Write("Введите m(строки): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n(столбцы): ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] realArray = new double[m, n];

Console.WriteLine();

for (int k = 1; k < n + 1; k++)
{
    Console.Write(k + "\t");
}

Console.WriteLine();

for (int k = 1; k < n + 1; k++)
{
    Console.Write("————————");
}

Console.WriteLine();

for (int i = 0, k = 1; i < m; i++, k++)
{
    for (int j = 0; j < n; j++)
    {
        realArray[i, j] = (new Random().NextDouble() * 15);
        Console.Write(Math.Round(realArray[i, j], 2) + "\t");
    }
    Console.Write("|" + k);
    Console.WriteLine();
}
Console.WriteLine();

Console.WriteLine("Введите строку и столбец, чтобы узнать значение.");
Console.Write("Введите m:");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n:");
int column = Convert.ToInt32(Console.ReadLine());

if (row <= m && column <= n)
{
    Console.WriteLine($"Значение элемента: ({row};{column}) : {realArray[row-1, column-1]} ");
}
else
{
    Console.WriteLine($"Такого элемента в массиве нет");
}
