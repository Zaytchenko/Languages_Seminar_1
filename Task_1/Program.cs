Console.Clear();
Console.Write("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("ВВедите второе число: ");
int numberB = int.Parse(Console.ReadLine());

int square = numberB * numberB;
//Console.Write($"Квадрат числа {number} равен {square}");
if (numberA == square)
{
Console.Write($"Первое число {numberA} является квадратом второго число {numberB}");
 }   
else
{
Console.Write($"Первое число {numberA} не является квадратом второго числа {numberB}");
 }
