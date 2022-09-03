// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
Console.Clear();
Console.Write("Введите 8 чисел через пробел: ");
int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
for (int i = 0; i < numbers.Length; i++)
 {
     Console.Write("| " + numbers[i] + " |");
 }
