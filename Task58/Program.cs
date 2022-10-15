/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/


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
int[,] arrayMultiplication(int[,] ArrayA, int[,] ArrayB)
{
    int[,] result = new int[ArrayA.GetLength(0), ArrayB.GetLength(1)];
    for (int i = 0; i < ArrayA.GetLength(0); i++)
    {
        for (int j = 0; j < ArrayB.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < ArrayA.GetLength(1); k++)
            {
                sum = sum + ArrayA[i, k] * ArrayB[k, j];
            }
            result[i, j] = sum;
        }
    }
    return result;
}

int numXA = getIntNumberFromUser("Введите значение по вертикали для матрицы 1 ");
int numYA = getIntNumberFromUser("Введите значение по горизонтали матрицы 1 ");
int numXB = getIntNumberFromUser("Введите значение по вертикали для матрицы 2 ");
int numYB = getIntNumberFromUser("Введите значение по горизонтали матрицы 2 ");
if (numYA != numXB) Console.WriteLine($"Перемножение матриц A и B невозможно поскольку они несовместимы. Число колонок {numYA} матрицы A не равно числу срок {numXB} матрицы B");
else
{
    int numFrom = getIntNumberFromUser("Введите минимальное значение элемента: ");
    int numTo = getIntNumberFromUser("Введите максимальное значение элемента: ");
    int[,] userArrayA = create2DArray(numXA, numYA);
    int[,] userArrayB = create2DArray(numXB, numYB);
    userArrayA = Fill2DDataArray(userArrayA, numFrom, numTo + 1);
    userArrayB = Fill2DDataArray(userArrayB, numFrom, numTo + 1);
    Console.WriteLine("Массив A");
    Print2DArray(userArrayA);
    Console.WriteLine("Массив B");
    Print2DArray(userArrayB);
    int[,] userArrayC = create2DArray(numXA, numYB);
    userArrayC = arrayMultiplication(userArrayA, userArrayB);
    Console.WriteLine("Результат перемножения массивов A и B");
    Print2DArray(userArrayC);

}
