/*
Задача №61
Вывести первые N строк треугольника Паскаля. 
Сделать вывод в виде равнобедренного треугольника
*/


int ReadDataToInt(string msg)
{
    Console.Write(msg);
    string inStr = Console.ReadLine() ?? "0";

    inStr = inStr.Replace(',', '.');

    return (int.Parse(inStr));
}

long Factorial(int n)
{
    long res = 1;

    for (int i = 1; i <= n; i++)
        res = res * i;

    return res;
}

//      1
//     1 1
//    1 2 1
void PrintPascaleTriangle(int nRow)
{
    for (int i = 0; i < nRow; i++)
    {
        for (int k = 0; k < nRow - i; k++)
            Console.Write(" ");
        for (int j = 0; j <= i; j++)
        {
            Console.Write(" ");
            Console.Write(Factorial(i) / (Factorial(j) * Factorial(i - j)));
        }
        Console.WriteLine();
    }
}

Console.Clear();

int countRaw = ReadDataToInt("Введите количество строк треугольника Паскаля: ");
Console.WriteLine();
PrintPascaleTriangle(countRaw);
Console.WriteLine();
