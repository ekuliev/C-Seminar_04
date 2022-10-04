// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
// Заполнение массива случайными 3-зн числами

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10,10);
    Console.Write(array[i] + " ");
}
}
// Проходим по массиву, если индекс нечётный - инкремент счётчика. Возвращает счётчик
double CalcSumOfOdd(int[] Array)
{
    double count = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (i % 2 != 0) count += Array[i];
    }
    return count;
}

int[] Arr = new int[8];
Console.Write("Массив: ");
FillArray(Arr);
Console.WriteLine();
Console.WriteLine($"Сумма элементов на нечётных позициях: {CalcSumOfOdd(Arr)}");