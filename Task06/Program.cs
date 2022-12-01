
// 3.1. Напишите программу, которая будет принимать 
// на вход пять чисел и выводить сумму и 
// среднее арифметическое этих чисел.
// 2, 5, 6, 8, 1 -> сумма 22, среднее 4,4 

int Prompt(string message)
{
    Console.Write($"{message} ");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;

}
int num1 = Prompt("Enter a first number ");
int num2 = Prompt("Enter a second number ");
int num3 = Prompt("Enter a third number ");
int num4 = Prompt("Enter a fourth number ");
int num5 = Prompt("Enter a fifst number ");

double sum = num1 + num2 + num3 + num4 + num5;

double average = sum / 5;
Console.WriteLine($"sum is {sum}, average is {average}");