/*
Задача 4: 
Напишите программу, 
которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.Write("Введите первое число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int B = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int C = Convert.ToInt32(Console.ReadLine());
int max = A;
if (B > max)
{
    max = B;
}
if (C > max)
{
    max = C;
}
Console.Write("Наибольшее из введённых чисел = ");
Console.Write(max);