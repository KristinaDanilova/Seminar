// Задайте двумерный массив. Напишите программу, которая поменяет местами 1 и последнюю строку массива.

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

int[,] SwapFirstAndLastRow (int[,] array) 
{
    int LastRowIndex = array.GetLength(0) - 1;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int temporary = array[0, i];
        array[0, i] = array[LastRowIndex, i];
        array[LastRowIndex, i] = temporary;
    }
    return array;
}

int[,] MyArray = GetArray(5, 6, 1, 9);
PrintArray(MyArray);
Console.WriteLine();
SwapFirstAndLastRow(MyArray);
PrintArray(MyArray);