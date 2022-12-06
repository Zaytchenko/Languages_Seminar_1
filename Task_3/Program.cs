/*Напишите программу, которая на вход принимает одно число (N), 
а на выходе показывает все целые числа в промежутке от -N до N.
*/
Console.Clear();

Console.Write("Введите число N: ");

int number = int.Parse(Console.ReadLine());
int count = 0;
if(number > 0)
{
count = number*(-1);
    while (count <= number)
    {
        Console.Write($"{count}, ");
        count++;
    }
}
else
{
    count=number;
    while (count<= number*(-1))
    {
     Console.Write($"{count}, ");
    count++;
    }
}