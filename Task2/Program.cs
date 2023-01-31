// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Clear();

int a;
int b;

Console.Write("Введите число а: ");
a = int.Parse(Console.ReadLine()!);
Console.Write("Введите число b: ");
b = int.Parse(Console.ReadLine()!);

if (a > b)
{
    Console.Write($"Max = ");
    Console.Write(a);
}
else
{
    Console.Write($"Max = ");
    Console.Write(b);
}