﻿/*
Задача 64: 
Задайте значение N. 
Напишите программу, 
которая выведет все натуральные числа в промежутке от 1 до N. 
Выполнить с помощью рекурсии.
*/


int ReadDataToInt(string msg)
{
    Console.Write(msg);
    return (int.Parse(Console.ReadLine() ?? "0"));
}


void LineGenRec(int numStart, int numFinish)
{
    if (numStart >= numFinish)
        Console.Write(numStart);
    else
    {
        Console.Write($"{numStart}, ");
        LineGenRec(numStart + 1, numFinish);
    }
}

int num = ReadDataToInt("Введите значение: ");

LineGenRec(1, num);
Console.WriteLine();