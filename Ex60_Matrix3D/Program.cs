// ### Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int InputNumber(string text) // Ручной ввод числа
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(int[,,] array, int min, int max) // Заполнение 3-х мерного массива
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
                array[i, j, k] = new Random().Next(min, max + 1);
}

// Вывод 3-х мерного массива по строкам
void PrintArray(int[,,] Array, string text)
{
    Console.WriteLine(text);
    for (int k = 0; k < Array.GetLength(2); k++)
        for (int i = 0; i < Array.GetLength(0); i++)
        {
            for (int j = 0; j < Array.GetLength(1); j++)
                Console.Write($"{Array[i, j, k]}({i}, {j}, {k}) ");
            Console.WriteLine();
        }
}
// Ввод данных
int m = InputNumber("Введите размерность массива m: "),
    n = InputNumber("Введите размерность массива n: "),
    l = InputNumber("Введите размерность массива l: "),
    min = InputNumber("Введите минимальное число, допустимое в массиве: "),
    max = InputNumber("Введите максимальное число, допустимое в массиве: ");
int[,,] matrix = new int[m, n, l];
FillArray(matrix, min, max);
PrintArray(matrix, "3-х мерный Массив:");