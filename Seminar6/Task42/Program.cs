// Преобразовывать десятичное число в двоичное

string Binary(int num)
{
    string binaryNum = String.Empty;
    while (num > 0)
    {
        if (num % 2 == 1) binaryNum += "1";
        else binaryNum += "0";
        num /= 2;
    }
    return binaryNum;
}

Console.WriteLine("Введите число: ");
int decNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Binary(decNum));