// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
int n;
Console.Write("Введите Номер дня недели от 1 до 7: ");
n = int.Parse(Console.ReadLine()!);

while (n < 1 || n > 7)
{
    Console.WriteLine($"Введите число от 1 до 7");
    n = int.Parse(Console.ReadLine()!);
}
if (n == 6 || n == 7)
{
    Console.WriteLine($"{n} -> Да");
}
else
{
    Console.WriteLine($"{n} -> Нет");
}