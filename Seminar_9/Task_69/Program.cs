//Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)


int AddNumber(string str)
{
    System.Console.WriteLine(str);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int PowerNumbers (int num, int power)
{
   
    if (power <= 0) return 1;
    return PowerNumbers(num, power-1) * num;
}

int a = AddNumber("ВВедите число A ");
int b = AddNumber("ВВедите число B ");
System.Console.WriteLine(PowerNumbers(a, b));