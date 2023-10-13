// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1 y = k2 * x + b2 значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("введите значение b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k2");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2;

Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");


// Напишите программу, которая найдёт точку пересечения двух прямых
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем

// double pointX;
// double pointY;

// Console.Write("Даны прямые заданные формулами y = k1 * x + b1, y = k2 * x + b2");
// Console.Write("Введите по очереди b1, k1, b2 и k2 одной строкой через пробел: ");
// int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
// int a = arr [1];
// int b = arr [3];
// int c = arr [0];
// int d = arr [2];

// if (a == b)
// {
//     Console.WriteLine("Прямые с такими параметрами паралельны");
// }
// else
// {
//     pointX = (double) (d-c)/(a-b);
//     pointY = (double) a*(d-c)/(a-b) + c;
//     Console.WriteLine("Координаты точки пересечения двух прямых:");
//     Console.WriteLine($"Х: {pointX:0.00}");
//     Console.WriteLine($"Y: {pointY:0.00}");
// }
