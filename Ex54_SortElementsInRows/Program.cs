// ### Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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
// Сортировка элементов в строках массива по убыванию
void SelectionSort(int[,] array)
{
    for (int i = 0; i < array.GetLength(0) ; i++)
    {
        for (int j = 0; j < array.GetLength(1) ; j++)
        {
            int maxPosition = j;

            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, k] > array[i, maxPosition]) maxPosition = k;
            }
            int temporary = array[i, j];
            array[i, j] = array[i, maxPosition];
            array[i, maxPosition] = temporary;
        }

    }
}


int m = InputNumber("Введите размерность массива m: "),
    n = InputNumber("Введите размерность массива n: "),
    min = InputNumber("Введите минимальное число, допустимое в массиве: "),
    max = InputNumber("Введите максимальное число, допустимое в массиве: ");
int[,] matrix = new int[m, n];

FillArray(matrix, min, max);
PrintArray(matrix, "Исходный массив");
SelectionSort(matrix);
PrintArray(matrix, "Результирующий массив");