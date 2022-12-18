//  принимает на вход два числа и проверяет, является ли одно число квадратом другого
Console.Clear();

Console.Write("Bвeдите первое число: ");
int number1 = int.Parse(Console.ReadLine());

Console.Write("Bвeдите второе число: ");
int number2 = int.Parse(Console.ReadLine());
if (number1 == number2 * number2)
{
    Console.WriteLine($"{number1} является квадратом {number2}");
}
else
{

    if (number2 == number1*number1)

    {
        Console.WriteLine($"{number2} является квадратом {number1}");
    }
    else
    {
        Console.WriteLine($" ни одно число не является квадратом другого");
    }
} 

