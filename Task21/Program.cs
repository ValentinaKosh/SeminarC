// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.WriteLine("Введите xa");
int xa = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите ya");
int ya = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите za");
int za = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите xb");
int xb = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите yb");
int yb = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите zb");
int zb = int.Parse(Console.ReadLine()!);

double A = Math.Pow(xb - xa, 2);
double B = Math.Pow(yb - ya, 2);
double C = Math.Pow(zb - za, 2);


double D = Math.Sqrt(A + B + C);
double R = Math.Round(D, 2);


Console.Write(R);