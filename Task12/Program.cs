// Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли второе число кратным первому. Если число 2 не кратно числу 1,
// то программа выводит остаток от деления.

Console.WriteLine("Введите первое число: ");
int a1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int a2 = int.Parse(Console.ReadLine());
int a3 = a1 % a2;

if(a3 == 0)
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine($"Не кратно. Остаток равен {a3}");
}
