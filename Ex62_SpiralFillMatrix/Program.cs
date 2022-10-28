// ### Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// Ввод данных
int InputNumber(string text) 
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
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

// Заполнение массива. Thanks, Rosetta!
int[,] Spiral(int n)
{
    int[,] result = new int[n, n];

    int pos = 0, count = n,
        value = -n, sum = -1;
    do 
    {
        value = -1 * value / n;
        for (int i = 0; i < count; i++) 
        {
            sum += value;
            result[sum / n, sum % n] = pos++;
        }
        value *= n;
        count--;
        for (int i = 0; i < count; i++) 
        {
            sum += value;
            result[sum / n, sum % n] = pos++;
        }
    } 
    while (count > 0);
    return result;
}

int n = InputNumber("Введите размер массива: ");
PrintArray(Spiral(n), "Спиральная матрица:");