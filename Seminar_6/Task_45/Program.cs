// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования
Console.Clear();

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
const int size = 5;
const int leftRange = 3;
const int rightRange = 5;

int[] CopyOfArray1(int[] arr)
{
    int[] array2 = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
       array2[i] =arr[i];
    }
    return array2;
}

int[] array1 = FillArrayWithRandomNumbers(5,3,5);
System.Console.WriteLine("["+ string.Join(" ", array1) + "]");
int[] array2 = CopyOfArray1(array1);
System.Console.WriteLine("["+ string.Join(" ", array2) + "]");