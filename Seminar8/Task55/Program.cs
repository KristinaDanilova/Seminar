// Напишите программу, которая заменяет строки на столбцы. 
// Если это невозможно, пограмма должна вывести смс для пользователя.

int[,] GetMatrix(int rows, int columns, int start, int end)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(start, end + 1);
        }
    }
    return result;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] SwapRowsAndColumns(int[,] array)
{
    int[,] tempArray = new int[array.GetLength(0), array.GetLength(1)];
    if (array.GetLength(0) == array.GetLength(1))
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                tempArray[j, i] = array[i, j];
            }
        }
        return tempArray;
    }
    else
    {
        Console.WriteLine("Замена невозможна");
        return array;
    }
}
Console.WriteLine("Введите количество строк: ");
int arrayRows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int arrayColumns = int.Parse(Console.ReadLine());
Console.WriteLine("Введите начало диапазона: ");
int arrayStart = int.Parse(Console.ReadLine());
Console.WriteLine("Введите конец диапазона: ");
int arrayEnd = int.Parse(Console.ReadLine());
int[,] newMatrix = GetMatrix(arrayRows, arrayColumns, arrayStart, arrayEnd);
PrintMatrix(newMatrix);
int[,] changedArray = SwapRowsAndColumns(newMatrix);
Console.WriteLine();
PrintMatrix(changedArray);

