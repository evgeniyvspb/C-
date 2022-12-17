// Задача 2: Напишите программу, которая на вход
// принимает два числа и выдаёт, какое число большее, а
// какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("введите любое натуральное число 1");
int first = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите любое натуральное число 2");
int second = Convert.ToInt32(Console.ReadLine());

if (first > second)
{
    Console.WriteLine($" Первое число {first} больше чем второе число {second} ");
}
else
if (first < second)
{
    Console.WriteLine($" Первое число {first} меньше чем второе число {second} ");
}
else 
if (first == second)
{
    Console.WriteLine($" Первое число {first} равно второму числу {second} ");
}
else 
Console.WriteLine("Ввод данных некорректный");