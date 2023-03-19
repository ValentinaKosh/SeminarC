// Написать программу которая из имеющегося массива 
// строк формирует массив из строк, длина которых меньше либо равно 3 символа

string[] M; // массив строк
Console.WriteLine("Введите массив строк через запятую");
String stroka = Console.ReadLine(); 
M = stroka.Split(',');
var result = new string[M .Length];
var rSize = 0;
    foreach (var value in M )
    {
    if (value.Length < 4)
        {
        result[rSize] = value;
        rSize++;
        }
    }
Console.Write(string.Join(Environment.NewLine, result, 0, rSize));
Console.ReadKey(true);
