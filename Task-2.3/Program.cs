﻿// принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

Console.Clear();

Console.Write("Введите число: ");

int number = int.Parse(Console.ReadLine());

if (number % 7 == 0 && number % 23 == 0)
{
    Console.WriteLine ($"{number} число кратное и 7 и 23");
}
else
{
    Console.WriteLine ($"{number} число не кратное и 7 и 23");
}