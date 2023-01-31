// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Clear();
int a;
int b;
int c;

Console.Write("Введите число a: ");
a = int.Parse(Console.ReadLine()!);
Console.Write("Введите число b: ");
b = int.Parse(Console.ReadLine()!);
Console.Write("Введите число c: ");
c = int.Parse(Console.ReadLine()!);
int max = a;

if (b > max) max = b;
if (c > max) max = c;

Console.Write($"Max = ");
Console.Write(max);