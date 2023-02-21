/*
Задача №24
Напишите программу, 
которая принимает на вход число (А) 
и выдаёт сумму чисел от 1 до А.
*/

int ReadData(string line)
{

}

void PrintResult(string line)
{

}

int SumSimple(int numA)
{
    long sum =0;
    for (int i = 0; i < length; i++)
    {
        
    }
    return sum;
    

}

int SumGausse(int numA)
{
    return ((1+(long)numA)*(long)numA)/2;
}
int numberA = ReadDara("Введите число А:");

long res1 = SumSimple(numberA);

long res2 = SumSimple(numberA);

PrintResult("Сумма чисел от 1 до А равна(простой метод):" + res1 );
PrintResult("Сумма чисел от 1 до А равна(метод Гауса):" + res2 );