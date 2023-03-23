// Итоги блока. Выбор специализации. IT-специалист 
// Из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
string[] array1 = new string[5] {"123", "56", "archivarius", "suck", "ini"};
string[] array2 = new string[array1.Length];
void CreateSecondArray(string[] array1, string[] array2)
{
    int n = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[n] = array1[i];
        n++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
CreateSecondArray(array1, array2);
PrintArray(array1);
PrintArray(array2);