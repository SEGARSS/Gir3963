/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
*/


int ReadDataToInt(string msg)
{
    Console.Write(msg);
    return (int.Parse(Console.ReadLine() ?? "0"));
}


int[,] FillSquareSpiral(int countSide)
{
    int[,] arr = new int[countSide, countSide];

    int limLft = 0;
    int limRgt = countSide - 1;
    int value = 1;

    for (int circ = 0; circ < countSide / 2; circ++)
    {
        int adjustValue = countSide - 2 * circ - 1; 

        for (int i = limLft; i < limRgt; i++)
        {
            arr[limLft, i] = value;
            arr[i, limRgt] = value + adjustValue;
            value++;
        }
        value += adjustValue;

        for (int i = limRgt; i > limLft; i--)
        {
            arr[limRgt, i] = value;
            arr[i, limLft] = value + adjustValue;
            value++;
        }
        value += adjustValue;

        limLft++;
        limRgt--;
    }

    if (countSide % 2 == 1) arr[countSide / 2, countSide / 2] = value;

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


Console.Clear();

int sideLen = ReadDataToInt("Введите размер для стороны квадрата: ");
Console.WriteLine();

int[,] spiral = FillSquareSpiral(sideLen);
Print2DArr(spiral);