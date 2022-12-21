// принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
//Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

Console.Clear();
int DataEntry(string str)
{
    System.Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

void SumSidesOfTriangle(int a, int b, int c)
{
    if (a + b > c && b + c > a && a + c > b)
    {
        System.Console.WriteLine("Да");
    }
    else
    {
        System.Console.WriteLine("Нет");
    }
}
int a = DataEntry("Введите длину стороны a: ");
int b = DataEntry("Введите длину стороны b: ");
int c = DataEntry("Введите длину стороны c: ");
SumSidesOfTriangle(a, b, c);