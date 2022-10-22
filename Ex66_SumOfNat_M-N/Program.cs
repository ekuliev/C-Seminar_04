// ### Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int InputNumber(string text) // Ручной ввод числа
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
// Подсчёт суммы
int SumOfNaturals(int firstNumber, int lastNumber)
{
    int Sum = 0;
    for (int i = firstNumber; i <= lastNumber; i++)
    {
        Sum += i;
    }
    return Sum;
} 
int firstNumber = InputNumber("Введите начальное число: ");
int lastNumber = InputNumber("Введите конечное число: ");
Console.WriteLine($"Сумма натуральных чисел от {firstNumber} до {lastNumber} = {SumOfNaturals(firstNumber, lastNumber)}");