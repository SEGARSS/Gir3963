/*
Задача 25: 
Напишите цикл, 
который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
*/

int ReadDataInt(string msg)
{
    Console.Write(msg);
    return (int.Parse(Console.ReadLine() ?? "0"));
}

string ReadDataStr(string msg)
{
    Console.Write(msg);
    return (Console.ReadLine() ?? "0");
}

void PrintAnswer(string explain, double num)
{
    Console.WriteLine(explain + num);
}

double CalculatorSimple(int a, int b, string act)
{
    double res = 0;
    switch (act)
    {
        case "+":
            res = a + b;
            break;
        case "-":
            res = a - b;
            break;
        case "*":
            res = a * b;
            break;
        case "/":
            res = (double)a / b;
            break;
        case "pw":
            res = Math.Pow(a, b);
            break;
        default:
            Console.WriteLine($"Данной операции не существует '{act}'! CalculatorSimple().");
            return -12345.12345;
    }

    return res;
}
Console.WriteLine("Введите два числа");
int num1 = ReadDataInt("Введите первое число - ");
int num2 = ReadDataInt("Введите второе число - ");
string action = ReadDataStr("Выбирите операцию с числами (+, -, *, /, pw): ");

Console.WriteLine();

PrintAnswer($"{num1} {action} {num2} = ", CalculatorSimple(num1, num2, action));