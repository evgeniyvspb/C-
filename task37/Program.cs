// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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

int[] MakeArray(int[] array)
{
    int size = array.Length % 2 !=0 ? array.Length/2+1: array.Length/2;
    int[] resArray = new int[size];
    for (int i = 0; i < resArray.Length; i++)
    {
        if (i==resArray.Length - 1 && array.Length%2 ==1)
        {
            resArray[i]=array[i];
        }
        else
        {
            resArray[i] = array[i]*array[array.Length-i-1];
        }
    }
    return resArray;
}

int arraySize = 5, arrayMinValue=0, arrayMaxValue=10;

int[] newArray = CreateArrayRndInt(arraySize, arrayMinValue, arrayMaxValue);
string strArray= ArrayToString(newArray);

int[] halfAndDouble = MakeArray(newArray);
string strHalfAndDouble = ArrayToString(halfAndDouble);
Console.WriteLine($"{strArray} -> {strHalfAndDouble}");