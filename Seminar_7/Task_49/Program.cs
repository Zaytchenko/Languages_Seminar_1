// Задайте двумерный массив. Найдите элементы, у которых оба индекса четные
//и замените эти элементы на их квадраты
Console.Clear();

int[,] Square(int[,] array)
{
    for (int i = 2; i < array.GetLength(0); i = i + 2)
    {
        for (int j = 2; j < array.GetLength(1); j = j + 2)
        {
            array[i, j] *= array[i, j];
        }
       }
       return array;
}



void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($" {array[i, j]} ");
        }
        System.Console.WriteLine();
    }
}


int[,] CreateRandomArray(int rows, int columns, int leftRange, int rightRange)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(leftRange, rightRange);
        }
    }
    return array;
}

int DataEntry(string message)
{
    System.Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

//получить от пользователя M и N
int m = DataEntry("Введите M: ");
int n = DataEntry("Введите N: ");
//создаем и заполняем двумерный массив
int[,] matrix = CreateRandomArray(m, n, 1, 10);
//вывести на экран
PrintArray(matrix);
matrix = Square(matrix);
System.Console.WriteLine();
PrintArray(matrix);