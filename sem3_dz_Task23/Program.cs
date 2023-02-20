/*
Задача 23
Напишите программу, 
которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.
*/

int ReadData(string msg)
{
    Console.Write(msg);
    return(int.Parse(Console.ReadLine()??"0"));
}
string LineBuilder(int nbr, int che)
{
    string res = "│";

    for(int i=1; i<=nbr; i++)
    {
        res = res + Math.Pow(i, che) + "\t│";
    }
 
    return res;
}
string TableLineBuilder(int nbr, string linePosition)
{
    string res = String.Empty;
    int i;

    switch(linePosition){
        case "Верхние границы таблицы": 
            res = "┌"; 
            for(i=1; i<nbr; i++) res = res + "───────┬";
            res = res + "───────┐";
            break;
        case "Средние границы таблицы": 
            res = "├"; 
            for(i=1; i<nbr; i++) res = res + "───────┼";
            res = res + "───────┤";
            break;
        case "Нижние границы таблицы": 
            res = "└"; 
            for(i=1; i<nbr; i++) res = res + "───────┴";
            res = res + "───────┘";
            break;
        default: 
            for(i=1; i<=nbr; i++) res = res + "────────";
            break;
    }
    return res;
}

int nbr = ReadData("Ведите число: ");

Console.WriteLine(TableLineBuilder(nbr, "Верхние границы таблицы"));
Console.WriteLine(LineBuilder(nbr, 1));
Console.WriteLine(TableLineBuilder(nbr, "Средние границы таблицы"));
Console.WriteLine(LineBuilder(nbr, 3));
Console.WriteLine(TableLineBuilder(nbr, "Нижние границы таблицы"));