// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100,1000);
Console.WriteLine($"случайное число это {number}");

int MakeDigit(int number)
{
    return ((number/100)*10 + number % 10);
}

int newDigit = MakeDigit(number);
Console.WriteLine($"{number} - > {newDigit}");