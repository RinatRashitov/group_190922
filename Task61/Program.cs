/*Задача 61. Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника*/

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

void PrintPascalTriangle(int[,] usArray, int widthShift)
{
    Console.Clear();
    for (int j = 0; j < usArray.GetLength(0); j++)
    {
        printColorData(j + 1 + "\t");
        for (int k = 0; k < usArray.GetLength(1); k++)
        {
            Console.SetCursorPosition(widthShift * usArray.GetLength(0) / 2 + widthShift * k - widthShift * j / 2 + 1, j); // +1 чтобы отступить от номеров рядов
            if (usArray[j, k] != 0) Console.WriteLine(usArray[j, k]);
        }
        Console.WriteLine("");
    }
}

int[,] Fill2DDataPascalTriangleArray(int[,] usArray)
{
    for (int i = 0; i < usArray.GetLength(0); i++)
    {
        for (int j = 0; j <= i; j++)
        {
            if (j == 0 | j == usArray.GetLength(0) - 1)
            {
                usArray[i, j] = 1;
            }
            else
            {
                usArray[i, j] = usArray[i - 1, j - 1] + usArray[i - 1, j];
            }
        }
    }
    return usArray;
}
int getMaxDigitalFromPascalTriangle(int[,] usArray)
{
    int result = usArray[usArray.GetLength(0) - 1, (usArray.GetLength(0) - 1) / 2];
    result = Convert.ToInt32(Math.Log10(result));
    return result;
}

int numN = getIntNumberFromUser("Введите значение значение N для определения высоты треугольника Паскаля ");
int[,] pascalTriangle = create2DArray(numN, numN);
pascalTriangle = Fill2DDataPascalTriangleArray(pascalTriangle);
int minIndent = 2; // минимальный отступ между числами в печатаемом треугольнике
PrintPascalTriangle(pascalTriangle, getMaxDigitalFromPascalTriangle(pascalTriangle) + minIndent);
