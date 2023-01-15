// Задача 27: Напишите программу, которая принимает на
// вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число:");
int userNumber = Convert.ToInt32(Console.ReadLine());

int SumDigit(int insertNum)
{
    insertNum = Math.Abs(insertNum); // взяли модуль по числу
    int sum = 0;
    while (insertNum>0)
    {
        sum = sum + insertNum % 10;
        insertNum=insertNum/10;
    }
    return sum;
}

int sumDigit = SumDigit(userNumber);

    Console.WriteLine($"сумма цыфр в числе {userNumber} = {sumDigit}");