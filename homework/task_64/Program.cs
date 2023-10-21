﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"



Console.Write("Введите значение N: ");
int N = int.Parse(Console.ReadLine());

Console.WriteLine("Вывод натуральных чисел от {0} до 1:", N);
PrintNaturalNumbers(N);


static void PrintNaturalNumbers(int N)
{
    if (N >= 1)
    {
        Console.Write(N);
        if (N > 1)
        {
            Console.Write(", ");
        }
        PrintNaturalNumbers(N - 1);
    }
}

