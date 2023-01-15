// сделать массив 8 элементо вс 0 и 1 рендом
int[] FillArray(int size)
{
    int[] array = new int[size];
    // Random rnd = new Random();
    for (int i = 0; i < array.Length;i++)
    {
        array[i]=new Random().Next(0,2);
    }
    return array;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}
int[] arr = FillArray(8);
PrintArray(arr);