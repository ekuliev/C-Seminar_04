// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел 
// больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void FillArray(int[] array) // Ввод М чисел в массив
{
    for (int i = 0; i < array.Length; i++)
{   
    // array[i] = Convert.ToInt32(Console.ReadLine());
    array[i] = int.Parse(Console.ReadLine());
}
}

void PrintArray(int[] array) // Вывод массива на экран
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
int CountPositives(int[] array) // подсчёт + в массиве
{
    int Sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 0 ) Sum++;
    }
    return Sum;
}

int[] digits = new int[5];
Console.Write($"Введите {digits.Length} чисел: ");
FillArray(digits);
Console.Write("Вы ввели: ");
PrintArray(digits);
Console.Write($"Число положительных: {CountPositives(digits)}");