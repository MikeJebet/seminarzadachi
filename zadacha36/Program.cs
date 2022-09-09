/* Задайте одномерный массив, заполненный случайными числами. 
 Найдите сумму элементов, стоящих на нечётных позициях. */

Console.Clear();
Console.Write("Укажите размер массива: ");
int Count = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[Count];
Random rnd = new Random();

for (int i = 0; i < arr.Length; i++)

    arr[i] = rnd.Next(-100, 100);

int sumValue = 0;

for (int i = 1; i < arr.Length; i++)

    if (i % 2 != 0)
    {
        sumValue += arr[i];
        Console.WriteLine($"Нечетный элемент: {arr[i]}");
    
    }

Console.WriteLine($"[{String.Join("; ", arr)}]");
Console.WriteLine($"Сумма элементов на нечётных позициях = {sumValue}");
