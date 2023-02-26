// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого числа в массиве нет


int[,] GetArray(int m, int n, int minValue, int maxValue) 
{ 
    int[,] rezult = new int[m, n]; 
    for (int i = 0; i < m; i++) 
    { 
        for (int j = 0; j < n; j++) 
        { 
            rezult[i, j] = new Random().Next(minValue, maxValue + 1);
        } 
    } 
    return rezult; 
} 

void PrintArray(int[,] inArray) 
{ 
    for (int i = 0; i < inArray.GetLength(0); i++) 
    { 
        for (int j = 0; j < inArray.GetLength(1); j++) 
        { 
            Console.Write($"{inArray[i, j]}\t ");
        } 
        Console.WriteLine(); 
    } 
} 

string GetElement1(int m, int n, int[,] inArray)
{
    string rezult;
    bool hasElement = m <= inArray.GetLength(0) - 1 && n <= inArray.GetLength(1) - 1;
    if (hasElement)
    {
        rezult = $"{m},{n} -> {inArray[m,n]}";
    }
    else 
    {
        rezult = $"Элемента с индексами {m},{n} в массиве нет!";
    }
    return rezult;
}

Console.Clear();

int row = new Random().Next(3, 8);
int col = new Random().Next(3, 8);
int[,] Array1 = GetArray(row, col, -10, 10);
PrintArray(Array1);
Console.WriteLine();

Console.Write("Введите положительные индексы элемента массива через запятую ");
int[] position = Array.ConvertAll(Console.ReadLine().Split(','), Convert.ToInt32);
int m = position[0];
int n = position[1];
Console.WriteLine(GetElement1(m, n, Array1));