//  Напишите программу, которая будет принимать на вход два числа 
//и выводить, является ли второе число кратным первому. 
//Если число 2 не кратно числу 1, то программа выводит остаток от деления.
//34, 5 -> не кратно, остаток 4
//16, 4 -> кратно
Console.Clear();
Console.Write("Bвeдите первое число: ");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Bвeдите второе число: ");
int number2 = int.Parse(Console.ReadLine());

int remains = number2 % number1;

if (remains == 0)
{
    Console.WriteLine("кратно");
}
else
    Console.WriteLine($"не кратно, остаток {remains}");
