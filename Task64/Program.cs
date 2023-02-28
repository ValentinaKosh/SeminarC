// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();
Console.Write("Введите натуральное число, N = ");
int n = int.Parse(Console.ReadLine()!);

int m = 1;

Console.Write($"N = {n} -> ");
Console.WriteLine(Number(n, m));

int Number(int n, int m)
{
    if (n == m)
        return n;
    else
        Console.Write($"{Number(n, m + 1)}, ");
    return m;
}

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}