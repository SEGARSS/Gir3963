/*
Задача №22
Напишите программу, 
которая принимает на вход число (N) 
выдаёт таблицу квадратов чисел от 1 до N.
*/

/*Вариант без метода
using System;
class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Введите число N");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
            Console.WriteLine("{0}^2 = {1}", i, i * i);
        Console.ReadKey(true);
    }
}
*/

//Вариант с методом


