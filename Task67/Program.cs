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

void getSumOfDigits(int N)
{
    int result = 0;
    for(int i=N;i>0;i=i/10)
    {
        result=result+i%10;
    }
    Console.WriteLine($"Сумма цифр числа {N} равна {result}");
}

int numN = getIntNumberFromUser("Введите значение ");
Console.WriteLine("");
getSumOfDigits(numN);
