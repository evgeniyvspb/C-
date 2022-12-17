// Задача 6: Напишите программу, которая на вход
// принимает число и выдаёт, является ли число чётным
// (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите любое натуральное число");
int num = Convert.ToInt32(Console.ReadLine());
num = num % 2;
if (num == 0)
{
    Console.WriteLine("ДА");
}
else 
{
    Console.WriteLine("НЕТ");
}

