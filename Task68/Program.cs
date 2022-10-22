/*Задача 68. Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3, A(m,n) = 29 */

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

int genFuncAkkerman(int n, int m)
{
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) & (m == 0))
        return genFuncAkkerman(n - 1, 1);
    else
        return genFuncAkkerman(n - 1, genFuncAkkerman(n, m - 1));
}

int numM = getIntNumberFromUser("Введите значение M ");
int numN = getIntNumberFromUser("Введите значение N ");
Console.WriteLine($"Значение функции Аккермана для n={numN} и m={numM} равно {genFuncAkkerman(numN, numM)}");