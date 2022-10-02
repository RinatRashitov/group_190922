/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

int calcSumDigital(int inNumber)
{
    int result = 0;
    while (inNumber > 0)
    {
        result = result + inNumber % 10;
        inNumber = inNumber / 10;
    }
    return result;
}

Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма чисел в числе {userNumber} в равна {calcSumDigital(userNumber)}");