// Задача 58: Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.

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

int[,] Multiplication(int[,] a, int[,] b)
{
    int[,] r = new int[a.GetLength(0), b.GetLength(1)];
    if (a.GetLength(1) != b.GetLength(0)) 
    {
        Console.WriteLine("!!!!!!!!!!!Матрицы нельзя перемножить!!!!!!!!!!");
        return r;
    }
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
            for (int k = 0; k < b.GetLength(0); k++)
            {
                r[i, j] += a[i, k] * b[k, j];
            }
        }
    }
    return r;
}

Console.WriteLine("Введите размерность первой матрицы: ");
int row = Convert.ToInt32(Console.ReadLine());
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix1= CreateMatrixRndInt(row, column, 0 , 10);

Console.WriteLine("Введите размерность второй матрицы: ");
row = Convert.ToInt32(Console.ReadLine());
column = Convert.ToInt32(Console.ReadLine());
int[,] matrix2= CreateMatrixRndInt(row, column, 0 , 10);

Console.WriteLine("\n Первая матрица 1:");
PrintMatrix(matrix1);
Console.WriteLine("\n Вторая Матрица 2:");
PrintMatrix(matrix2);
Console.WriteLine("\nМатрица 3 = 1 * 2:");
int[,] matrix3 = Multiplication(matrix1, matrix2);
PrintMatrix(matrix3);