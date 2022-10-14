/*Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.*/


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

int[,] changeFirstLastRowInArray(int[,] usArray)
{
    for(int j=0;j<usArray.GetLength(1);j++)
    {
        int tmp=0;
        tmp=usArray[0,j];
        usArray[0,j]=usArray[usArray.GetLength(0)-1,j];
        usArray[usArray.GetLength(0)-1,j]=tmp;
    }
    return usArray;
}

int numX = getIntNumberFromUser("Введите значение по вертикали ");
int numY = getIntNumberFromUser("Введите значение по горизонтали ");
int numFrom = getIntNumberFromUser("Введите минимальное значение элемента: ");
int numTo = getIntNumberFromUser("Введите максимальное значение элемента: ");
int[,] userArray = create2DArray(numX, numY);
userArray = Fill2DDataArray(userArray, numFrom, numTo + 1);
Console.WriteLine("Матрица");
Print2DArray(userArray);
int[,] reversedArray=changeFirstLastRowInArray(userArray);
Console.WriteLine("Матрица cо замененными первой и последней строкой");
Print2DArray(reversedArray);
