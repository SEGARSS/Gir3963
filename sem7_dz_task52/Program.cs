/*
Задача 52. 
Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
*/


int ReadDataToInt(string msg)
{
    Console.Write(msg);
    string inStr = Console.ReadLine() ?? "0";

    inStr = inStr.Replace(',', '.');

    return (int.Parse(inStr));
}


int[,] Gen2DArr(int countRow, int countCol, int min, int max)
{
    if (min > max) 
    {
        int temp = min;
        min = max;
        max = temp;
    }

    int[,] arr = new int[countRow, countCol];

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countCol; j++)
        {
            arr[i, j] = new Random().Next(min, max + 1);
        }
    }
    return arr;
}


void Print2DArr(int[,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}\t");
        }
        Console.WriteLine();
    }

}

double[] Mean2dArrCol(int[,] arr)
{
    double[] mean = new double[arr.GetLength(1)];

    for (int j = 0; j < arr.GetLength(1); j++)
    {
        int sum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum += arr[i, j];
        }
        mean[j] = (double)sum / arr.GetLength(0);
    }

    return mean;
}

void Print1DArrGreen(double[] arr, int RoundDgtNum)
{
    Console.ForegroundColor = ConsoleColor.Green;

    for (int i = 0; i < arr.GetLength(0); i++)
    {

        Console.Write($"{Math.Round(arr[i], RoundDgtNum)}\t");

    }
    Console.ResetColor();
    Console.WriteLine();
}


Console.Clear();

int rowNum = ReadDataToInt("Введите количество строк: ");
int colNum = ReadDataToInt("Введите количество столбцов: ");

Console.WriteLine();
int[,] testArr = Gen2DArr(rowNum, colNum, 10, 99);
Print2DArr(testArr);

Print1DArrGreen(Mean2dArrCol(testArr), 2);
Console.WriteLine();