// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
// 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i]= rnd.Next(min,max+1);
    }
    return array;
}

// void PrintArray(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i < array.Length-1) Console.Write(array[i]+",");
//         else Console.Write(array[i]);

//     }
//     Console.WriteLine("]");
// }

string ArrayToString (int[] array) // метод преобразования массива в строку
{
    string result = "[";
    for (int i = 0; i < array.Length; i++)
    {
        result=result+$" {array[i]}";
        result=i<(array.Length -1)? result = result+",": result; //для корректности вывода запятых
    }
    return result + " ]";
}

int CountElement (int[] array, int fMin, int fMax)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>=fMin&&array[i]<=fMax) result++;
    }
    return result;
}

int arraySize = 123, arrayMinValue=0, arrayMaxValue=100, findMin =10, findMax=99;

int[] newArray = CreateArrayRndInt(arraySize, arrayMinValue, arrayMaxValue);
string strArray= ArrayToString(newArray);

int count = CountElement(newArray, findMin, findMax);
Console.WriteLine($"{strArray} -> {count}");
