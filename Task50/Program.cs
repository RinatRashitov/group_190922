/*Задача 50. Напишите программу, которая на вход принимает позицию элемента в двумерном массиве, и возвращает значение этого элемента 
или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
5 -> 9
2 -> 7
9 -> 4
индексы:
[0][1][2][3]
1 4 7 2
[4][5][6][7]
5 9 2 3
[8][9][10][11]
8 4 2 4*/

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
int[,] create2DArray(int userNumX, int userNumY)
{
    int[,] userAr = new int[userNumX, userNumY];
    return userAr;
}
void printColorData(string data)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(data);
    Console.ResetColor();
}
void Print2DArray(int[,] usArray)
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
int[,] Fill2DDataArray(int[,] usArray, int numFrom, int numTo)
{
    for (int j = 0; j < usArray.GetLength(0); j++)
    {
        for (int k = 0; k < usArray.GetLength(1); k++)
        {
            usArray[j, k] = new Random().Next(numFrom, numTo);
        }
    }
    return usArray;
}
int findPositionInArray(int[,] usArray, int seekPosition)
{
    if (seekPosition > usArray.GetLength(0) * usArray.GetLength(1) - 1)
    {
       return -1;
    }
    else
    {
        return usArray[(seekPosition) / usArray.GetLength(1), (seekPosition) % usArray.GetLength(1)];
    }
}

int numX = getIntNumberFromUser("Введите значение по вертикали ");
int numY = getIntNumberFromUser("Введите значение по горизонтали ");
int numFrom = getIntNumberFromUser("Введите минимальное значение элемента: ");
int numTo = getIntNumberFromUser("Введите максимальное значение элемента: ");
int[,] userArray = create2DArray(numX, numY);
userArray = Fill2DDataArray(userArray, numFrom, numTo + 1);
Console.WriteLine("Матрица");
Print2DArray(userArray);

int userPosition = getIntNumberFromUser("Введите искомую позицию ");

if (findPositionInArray(userArray, userPosition) == -1)
{
    Console.WriteLine("такого числа в массиве нет");
}
else
{
    Console.WriteLine($"В позиции {userPosition} находится значение {findPositionInArray(userArray, userPosition)}");
}