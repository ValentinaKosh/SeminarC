// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();

int Prompt(string message)
{
    Console.Write(message);
    string ReadInput = Console.ReadLine();
    int rezult = int.Parse(ReadInput);
    return rezult;
}

int[] GenerateArray(int Length, int minValue, int maxValue)
{
    int[] array = new int[Length];
    Random random = new Random();
    for (int i = 0; i < Length; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);
        }
    return array;
}

void PrintArray(int[] array)
{
Console.Write("[");
for (int i = 0; i < array.Length - 1; i++)
{
    Console.Write($"{array[i]}, ");
}
Console.Write($"{array[array.Length -1]}");
Console.Write("]");
}

int length = Prompt("Количество элементов в массиве= ");
int min = Prompt("Минимальное значение для диапазона= ");
int max = Prompt("Максимальное значение для диапазона= ");
int[] array = GenerateArray(length, min, max);
PrintArray(array);