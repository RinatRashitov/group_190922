/*Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8*/

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

int getPowAFromB(int A, int B)
{
    if (B == 0)
    {
        return 1;
    }
    else
    {
        return A * getPowAFromB(A, B - 1);
    }
}

int numA = getIntNumberFromUser("Введите значение A ");
int numB = getIntNumberFromUser("Введите значение B ");
Console.WriteLine("");
getPowAFromB(numA, numB);
Console.WriteLine($"Число {numA} в {numB} степени равно {getPowAFromB(numA, numB)}");