//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.Clear();

Console.Write("Введите число   : ");
int numberA = int.Parse(Console.ReadLine());

Console.Write("Введите степень : ");
int numberB = int.Parse(Console.ReadLine());

int num_AB=1;
  for(int i=0; i<numberB; i++) 
  {
   num_AB*=numberA;
  }
  Console.WriteLine("{0} ^ {1} = {2}", numberA, numberB, num_AB);

