/*Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. 456 -> 46 782 -> 72 918 -> 98*/

int getDeleteSecondDigitalFromNumber(int number)
{
    int number1 = number%10;
    number = number/100;
    int number2 = number%10;
    int result = number2*10+number1;
    return(result);
}
int randNumber = new Random().Next(100, 999);
Console.WriteLine($"Случайное число {randNumber}");
int delNumber = getDeleteSecondDigitalFromNumber(randNumber);
Console.WriteLine($"Число в котором удалена вторая цифра {delNumber}");
