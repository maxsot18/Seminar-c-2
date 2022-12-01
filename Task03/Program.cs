// 3. Напишите программу, 
// которая будет принимать на вход два числа и выводить,
//  является ли второе число кратным первому. 
//  Если число 2 не кратно числу 1, то программа 
//  выводит остаток от деление.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно
int Prompt(string message)
{
    Console.Write($"{message} ");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;




}

int input1 = Prompt("Enter a first number ");
int input2 = Prompt("Enter a second number ");

int div = input1 % input2;


if(div > 0)
{
    Console.WriteLine($"Not briefly, reminder = {div}");
}
else
{
Console.WriteLine($"Briefly");
}


