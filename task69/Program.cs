// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8 

int mUser = InsertDigit("number:");
int nUser = InsertDigit("power:");
int pow = PowerNumbers(mUser,nUser);
Console.WriteLine($"Power = {pow}");


int PowerNumbers(int num, int power)
{
    if (power==0) return 1;
    return PowerNumbers(num,power-1)*num;
}



int InsertDigit(string text)
{
    int result; bool parse;
    Console.WriteLine(text);
    parse = Int32.TryParse(Console.ReadLine(), out result);
    if (!parse) result = InsertDigit(text); //Если не корреткно ввёл заново вызывае метод
    return result;
}
