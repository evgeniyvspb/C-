// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8" 

int mUser = InsertDigit("N:");
int nUser = InsertDigit("M:");
int sign = Math.Sign(mUser - nUser);
IntegerNumber(nUser, mUser, sign);

void IntegerNumber(int n, int m, int sign)
{
    if (m == n)
    {
        Console.Write(n + " ");
        return;
    }
    IntegerNumber(n + sign, m, sign);
    Console.Write(n + " ");
}

int InsertDigit(string text)
{
    int result; bool parse;
    Console.WriteLine(text);
    parse = Int32.TryParse(Console.ReadLine(), out result);
    if (!parse) result = InsertDigit(text); //Если не корреткно ввёл заново вызывае метод
    return result;
}
