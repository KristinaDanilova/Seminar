int [] GetArray(int size, int minValue, int maxValue)
{
    int [] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int ElementsCount(int[] arr)
{
    int counter = 0;
    foreach (var item in arr)
    {
        if (item >= 10 && item <= 99)
        counter++;
    }
    return counter;
}

// если поставить диапазон от 10 до 99, тогда все попадут
int[] myArray = GetArray(123, -100, 100);
Console.WriteLine(String.Join(" ", myArray));

int result = ElementsCount(myArray);

Console.WriteLine($"Количество чисел из диапазона: {result}");