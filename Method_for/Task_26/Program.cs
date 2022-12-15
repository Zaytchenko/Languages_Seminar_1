// принимает на вход число и выдает количество цифр в числе

Console.Clear();

int DataEntry(string str)
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}


int FindDischarge(int number)
{
int i;
for (i = 0; number != 0; i++)
{
 number = number / 10; 
}
return i;
}
int number = DataEntry("Введите число А: ");
int discharge = FindDischarge(number);

Console.Write($"В числе {number} -> {discharge} знаков");