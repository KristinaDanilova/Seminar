﻿// Выведите первые N чисел Фибоначчи (0 и 1)
// Если N=5 -> 0 1 1 2 3

int[] Fibonacci (int num)
{
    int[] fArray = new int[num];
    fArray[0] = 0;
    fArray[1] = 1;
    for (int i = 2; i < num; i++)
    {
        fArray[i] = fArray[i - 2] + fArray[i - 1];
    }
    return fArray;
}

Console.Write("Введите число: ");
int fibNum = Convert.ToInt32(Console.ReadLine());
if (fibNum >= 2) Console.WriteLine(String.Join(" ", Fibonacci(fibNum)));
else if (fibNum == 1) Console.WriteLine("1");
else Console.WriteLine("Нет последовательности");