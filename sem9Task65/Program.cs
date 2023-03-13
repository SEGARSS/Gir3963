/*
Задача 65
Задайте значения M и N.
Напишите программу, 
которая найдёт все натуральные элементы в промежутке от M до N.
*/


int ReadDataToInt(string msg)
{
    Console.Write(msg);
    return (int.Parse(Console.ReadLine() ?? "0"));
}

string LineGenRecRange(int m, int n)
{
    string res = string.Empty;
    if (m >= n)
    {
        res = " " + n.ToString();
    }
    else
    {
        res = res + " " + m + LineGenRecRange(m + 1, n);
    }
    return res;
}


int num1 = ReadDataToInt("Введите номер, чтобы начать : ");
int num2 = ReadDataToInt("Введите номер для завершения: ");

Console.WriteLine();

string numbers = num1 < num2 ? LineGenRecRange(num1, num2) : LineGenRecRange(num2, num1);
Console.WriteLine(numbers);