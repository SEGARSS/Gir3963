/*
Задача 41: 
Пользователь вводит с клавиатуры M чисел. 
Посчитайте, 
сколько чисел больше 0 ввёл пользователь.
*/


Console.Write("Введите числа (через пробел): - ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        count++;
    }
}

Console.WriteLine($"Кол-во чисел > 0: {count}");