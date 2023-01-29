// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

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

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5},");
            else Console.Write($"{matrix[i, j],5}  ");
        }
        Console.WriteLine("]");
    }

}

int[] MatrixToArray(int[,] matrix)
{
    int[] array = new  int[matrix.Length];
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[count]=matrix[i,j];
            count++;
        }
    }
    return array;
}

void PrintArray(int[] arr)
{
    // Console.Write($"{arr[0]}");
    // for (int i = 1; i < arr.Length; i++)
    // {
    //     Console.Write($", {arr[i]}");
    // }
    // Console.Write(" -> ");
    Console.Write($"[{arr[0]}");
    for (int i = 1; i < arr.Length; i++)
    {
        Console.Write($", {arr[i]}");
    }
    Console.Write("]");

}

int[,] CreateDictionaryFromArray(int[] array)
{
    int[,] matrixArray= new int[array.Length,2];
    int currValue = array[0];
    matrixArray[0,0]=currValue;
    matrixArray[0,1]=1; //заполнили первую строчку что первого элемента в масиве одна штука
    int cnt=0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] == currValue) matrixArray[cnt,1]++;
        else
        {
            cnt++;
            matrixArray[cnt,0]=array[i];
            matrixArray[cnt,1]++;
            currValue=array[i];
        }
    }
    return matrixArray;
}


int[,] array2D = CreateMatrixRndInt(3,3,1,10);
PrintMatrix(array2D);
Console.WriteLine();
int[] arrayFromMatrix = MatrixToArray(array2D);
Array.Sort(arrayFromMatrix);
PrintArray(arrayFromMatrix);
Console.WriteLine();
int[,] dictionaryMatrix = CreateDictionaryFromArray(arrayFromMatrix);
PrintMatrix(dictionaryMatrix);