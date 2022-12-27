// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит 
//строку и столбец, на пересечении которых расположен наименьший элемент массива.


void FindeIntersectionRowAndColumMinimumOfArray(int[,] arr)
{
    int minRow = 0;
    int minColumn = 0;
    int min = arr[0, 0];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 1; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] < min)
            {
                min = arr[i, j];
                minRow = i;
                minColumn = j;
            }
        }
    }
    System.Console.WriteLine(minRow + " " + minColumn);
    FillNewArray(arr, minRow, minColumn);
}

void FillNewArray(int[,] matrix, int minRow, int minColumn)
{
    int k = 0;
    int l = 0;
    int row = matrix.GetLength(0)-1;
    int column = matrix.GetLength(1)-1;
    int[,] arr = new int[row, column];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (i == minRow)
            continue;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j == minColumn)
                continue;
            arr[k, l] = matrix[i, j];
            l++;
        }
        k++;
        l=0;
    }
    PrintArray(arr);
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
FindeIntersectionRowAndColumMinimumOfArray(matrix);
//PrintArray(array);