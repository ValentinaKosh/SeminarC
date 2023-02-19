// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();

Console.WriteLine("Введите количество элементов массива:  ");
int size = int.Parse(Console.ReadLine()!);
int[] numbers = new int[size];

DifNumbers(numbers);

PrintArray(numbers);

void DifNumbers(int[] numbers)
{
    for(int i = 0; i < size; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}

int count = 0;

for (int x = 0; x < size; x++)
{
if (numbers[x] % 2 == 0)
count++;
}
Console.Write($"-> {count} четных числа");

void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < size; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}