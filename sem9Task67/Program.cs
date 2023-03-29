/*
Задача 67
принимает на вход число и возвращает сумму цифр числа
*/


int ReadDataToInt(string msg)
{
    Console.Write(msg);
    return (int.Parse(Console.ReadLine() ?? "0"));
}

int RecSumDigits(int num)
{
    if (num == 0) return 0;
    else return num % 10 + RecSumDigits(num / 10);
}


int num = ReadDataToInt("Введите число, чтобы вычислить количество его цифр: ");

Console.WriteLine();
Console.WriteLine(RecSumDigits(num));