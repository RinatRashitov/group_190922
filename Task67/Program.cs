/*Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9*/


int getIntNumberFromUser(string userInformation)
{
    int result = 0;
    while (result == 0)
    {
        Console.Write(userInformation);
        string userLine = Console.ReadLine();
        int.TryParse(userLine, out result);
        if (result == 0 && userLine != "0")
        {
            Console.WriteLine($"Введите целое число, Вы ввели: {userLine}");
        }
        else
        {
            break;
        }
    }
    return result;
}

int getSumOfDigits(int N)
{
    if(N==0)
    {
        return 0;
    }
    return N%10+getSumOfDigits(N/10);
}

int numN = getIntNumberFromUser("Введите значение ");
Console.WriteLine("");
Console.WriteLine($"Сумма цифр числа {numN} равна {getSumOfDigits(numN)}");
