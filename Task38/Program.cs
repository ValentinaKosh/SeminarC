// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());

double[] GetArray(int size, double minValue, double maxValue)
{
     double[] rezult = new double[size];
     for (int i = 0; i < size; i++)
     {
        rezult[i] = new Random().NextDouble()*(maxValue - minValue)+minValue;
     }
     return rezult;
 }

double FindMax(double[] array) 
{ 
    double max = array[0]; 
    for (int i = 0; i < array.Length; i++) 
    { 
        if (array[i] > max) 
        { 
            max = array[i]; 
        } 
    } 
    return max; 
} 

double FindMin(double[] array) 
{ 
    double min = array[0]; 
    for (int i = 0; i < array.Length; i++) 
    { 
        if (array[i] < min) 
        { 
            min = array[i]; 
        } 
    } 
    return min; 
} 

double[] array = GetArray(size, 1, 999); 
Console.WriteLine(String.Join(", ", array)); 

double res = FindMax(array) - FindMin(array); 
Console.WriteLine($"Разность Максимального и Минимального равна {res} ");