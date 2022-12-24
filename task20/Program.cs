//задача 20
// найти длтнну отрезка

int InsertPosition(string text)
{
    Console.WriteLine(text);
    int pos = Convert.ToInt32(Console.ReadLine());
    return pos;
}

int x1 = InsertPosition("Введите кооржинаты X первой точки:");
int y1 = InsertPosition("Введите кооржинаты Y первой точки:");
int x2 = InsertPosition("Введите кооржинаты X второй точки:");
int y2 = InsertPosition("Введите кооржинаты Y второй точки:");

double LenghtLine(int xpos1, int xpos2, int ypos1, int ypos2)
{
    int temp = (xpos1 - xpos2) * (xpos1 - xpos2) +
    (ypos1 - ypos2) * (ypos1 - ypos2);
    return Math.Sqrt(temp);
}

double res = LenghtLine(x1, x2, y1, y2);
double resRound = Math.Round(res, 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между точками равно : {resRound}");