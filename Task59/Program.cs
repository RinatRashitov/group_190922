/*Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим
следующий массив:
9 4 2
2 2 6
3 4 7*/

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

int[] getMinPositionFromArray(int[,] usArray)
{
    int minHight = 0;
    int minWide = 0;
    int[] result = new int[2];
    for (int i = 0; i < usArray.GetLength(0); i++)
    {
        for (int j = 0; j < usArray.GetLength(1); j++)
        {
            if (usArray[minHight, minWide] > usArray[i, j])
            {
                minHight = i;
                minWide = j;
            }
        }
    }
    result[0] = minHight;
    result[1] = minWide;
    return result;
}
int[,] delRowColFromArray(int[,] usArray, int[] position)
{
    int[,] result = create2DArray(usArray.GetLength(0) - 1, usArray.GetLength(1) - 1);
    int[] delPosition = getMinPositionFromArray(usArray);
    for (int i = 0; i < usArray.GetLength(0); i++)
    {
        for (int j = 0; j < usArray.GetLength(1); j++)

        {
            if (i != delPosition[0] && j != delPosition[1])
            {
                int numI = i;
                int numJ = j;
                if (numI > delPosition[0]) numI = numI - 1;
                if (numJ > delPosition[1]) numJ = numJ - 1;
                result[numI, numJ] = usArray[i, j];
            }
        }

    }
    return result;
}

int numX = getIntNumberFromUser("Введите значение по вертикали ");
int numY = getIntNumberFromUser("Введите значение по горизонтали ");
int numFrom = getIntNumberFromUser("Введите минимальное значение элемента: ");
int numTo = getIntNumberFromUser("Введите максимальное значение элемента: ");
int[,] userArray = create2DArray(numX, numY);
userArray = Fill2DDataArray(userArray, numFrom, numTo + 1);
Console.WriteLine("Массив");
Print2DArray(userArray);

int[,] delArray = create2DArray(numX - 1, numY - 1);
delArray = delRowColFromArray(userArray, getMinPositionFromArray(userArray));
int[] delPos = getMinPositionFromArray(userArray);
Console.WriteLine($"Минимальное значение находится в ячейке {delPos[0]},{delPos[1]}");
Console.WriteLine("Измененный массив");
Print2DArray(delArray);


