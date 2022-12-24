// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите число");
int x = Convert.ToInt32(Console.ReadLine());
int index = (Digits(x) - 1);
double newX = 0;
int temp = x;

while (index >= 0)
{
    newX = newX + (temp % 10) * Math.Pow(10,index);
    index--;
    temp = temp/10;
}
if (x == newX) Console.WriteLine("Yes");
else Console.WriteLine("NO");

int Digits(int num)
{
    if (num == 0) return 1;
    int result = 0;
    while (num > 0)
    {
        num = num / 10;
        result++;
    }
    return result;
}