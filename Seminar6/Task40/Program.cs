// Принимает 3 числа и проверяет,
// может ли существовать треугольник со сторонами такой длины

bool Triangle(int a, int b, int c)
{
    return (a < b + c && b < a + c && c < b + a);
}

Console.Write("Введите сторону а: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите сторону b: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите сторону c: ");
int num3 = Convert.ToInt32(Console.ReadLine());
Triangle(num1, num2, num3);
if (Triangle(num1, num2, num3)) Console.WriteLine("Может сушествовать");
else Console.WriteLine("Не может существовать");
