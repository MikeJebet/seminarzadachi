// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Clear();
int SumNumbers(int number)
{
    int sum = 0;
    while(number > 0)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}

Console.Write("Введите число : ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма цифр в числе {numberA} -> {SumNumbers(numberA)}");


