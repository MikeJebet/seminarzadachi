Console.Clear();
Console.Write("Укажите размер массива: ");
 int Count = Convert.ToInt32(Console.ReadLine());
 int SumIndex = 0;
 int[] arr = new int[Count];
 Random rnd = new Random();
 for(int i =0;i<arr.Length;i++)
{
    arr[i] = rnd.Next(100,999);
    if (arr[i] % 2 == 0)
    {
        Console.WriteLine(arr[i]);
        SumIndex += 1;
    } 
}
Console.WriteLine($"Количество чётных чисел в массиве: {SumIndex}");