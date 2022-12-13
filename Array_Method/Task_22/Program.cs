// принимает на вход число (N) и выдаёт таблицу квадратов чисел
//от 1 до N.

Console.Clear();

void TableOfPow2(string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    int count = 1;
    while (count <= number)
    {
        int pow2 = count * count;
        Console.Write(pow2 +" ");
        count++;
    }
    Console.WriteLine();
}
TableOfPow2("Введите число N: ");


