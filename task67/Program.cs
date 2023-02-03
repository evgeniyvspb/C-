// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int number = InsertDigit("Enter number");
int sum = SumDigit(number);
Console.WriteLine(sum);

int SumDigit(int number)
{
    if (number == 0) return 0;
    return SumDigit(number/10) + number % 10;
}

int InsertDigit(string text)
{
    int result; bool parse;
    Console.WriteLine(text);
    parse = Int32.TryParse(Console.ReadLine(), out result);
    if (!parse) result = InsertDigit(text); //Если не корреткно ввёл заново вызывае метод
    return result;
}
