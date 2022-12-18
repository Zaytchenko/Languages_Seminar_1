// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
Console.Clear();

int DataEntry(string str)
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

const int SIZE = 12;
const int LEFT_RANGE = -9;
const int RIGHT_RANGE = 9;

int[] array = new int[SIZE];


int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
{
    Random rand = new Random();
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1); //[-9;10)
    }
    return arr;
}

array = FillArrayWithRandomNumbers(SIZE, LEFT_RANGE, RIGHT_RANGE);
Console.WriteLine('[' + string.Join(", ", array) + ']');

int number = DataEntry("Введите число : ");
bool result = false;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] == number)
    {
        result = true;
        break;
    }
}
if (result)
{
    Console.WriteLine("в массиве есть такое число");
}
else
{
    Console.WriteLine("в массиве нет такого числа");
}