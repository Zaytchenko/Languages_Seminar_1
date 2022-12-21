// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
//45 -> 101101
//3 -> 11
//2 -> 10
Console.Clear();
int DataEntry(string str)
{
    System.Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}


void GetBinaryView(int number)
{
    if (number <= 0)
    {
        return;
    }
    GetBinaryView(number/2);
    System.Console.Write(number%2);
}

int number = DataEntry("Введите число");
GetBinaryView(number);