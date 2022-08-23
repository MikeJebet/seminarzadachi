Console.WriteLine("Введите число: ");
string? numberAu = Console.ReadLine();
int numberAe;
if(int.TryParse(numberAu, out numberAe))
{
    if(numberAe % 2 == 0)
    {
        Console.WriteLine("Число четное");
    }
    else
    {
        Console.WriteLine("Число нечетное");
    }
}
else 
{
Console.WriteLine("Error");    
}
