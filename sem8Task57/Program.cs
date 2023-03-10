/*
Задача №57
Составить частотный словарь элементов двумерного массива. 
Частотный словарь содержит информацию о том, 
сколько раз встречается элемент входных данных.
*/


int ReadDataToInt(string msg)
{
    Console.Write(msg);
    return (int.Parse(Console.ReadLine() ?? "0"));
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

void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++) Console.Write($"{arr[i]}, ");
    Console.WriteLine($"{arr[arr.Length - 1]}]");
}

int[] FreqDicBuild(int[,] arr, int len)
{
    int[] dic = new int[len];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            dic[arr[i, j]]++;
        }
    }

    return dic;
}
Console.Clear();

int rowNum = ReadDataToInt("Введите количество строк:    ");
int colNum = ReadDataToInt("Введите количество столбцов: ");

Console.WriteLine();
int[,] testArr = Gen2DArr(rowNum, colNum, 0, 9);
Print2DArr(testArr);

Console.WriteLine();
Print1DArr(FreqDicBuild(testArr, 10));