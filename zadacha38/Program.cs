Console.Clear();
Console.Write("Количество элементов в массиве: ");
int num = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[num];
double result = 0;
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = Convert.ToDouble(new Random().Next(1,1000)) / 100;
    Console.Write("| " + numbers[i] + " |");
}

result = numbers.Max() - numbers.Min();
Console.WriteLine($"\n Разница между максимальным числом массива и минимальным: {result}");

