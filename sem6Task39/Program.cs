/*
Задача №39
Напишите программу, 
которая перевернёт одномерный массив 
(последний элемент будет на первом месте, 
а первый - на последнем и т.д.)
*/

void Print1Daee(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]+", ");
    }
    Console.WriteLine(arr[arr.Length]);
}