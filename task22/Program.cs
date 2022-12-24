// на вход N  а на выходе таблица с квадратами чисел

Console.WriteLine("введите натуральное число N: ");
int num = Convert.ToInt32(Console.ReadLine());

void SqNum(int number)
{
    int index = 1;
    while (index <= number)
    {
        Console.Write($"{index}    ");
        Console.WriteLine($"{index * index}");
        index++;
    }
}
if (num>0) SqNum(num);
else Console.WriteLine("Ввод некорректный");
