Console.Clear();
Console.Write("Укажите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

 int[ , ] matrix = new int [rows,columns];

 for (int i = 0; i < rows; i++)
 {
     for (int j = 0; j < columns; j++)
     {
         matrix[i,j] = new Random().Next(10);
         Console.Write("\t" + matrix[i,j]);
     }
     Console.WriteLine();
 }

 int[] SumOfRow = new int[columns];

 for (int i = 0; i < rows; i++)
 {
     int sum = 0;
     int j;
     for (j = 0; j < columns; j++)
     {
         sum += matrix[i,j];
     }
     SumOfRow[i] = sum;
 }
 int minSumOfRow = Array.IndexOf(SumOfRow,SumOfRow.Min());

 Console.WriteLine($"Строка номер {minSumOfRow + 1}, строка с минимальным значением суммы элементов!");
