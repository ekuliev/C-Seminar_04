// ### Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11 82 -> 10 9012 -> 12
int GetNumber()
{
    Console.Write("Input num: ");
    return Convert.ToInt32(Console.ReadLine());
}

int LenghNum(int Number) // вычисляем разрядность
{
    int DigCount=0;
    while(Math.Abs(Number)>0)
    {
        Number=Number/10;
        DigCount++;
    }
    return DigCount;
}
int GetDigitFromNumber(int number, int index) // используем наработки, вытаскиваем нужную цифру
{

    int num = number/Convert.ToInt32(Math.Pow(10, LenghNum(number)-index))%10;
    return num;
}
int num = GetNumber();
int sum = 0;
for (int i=1; i <= LenghNum(num); i++)
{
    sum =  sum + GetDigitFromNumber(num, i);
}
Console.WriteLine();
Console.WriteLine("Sum of digits: " +sum);
