﻿int max = 0;
int min = 0;

Console.Write("Enter the first number ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the second number ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if(firstNumber > secondNumber)
{
    max = firstNumber;
    min = secondNumber;
}
else
{
    max = secondNumber;
    min = firstNumber;
}
Console.WriteLine("max = " + max + " and " + "min = " + min); 