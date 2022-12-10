//  выводит случайное трехзначное число и удаляет вторую цифру этого числа
Console.Clear();
int random = new Random().Next(100, 1000);
Console.WriteLine("Случайное число: " +random);
int result = (random /100)*10 + random %10;
Console.WriteLine(random + "->" + result);
