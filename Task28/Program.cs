/*Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24
5 -> 120*/

int getFaсtorialNumber(int userNum)
{
    int result=1;
    for(int j=1;j<=userNum;j++)
    {
        result = result*j;
    }
    return result;
}

Console.WriteLine("Введите число: ");
int userNumber=Math.Abs(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine($"Факториал числа {userNumber} равен {getFaсtorialNumber(userNumber)}");