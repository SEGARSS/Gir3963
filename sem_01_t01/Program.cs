/* 
Задача №0 
Напишите программу, которая на вход принимает число и
выдаёт его квадрас (число умноженное на само себя)
*/

Console.WriteLine("Введите число: ");

// Считываем данные с консоли
string? inputNum = Console.ReadLine();

//Проверяем, чтобы данные были не пустые
if(inputNum != null)
{
    //Парсим введённое число
    int number = int.Parse(inputNum);

    //Находим квадрат числа
    int outNum = number*number;
    //Другой пример
    //int outNum = (int)Math.Pow(number,2);

    //Выводим данные в консоль
    Console.WriteLine(outNum);

    //Оптимизированный вариант 
    //Console.WriteLine(Math.Pow(int.Parse(inputNum),2));
}
