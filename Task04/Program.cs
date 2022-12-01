// 4. Напишите программу, которая принимает на 
// вход число и проверяет, 
// кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да




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


