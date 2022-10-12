// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
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
    Console.WriteLine("Массив");
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            // if (Array[i, j] == 0) Console.Write($" ");
            Console.Write($"{Array[i, j]} ");
        }
        Console.WriteLine();
    }
}

// Ввод данных
int InputIndex(string k)
{
    Console.Write($"{k}? ");
    return Convert.ToInt32(Console.ReadLine());
}

int[,] matrix = new int[3, 4];
FillArray(matrix);
PrintArray(matrix);
int I = InputIndex("I")-1;
int J = InputIndex("J")-1;
// По условию - вывести значение элемента по индексу или сообщение, если нет элемента с таким индексом
if (I < matrix.GetLength(0) && J < matrix.GetLength(1)) 
{
    Console.WriteLine($"Элемент с индексом [{I+1},{J+1}] = {matrix[I,J]}");
}
else Console.WriteLine($"Нет элемента с индексом [{I+1}, {J+1}]");


