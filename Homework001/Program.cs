// int max = 0;
// int min = 0;

// Console.Write("Enter the first number ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());

// Console.Write("Enter the second number ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());

// if(firstNumber > secondNumber)
// {
//     max = firstNumber; min = secondNumber;
// }
// else
// {
//     max = secondNumber; min = firstNumber;
// }
// Console.WriteLine("max = " + max + " and " + "min = " + min); 

Console.WriteLine("Введите первое число:");

int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");

int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(a > b ? "Первое число больше второго" : "Второе число больше первого");