// ### Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
int InputNumber(string text) // Ручной ввод числа
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
void WriteNatNumbers(int N) // Write from N to 1
{
    if (N >= 1)
    {
        Console.Write(N + " ");
        WriteNatNumbers(N-1);
    }     
}
int N = InputNumber("Введите число: ");
WriteNatNumbers(N);