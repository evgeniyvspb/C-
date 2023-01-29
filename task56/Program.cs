// Задача 56: Задайте прямоугольный двумерный массив. Напишите
// программу, которая будет находить строку с наименьшей суммой элементов.

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

int SearchMinIndRow(int[,] matr)
{
    int sum=0; // сумма для прохода lzk сравнения
    int sumMin=0;
    int index = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum+=matr[i,j];
        }
        if (i==0) sumMin=sum;
        else if (sum<sumMin) 
        {
            sumMin=sum;
            index=i;
        }
        sum=0;
    }
    return index;
}

int[,] array2D = CreateMatrixRndInt(4,6,0,10);
PrintMatrix(array2D);
Console.WriteLine();
Console.Write("Строка с наименьшей суммой элементов это строка ");
Console.Write(SearchMinIndRow(array2D)+1);// Чтобы выводить не идекс строки а именно строку как указано в задании добавил 1
