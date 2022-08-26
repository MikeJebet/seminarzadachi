Console.Clear();
Console.WriteLine("Введите число : ");
string? numberAu = Console.ReadLine();
Console.WriteLine();
int numberAe;
int N = 0;
int i = 1;
if(int.TryParse(numberAu, out numberAe))
{
    N = numberAe;
    while(i < N)
    {
        double Nx = Math.Pow(i,3);
        i += 1;
        Console.WriteLine(Nx);
    }    
}
else 
{
    Console.WriteLine("Error");    
}
