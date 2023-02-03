// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int nUser = InsertDigit("enter N:");
int mUser = InsertDigit("enter M:");
int summa = SumNumber(nUser, mUser);
Console.WriteLine(summa);

int SumNumber(int n, int m)
{
    if (m == n) return m;
    if (m > n)  return SumNumber(n + 1, m)+n;
    else return SumNumber(n - 1, m)+n;
}

int InsertDigit(string text)
{
    int result; bool parse;
    Console.WriteLine(text);
    parse = Int32.TryParse(Console.ReadLine(), out result);
    if (!parse) result = InsertDigit(text); //Если не корреткно ввёл заново вызывае метод
    return result;
}
