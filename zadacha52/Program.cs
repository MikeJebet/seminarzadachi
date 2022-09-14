Console.Clear();
Console.Write("Введите m(строки): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n(столбцы): ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[m, n];

Console.WriteLine();

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        numbers[i, j] = new Random().Next(101);
        Console.Write("|" + numbers[i, j] + "|" + "\t");
    }
    Console.WriteLine();
}

Console.WriteLine();

for (int i = 0; i < n; i++)
{
    int sum = 0;
    for (int j = 0; j < m; j++)
    {
        sum += numbers[j, i];
    }
    double avg = (double) sum / m;
    Console.WriteLine($"Среднее арифметическое всех элементов столбца {i} равняется {avg}");
}