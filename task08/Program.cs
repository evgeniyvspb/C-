//  Задача 8: Напишите программу, которая на вход
// принимает число (N), а на выходе показывает все чётные
// числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите любое число");
int N = Convert.ToInt32(Console.ReadLine());
int count = 2;
if (N<1)
{
    Console.WriteLine("Число меньше 1 тут не подходит, дружище. Только цыфры от 1 и больше");
}
else
while (count <= N)
{
    Console.Write(count + " ");
    count = count + 2;
}