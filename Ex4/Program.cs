// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит
//  число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
int GetNumber( string k)
{
    Console.Write("Input " +k);
    return Convert.ToInt32(Console.ReadLine());
}

double Pow (double a, double b)
{
    double result = a;
    for (int i=1; i<b; i++)
    {
        result = result * a;
    }
    return result;
}

double A = GetNumber("number: ");
double B = GetNumber("power: ");
Console.WriteLine (Pow (A, B));