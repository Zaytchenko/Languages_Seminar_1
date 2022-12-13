// по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
Console.Clear();

int QuartEntry(string str)
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

void Quarter(int quart)
{
    if (quart==1)Console.WriteLine ("x>0: y>0");
    if (quart==2)Console.WriteLine ("x<0: y>0");
    if (quart==3)Console.WriteLine ("x<0: y<0");
    if (quart==4)Console.WriteLine ("x>0: y<0");
}


int quart = QuartEntry("Введите четверть: ");
Quarter(quart);