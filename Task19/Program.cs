// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.WriteLine("Введите пятизначное число= ");
int num = int.Parse(Console.ReadLine()!);

int a1 = num % 10;
int a2 = num / 10 % 10;
int a3 = num / 100 % 10;
int a4 = num / 1000 % 10;
int a5 = num / 10000 % 10;
int y = a1 * 10000 + a2 * 1000 + a3 * 100 + a4 * 10 + a5;

if (num == y)
{
    Console.WriteLine($"{num} -> yes");
}
else
{
    Console.WriteLine($"{num} -> no");
    // Console.WriteLine($"{y}");
}