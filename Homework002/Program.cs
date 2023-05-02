int max = 0;

Console.Write("add first number ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("add second number ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("add third number ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

if(firstNumber > max)
{
    max = firstNumber;
}
if(secondNumber > max)
{
    max = secondNumber;
}
if(thirdNumber > max)
{
    max = thirdNumber;
}

Console.WriteLine("max = " + max);
