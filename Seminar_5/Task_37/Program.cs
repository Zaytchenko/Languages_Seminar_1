// произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//Результат запишите в новом массиве.

const int SIZE = 11;
const int LEFT_RANGE = 0;
const int RIGHT_RANGE = 100;

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

int[] newArray = new int[SIZE / 2 + SIZE % 2];
for (int i = 0; i < SIZE / 2; i++)
{
    newArray[i] = array[i] * array[array.Length - 1 - i];
}

if (array.Length % 2 != 0)
{
    newArray[newArray.Length - 1] = array[array.Length / 2];
}
Console.WriteLine('[' + string.Join(", ", newArray) + ']');