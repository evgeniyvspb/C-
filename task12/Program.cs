// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите два числа");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());

bool DivCheck(int num1, int num2)
{
    return num1 % num2 == 0;
}

if (DivCheck(num1, num2))
{
    Console.WriteLine($"{num1}, {num2} -> кратно");
}
else Console.WriteLine($"{num1}, {num2} -> не кратно, остаток " + (num1 % num2));