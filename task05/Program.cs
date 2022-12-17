// 5. Напишите программу, которая на вход принимает
// одно число (N), а на выходе показывает все целые
// числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"


Console.WriteLine("введите любое натуральное число");
int a = Convert.ToInt32(Console.ReadLine());
int count = -a;

while (count <= a)
{
    Console.Write(count + " ");
    count++;
}