// Задача 13: Напишите программу, которая выводит
// третью цифру заданного числа или сообщает, что третьей
// цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if (number <0) number =  (-1) * number; // поскольку трехначный числом может быть и отрицательное число то поменяем знак

if (number > 100)
{
    while ((number >= 999) || (number < 100))
    {
        number = number / 10;
    }
    Console.WriteLine($"Третья цыфра числа это " + (number % 10));
}
else Console.WriteLine("третьей цыфры нет");

