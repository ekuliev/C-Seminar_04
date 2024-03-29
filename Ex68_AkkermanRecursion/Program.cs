﻿// ### Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// функция Аккермана
uint Akkerman(uint m, uint n)
{
  if (m == 0)
    return n + 1;
  else
    if ((m != 0) && (n == 0))
      return Akkerman(m - 1, 1);
    else
      return Akkerman(m - 1, Akkerman(m, n - 1));
}

uint InputNumber(string text) // Ручной ввод числа
{
    Console.Write(text);
    return Convert.ToUInt32(Console.ReadLine());
}
uint M = InputNumber("Введите число m: ");
uint N = InputNumber("Введите число n: ");
Console.WriteLine($"Функция Аккермана ({M}, {N}) = {Akkerman(M, N)}");