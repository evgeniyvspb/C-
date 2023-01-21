﻿// Задача 36: Задайте одномерный массив, заполненный
// случайными числами. Найдите сумму элементов, стоящих
// на нечётных позициях
 
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
 
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
 
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length-1) Console.Write(array[i]+",");
        else Console.Write(array[i]);
 
    }
    Console.Write("]");
}
 
int SummaNech(int[] arr)
{
    int summa = 0;
    for (int i = 1; i < arr.Length; i=i+2)
    {
        summa = summa + arr[i];
    }
    return summa;
}
 
int[] array = CreateArrayRndInt(10,-99,99);
int sum = SummaNech(array);
PrintArray(array);
Console.Write($" -> {sum}");