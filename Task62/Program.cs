/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/


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
string[,] createSquareArray(int userNumX)
{
    string[,] userAr = new string[userNumX, userNumX];
    return userAr;
}
void printColorData(string data)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(data);
    Console.ResetColor();
}
void Print2DArray(string[,] usArray)
{
    Console.Write(" \t");
    for (int j = 0; j < usArray.GetLength(1); j++)
    {
        printColorData(j + "\t");
    }
    Console.WriteLine();
    for (int j = 0; j < usArray.GetLength(0); j++)
    {
        printColorData(j + "\t");
        for (int k = 0; k < usArray.GetLength(1); k++)
        {
            Console.Write($"{usArray[j, k]}" + "\t");
        }
        Console.WriteLine("");
    }
}
string[,] FillSnail2DDataArray(string[,] usArray)
{
    int x = 0;
    int y = 0;
    int count = 1;
    int direction = 0;
    while (count <= usArray.GetLength(0) * usArray.GetLength(1))
    {
        if (y > usArray.GetLength(0) - 1)
        {
            y = y - 1;
            x = x - 1;
            direction = (direction + 1) % 4;
        }
        if (x > usArray.GetLength(1) - 1)
        {
            x = x - 1;
            y = y + 1;
            direction = (direction + 1) % 4;
        }
        if (y < 0)
        {
            y = y + 1;
            x = x + 1;
            direction = (direction + 1) % 4;
        }
        if (x < 0)
        {
            x = x + 1;
            y = y - 1;
            direction = (direction + 1) % 4;
        }
        if (usArray[y, x] is not null)
        {
            if (direction == 0)
            {
                x = x - 1;
                y = y + 1;
            }
            if (direction == 1)
            {
                y = y - 1;
                x = x - 1;
            }
            if (direction == 2)
            {
                x = x + 1;
                y = y - 1;
            }
            if (direction == 3)
            {
                y = y + 1;
                x = x + 1;
            }
            direction = (direction + 1) % 4;
        }
        if (usArray[y, x] is null)
        {
            usArray[y, x] = count.ToString("D2");
            count = count + 1;
            if (direction == 0) x = x + 1;
            if (direction == 1) y = y + 1;
            if (direction == 2) x = x - 1;
            if (direction == 3) y = y - 1;
        }
    }
    return usArray;
}

int numX = getIntNumberFromUser("Введите значение размер массива ");
string[,] userArray = createSquareArray(numX);
userArray = FillSnail2DDataArray(userArray);
Console.WriteLine("Массив улитка");
Print2DArray(userArray);