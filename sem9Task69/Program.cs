/*
Задача 69:
Напишите прграмму, которая будет принимать 2 числа А и В
возыедите А в степень В с помощью рекурсии.
*/



int ReadDataToInt(string msg)
{
    Console.Write(msg);
    return (int.Parse(Console.ReadLine() ?? "0"));
}


long RecPow(int a, int b)
{
    if (b <= 1)
    {
        return a;
    }
    else
    {
        return a * (RecPow(a, b - 1));
    }
}

long MyPow(int a, int b)
{
    if (b == 2)
    {
        return 4;
    }
    return MyPow(a, b / 2) * MyPow(a, b / 2);
}

int a = ReadDataToInt("Войдите на базу : ");
int b = ReadDataToInt("Войдите в режим питания: ");

Console.WriteLine();

Console.WriteLine(RecPow(a, b));
Console.WriteLine(MyPow(a, b));