Console.WriteLine("Введите число: ");
string? numberAu = Console.ReadLine();
int numberAe;
Console.WriteLine("Введите число: ");
string? numberBu = Console.ReadLine();
int numberBe;
Console.WriteLine("Введите число: ");
string? numberCu = Console.ReadLine();
int numberCe;
int max = 0;
if(int.TryParse(numberAu, out numberAe))
{
    if(int.TryParse(numberBu, out numberBe))
    {
        if(int.TryParse(numberCu, out numberCe))
        {
           max = numberAe;
           if(numberBe > max)
           {
            max = numberBe;
            if(numberCe > max)
            {
             max = numberCe;
             Console.WriteLine("numberCe = max");
            }
            else
            {
                Console.WriteLine("numberBe = max");
            }
        }
        else
        {
            Console.WriteLine("numberAe = max");
        }
        }
        else 
        {
        Console.WriteLine("Error");
        }
    }
    else 
    {
    Console.WriteLine("Error");
    }
}
else 
{
Console.WriteLine("Error");
}