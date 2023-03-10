/*
Задача №55
Задайте двумерный массив. 
Напишите программу, 
которая заменяет строки на столбцы. 
В случае, если это невозможно, 
программа должна вывести сообщение для пользователя.
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


void TransposeArray(int[,] arr)
{
    int temp = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = i + 1; j < arr.GetLength(1); j++)
        {
            temp = arr[i, j];
            arr[i, j] = arr[j, i];
            arr[j, i] = temp;
        }
    }
}

Console.Clear();

int rowNum = ReadDataToInt("Введите количество строк:    ");
int colNum = ReadDataToInt("Введите количество столбцов: ");

Console.WriteLine();
int[,] testArr = Gen2DArr(rowNum, colNum, 10, 99);
Print2DArr(testArr);

if (testArr.GetLength(0) == testArr.GetLength(1))
{
    TransposeArray(testArr);
    Console.WriteLine();
    Print2DArr(testArr);
}
else
{
    Console.WriteLine("Матрица не квадратная!");
}

Console.WriteLine();
Print2DArr(testArr);