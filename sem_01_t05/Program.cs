/*
Задача №4
Напишите программу, 
которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
*/

Console.Write("Введите число: ");
var number = Convert.ToInt32(Console.ReadLine());

if (number > 0 && number <100)
{
    Console.WriteLine(number%10);
}
else
Console.WriteLine("Введено не то число");
