// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
//N = 5 -> "1, 2, 3, 4, 5"

int number = 10;
int count = 1;
void NumberPlus(int number, int count)
{
    if (count <= number)
    {
        System.Console.Write($"{count}, ");
        count++;
        NumberPlus (number, count);
    }
    
    }


NumberPlus(number, count);