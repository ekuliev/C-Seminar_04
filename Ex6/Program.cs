// ### Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]  6, 1, 33 -> [6, 1, 33]
void FillArray(int[] array, int min, int max) // Заполнение массива случайными числами по заданному диапазону
{
    int length=array.Length;
    for(int i=0; i<length; i++)
    {
        array[i]=new Random().Next(min,max+1);
    }
}
void PrintArray(int[] array) // Вывод массива
{
    for (int i=0; i< array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
} 

// Инициализация, заполнение и вывод массива
int[] array = new int[8];
FillArray(array, 10, 100);
PrintArray (array);