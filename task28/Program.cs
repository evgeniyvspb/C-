// произвдеение цыфр в число

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

int Multiply(int num)
{
    int proizv = 1;
    for (int i = 1; i <= num; i++)
    {
        proizv = proizv * i;
    }
    return proizv;
}

int multiply = Multiply(number);
Console.WriteLine($"Произведение цыфр числа {number} составляет {multiply}");