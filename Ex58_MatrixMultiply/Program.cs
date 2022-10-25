// ### Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
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
// Метод умножения матриц - элементы строк А на элементы столбцов B
int [,] MatrixMult(int[,] arrayA, int[,] arrayB)
    {
      int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
      for (int i = 0; i < arrayA.GetLength(0); i++)
      {
        for (int j = 0; j < arrayB.GetLength(1); j++)
        {
          for (int k = 0; k < arrayA.GetLength(1); k++)
          {
            arrayC[i, j] += arrayA[i, k] * arrayB[k, j];
          }
        }
      }
      return arrayC;
    }

//Блок ввода параметров массива
int m = InputNumber("Введите размерность 1 массива m: "),
    n = InputNumber("Введите размерность 1 массива n: "),  
    k = InputNumber("Введите размерность 2 массива k: "),
    l = InputNumber("Введите размерность 2 массива m: ");
if (n != k)
{
  Console.WriteLine("Такие матрицы не умножаются!");
  return;
}
int min = InputNumber("Введите минимальное число, допустимое в массиве: "),
    max = InputNumber("Введите максимальное число, допустимое в массиве: ");
int[,] matrix1 = new int[m, n];
int[,] matrix2 = new int[k, l];
// Заполняем массив
FillArray(matrix1, min, max);
FillArray(matrix2, min, max);
// Выводим для контроля
PrintArray(matrix1, "1 Матрица");
Console.WriteLine();
PrintArray(matrix2, "2 Матрица");
Console.WriteLine();
// Вывод результата умножения
PrintArray(MatrixMult(matrix1, matrix2), "Произведение матриц");
