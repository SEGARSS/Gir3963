﻿/*
Задача №40
Напишите программу, 
которая принимает на вход три числа и проверяет, 
может ли существовать треугольник с сторонами такой длины.
*/

int ReadInputInt(string mess)
{
    Console.Write(mess);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}

//Метод для вывода данных
void WriteMess(string mess)
{
    Console.WriteLine(mess);
}

bool Test(int a, int b, int c)
{
    if (a <= b + c) return true;
    else return false;
}
//if triangle with such sides exists
bool TriungleTest(int a, int b, int c)
{
    if (Test(a, b, c) && Test(b, a, c) && Test(c, a, b)) return true;
    else return false;
}

int numA = ReadInputInt("Введите сторону a: ");
int numB = ReadInputInt("Введите сторону b: ");
int numC = ReadInputInt("Введите сторону c: ");

WriteMess(TriungleTest(numA, numB, numC) ? "Равно" : "Не равно");
