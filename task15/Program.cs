// Задача 15: Напишите программу, которая принимает на
// вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if ((number>8||number<1)) Console.WriteLine("Такого дня недели нет");
else
if (number >5) Console.WriteLine("Да");
else Console.WriteLine("Нет");