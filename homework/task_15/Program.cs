//  Задача 15: Напишите программу, 
// которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
//  7 -> да
//  1 -> нет


int Prompt(string msg)
{

System.Console.WriteLine($"{msg}");
return Convert.ToInt32(Console.ReadLine());
}
int number = Prompt("Введите число");
string day = "Это не день недели";
string check(int number)
{
if (number >= 6 && number < 8) day = "Это выходной";
if (number >= 1 && number < 7) day = "Это будний день";
return day;
}
System.Console.WriteLine(check(number));