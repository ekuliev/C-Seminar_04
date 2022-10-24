// ### Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
int InputNumber(string text) // Ручной ввод числа
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
void FillArray(int[,] array, int min, int max) // Заполнение массива
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(min, max + 1);
}

// Вывод массива
void PrintArray(int[,] Array, string text)
{
    Console.WriteLine(text);
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"{Array[i, j]} ");
        }
        Console.WriteLine();
    }
}
// Подсчёт суммы в строке 
int GetSumInRow (int[,] Array, int i)
{
    int Sum = 0;
    for (int j = 0; j < Array.GetLength(1); j++)
        {
            Sum += Array[i,j];
        }
    return Sum;
}
// Проход по строкам и вычисление строки с минимальной суммой
int FindMinPosition (int[,] Array)
{
    int MinPosition = 0;
    int Min = GetSumInRow(Array, 0);
    for (int i = 1; i < Array.GetLength(0); i++)
    {
        if (GetSumInRow(Array, i) < Min) 
        {
            Min = GetSumInRow(Array, i);
            MinPosition = i;
        }
    }
    return MinPosition;
}

int m = InputNumber("Введите размерность массива m: "),
    n = InputNumber("Введите размерность массива n: "),
    min = InputNumber("Введите минимальное число, допустимое в массиве: "),
    max = InputNumber("Введите максимальное число, допустимое в массиве: ");
int[,] matrix = new int[m, n];

FillArray(matrix, min, max);
PrintArray(matrix, "Исходный массив");
Console.WriteLine ($"Минимальная сумма в строке: {FindMinPosition(matrix)}");