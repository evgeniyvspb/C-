// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования. 

int[] arr1 = CreateArrayRndInt(7, 1, 9);
int[] arr2 = CopyArray(arr1);
Console.Write("Исходный массив ->");
PrintArray(arr1);
arr2[0] = 55;
Console.Write("Скопированный массив ->");
PrintArray(arr2);

int[] CopyArray(int[] input)
{
    int[] result = new int[input.Length];
    for (int i = 0; i < input.Length; i++)
    {
        result[i] = input[i];
    }
    return result;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write(array[i] + ",");
        else Console.Write(array[i]);

    }
    Console.WriteLine("]");
}

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}