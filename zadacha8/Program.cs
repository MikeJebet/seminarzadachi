Console.WriteLine("Введите число: ");
string? numberAu = Console.ReadLine();
int numberAe;
int i = 1;
int N = 0;
if(int.TryParse(numberAu, out numberAe))
{
Console.WriteLine("Четные числа: ");
    N = numberAe;
    while(i < N)
    {
        if(i % 2 == 0)
        {
            Console.WriteLine(i);
        }
        i += 1;

    }
}
else 
{
Console.WriteLine("Error");    
}