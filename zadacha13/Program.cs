Console.WriteLine("Введите число: ");
string? numberA = Console.ReadLine();
if(numberA.Length > 2)
    {
    Console.WriteLine(numberA[2]);
    }
else 
    {
    Console.WriteLine("Третьей цифры нет");
    }