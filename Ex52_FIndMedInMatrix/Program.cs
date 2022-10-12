// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов 
// в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Заполнение массива случайными числами
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);//[1; 10)
        }
    }
}
// Вывод массива
void PrintArray(int[,] Array)
{
    Console.WriteLine("Массив:");
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"{Array[i, j]} ");
        }
        Console.WriteLine();
    }
}
// Вычисление среднего в выбранном столбце матрицы
double Median (int[,] matr, int column)
{
    double sum =0;
    for (int i=0; i < matr.GetLength(0); i++)
    {
        sum += matr[i,column];
    }
    return sum / matr.GetLength(0);
}

// Проходим матрицу по столбцам 
void CalcMedians( int[,] matr)
{
    Console.WriteLine("Среднее арифм по столбцам:");
    for (int j=0; j < matr.GetLength(1); j++)
    {
        Console.Write($"{Median(matr, j)} ");
    }
}
int[,] matrix = new int[3, 6];
FillArray(matrix);
PrintArray(matrix);
CalcMedians(matrix);