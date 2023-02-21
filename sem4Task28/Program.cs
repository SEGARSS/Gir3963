/*
Задача №28
Напишите программу, 
которая принимает на вход число N 
и выдаёт произведение чисел от 1 до N.
*/
// Один вариант

// Console.Clear();
// int ReadData(string WrDate)
// {
//     Console.WriteLine(WrDate);
//     int result = int.Parse(Console.ReadLine() ?? "0");
//     return result;
// }
// int number = ReadData("Введите число");
// long fact = 1;
// for (int x = 1; x <= number; x++)
// {
// fact *= x;
// }
// Console.WriteLine(fact);

// Второй вариант

// int ReadData(string msg)
// {
//     Console.Write(msg);
//     return(int.Parse(Console.ReadLine()??"0"));
// }
// void PrintAnswer(string explain, int num)
// {
//     Console.WriteLine(explain + num);
// }
// long FactSimple(int num)
// {
//     long sum = 1;
//     for (int i=2; i<=num; i++)
//     {
//         sum*=i;
//     }   
//     return sum;
// }
// int num = ReadData("Enter a value: ");
// Console.WriteLine($"The factorial of the value: {FactSimple(num)}");

// Третий вариант и самый верный

using System.Numerics;

int ReadInputInt(string mess)
{
    Console.Write(mess);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}
void WriteMess(string mess)
{
    Console.WriteLine(mess);
}

BigInteger FactorialCalc(BigInteger numer)
{   
    BigInteger fact = 1;

    for(int i = 2; i<= numer; i++)
    {
        fact *= i;
    }

    return fact;
}

int num = ReadInputInt("Введите число: ");

WriteMess($"{num}! = {FactorialCalc(num)}");