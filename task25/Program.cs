// Задача 25: Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную
// степень B.

int Stepen (int numa, int numb)
{
    int stepen = numa;
    for (int i = 1; i < numb; i++)
    {
        stepen = stepen * numa;
    }
    return stepen;
}

Console.WriteLine("Введите число А: ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите натуральное число В: ");
int numberB = int.Parse(Console.ReadLine());
if (numberB > 0)
{
    int result = Stepen(numberA, numberB);
    Console.WriteLine($"Число {numberA}  в степени {numberB}  равно {result}");
}
else Console.WriteLine("Введите натуральное число для степени");

