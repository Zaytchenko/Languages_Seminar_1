// Задайте одномерный массив из 123 случайных чисел. 
//Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

const int SIZE = 123;
const int LEFT_RANGE = 0;
const int RIGHT_RANGE = 500;

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

int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if ((array[i] >= 10) && (array[i] <= 99))
    {
        count += 1;
    }
}
System.Console.WriteLine("Кол-вo эл-тов в заданном диапазоне = " + count);