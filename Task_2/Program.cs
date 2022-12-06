Console.Clear();

Console.Write("Введите номер дня недели: ");

int number = int.Parse(Console.ReadLine());

string[] day = new string[8];
day[0] = "Ну, давайте серьезно!";
day[1] = "Понедельник";
day[2] = "Вторник";
day[3] = "Среда";
day[4] = "Четверг";
day[5] = "Пятница";
day[6] = "Суббота";
day[7] = "Врскресенье";
Console.Write($"День {number} это- {day[number]}");