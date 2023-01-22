// Задача 43. Напишите программу, которая найдёт точку
// пересечения двух прямых, заданных уравнениями y = k1 *
// x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
// // пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 =
// 9 -> (-0,5; -0,5)

// x = (b2 - b1) / (k1 -k2)

double[] EnterUser(int par)
{
    double[] numbers = new double[par];
    for (int i = 0; i < par/2; i++)
    {
        Console.WriteLine($"Введите параметр k{i+1}:");
        numbers[i] = Convert.ToInt32(Console.ReadLine());
    }    
    for (int i = par/2; i < par; i++)
    {
        Console.WriteLine($"Введите параметр b{i-par/2+1}:");
        numbers[i] = Convert.ToInt32(Console.ReadLine());
    }
    return numbers;
}

(double,double) CountXY(double[] par)
{
    (double,double) tuple = (0, 0);
    tuple.Item1 = ((par[3] - par[2])/(par[0]- par[1]));
    tuple.Item2 = par[1]*tuple.Item1+par[3];
    return tuple;
}

double[] arr =EnterUser(4);
(double,double) tuple = CountXY(arr);
Console.WriteLine($"точка пересечения двух прямых это ({tuple.Item1}; {tuple.Item2})");
