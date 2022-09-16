// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали.

void FillArray(int[,] collection)
{
    for (int rows = 0; rows < collection.GetLength(0); rows++)
    {
        for (int cols = 0; cols < collection.GetLength(1); cols++)
        {
            collection[rows, cols] = new Random().Next(0, 100000);
        }
    }
}

void PrintArray(int[,] collection1)
{
    for (int rows = 0; rows < collection1.GetLength(0); rows++)
    {
        for (int cols = 0; cols < collection1.GetLength(1); cols++)
        {
            Console.Write($" {collection1[rows, cols]}\t");
        }
        Console.WriteLine();
    }
}

void DiagonalArrayElementsSum(int[,] collection2)
{
    int diagonalPosition = 0;
    int Summ = 0;
    int value = diagonalPosition;
    for (value = 0; value < collection2.GetLength(0); value++)
    {
        {
            Summ = Summ + collection2[value, value];
        }
        Console.WriteLine($"Сумма диагональных элементов массива равна {Summ}");
    }
}
Console.WriteLine("Введите размерность массива");
int size = int.Parse(Console.ReadLine());

Console.WriteLine();
if (size < 2) Console.WriteLine("Неверный ввод");
else
{
    int[,] array = new int [size, size];
    FillArray (array);
    PrintArray (array);
    Console.WriteLine();
    DiagonalArrayElementsSum (array);
    Console.WriteLine();
}
