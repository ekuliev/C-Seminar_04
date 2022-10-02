// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27 5 -> 1, 8, 27, 64, 125
int GetNumber()
{
    Console.Write("Input number: ");
    return Convert.ToInt32(Console.ReadLine());
}

void WriteCubes(int N)
{
    for (int i=1; i<=N; i++)
    {
        Console.Write($"{Math.Pow(i, 3)} ");
    } 
}
WriteCubes(GetNumber());