// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// сумма чисел введенного числа

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
int sumNumbers = SumNumbers(number);
Console.WriteLine($"Сумма чисел от 1 до {number} = {sumNumbers}");

int SumNumbers(int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        sum = sum + i;
    }
    return sum;
}