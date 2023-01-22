// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length-1) Console.Write(array[i]+",");
        else Console.Write(array[i]);

    }
    Console.WriteLine("]");
}

int[] EnterUser()
{
    Console.WriteLine("Сколько чисел Вы собираетесь ввести?");
    int count = Convert.ToInt32(Console.ReadLine());
    int[] numbers = new int[count];
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine($"Введите число {i+1}:");
        numbers[i] = Convert.ToInt32(Console.ReadLine());
    }    
    return numbers;
}

int Counting(int[] number)
{
    int count = 0;
    for (int i = 0; i < number.Length; i++)
    {
        if (number[i]>0) count++;
    }
    return count;
}

int[] num=EnterUser();
int count = Counting(num);
Console.WriteLine("Среди введенных чисел");
PrintArray(num);
Console.WriteLine($"больше нуля пользователь ввёл {count} раз");
