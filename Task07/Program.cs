// 4.1. Напишите программу, которая генерирует 
// несколько случайных чисел, и в цикле проверяет, 
// кратны ли эти числа предварительно введенному числу, 
// при кратности - цикл прерывается.
// Введенное число 2
// 13 -> нет 
// 15 -> нет 
// 12 -> да

 int Prompt(string message)
 {
     Console.Write($"{message} ");
     int answer = Convert.ToInt32(Console.ReadLine());
     return answer;
 }
int div = Prompt("Divider = ");

// int Random()
// {
//     int number = new Random().Next(0, 10);
//     return number;
// }

int number1 = new Random().Next(1, 10);
while (number1 % div != 0)
{
    Console.WriteLine($"{number1} -> NO");
    number1 = new Random().Next(1, 110);
    
    if(number1 % div == 0)
    {
        Console.WriteLine($"{number1} -> YEs");
        break;
        
    }
}






