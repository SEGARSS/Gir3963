/*
Задача №14
Напишите программу, 
которая принимает на вход число и проверяет, 
кратно ли оно одновременно 7 и 23.
*/
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()??"0");
if ((a%23 == 0)&&(a%7 == 0))
{
    Console.WriteLine("Кратное " );
}
else
{
    Console.WriteLine("Не кратное " );
}