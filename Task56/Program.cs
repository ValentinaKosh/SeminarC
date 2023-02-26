// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] GetArray2D(int row, int col, int minValue, int maxValue)
{
    int[,] array2D = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array2D[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array2D;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} \t");
        }
        Console.WriteLine();
    }
}


void GetSumMinRow(int[,] inArray)
{
    int min = -10;
    int minrow = 1;
    int sum;
    bool Start = false;
    
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            sum += inArray[i, j];
                    }
        if (!Start || sum < min)
        {
            Start = true;
            minrow = sum;
            minrow = i + 1;
        }
    }
    Console.WriteLine($"{minrow} строка имеет минимальную сумму элементов");    
}

Console.Clear();

Console.Write("Введите количество строк массива = ");
int row = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов массива = ");
int col = int.Parse(Console.ReadLine()!);

int[,] Array1 = GetArray2D(row, col, -10, 10);
Console.WriteLine();
PrintArray(Array1);
GetSumMinRow(Array1);