﻿// 7. Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.WriteLine("введите любое трех значное число");
int num = Convert.ToInt32(Console.ReadLine());
if (num>=100 && num<1000)
{
    Console.WriteLine($"последнее число {num % 10}");
}
else
{
    Console.WriteLine("число не является трёхзначным");
}