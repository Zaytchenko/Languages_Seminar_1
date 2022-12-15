// Принимает на вход число А и выдает сумму чисел от 1 до А.
Console.Clear();
int DataEntry(string str)
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int FindSum(int num)
{
    //пишем цикл от 1 до А
    //суммируем каждый иттератор

    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        sum = sum + i;
    }
    return sum;
}
//получить число
int number = DataEntry("Введите число А: ");
int result = FindSum(number);
Console.WriteLine("Сумма всех чисел до А =" + result);