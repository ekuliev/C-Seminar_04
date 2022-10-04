// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// Заполнение массива случайными 3-зн числами

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100,999);
    Console.Write(array[i] + " ");
}
}
// Проходим по массиву, если четное - инкремент счётчика. Возвращает счётчик
int CalcEvenElements(int[] Array)
{
    int count = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] % 2 == 0) count++;
    }
    return count;
}


int[] Arr = new int[10];
FillArray(Arr);
Console.WriteLine();
Console.WriteLine($"Количество чётных чисел - {CalcEvenElements(Arr)}");