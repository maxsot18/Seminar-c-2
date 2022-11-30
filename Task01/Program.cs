// 1. Напишите программу, 
// которая принимает на вход трёхзначное число 
// и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

int Prompt(string message)
{
    Console.Write($"{message} ");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;




}

bool VAlidateNumber(int number)
{
    if (number >= 100 && number < 1000)
    {
        return true;

    }
    Console.WriteLine("Not Three Numbers");
    return false;

}
int number = Prompt("Enter a number");
if(VAlidateNumber(number))
{
    int result = number % 10;
    Console.WriteLine($"Last number is {result}");
}



