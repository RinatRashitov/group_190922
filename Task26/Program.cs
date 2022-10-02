/*Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5*/

int countDigitals(int userNum)
{
    int result = 0;
    while (userNum>0)
    {
        result = result +1;
        userNum = userNum/10;
    }
    return result;
}

Console.WriteLine("Введите число: ");
int userNumber=Math.Abs(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine(countDigitals(userNumber));