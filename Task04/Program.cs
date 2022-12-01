// 2.1. Напишите программу, 
// которая выводит случайное число из отрезка 
// [10, 9999] и показывает наибольшую цифру числа.
// 7812 -> 8 
// 1213-> 3 
// 845 -> 8





int Prompt(string message)
{
    Console.Write($"{message} ");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;




}

int input = Prompt("Enter a number ");

if(input % 7 ==0 && input % 23 == 0)
{
    Console.WriteLine("Yeah");

}
else
{
    Console.WriteLine("No");

}


