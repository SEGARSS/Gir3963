/*
Задача №16
Напишите программу, 
которая принимает на вход два числа и проверяет, 
является ли одно число квадратом другого.
*/
Console.WriteLine("Введите два числа: ");
Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine()??"0");
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine()??"0");
void SqeaTest(int a, int b)
{
    if (a == b*b)
    {
        Console.WriteLine($"Число {a} квадрат числа {b} ");
    }
    else
    {
        Console.WriteLine($"Число {a} не квадрат числа {b} ");
    }
}
SqeaTest(a,b);
SqeaTest(b,a);
