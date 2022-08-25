Console.WriteLine("Введите цифру дня недели от 1 до 7: ");
string? numberAu = Console.ReadLine();
int numberAe;
if(int.TryParse(numberAu, out numberAe))
{
    if(numberAe == 6)
    {
        Console.WriteLine("Сегодня выходной!!!");
    }
    else if(numberAe == 7)
    {
        Console.WriteLine("Сегодня выходной!!!");
    }
    else if(numberAe > 7)
    {
        Console.WriteLine("Error");
    }
    else if(numberAe < 1)
    {
        Console.WriteLine("Error");
    }
    else
    {
        Console.WriteLine("Рабочий день");
    }
}
else 
    {
    Console.WriteLine("Error");
    }