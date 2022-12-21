// случайное число от 10 до 99 и показать наибольшую цыфру

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из диапозона 10-99 => {number}");
// int firstDigit = number / 10;
// int secondDigit = number % 10;
// //if (firstDigit > secondDigit) Console.WriteLine($"наибольшая цыфра числа = {firstDigit}");
// //else Console.WriteLine($"наибольшая цыфра числа = {secondDigit}");

// Console.WriteLine("наибольшая цыфра числа = ");
// Console.WriteLine(firstDigit > secondDigit ? firstDigit: secondDigit);

int maxdigit = MaxDigit(number);
Console.WriteLine($"наибольшая цыфра числа = {maxdigit}");



int MaxDigit(int number)
{
    int firstDigit = number / 10;
    int secondDigit = number % 10;
    return firstDigit > secondDigit ? firstDigit: secondDigit;
}

