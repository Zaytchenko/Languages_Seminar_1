// запрос координат
Console.Clear();
int DataEntryXY(string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}
void FindQandrat(int x, int y)
{
    if (x > 0 && y > 0) Console.WriteLine("Это первый квадрат");
    if (x < 0 && y > 0) Console.WriteLine("Это второй квадрат");
    if (x < 0 && y < 0) Console.WriteLine("Это третий квадрат");
    if (x > 0 && y < 0) Console.WriteLine("Это четвертый квадрат");
}




int x = DataEntryXY("Введите координаты X =");

int y = DataEntryXY("Введите координаты Y =");

FindQandrat(x, y);

