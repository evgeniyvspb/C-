// Задача 54: Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.


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

void SortMatrix(int[,] arr)
{
    int temp = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int write = 0; write < arr.GetLength(1); write++)
        {
            for (int sort = 0; sort < arr.GetLength(1) - 1; sort++)
            {
                if (arr[i, sort] < arr[i, sort + 1])
                {
                    temp = arr[i, sort + 1];
                    arr[i, sort + 1] = arr[i, sort];
                    arr[i, sort] = temp;
                }
            }
        }
    }

}

int[,] array2D = CreateMatrixRndInt(4, 6, -10, 10);
PrintMatrix(array2D);
Console.WriteLine();
SortMatrix(array2D);
PrintMatrix(array2D);