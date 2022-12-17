// Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.WriteLine("введите число от пользователя от 1 до 7");
int day = Convert.ToInt32(Console.ReadLine());
while (day > 7)
{
    Console.WriteLine("введите число от пользователя от 1 до 7");
    day = Convert.ToInt32(Console.ReadLine());
}
if (day == 1)
{
    Console.WriteLine("сегондя понедельник");
}
else 
if (day == 2)
{
    Console.WriteLine("сегондя вторник");
}
else
if (day == 3)
{
    Console.WriteLine("сегондя среда");
}
if (day == 4)
{
    Console.WriteLine("сегондя четверг");
}
else
if (day == 5)
{
    Console.WriteLine("сегондя пятница");
}
else
if (day == 6)
{
    Console.WriteLine("сегондя суббота");
}
else
if (day == 7)
{
    Console.WriteLine("сегондя воскресенье");
}
