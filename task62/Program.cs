// Задача 62: Заполните спирально массив 4 на 4.

void FillArraySpiral(int[,] squareMatrix)
{
    int temp = 1;
    int i = 0;
    int j = 0;
    while (temp <= squareMatrix.GetLength(0) * squareMatrix.GetLength(1))
    {
        squareMatrix[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < squareMatrix.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= squareMatrix.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > squareMatrix.GetLength(1) - 1)
            j--;
        else
            i--;
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] / 10 <= 0)
                Console.Write($" {array[i, j]} ");

            else Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}


Console.WriteLine("Введите количсетво строк в массиве");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количсетво столбцов в массиве");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[row,column];
//PrintArray(matrix);
FillArraySpiral(matrix);
PrintArray(matrix);
