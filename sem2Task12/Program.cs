/*
Задача №12
Напишите программу, 
которая будет принимать на вход два числа и выводить, 
является ли второе число кратным первому. 
Если второе число некратно первому, 
то программа выводит остаток от деления.
*/
Console.Write("Введите первое число: ");
int fstA = int.Parse(Console.ReadLine()??"0");
Console.Write("Введите второе число: ");
int secA = int.Parse(Console.ReadLine()??"0");
if (fstA%secA == 0)
{
    Console.WriteLine("Кратное " );
}
else
{
    Console.WriteLine("Не кратное " +fstA%secA);
}
