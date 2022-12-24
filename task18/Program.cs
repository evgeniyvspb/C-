// по номеру четверти показываем диапозон возможных координат точек в четвергти х и у


Console.WriteLine("Введите номер четверти");
int x = Convert.ToInt32(Console.ReadLine());

string quarter = Quarter(x);
string result = quarter;
if (x > 4 && x < 1) Console.WriteLine($"Указанному номеру четверти соответствуют коодинаты {quarter}");
else Console.WriteLine(result);

string Quarter(int xc)
{
    if (xc == 1) return "xc > 0 и yc > 0";
    if (xc == 2) return ("xc < 0 и yc > 0");
    if (xc == 3) return ("xc < 0 и yc < 0");
    if (xc == 4) return ("xc > 0 и yc < 0");
    return "Не является четвертью";
}