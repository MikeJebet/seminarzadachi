Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
string? numberAu = Console.ReadLine();
int numberAe = 0;
if (int.TryParse(numberAu, out numberAe))
{
int oldnum = numberAe;
int newnum = 0;
    while (numberAe > 0)
    {
        int dig = numberAe % 10;
        newnum = newnum * 10 + dig;
        numberAe = numberAe / 10;
    }
    if (newnum == oldnum)
    {
        Console.WriteLine("Число является палиндромом");
    }
    else
    {
        Console.WriteLine("Число не является палиндромом");
    }
}
else 
{
    Console.WriteLine("Error");
}
