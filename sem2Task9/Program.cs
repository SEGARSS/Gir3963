﻿/*

*/
System.Random numSintezator = new System.Random();

// Вариант 1
int rndNumber = numSintezator.Next(10,100);
Console.WriteLine(rndNumber);
int firstNum = rndNumber/10;
int secondNum = rndNumber%10;

if (firstNum>secondNum)
{
    Console.WriteLine("Первое число " + firstNum +  " Больше второго числа " + secondNum);
}
else
{
    Console.WriteLine(secondNum);
}

//Вариант 2
char[] digits = numSintezator.Next(10,100).ToString().ToCharArray();
Console.WriteLine(digits);
int firstNumber = ((int)digits[0])-48;
int secondNumber = ((int)digits[1])-48;

//<переменная> = (условие)? <значение1>:<значение2>;

int resultNumber = (firstNumber>secondNumber)?resultNumber=firstNumber:resultNumber=secondNum;
Console.WriteLine(resultNumber);

