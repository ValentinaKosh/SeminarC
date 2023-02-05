// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int index = 1;
int k = 1;
Console.Write($"{num} ->");
while (index <= num)
{
   k = index * index * index;
   Console.Write($" {k}");
   if (index != num)
   {
       Console.Write($", ");
   }
   index++;
}