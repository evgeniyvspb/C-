﻿// 1. Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет


Console.WriteLine("введите число 1");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число 2");
int b = Convert.ToInt32(Console.ReadLine());
if (a == b * b)
{
    Console.WriteLine("первое число является квадратом второго ");
}
else Console.WriteLine("первое число НЕ является квадратом второго ");