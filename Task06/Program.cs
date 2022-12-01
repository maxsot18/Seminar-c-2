
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
int quant = Prompt("Enter a quantity of number ");
int i = 0;
double sum = 0;


while(i < quant)
{
    int value = Prompt($"Enter {i} number ");
    sum = sum + value;
    i++;
}



double average = sum / i;
Console.WriteLine($"sum is {sum}, average is {average:f2}");