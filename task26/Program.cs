// Сколько чисел в введенной цыфре

Console.WriteLine("Введите число:");
int userNumber = Convert.ToInt32(Console.ReadLine());

int CountDigit(int insertNum)
{
    // insertNum = Math.Abs(insertNum); // взяли модуль по числу
    int temp = 0;
    while (insertNum != 0) // так как если меньше 1 то число же только челое поэтому и ноль
    {
        insertNum = insertNum / 10;
        temp++;
    }
    return temp;
}
    int count = CountDigit(userNumber);

    Console.WriteLine($"количество цыфр в числе {userNumber} = {count}");