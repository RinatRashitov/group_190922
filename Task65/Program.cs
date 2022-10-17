/*Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8"*/
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

void printFromOneToN(int M, int N)
{
    if (N == M-1)
    {
        return;
    }
    else
    {
        printFromOneToN(M, N - 1);
        Console.Write($"{N}, ");
    }
}

int numM = getIntNumberFromUser("Введите значение M ");
int numN = getIntNumberFromUser("Введите значение N ");
Console.WriteLine("");
printFromOneToN(numM, numN);
