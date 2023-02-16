/*
Задача 15:
Напишите программу, 
которая принимает на вход цифру, 
обозначающую день недели, и проверяет, 
является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

// Первый вариант решения.

Console.Write("Введите номер дня недели: ");
int Day = Convert.ToInt32(Console.ReadLine());
if (Day >= 1 && Day <=7) 
{
    if (Day >= 6)
    {
        Console.Write("Выходной день" ); 
            
    }
    else
    {
        Console.Write("Рабочий день" );
    }
    }
    else
    {
        Console.Write("Данное число не являеться днём недели");
}
  

// Второй вариант решения

var day = new Dictionary <int, string> ()
{
    [1] = "1 - Понедельник, рабочий день ",
    [2] = "2 - Вторник, рабочий день ",
    [3] = "3 - Среда, рабочий день ",
    [4] = "4 - Четверг, рабочий день ",
    [5] = "5 - Пятница, рабочий день ",
    [6] = "6 - Суббота, выходной день ",
    [7] = "7 - Воскресенье, выходной день "
};

Console.Write("Введите номер дня недели: ");
int dayNum = int.Parse(Console.ReadLine()??"0");

if(dayNum>0 && dayNum<8)
{
  Console.WriteLine(day[dayNum]);
} 
else
{
    Console.WriteLine("Данное число не являеться обозначением дня недели!");
}

// Третий вариант

Console.Write("Введите номер дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());
var dayNum = new Dictionary <int, string> ()
{
    [1] = "Понедельник",
    [2] = "Вторник",
    [3] = "Среда",
    [4] = "Четверг",
    [5] = "Пятница",
    [6] = "Суббота",
    [7] = "Воскресенье"
};
if(day>0 && day<8)
{
  Console.Write(dayNum[day]);
} 
if (day >= 1 && day <=7) 
{
    if (day >= 6)
    {
        Console.Write(" выходной день" ); 
    }
    else
    {
        Console.Write(" рабочий день" );
    }
}
else
{
    Console.Write("Данное число не являеться днём недели");
}
