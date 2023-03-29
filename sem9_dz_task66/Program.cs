/*
Задача 66: 
Задайте значения M и N. 
Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
*/


int ReadDataToInt(string msg)
{
    Console.Write(msg);
    return (int.Parse(Console.ReadLine() ?? "0"));
}


int SumRecRange(int m, int n)
{
    if (m == n)
    {
        return n;
    }
    else
    {
        return m + SumRecRange(m + 1, n);
    }
}


void PrintAnswer(string explain, int num)
{
    Console.WriteLine("\n" + explain + num);
}


int num1 = ReadDataToInt("Введите номер, чтобы начать : ");
int num2 = ReadDataToInt("Введите номер для завершения: ");

int sum = num1 < num2 ? SumRecRange(num1, num2) : SumRecRange(num2, num1);
PrintAnswer("Сумма ровна = ", sum);