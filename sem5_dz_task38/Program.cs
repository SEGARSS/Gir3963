/*
Задача 38: 
Задайте массив вещественных чисел. 
Найдите разницу между максимальным 
и минимальным элементов массива.
*/

int ReadDataToInt(string msg)
{
    Console.Write(msg);
    return (int.Parse(Console.ReadLine() ?? "0"));
}

double[] Gen1DArrDbl(int len, int min, int max)
{
    if (min > max) 
    {
        int temp = min;
        min = max;
        max = temp;
    }

    double[] arr = new double[len];

    for (int i = 0; i < len; i++) arr[i] = new Random().Next(min, max) + new Random().NextDouble();

    return arr;
}

void Print1DArrDbl(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++) Console.Write($"{arr[i]}, ");
    Console.WriteLine($"{arr[arr.Length - 1]}]");
}

void InsertionSortDbl(double[] arr)
{
    double k;
    int j;

    for (int i = 1; i < arr.Length; i++)
    {
        k = arr[i];
        j = i - 1;

        while (j >= 0 && arr[j] > k)
        {
            arr[j + 1] = arr[j];
            arr[j] = k;
            j--;
        }
    }
}

int arrLng = ReadDataToInt("Введите количество элементов в массиве: ");
double[] arr = Gen1DArrDbl(arrLng, -100, 100);
Print1DArrDbl(arr); 

double[] arrSort = arr;
InsertionSortDbl(arrSort);
Console.WriteLine("\nМассив, отсортированный по способу вставки:");
Print1DArrDbl(arrSort);

Console.WriteLine("\nРазница между максимальными и минимальными элементами массива составляет: {0}", 
arrSort[arrLng-1]-arrSort[0]);