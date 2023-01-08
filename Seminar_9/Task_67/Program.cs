//Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
//453 -> 12

int AddNumber(string str)
{
    System.Console.WriteLine(str);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int SumNumbers(int number, int sum)
{
    sum += number % 10;
    if (number > 0)
    {
        SumNumbers(number / 10, sum);
    }
    else System.Console.WriteLine(sum);
    return sum;
}

int sum = 0;
int number = AddNumber("ВВедите число");
sum = SumNumbers(number, sum);