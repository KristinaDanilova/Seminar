

int [] GetArray(int size, int minValue, int maxValue)
{
    int [] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

bool IsExist(int number, int [] arr)
{
    foreach (var item in arr)
    {
        if (item == number)
        return true;
    }
    return false;
}

Console.Write("Число: ");
int number = int.Parse(Console.ReadLine());

int[] myArray = GetArray(30, -10, 10);
Console.WriteLine(String.Join(" ", myArray));

if (IsExist(number, myArray))
Console.WriteLine("Число найдено");
else
Console.WriteLine("Число не найдено");

