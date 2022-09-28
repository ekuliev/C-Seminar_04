// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
int GetNumber()
{
    Console.Write("Input num: ");
    return Convert.ToInt32(Console.ReadLine());
}
int LenghNum(int Number) 
{
    int DigCount=0;
    while(Math.Abs(Number)>0)
    {
        Number=Number/10;
        DigCount++;
    }
    return DigCount;
}
int GetDigitFromNumber(int number, int index)
{
    int num = number/Convert.ToInt32(Math.Pow(10, LenghNum(number)-index))%10;
    return num;
}
int num = GetNumber();
int D1 = GetDigitFromNumber(num, 1);
int D2 = GetDigitFromNumber(num, 2);
int D4 = GetDigitFromNumber(num, 4);
int D5 = GetDigitFromNumber(num, 5);
if (D1 == D5 && D2 == D4) Console.Write("Palindrome!");
else
{
    Console.Write("Try again");
}