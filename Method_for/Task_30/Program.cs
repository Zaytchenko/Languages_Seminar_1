// Выводит массив из N элементов, заполненный нулями и единицами в случайном порядке

Console.Clear();


int ArrayLengthEntry(string str)
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}



void FillArray(int[] array)
{
    int number = array.Length;
    for ( int i = 0; i < number; i++)
    {
     array[i] = new Random().Next(2);   
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    for (int j = 0; j < count; j++)
    {
        Console.Write(col[j]);
    }
}
int number = ArrayLengthEntry("Введите размер массива: ");
int [] array = new int[number];
FillArray(array);
PrintArray(array);
//Console.WriteLine();
