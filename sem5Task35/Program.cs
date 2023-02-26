﻿/*
Задача №35
Задайте одномерный массив из 123 случайных чисел. 
Найдите количество элементов массива, 
значения которых лежат в отрезке [10,99].
*/

int[] Gen1DArr(int len, int min, int max)
{
    if (min > max) 
    {
        int temp = min;
        min = max;
        max = temp;
    }

    int[] arr = new int[len];

    for (int i = 0; i < len; i++) arr[i] = new Random().Next(min, max + 1);

    return arr;
}

void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++) Console.Write($"{arr[i]}, ");
    Console.WriteLine($"{arr[arr.Length - 1]}]");
}

void PrintAnswer(string explain, int num)
{
    Console.WriteLine(explain + num);
}


int NumElemInRange(int[] arr, int bottom, int top)
{
    if(bottom>top)
    {
        int temp = bottom;
        bottom = top;
        top = temp;
    }

    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]>=bottom && arr[i]<=top) count++;
    }
return count;
}


int[] testArr = Gen1DArr(123,-1000,1000);
Print1DArr(testArr);

PrintAnswer("Number of elements in the range: ", NumElemInRange(testArr, 10, 99));
