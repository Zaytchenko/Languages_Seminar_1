/*Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает последнюю цифру этого числа.
*/
Console.Clear();

Console.Write("Введите трехзначное число: ");

int number1 = int.Parse(Console.ReadLine());
int number2 = number1%10;
Console.WriteLine($"Магия! последняя цифра введенного числа: {number2} ");