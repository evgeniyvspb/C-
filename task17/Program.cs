﻿// на вход х и у не равные 0 у определеить четверть плоскости

Console.WriteLine("Введите координаты точки");
Console.Write("X:");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y:");
int y = Convert.ToInt32(Console.ReadLine());

int quarter = Quarter(x,y);
string result = quarter >0
        ? $"Указанные коодинаты соответствуют четверти {quarter}"
        : "Введены некоректные координаты";

Console.WriteLine(result);

int Quarter(int xc, int yc)
{
    if (xc > 0 && yc > 0) return 1;
    if (xc < 0 && yc > 0) return 2;
    if (xc < 0 && yc < 0) return 3;
    if (xc > 0 && yc < 0) return 4;
    return 0;
}
