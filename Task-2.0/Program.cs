// выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа
Console.Clear();
int random = new Random().Next(10, 100);
Console.WriteLine("Случайное число: " +random);
int numberEnd = random %10;
int numberOne = random /10;
Console.WriteLine("Первая цифра числа: " +numberOne);
Console.WriteLine("Последняя цифра числа: " +numberEnd);
int max = numberOne;
if (numberEnd > numberOne) max = numberEnd;
Console.WriteLine("Максимальная цифра числа: " +max);