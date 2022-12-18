// Задать массив из 12-ти элементов,заполненный случайными числами из промежутка [-9;9]
//найдите сумму положительных и атрицательных элементов массива.

const int SIZE = 12;
const int LEFT_RANGE = -9;
const int RIGHT_RANGE = 9;

int[] array = new int[SIZE];

int sumPozitive = 0;
int sumNegative = 0;


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

void SumpositiveAndNegative(int[] arr, out int sumP, out int sumN)
{
    sumP = 0;
    sumN = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            sumP += arr[i];
        }
        else
        {
            sumN += arr[i];
        }
    }
}

array = FillArrayWithRandomNumbers(SIZE, LEFT_RANGE, RIGHT_RANGE);
Console.WriteLine('[' + string.Join(", ", array) + ']');
SumpositiveAndNegative(array, out int sumP, out int sumN);


System.Console.WriteLine($"Сумма положительных элементов = {sumP}");
System.Console.WriteLine($"Сумма отрицательных элементов = {sumN}");
