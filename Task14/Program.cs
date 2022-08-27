// Напишите программу, которая принимает на вход число
// и проверяет, кратно ли оно одновременно 7 и 23.

Console.WriteLine("Введите число: ");
int num1 = int.Parse(Console.ReadLine());

if(num1 % 7 == 0 && num1 % 23 == 0)
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine($"Не кратно");
}
