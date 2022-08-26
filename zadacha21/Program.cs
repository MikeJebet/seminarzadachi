Console.Clear();
Console.WriteLine("Введи координаты точки X через пробел");
int[] X = Console.ReadLine().Split().Select(int.Parse).ToArray();
Console.WriteLine("Введи координаты точки Y через пробел");
int[] Y = Console.ReadLine().Split().Select(int.Parse).ToArray();
double dist = Math.Sqrt(Math.Pow(Y[0] - X[0], 2) + Math.Pow(Y[1] - X[1], 2) + Math.Pow(Y[2] - X[2], 2));
Console.WriteLine(Math.Round(dist, 2));
