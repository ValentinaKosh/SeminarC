// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
int Prompt(string message)
{
    Console.Write(message);
    string readInput = Console.ReadLine();
    int rezult = int.Parse(readInput);
    return rezult;
}

int Power(int BaseA, int ExpB)
{
    int power = 1;
    for (int i = 0; i < ExpB; i++)
    {
        power *=  BaseA;
    }
    return power;
}

bool CheckExp(int ExpB)
{
    if (ExpB < 0)
    {
        Console.WriteLine("Покаказетль не должен быть отрицательным");
        return false;
    }
    return true;
}

int BaseA = Prompt("Введите основание = ");
int ExpB = Prompt("Введите показатель степени = ");
if (CheckExp(ExpB))
{
    Console.WriteLine($"Число {BaseA} в степени {ExpB} равно {Power(BaseA, ExpB)}");
    }