// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

int Max(int n1, int n2)
{
    if (n1 > n2) return n1;
    return n2;
}


int Min(int n1, int n2)
{
    if (n1 < n2) return n1;
    return n2;
}

Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Большее число: " + Max(num1, num2));
Console.WriteLine("Меньшее число: " + Min(num1, num2));
