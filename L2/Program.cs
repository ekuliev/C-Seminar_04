// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

void FillArray(int[] array, int min, int max) // Случайный ввод массива по заданному диапазону
{
    int length=array.Length;
    for(int i=0; i<length; i++)
    {
        array[i]=new Random().Next(min,max+1);
    }
}

string StringArray(int[] array, string split) // Преобразование массива в строку с заданным разделителем
{
    int length=array.Length;
    string textarray=String.Empty;
    for(int i=0; i<length; i++)
    {
        textarray+=array[i];
        if(i<length-1)
        {
            textarray+=split;
        }
    }
    return textarray;
}

Boolean FindNumber(int[] arr, int find) // Поиск индекса элемента массива с заданным числом (если число не найдено возвращает -1)
{
    for (int i=0; i < arr.Length; i++)
    {
        if (arr[i] == find)
            return true;
    }
    return false;
}

// Инициализация, заполнение и вывод массива
int[] array = new int[4];
FillArray(array,-9,9);
Console.WriteLine("Случайно заполненный массив: ["+StringArray(array,", ")+"]");
// Инициализация и ввод числа для поиска в массиве
int number = 0;
Console.Write("Введите число для поиска в массиве: ");
number = Convert.ToInt32(Console.ReadLine());
// Поиск заданного числа в массиве и выдача результата
if (FindNumber(array, number))
    Console.WriteLine("Число "+number+" в массиве присутствует (ДА)");
else
    Console.WriteLine("Число "+number+" в массиве не присутствует (НЕТ)");