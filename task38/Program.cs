// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным
// элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2// 

double[] CreateArrayRndDouble(int size, int min, int max, int round)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i]= rnd.NextDouble()*(max-min)+min;
        array[i]=Math.Round(array[i], round); // можно было бы объеденить с первой строчкой но мне кажется так понятнее и не награможденнее
    }
    return array;
}

void PrintArrayDouble(double[] array)
{
    Console.Write("["); 
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length-1) Console.Write(array[i]+";");
        else Console.Write(array[i]);
    }
    Console.WriteLine("]");
}

double FindMin (double[] arr)
{
    double findMin=arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (findMin>arr[i]) findMin=arr[i];
    }
    return findMin;
}

double FindMax (double[] arr)
{
    double findMax=arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (findMax<arr[i]) findMax=arr[i];
    }
    return findMax;
}

double[] array=CreateArrayRndDouble(8,0,99,1); // создали массив от 0 до 99 включительно. 
double findMax = FindMax(array);
double findMin = FindMin(array);

Console.WriteLine("Разница в массиве");
PrintArrayDouble(array);
Console.WriteLine($"между минимальным и максимальным числом составляет {findMax - findMin}");

