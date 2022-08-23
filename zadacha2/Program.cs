Console.WriteLine("Введите число: ");
string? numberAu = Console.ReadLine();
int numberAe;
Console.WriteLine("Введите число: ");
string? numberBu = Console.ReadLine();
int numberBe;
if (int.TryParse(numberAu, out numberAe))
{
    if (int.TryParse(numberBu, out numberBe))
    {
        if (numberAe > numberBe)
        {
            Console.WriteLine("numberAe the biggest one");
        }
        else
        {
            Console.WriteLine("numberBe the biggest one");
        }
        if (numberAe == numberBe)
        {
            Console.WriteLine("numberAe = numberBe");
        }

    }
}
else 
{
    Console.WriteLine("Error");
}