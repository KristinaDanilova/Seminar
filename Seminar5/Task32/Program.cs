// замена элементов массива: положительные элементы заменить на отриц.; наоборот

int [] GetArray(int size, int minValue, int maxValue)
{
    int [] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

void ChangeArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = -arr[i];
    }
}

int[] myArray = GetArray(10, -10, 10);
Console.WriteLine(String.Join(" ", myArray));

ChangeArray(myArray);
Console.WriteLine(String.Join(" ", myArray));

