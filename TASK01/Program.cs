// Задача 1: Напишите программу, 
// которая принимает на вход число (А) 
// и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int Prompt(string message)
{
    Console.WriteLine($"{message}");
    return Convert.ToInt32(Console.ReadLine());
}    

int sumNumbers(int number)
{
    int sum = 0;
    int i = 1;
    while(i <= number)
    {
        sum +=i;
        i++;
    }
    return sum;
}

int number = Prompt("Enter a number ");
int result = sumNumbers(number);
Console.WriteLine(result);