// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Ввод данных
double InputCoeff(string k)
{
    Console.Write($"{k}? ");
    return Convert.ToDouble(Console.ReadLine());
}
// Два линейных уравнения
// Вычисление х
double FindX(double K1, double K2, double B1, double B2)
{
    double X = (B2-B1)/(K1-K2);
    return X;
}
// Вычисление y
double FindY(double K2, double B2, double X)
{
    double Y = K2*X + B2;
    // Console.WriteLine(Y);
    return Y;
}
// Инициализация переменных
double k1 = InputCoeff("k1");
double b1 = InputCoeff("b1");
double k2 = InputCoeff("k2");
double b2 = InputCoeff("b2");
if (k1 != k2) 
{
    double x = FindX(k1, k2, b1, b2);
    double y = FindY(k2, b2, x);
    Console.WriteLine($"Точка пересечения в координатах: {x}; {y}");
}
else 
    Console.WriteLine("Прямые параллельны");
