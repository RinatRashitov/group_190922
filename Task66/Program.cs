/*Задача 66: Задайте значения M и N. Напишите программу, которая сумму натуральных числе в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8 -> 30*/
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

int getSummFromMToN(int M, int N)
{
    int result=0;
    while (N >= M)
    {
        result=result+N;
        N=N-1;
    }
    return result;
}

int numM = getIntNumberFromUser("Введите значение M ");
int numN = getIntNumberFromUser("Введите значение N ");
Console.WriteLine("");
Console.WriteLine($"Сумма чисел от {numM} до {numN} равна {getSummFromMToN(numM, numN)}");
