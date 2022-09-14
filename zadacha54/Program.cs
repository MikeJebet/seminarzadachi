Console.Clear();
Console.Write("Укажите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[ , ] matrix = new int [rows,columns];

Console.WriteLine("Изначальный массив: ");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        matrix[i,j] = new Random().Next(10);
        Console.Write(matrix[i,j] + "\t");
    }
    Console.WriteLine();
}

Console.WriteLine("Упорядоченный массив: ");
for (int i = 0; i < rows; i++)
{
    int[] array = new int[columns];
    for (int j = 0; j < columns; j++)
    {
        array[j] = matrix[i,j];
        Array.Sort(array);
        Array.Reverse(array);
    }
    Console.WriteLine(String.Join("\t", array));
    Console.WriteLine();
}