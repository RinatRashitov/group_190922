/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1*/

int getSecondDigitalFromNumber(int number)
{
    number = (number%100)/10;
    int result = number;
    return(result);
}
Console.WriteLine("Введите число:");
int userNumber = 0;
userNumber = Convert.ToInt32(Console.ReadLine());
int delNumber = getSecondDigitalFromNumber(userNumber);
Console.WriteLine($"Вторая цифра {delNumber}");
