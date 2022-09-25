/*Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа. 78 -> 8 12-> 2 85 -> 8*/

int getRandomNumberFromRange(int minBorder, int maxBorder)
{
    int result = new int();
    result = new Random().Next(minBorder, maxBorder + 1);
    return result;
}

int getMaxDigitFromNumber(int number)
{
    int maxDigit = 0;
    while (number > 0)
    {
        int currentDigit = number % 10;
        if (currentDigit > maxDigit)
        {
            maxDigit = currentDigit;
        }
        number = number / 10;
    }
    return maxDigit;
}

int getMinDigitFromNumber(int number)
{
    int minDigit = 9;
    while (number > 0)
    {
        int currentDigit = number % 10;
        if (currentDigit < minDigit)
        {
            minDigit = currentDigit;
        }
        number = number / 10;
    }
    return minDigit;
}

int randNumber = getRandomNumberFromRange(10, 99999);
Console.WriteLine($"Случайное число {randNumber}");
int maxDigit = getMaxDigitFromNumber(randNumber);
Console.WriteLine($"Для числа {randNumber} большая цифра {maxDigit}");

int minDigit = getMinDigitFromNumber(randNumber);
Console.WriteLine($"Для числа {randNumber} меньшая цифра {minDigit}");