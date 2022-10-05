// Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементом массива.
// [3 7 22 2 78] -> 76
// Заполнение массива случайными вещественными числами

void FillArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10,10) + new Random().NextDouble();
    Console.Write(array[i] + " ");
}
}

// Найти минимальный элемент
double MinElement( double[] array)
{
    double Min = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < Min ) Min = array[i];
    }
    return Min;
   // Console.Write($"Min: {Min}");
}
// Найти максимальный элемент
double MaxElement( double[] array)
{
    double Max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > Max) Max = array[i];
    }
    return Max;
    // Console.Write($"Max: {Max}");
}

double[] Arr = new double[8];
Console.Write("Массив: ");
FillArray(Arr);
Console.WriteLine();
Console.WriteLine($"Max: {MaxElement(Arr)}");
Console.WriteLine($"Min: {MinElement(Arr)}");
Console.Write($"Difference: {MaxElement(Arr) - MinElement(Arr)}");