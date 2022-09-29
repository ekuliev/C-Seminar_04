// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Ввод координат
double GetNumber(string name)
{
    Console.WriteLine("Введите координату " + name);
return Convert.ToDouble(Console.ReadLine());
}
// Вычисление расстояния
double Distance3D (double x1, double y1,double z1,double x2, double y2, double z2)
{
    double D = Math.Sqrt( Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2) + Math.Pow((z2-z1),2));
    return D;
}
double x1 = GetNumber("x1");
double y1 = GetNumber("y1");
double z1 = GetNumber("z1");
double x2 = GetNumber("x2");
double y2 = GetNumber("y2");
double z2 = GetNumber("z2");

Console.WriteLine("Расстояние " + Distance3D(x1, y1, z1, x2, y2, z2));