// Задайте двумерный массив.
// Напишите программу, которая поменяет местами первую и последнюю строку массива.

int[,] ChangePlaceOfFirstAndEndRow(int[,] matrix)
{
    int temp = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        temp = matrix[0, i];
        matrix[0, i] = matrix[matrix.GetLength(0) - 1, i];
        matrix[matrix.GetLength(0) - 1, i] = temp;
    }
    return matrix;
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
ChangePlaceOfFirstAndEndRow(matrix);
System.Console.WriteLine();
PrintArray(matrix);