/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

int getCountDigitalFromNumber(int number)
{
    int count = 0;
    while (number > 0)
    {
        number = number / 10;
        count = count + 1;
    }
    return (count);
}

int getThirdDigitalFromNumber(int number, int count)
{
    number = (number / Convert.ToInt32(Math.Pow(10, count - 3))%10);
    int result = number;
    return (result);
}
Console.WriteLine("Введите число:");
int userNumber = 0;
userNumber = Convert.ToInt32(Console.ReadLine());
if (getCountDigitalFromNumber(userNumber) < 3)
{
    Console.WriteLine("Третьей цифры нет");
    //break;
}
else
{
    int thirdNumber = getThirdDigitalFromNumber(userNumber, getCountDigitalFromNumber(userNumber));
    Console.WriteLine($"Третья цифра {thirdNumber}");
}
